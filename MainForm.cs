using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdbAssistant
{
    public partial class MainForm : Form
    {
        private BatStatus curBatSataus = BatStatus.NONE;

        private Process curProcess = new Process();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitInfo();
        }
        private void InitInfo()
        {
            InitInfo(null);
        }
        private void InitInfo(Encoding encoding)
        {
            
            curProcess.OutputDataReceived -= new DataReceivedEventHandler(ProcessOutDataReceived);
            ProcessStartInfo p = new ProcessStartInfo();
            if (encoding != null)
            {
                p.StandardErrorEncoding = encoding;
                p.StandardOutputEncoding = encoding;
            }

            p.FileName = "cmd.exe";
            //p.Arguments = " -t 192.168.1.103";
            p.UseShellExecute = false;
            p.WindowStyle = ProcessWindowStyle.Hidden;
            p.CreateNoWindow = true;
            p.RedirectStandardError = true;
            p.RedirectStandardInput = true;
            p.RedirectStandardOutput = true;

            curProcess.StartInfo = p;
            curProcess.Start();
            curProcess.BeginOutputReadLine();

            curProcess.OutputDataReceived += new DataReceivedEventHandler(ProcessOutDataReceived);
        }

        /// <summary>
        /// 开始命令行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCommand.Text.Trim()))
            {
                MessageBox.Show("请输入命令");
            }
            if (curBatSataus == BatStatus.ON)
            {
                stopCMD();
                InitInfo();
            }
       
            curProcess.StandardInput.WriteLine(this.txtCommand.Text.Trim());
                curBatSataus = BatStatus.ON;
            

        }

        /// <summary>
        /// 结束命令行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (curBatSataus == BatStatus.ON)
            {
                stopCMD();
                InitInfo();
            }
        }

        private void stopCMD()
        {
            if (curProcess != null)
            {
                try
                {
                    curProcess.CancelOutputRead();//取消异步操作
                    curProcess.Kill();
                    curBatSataus = BatStatus.OFF;
                    //如果需要手动关闭，则关闭后再进行初始化 
                }
                catch { }
        
            }


        }
   

        /// <summary>
        /// 进程接受事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ProcessOutDataReceived(object sender, DataReceivedEventArgs e)
        {
          
      
            if (this.txtOutPutInfo.InvokeRequired)
            {
                this.txtOutPutInfo.Invoke(new Action(() =>
                {
                    this.txtOutPutInfo.AppendText(e.Data + "\r\n");
                }));
            }
            else {
                this.txtOutPutInfo.AppendText(e.Data + "\r\n");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if ((string.IsNullOrEmpty(this.curProcess.StartInfo.FileName) || this.curProcess.StandardInput.BaseStream.CanWrite) && curBatSataus != BatStatus.OFF)
            //{
            //    curBatSataus = BatStatus.OFF;
   
            //}
        }

        private void btnPrintLog_Click(object sender, EventArgs e)
        {
            stopCMD();
            InitInfo(Encoding.UTF8);
            curProcess.StandardInput.WriteLine("adb logcat -s RxLog");
            curBatSataus = BatStatus.ON;
        }

        private void btnPrintClear_Click(object sender, EventArgs e)
        {
            this.txtOutPutInfo.Clear();
        }

        private void btnPrintDeviceInfo_Click(object sender, EventArgs e)
        {
            normalButtonClick("adb shell wm size");
            
        }

        private void btnCPUInfo_Click(object sender, EventArgs e)
        {
            normalButtonClick("adb shell cat /proc/cpuinfo");
        }

        private void btnScreenParams_Click(object sender, EventArgs e)
        {
            normalButtonClick("adb shell dumpsys window displays");
        }

        private void btnMemoryInfo_Click(object sender, EventArgs e)
        {
            normalButtonClick("adb shell dumpsys meminfo");
        }

        private void normalButtonClick(string cmd)
        {
            if (curBatSataus == BatStatus.ON)
            {
                stopCMD();
                InitInfo();
            }
            curProcess.StandardInput.WriteLine(cmd);
            curBatSataus = BatStatus.ON;
        }

        private void btnConnectDevices_Click(object sender, EventArgs e)
        {
            normalButtonClick("adb devices");
        }

        private void btnProcessShow_Click(object sender, EventArgs e)
        {
            string cmd = txtProssFilter.Text;
            if (string.IsNullOrEmpty(cmd))
            {
                normalButtonClick("adb shell ps");
            }
            else
            {
                normalButtonClick("adb shell ps | findstr "+cmd);
            }
      
        }

        private void btnLogFilter_Click(object sender, EventArgs e)
        {
            stopCMD();
            InitInfo(Encoding.UTF8);
            string cmd = txtLogFilter.Text;
            if (string.IsNullOrEmpty(cmd))
            {
                curProcess.StandardInput.WriteLine("adb logcat");
            }
            else
            {

                curProcess.StandardInput.WriteLine("adb logcat | find \"" + cmd + "\"");
            }
            curBatSataus = BatStatus.ON;
        }

        private void btnCurentAcitivity_Click(object sender, EventArgs e)
        {
            normalButtonClick("adb shell dumpsys activity activities");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCommand_TextChanged(object sender, EventArgs e)
        {

        }
    }

    /// <summary>
    /// 命令状态
    /// </summary>
    public enum BatStatus {
        NONE = 0,
        ON = 1,
        OFF = 2
    }
}
