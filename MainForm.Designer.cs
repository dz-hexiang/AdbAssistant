namespace AdbAssistant
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtOutPutInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrintLog = new System.Windows.Forms.Button();
            this.btnPrintDeviceInfo = new System.Windows.Forms.Button();
            this.btnPrintClear = new System.Windows.Forms.Button();
            this.btnCPUInfo = new System.Windows.Forms.Button();
            this.btnScreenParams = new System.Windows.Forms.Button();
            this.btnMemoryInfo = new System.Windows.Forms.Button();
            this.btnConnectDevices = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProssFilter = new System.Windows.Forms.TextBox();
            this.btnProcessShow = new System.Windows.Forms.Button();
            this.txtLogFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogFilter = new System.Windows.Forms.Button();
            this.btnCurentAcitivity = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(397, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "执行命令";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(478, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "结束命令";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtOutPutInfo
            // 
            this.txtOutPutInfo.Location = new System.Drawing.Point(0, 120);
            this.txtOutPutInfo.Multiline = true;
            this.txtOutPutInfo.Name = "txtOutPutInfo";
            this.txtOutPutInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutPutInfo.Size = new System.Drawing.Size(918, 431);
            this.txtOutPutInfo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dos命令:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(73, 9);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(318, 21);
            this.txtCommand.TabIndex = 4;
            this.txtCommand.Text = "adb devices";
            this.txtCommand.TextChanged += new System.EventHandler(this.txtCommand_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "快捷命令:";
            // 
            // btnPrintLog
            // 
            this.btnPrintLog.Location = new System.Drawing.Point(73, 34);
            this.btnPrintLog.Name = "btnPrintLog";
            this.btnPrintLog.Size = new System.Drawing.Size(75, 23);
            this.btnPrintLog.TabIndex = 6;
            this.btnPrintLog.Text = "薪起程日志";
            this.btnPrintLog.UseVisualStyleBackColor = true;
            this.btnPrintLog.Click += new System.EventHandler(this.btnPrintLog_Click);
            // 
            // btnPrintDeviceInfo
            // 
            this.btnPrintDeviceInfo.Location = new System.Drawing.Point(154, 34);
            this.btnPrintDeviceInfo.Name = "btnPrintDeviceInfo";
            this.btnPrintDeviceInfo.Size = new System.Drawing.Size(75, 23);
            this.btnPrintDeviceInfo.TabIndex = 7;
            this.btnPrintDeviceInfo.Text = "屏幕分辨率";
            this.btnPrintDeviceInfo.UseVisualStyleBackColor = true;
            this.btnPrintDeviceInfo.Click += new System.EventHandler(this.btnPrintDeviceInfo_Click);
            // 
            // btnPrintClear
            // 
            this.btnPrintClear.Location = new System.Drawing.Point(559, 5);
            this.btnPrintClear.Name = "btnPrintClear";
            this.btnPrintClear.Size = new System.Drawing.Size(75, 23);
            this.btnPrintClear.TabIndex = 8;
            this.btnPrintClear.Text = "清理屏幕";
            this.btnPrintClear.UseVisualStyleBackColor = true;
            this.btnPrintClear.Click += new System.EventHandler(this.btnPrintClear_Click);
            // 
            // btnCPUInfo
            // 
            this.btnCPUInfo.Location = new System.Drawing.Point(235, 34);
            this.btnCPUInfo.Name = "btnCPUInfo";
            this.btnCPUInfo.Size = new System.Drawing.Size(75, 23);
            this.btnCPUInfo.TabIndex = 9;
            this.btnCPUInfo.Text = "CPU信息";
            this.btnCPUInfo.UseVisualStyleBackColor = true;
            this.btnCPUInfo.Click += new System.EventHandler(this.btnCPUInfo_Click);
            // 
            // btnScreenParams
            // 
            this.btnScreenParams.Location = new System.Drawing.Point(316, 34);
            this.btnScreenParams.Name = "btnScreenParams";
            this.btnScreenParams.Size = new System.Drawing.Size(75, 23);
            this.btnScreenParams.TabIndex = 10;
            this.btnScreenParams.Text = "屏幕参数";
            this.btnScreenParams.UseVisualStyleBackColor = true;
            this.btnScreenParams.Click += new System.EventHandler(this.btnScreenParams_Click);
            // 
            // btnMemoryInfo
            // 
            this.btnMemoryInfo.Location = new System.Drawing.Point(397, 34);
            this.btnMemoryInfo.Name = "btnMemoryInfo";
            this.btnMemoryInfo.Size = new System.Drawing.Size(75, 23);
            this.btnMemoryInfo.TabIndex = 11;
            this.btnMemoryInfo.Text = "内存信息";
            this.btnMemoryInfo.UseVisualStyleBackColor = true;
            this.btnMemoryInfo.Click += new System.EventHandler(this.btnMemoryInfo_Click);
            // 
            // btnConnectDevices
            // 
            this.btnConnectDevices.Location = new System.Drawing.Point(478, 34);
            this.btnConnectDevices.Name = "btnConnectDevices";
            this.btnConnectDevices.Size = new System.Drawing.Size(75, 23);
            this.btnConnectDevices.TabIndex = 12;
            this.btnConnectDevices.Text = "连接的设备";
            this.btnConnectDevices.UseVisualStyleBackColor = true;
            this.btnConnectDevices.Click += new System.EventHandler(this.btnConnectDevices_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "过滤进程:";
            // 
            // txtProssFilter
            // 
            this.txtProssFilter.Location = new System.Drawing.Point(73, 66);
            this.txtProssFilter.Name = "txtProssFilter";
            this.txtProssFilter.Size = new System.Drawing.Size(318, 21);
            this.txtProssFilter.TabIndex = 14;
            this.txtProssFilter.Text = "qq";
            // 
            // btnProcessShow
            // 
            this.btnProcessShow.Location = new System.Drawing.Point(397, 63);
            this.btnProcessShow.Name = "btnProcessShow";
            this.btnProcessShow.Size = new System.Drawing.Size(75, 23);
            this.btnProcessShow.TabIndex = 15;
            this.btnProcessShow.Text = "查看进程";
            this.btnProcessShow.UseVisualStyleBackColor = true;
            this.btnProcessShow.Click += new System.EventHandler(this.btnProcessShow_Click);
            // 
            // txtLogFilter
            // 
            this.txtLogFilter.Location = new System.Drawing.Point(73, 93);
            this.txtLogFilter.Name = "txtLogFilter";
            this.txtLogFilter.Size = new System.Drawing.Size(318, 21);
            this.txtLogFilter.TabIndex = 16;
            this.txtLogFilter.Text = "RxLog";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "过滤标签:";
            // 
            // btnLogFilter
            // 
            this.btnLogFilter.Location = new System.Drawing.Point(397, 92);
            this.btnLogFilter.Name = "btnLogFilter";
            this.btnLogFilter.Size = new System.Drawing.Size(75, 23);
            this.btnLogFilter.TabIndex = 18;
            this.btnLogFilter.Text = "查看日志";
            this.btnLogFilter.UseVisualStyleBackColor = true;
            this.btnLogFilter.Click += new System.EventHandler(this.btnLogFilter_Click);
            // 
            // btnCurentAcitivity
            // 
            this.btnCurentAcitivity.Location = new System.Drawing.Point(559, 34);
            this.btnCurentAcitivity.Name = "btnCurentAcitivity";
            this.btnCurentAcitivity.Size = new System.Drawing.Size(75, 23);
            this.btnCurentAcitivity.TabIndex = 19;
            this.btnCurentAcitivity.Text = "当前界面";
            this.btnCurentAcitivity.UseVisualStyleBackColor = true;
            this.btnCurentAcitivity.Click += new System.EventHandler(this.btnCurentAcitivity_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(650, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "赞助bug...(gd.hexiang@gmail.com)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(787, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 548);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCurentAcitivity);
            this.Controls.Add(this.btnLogFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLogFilter);
            this.Controls.Add(this.btnProcessShow);
            this.Controls.Add(this.txtProssFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConnectDevices);
            this.Controls.Add(this.btnMemoryInfo);
            this.Controls.Add(this.btnScreenParams);
            this.Controls.Add(this.btnCPUInfo);
            this.Controls.Add(this.btnPrintClear);
            this.Controls.Add(this.btnPrintDeviceInfo);
            this.Controls.Add(this.btnPrintLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutPutInfo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(935, 591);
            this.Name = "MainForm";
            this.Text = "日志工具助手v.1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtOutPutInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrintLog;
        private System.Windows.Forms.Button btnPrintDeviceInfo;
        private System.Windows.Forms.Button btnPrintClear;
        private System.Windows.Forms.Button btnCPUInfo;
        private System.Windows.Forms.Button btnScreenParams;
        private System.Windows.Forms.Button btnMemoryInfo;
        private System.Windows.Forms.Button btnConnectDevices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProssFilter;
        private System.Windows.Forms.Button btnProcessShow;
        private System.Windows.Forms.TextBox txtLogFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogFilter;
        private System.Windows.Forms.Button btnCurentAcitivity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

