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
            this.writeToplc = new System.Windows.Forms.Button();
            this.sendDat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openServer = new System.Windows.Forms.Button();
            this.localport = new System.Windows.Forms.TextBox();
            this.localaddr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.stopMqtt = new System.Windows.Forms.Button();
            this.openMqtt = new System.Windows.Forms.Button();
            this.mqttSport = new System.Windows.Forms.TextBox();
            this.mqttSip = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pb = new System.Windows.Forms.Button();
            this.disConnect = new System.Windows.Forms.Button();
            this.connectServer = new System.Windows.Forms.Button();
            this.uname = new System.Windows.Forms.TextBox();
            this.serverIP = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.mqttCport = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sendmsg = new System.Windows.Forms.TextBox();
            this.recvShow3 = new pro2.recvShow();
            this.recvShow2 = new pro2.recvShow();
            this.recvShow1 = new pro2.recvShow();
            this.recvShow6 = new pro2.recvShow();
            this.recvShow5 = new pro2.recvShow();
            this.recvShow4 = new pro2.recvShow();
            this.recvFromTopic = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
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
            this.tabPage2.Controls.Add(this.openServer);
            this.tabPage2.Controls.Add(this.localport);
            this.tabPage2.Controls.Add(this.localaddr);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.recvShow6);
            this.tabPage2.Controls.Add(this.recvShow5);
            this.tabPage2.Controls.Add(this.recvShow4);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(738, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "plc做客户端";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // sendDat
            // 
            this.sendDat.Location = new System.Drawing.Point(259, 423);
            this.sendDat.Name = "sendDat";
            this.sendDat.Size = new System.Drawing.Size(224, 30);
            this.sendDat.TabIndex = 9;
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
            // localport
            // 
            this.localport.Location = new System.Drawing.Point(166, 124);
            this.localport.Name = "localport";
            this.localport.Size = new System.Drawing.Size(204, 30);
            this.localport.TabIndex = 2;
            this.localport.Text = "2001";
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.stopMqtt);
            this.tabPage3.Controls.Add(this.openMqtt);
            this.tabPage3.Controls.Add(this.mqttSport);
            this.tabPage3.Controls.Add(this.mqttSip);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(738, 527);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MQTT-Server";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // stopMqtt
            // 
            this.stopMqtt.Location = new System.Drawing.Point(530, 59);
            this.stopMqtt.Name = "stopMqtt";
            this.stopMqtt.Size = new System.Drawing.Size(92, 60);
            this.stopMqtt.TabIndex = 6;
            this.stopMqtt.Text = "停止";
            this.stopMqtt.UseVisualStyleBackColor = true;
            this.stopMqtt.Click += new System.EventHandler(this.stopMqtt_Click);
            // 
            // openMqtt
            // 
            this.openMqtt.Location = new System.Drawing.Point(406, 55);
            this.openMqtt.Name = "openMqtt";
            this.openMqtt.Size = new System.Drawing.Size(96, 68);
            this.openMqtt.TabIndex = 5;
            this.openMqtt.Text = "启动";
            this.openMqtt.UseVisualStyleBackColor = true;
            this.openMqtt.Click += new System.EventHandler(this.openMqtt_Click);
            // 
            // mqttSport
            // 
            this.mqttSport.Location = new System.Drawing.Point(137, 97);
            this.mqttSport.Name = "mqttSport";
            this.mqttSport.Size = new System.Drawing.Size(92, 30);
            this.mqttSport.TabIndex = 4;
            this.mqttSport.Text = "1883";
            // 
            // mqttSip
            // 
            this.mqttSip.FormattingEnabled = true;
            this.mqttSip.Location = new System.Drawing.Point(132, 34);
            this.mqttSip.Name = "mqttSip";
            this.mqttSip.Size = new System.Drawing.Size(229, 31);
            this.mqttSip.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(27, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 30);
            this.label10.TabIndex = 2;
            this.label10.Text = "端口号:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(22, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "IP 地址:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.recvFromTopic);
            this.tabPage4.Controls.Add(this.pb);
            this.tabPage4.Controls.Add(this.disConnect);
            this.tabPage4.Controls.Add(this.connectServer);
            this.tabPage4.Controls.Add(this.uname);
            this.tabPage4.Controls.Add(this.serverIP);
            this.tabPage4.Controls.Add(this.sendmsg);
            this.tabPage4.Controls.Add(this.pwd);
            this.tabPage4.Controls.Add(this.mqttCport);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(738, 527);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "MQTT-Client";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(538, 311);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(117, 60);
            this.pb.TabIndex = 12;
            this.pb.Text = "发布";
            this.pb.UseVisualStyleBackColor = true;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            // 
            // disConnect
            // 
            this.disConnect.Location = new System.Drawing.Point(550, 116);
            this.disConnect.Name = "disConnect";
            this.disConnect.Size = new System.Drawing.Size(117, 60);
            this.disConnect.TabIndex = 12;
            this.disConnect.Text = "断开连接";
            this.disConnect.UseVisualStyleBackColor = true;
            this.disConnect.Click += new System.EventHandler(this.disConnect_Click);
            // 
            // connectServer
            // 
            this.connectServer.Location = new System.Drawing.Point(426, 112);
            this.connectServer.Name = "connectServer";
            this.connectServer.Size = new System.Drawing.Size(96, 68);
            this.connectServer.TabIndex = 11;
            this.connectServer.Text = "连接";
            this.connectServer.UseVisualStyleBackColor = true;
            this.connectServer.Click += new System.EventHandler(this.connectServer_Click);
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(162, 219);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(222, 30);
            this.uname.TabIndex = 10;
            this.uname.Text = "kun";
            // 
            // serverIP
            // 
            this.serverIP.Location = new System.Drawing.Point(157, 92);
            this.serverIP.Name = "serverIP";
            this.serverIP.Size = new System.Drawing.Size(198, 30);
            this.serverIP.TabIndex = 10;
            this.serverIP.Text = "192.168.2.214";
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(162, 281);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(222, 30);
            this.pwd.TabIndex = 10;
            this.pwd.Text = "888888";
            // 
            // mqttCport
            // 
            this.mqttCport.Location = new System.Drawing.Point(157, 154);
            this.mqttCport.Name = "mqttCport";
            this.mqttCport.Size = new System.Drawing.Size(92, 30);
            this.mqttCport.TabIndex = 10;
            this.mqttCport.Text = "1883";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(52, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 30);
            this.label14.TabIndex = 7;
            this.label14.Text = "密码:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(47, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 30);
            this.label11.TabIndex = 7;
            this.label11.Text = "端口号:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(47, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 30);
            this.label13.TabIndex = 8;
            this.label13.Text = "用户名:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(42, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 30);
            this.label12.TabIndex = 8;
            this.label12.Text = "IP 地址:";
            // 
            // sendmsg
            // 
            this.sendmsg.Location = new System.Drawing.Point(281, 327);
            this.sendmsg.Name = "sendmsg";
            this.sendmsg.Size = new System.Drawing.Size(222, 30);
            this.sendmsg.TabIndex = 10;
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
            // recvFromTopic
            // 
            this.recvFromTopic.Location = new System.Drawing.Point(69, 381);
            this.recvFromTopic.Name = "recvFromTopic";
            this.recvFromTopic.Size = new System.Drawing.Size(434, 116);
            this.recvFromTopic.TabIndex = 13;
            this.recvFromTopic.Text = "";
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
            this.Text = "Connection";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox mqttSip;
        private System.Windows.Forms.TextBox mqttSport;
        private System.Windows.Forms.Button openMqtt;
        private System.Windows.Forms.Button stopMqtt;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button disConnect;
        private System.Windows.Forms.Button connectServer;
        private System.Windows.Forms.TextBox mqttCport;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox serverIP;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button pb;
        private System.Windows.Forms.TextBox sendmsg;
        private System.Windows.Forms.RichTextBox recvFromTopic;
    }
}

