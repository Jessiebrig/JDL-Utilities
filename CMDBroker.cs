using System;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace JDL_Utilities
{
	public class CMDBroker
	{
		//Experimenttal Class and to be publish as standalone DLL.
		private Form form;
		private TextBox TextBox;
		public CMDBroker(Form form1, TextBox textBox)
		{
			form = form1;
			TextBox = textBox;
		}

		private Process CMD;
		private ProcessStartInfo cmd;
		public void Command(string command)
		{
			CMD.StandardInput.WriteLine(command);
		}
		public void Start()
		{
			Sync_Out("CMDBroker by Jessie Daguia Lindayao");
			if (CMD == null)
			{
				cmd = new ProcessStartInfo("CMD.exe");
				Encoding encoding = Encoding.ASCII;
				ProcessStartInfo processStartInfo = cmd;
				processStartInfo.UseShellExecute = false;
				processStartInfo.CreateNoWindow = true;
				processStartInfo.RedirectStandardError = true;
				processStartInfo.RedirectStandardOutput = true;
				processStartInfo.RedirectStandardInput = true;
				processStartInfo.StandardOutputEncoding = encoding;
				processStartInfo.StandardErrorEncoding = encoding;
				processStartInfo = null;
				CMD = new Process
				{
					StartInfo = cmd,
					EnableRaisingEvents = true
				};
				CMD.ErrorDataReceived += Async_Data_Received;
				CMD.OutputDataReceived += Async_Data_Received;
				CMD.Exited += CMD_Exited;
				CMD.Start();
				CMD.BeginOutputReadLine();
				CMD.BeginErrorReadLine();
			}
		}

		private delegate void Invoke_CMD(string text);
		private void CMD_Exited(object sender, EventArgs e) { }
		private void Async_Data_Received(object sender, DataReceivedEventArgs e)
		{
			if (form.IsHandleCreated)
			{
				form.Invoke(new Invoke_CMD(Sync_Out), e.Data);
			}
		}
		private void Sync_Out(string logs)
		{
			if (form.IsHandleCreated)
			{
				logs = logs.Replace("????", "|___");
				logs = logs.Replace("?", "|");
				TextBox.AppendText(logs + Environment.NewLine);
				TextBox.ScrollToCaret();
			}
		}
	}
}
