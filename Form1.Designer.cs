namespace pro2
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connectPLC = new System.Windows.Forms.Button();
            this.plcport = new System.Windows.Forms.TextBox();
            this.plcaddr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.localaddr = new System.Windows.Forms.TextBox();
            this.localport = new System.Windows.Forms.TextBox();
            this.openServer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.recvShow3 = new pro2.recvShow();
            this.recvShow2 = new pro2.recvShow();
            this.recvShow1 = new pro2.recvShow();
            this.recvShow6 = new pro2.recvShow();
            this.recvShow5 = new pro2.recvShow();
            this.recvShow4 = new pro2.recvShow();
            this.sendDat = new System.Windows.Forms.TextBox();
            this.writeToplc = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.recvShow3);
            this.tabPage1.Controls.Add(this.recvShow2);
            this.tabPage1.Controls.Add(this.recvShow1);
            this.tabPage1.Controls.Add(this.connectPLC);
            this.tabPage1.Controls.Add(this.plcport);
            this.tabPage1.Controls.Add(this.plcaddr);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(738, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "plc做服务器";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "读real";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "读byte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "读bool";
            // 
            // connectPLC
            // 
            this.connectPLC.BackColor = System.Drawing.Color.Silver;
            this.connectPLC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.connectPLC.Location = new System.Drawing.Point(417, 48);
            this.connectPLC.Name = "connectPLC";
            this.connectPLC.Size = new System.Drawing.Size(111, 55);
            this.connectPLC.TabIndex = 2;
            this.connectPLC.Text = "连接";
            this.connectPLC.UseVisualStyleBackColor = false;
            this.connectPLC.Click += new System.EventHandler(this.connectPLC_Click);
            // 
            // plcport
            // 
            this.plcport.Location = new System.Drawing.Point(178, 83);
            this.plcport.Name = "plcport";
            this.plcport.Size = new System.Drawing.Size(204, 30);
            this.plcport.TabIndex = 1;
            this.plcport.Text = "2000";
            // 
            // plcaddr
            // 
            this.plcaddr.Location = new System.Drawing.Point(178, 42);
            this.plcaddr.Name = "plcaddr";
            this.plcaddr.Size = new System.Drawing.Size(204, 30);
            this.plcaddr.TabIndex = 1;
            this.plcaddr.Text = "192.168.2.15";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "端口号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLC IP 地址:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.writeToplc);
            this.tabPage2.Controls.Add(this.sendDat);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.recvShow6);
            this.tabPage2.Controls.Add(this.recvShow5);
            this.tabPage2.Controls.Add(this.recvShow4);
            this.tabPage2.Controls.Add(this.openServer);
            this.tabPage2.Controls.Add(this.localport);
            this.tabPage2.Controls.Add(this.localaddr);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(738, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "plc做客户端";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(21, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "本地IP 地址:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(21, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "本地端口:";
            // 
            // localaddr
            // 
            this.localaddr.Location = new System.Drawing.Point(166, 52);
            this.localaddr.Name = "localaddr";
            this.localaddr.ReadOnly = true;
            this.localaddr.Size = new System.Drawing.Size(204, 30);
            this.localaddr.TabIndex = 2;
            this.localaddr.Text = "192.168.2.214";
            // 
            // localport
            // 
            this.localport.Location = new System.Drawing.Point(166, 124);
            this.localport.Name = "localport";
            this.localport.Size = new System.Drawing.Size(204, 30);
            this.localport.TabIndex = 2;
            this.localport.Text = "2001";
            // 
            // openServer
            // 
            this.openServer.BackColor = System.Drawing.Color.Silver;
            this.openServer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.openServer.Location = new System.Drawing.Point(440, 73);
            this.openServer.Name = "openServer";
            this.openServer.Size = new System.Drawing.Size(111, 55);
            this.openServer.TabIndex = 3;
            this.openServer.Text = "打开";
            this.openServer.UseVisualStyleBackColor = false;
            this.openServer.Click += new System.EventHandler(this.openServer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "读real";
            // 
            // recvShow3
            // 
            this.recvShow3.DataType = thinger.DataConvertLib.DataType.Float;
            this.recvShow3.Location = new System.Drawing.Point(34, 357);
            this.recvShow3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recvShow3.Name = "recvShow3";
            this.recvShow3.Offset = 2;
            this.recvShow3.Size = new System.Drawing.Size(357, 57);
            this.recvShow3.Start = 2;
            this.recvShow3.TabIndex = 6;
            this.recvShow3.VarString = null;
            // 
            // recvShow2
            // 
            this.recvShow2.DataType = thinger.DataConvertLib.DataType.Byte;
            this.recvShow2.Location = new System.Drawing.Point(34, 274);
            this.recvShow2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recvShow2.Name = "recvShow2";
            this.recvShow2.Offset = 1;
            this.recvShow2.Size = new System.Drawing.Size(357, 57);
            this.recvShow2.Start = 1;
            this.recvShow2.TabIndex = 5;
            this.recvShow2.VarString = null;
            // 
            // recvShow1
            // 
            this.recvShow1.DataType = thinger.DataConvertLib.DataType.Bool;
            this.recvShow1.Location = new System.Drawing.Point(46, 198);
            this.recvShow1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recvShow1.Name = "recvShow1";
            this.recvShow1.Offset = 0;
            this.recvShow1.Size = new System.Drawing.Size(358, 57);
            this.recvShow1.Start = 0;
            this.recvShow1.TabIndex = 4;
            this.recvShow1.VarString = null;
            // 
            // recvShow6
            // 
            this.recvShow6.DataType = thinger.DataConvertLib.DataType.Float;
            this.recvShow6.Location = new System.Drawing.Point(72, 313);
            this.recvShow6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recvShow6.Name = "recvShow6";
            this.recvShow6.Offset = 0;
            this.recvShow6.Size = new System.Drawing.Size(388, 57);
            this.recvShow6.Start = 8;
            this.recvShow6.TabIndex = 7;
            this.recvShow6.VarString = null;
            // 
            // recvShow5
            // 
            this.recvShow5.DataType = thinger.DataConvertLib.DataType.Float;
            this.recvShow5.Location = new System.Drawing.Point(72, 245);
            this.recvShow5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recvShow5.Name = "recvShow5";
            this.recvShow5.Offset = 0;
            this.recvShow5.Size = new System.Drawing.Size(388, 57);
            this.recvShow5.Start = 4;
            this.recvShow5.TabIndex = 6;
            this.recvShow5.VarString = null;
            // 
            // recvShow4
            // 
            this.recvShow4.DataType = thinger.DataConvertLib.DataType.Float;
            this.recvShow4.Location = new System.Drawing.Point(26, 195);
            this.recvShow4.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.recvShow4.Name = "recvShow4";
            this.recvShow4.Offset = 0;
            this.recvShow4.Size = new System.Drawing.Size(448, 87);
            this.recvShow4.Start = 0;
            this.recvShow4.TabIndex = 5;
            this.recvShow4.VarString = null;
            // 
            // sendDat
            // 
            this.sendDat.Location = new System.Drawing.Point(259, 423);
            this.sendDat.Name = "sendDat";
            this.sendDat.Size = new System.Drawing.Size(224, 30);
            this.sendDat.TabIndex = 9;
            // 
            // writeToplc
            // 
            this.writeToplc.Location = new System.Drawing.Point(544, 399);
            this.writeToplc.Name = "writeToplc";
            this.writeToplc.Size = new System.Drawing.Size(96, 54);
            this.writeToplc.TabIndex = 10;
            this.writeToplc.Text = "写入";
            this.writeToplc.UseVisualStyleBackColor = true;
            this.writeToplc.Click += new System.EventHandler(this.writeToplc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 563);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socket_PLC1500";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox plcport;
        private System.Windows.Forms.TextBox plcaddr;
        private System.Windows.Forms.Button connectPLC;
        private recvShow recvShow1;
        private recvShow recvShow2;
        private recvShow recvShow3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button openServer;
        private System.Windows.Forms.TextBox localport;
        private System.Windows.Forms.TextBox localaddr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private recvShow recvShow6;
        private recvShow recvShow5;
        private recvShow recvShow4;
        private System.Windows.Forms.Button writeToplc;
        private System.Windows.Forms.TextBox sendDat;
    }
}

