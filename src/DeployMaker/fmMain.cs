using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeployMaker
{
	public partial class fmMain : Form
	{
		delegate void WriteLogDelegate(string text);
		delegate void TotalCountDelegate(int total);

		private int _totalCount = 0;
		private int _currentCount = 0;

		public fmMain()
		{
			InitializeComponent();
			InitExtentionAndFolder();
		}

		#region +Initalize File Extension List
		private void InitExtentionAndFolder()
		{
			string[] exts = ConfigurationManager.AppSettings["Extentions"].Split(';');
			foreach (string s in exts)
			{
				CheckBox chb = new CheckBox {
					Text = s,
					Width = s.Length * 10 + 20,
					Font = new Font("verdana", 9f, FontStyle.Regular),
					Checked = true
				};
				this.flowLayoutPanelExt.Controls.Add(chb);
			}

			string[] folders = ConfigurationManager.AppSettings["ExceptByFolder"].Split(';');
			foreach (string s in folders)
			{
				CheckBox chb = new CheckBox {
					Text = s.ToLower(),
					Width = s.Length * 10 + 20,
					Font = new Font("verdana", 9f, FontStyle.Regular),
					Checked = false
				};
				this.flowLayoutPanelFolder.Controls.Add(chb);
			}
		}
		#endregion

		#region +Check before start
		private bool IsCheckValidate()
		{
			this.lblLog.ForeColor = Color.Red;

			#region check base path input
			string orgPath = this.txtOrgPath.Text;
			if (orgPath == "")
			{
				this.lblLog.Text = "Input the Base Path";
				return false;
			}
			else if (!Directory.Exists(orgPath))
			{
				this.lblLog.Text = "Input the Base Path";
				return false;
			}
			#endregion

			#region check target path input
			string targetPath = this.txtTargetPath.Text;
			if (targetPath == "")
			{
				this.lblLog.Text = "Input the Target Path";
				return false;
			}
			#endregion

			#region check file extension
			bool isChecked = false;
			foreach (Control control in this.flowLayoutPanelExt.Controls)
			{
				if((control as CheckBox).Checked)
				{
					isChecked = true;
					break;
				}
			}
			if (!isChecked)
			{
				this.lblLog.Text = "Select one more the file extentions";
				return false;
			}
			#endregion

			this.lblLog.ForeColor = Color.Black;

			return true;
		}
		#endregion

		#region +Start Process
		private bool StartProcess()
		{
			List<string> fileExtList = new List<string>();
			List<string> folderList = new List<string>();
			List<FileInfo> baseFileList = new List<FileInfo>();
			List<FileInfo> targetFileList = new List<FileInfo>();
			DirectoryInfo dirBasePath = new DirectoryInfo(this.txtOrgPath.Text);
			DirectoryInfo dirTargetPath = new DirectoryInfo(this.txtTargetPath.Text);
			DateTime updateTime = Convert.ToDateTime(this.dateTimePicker.Value.ToString("yyyy-MM-dd") + " 00:00:00");

			WriteLog("------------------------------------------------------------");
			WriteLog("Start...");

			//Make selected File Extension List
			foreach (Control control in this.flowLayoutPanelExt.Controls)
			{
				if ((control as CheckBox).Checked)
					fileExtList.Add((control as CheckBox).Text);
			}

			//Make selected folder list
			foreach (Control control in this.flowLayoutPanelFolder.Controls)
			{
				if ((control as CheckBox).Checked)
					folderList.Add((control as CheckBox).Text);
			}

			//1.Select FileList
			WriteLog("Select Base File");
			if (!dirBasePath.Exists)
			{
				WriteLog($"Not exist files in BasePath[{dirBasePath.FullName}]");
				return false;
			}
			else
			{
				MakeBaseFiles(dirBasePath, updateTime, fileExtList, folderList, ref baseFileList);
			}

			//2.Copy files at TargetPath
			if (!dirTargetPath.Exists)
				dirTargetPath.Create();
			//Replace folder name from BasePath to TargetPath
			string dirName = "";
			double loop = 0;
			double count = baseFileList.Count;

			DisplayTotalCount(baseFileList.Count);
			foreach (FileInfo file in baseFileList)
			{
				Thread.Sleep(10);
				dirName = file.DirectoryName.Replace(dirBasePath.FullName, dirTargetPath.FullName);
				if (!Directory.Exists(dirName))
					Directory.CreateDirectory(dirName);
				file.CopyTo(dirName + "/" + file.Name, true);
				WriteLog($"[copy]{file.Name}->{dirName}/{file.Name}");
				RefreshLog();

				++loop;
				if ((loop / count) * count > 0)
				{
					loop = 0;
					DisplayProgress();
				}
			}

			WriteLog("...End");
			RefreshLog();

			return true;
		}
		#endregion

		#region +Make BaseFiles
		private void MakeBaseFiles(DirectoryInfo dir, DateTime updateTime, List<string> fileExtList, List<string> folderList, ref List<FileInfo> fileList)
		{
			if (folderList.Contains(dir.Name.ToLower()))
				return;
			else
			{
				//WriteLog($"directory name = {dir.Name}, folder list = {string.Join(";", folderList.ToArray())}");
				FileInfo[] files = dir.GetFiles();
				foreach (string ext in fileExtList)
				{
					foreach (FileInfo file in files)
					{
						if (file.Extension.ToUpper() == "." + ext.ToUpper() &&
							file.LastWriteTime > updateTime)
						{
							Thread.Sleep(10);
							fileList.Add(file);
							WriteLog(file.FullName);
							RefreshLog();
						}
					}
				}
			}

			DirectoryInfo[] dirs = dir.GetDirectories();
			foreach (DirectoryInfo directory in dirs)
			{
				MakeBaseFiles(directory, updateTime, fileExtList, folderList, ref fileList);
			}
		} 
		#endregion

		#region +Append log
		private void WriteLog(string text)
		{
			if (this.rtbLog.InvokeRequired)
				this.rtbLog.Invoke(new WriteLogDelegate(WriteLog), text);
			else
				this.rtbLog.Text += text + "\r\n";
		}
		#endregion

		#region +Move the scroll to end
		private void RefreshLog()
		{
			if (this.rtbLog.InvokeRequired)
				this.rtbLog.Invoke((MethodInvoker)delegate {
					this.rtbLog.SelectionStart = this.rtbLog.Text.Length;
					this.rtbLog.ScrollToCaret();
				});
		}
		#endregion

		#region +Display Progress
		private void DisplayProgress()
		{
			if (this.tspbProgress.GetCurrentParent().InvokeRequired)
				this.tspbProgress.GetCurrentParent().Invoke((MethodInvoker)delegate {
					this.tspbProgress.PerformStep();
				});

			if (this.tsslStatus.GetCurrentParent().InvokeRequired)
				this.tsslStatus.GetCurrentParent().Invoke((MethodInvoker)delegate {
					this._currentCount++;
					this.tsslStatus.Text = $"{this._currentCount}/{this._totalCount}";
				});
		}
		#endregion

		#region +Display TotalCount
		private void DisplayTotalCount(int total)
		{
			if (this.tsslStatus.GetCurrentParent().InvokeRequired)
				this.tsslStatus.GetCurrentParent().Invoke(new TotalCountDelegate(DisplayTotalCount), total);
			else
			{
				this._totalCount = total;
				this.tsslStatus.Text = "0/" + total.ToString();
			}
		}
		#endregion

		#region +=====================EVENT========================

		#region +Form Load
		private void fmMain_Load(object sender, EventArgs e)
		{
			this.lblLog.Text = "";
		} 
		#endregion

		#region +BasePath Click
		private void btnOrgPath_Click(object sender, EventArgs e)
		{
			if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				this.txtOrgPath.Text = this.folderBrowserDialog.SelectedPath;
			}
		}
		#endregion

		#region +TargetPath Click
		private void btnTargetPath_Click(object sender, EventArgs e)
		{
			if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				this.txtTargetPath.Text = this.folderBrowserDialog.SelectedPath;
			}
		}
		#endregion

		#region +BasePathOpen Click
		private void btnBasePathOpen_Click(object sender, EventArgs e)
		{
			if (this.txtOrgPath.Text != "")
			{
				Process.Start("explorer.exe", this.txtOrgPath.Text);
			}
		}
		#endregion

		#region +TargetPathOpen Click
		private void btnTargetPathOpen_Click(object sender, EventArgs e)
		{
			if (this.txtTargetPath.Text != "")
			{
				Process.Start("explorer.exe", this.txtTargetPath.Text);
			}
		}
		#endregion

		#region +Clear Log
		private void btnClearLog_Click(object sender, EventArgs e)
		{
			this.rtbLog.Clear();
		}
		#endregion

		#region +Start Click
		private async void btnStart_Click(object sender, EventArgs e)
		{
			this._currentCount = 0;
			this._totalCount = 0;

			if (IsCheckValidate())
			{
				this.btnClearLog.Enabled = false;
				this.btnStart.Enabled = false;
				this.tspbProgress.Value = 0;
				this.tsslStatus.Text = "0/0";
				this.tsslResult.Text = "";
				this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				bool process = await Task.Run(() => StartProcess());
				if (process)
				{
					this.btnClearLog.Enabled = true;
					this.btnStart.Enabled = true;
					this.tsslResult.Text = "Complete";
					this.tspbProgress.Value = this.tspbProgress.Maximum;
				}
				else
				{
					this.btnClearLog.Enabled = true;
					this.btnStart.Enabled = true;
					this.tsslResult.Text = "Fail (Confirm to log)";
				}
			}
			
		}
		#endregion

		#endregion

		
	}
}
