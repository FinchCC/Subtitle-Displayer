namespace SubToChrome
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnPreload = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblSettingsPanel = new System.Windows.Forms.Panel();
            this.lblcleanbox = new System.Windows.Forms.CheckBox();
            this.txtClean = new System.Windows.Forms.Label();
            this.lblhotkeycheck = new System.Windows.Forms.CheckBox();
            this.txtMoviemode = new System.Windows.Forms.Label();
            this.lblHotkeys = new System.Windows.Forms.CheckBox();
            this.txtHotkeys = new System.Windows.Forms.Label();
            this.txtCenterSubs = new System.Windows.Forms.Label();
            this.lblCenterSub = new System.Windows.Forms.CheckBox();
            this.txtSecs = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.TextBox();
            this.txtStartpos = new System.Windows.Forms.Label();
            this.txtMisc = new System.Windows.Forms.Label();
            this.btnDefault = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.TextBox();
            this.txtPos = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSettings = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.lblUpdater = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.btnFwd = new System.Windows.Forms.Button();
            this.btnBwd = new System.Windows.Forms.Button();
            this.txtSkipammount = new System.Windows.Forms.Label();
            this.lblSkipInSeconds = new System.Windows.Forms.TextBox();
            this.txtSecondsss = new System.Windows.Forms.Label();
            this.lblSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(88, 382);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(180, 38);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start! (press space on movie)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(224, 49);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(44, 20);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnPreload
            // 
            this.btnPreload.Location = new System.Drawing.Point(88, 75);
            this.btnPreload.Name = "btnPreload";
            this.btnPreload.Size = new System.Drawing.Size(180, 23);
            this.btnPreload.TabIndex = 3;
            this.btnPreload.Text = "Preload (required)";
            this.btnPreload.UseVisualStyleBackColor = true;
            this.btnPreload.Click += new System.EventHandler(this.btnPreload_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(88, 105);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(180, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(310, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(41, 23);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "?";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblSettingsPanel
            // 
            this.lblSettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSettingsPanel.Controls.Add(this.txtSecondsss);
            this.lblSettingsPanel.Controls.Add(this.lblSkipInSeconds);
            this.lblSettingsPanel.Controls.Add(this.txtSkipammount);
            this.lblSettingsPanel.Controls.Add(this.lblcleanbox);
            this.lblSettingsPanel.Controls.Add(this.txtClean);
            this.lblSettingsPanel.Controls.Add(this.lblhotkeycheck);
            this.lblSettingsPanel.Controls.Add(this.txtMoviemode);
            this.lblSettingsPanel.Controls.Add(this.lblHotkeys);
            this.lblSettingsPanel.Controls.Add(this.txtHotkeys);
            this.lblSettingsPanel.Controls.Add(this.txtCenterSubs);
            this.lblSettingsPanel.Controls.Add(this.lblCenterSub);
            this.lblSettingsPanel.Controls.Add(this.txtSecs);
            this.lblSettingsPanel.Controls.Add(this.lblSeconds);
            this.lblSettingsPanel.Controls.Add(this.txtStartpos);
            this.lblSettingsPanel.Controls.Add(this.txtMisc);
            this.lblSettingsPanel.Controls.Add(this.btnDefault);
            this.lblSettingsPanel.Controls.Add(this.lblSave);
            this.lblSettingsPanel.Controls.Add(this.label2);
            this.lblSettingsPanel.Controls.Add(this.label1);
            this.lblSettingsPanel.Controls.Add(this.lblX);
            this.lblSettingsPanel.Controls.Add(this.lblY);
            this.lblSettingsPanel.Controls.Add(this.lblSize);
            this.lblSettingsPanel.Controls.Add(this.txtPos);
            this.lblSettingsPanel.Controls.Add(this.txtSize);
            this.lblSettingsPanel.Controls.Add(this.btnExit);
            this.lblSettingsPanel.Controls.Add(this.txtSettings);
            this.lblSettingsPanel.ForeColor = System.Drawing.Color.Linen;
            this.lblSettingsPanel.Location = new System.Drawing.Point(88, -1);
            this.lblSettingsPanel.Name = "lblSettingsPanel";
            this.lblSettingsPanel.Size = new System.Drawing.Size(275, 450);
            this.lblSettingsPanel.TabIndex = 6;
            // 
            // lblcleanbox
            // 
            this.lblcleanbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcleanbox.Location = new System.Drawing.Point(183, 141);
            this.lblcleanbox.Name = "lblcleanbox";
            this.lblcleanbox.Size = new System.Drawing.Size(79, 20);
            this.lblcleanbox.TabIndex = 27;
            this.lblcleanbox.Text = "click me to enable";
            this.lblcleanbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcleanbox.UseVisualStyleBackColor = true;
            this.lblcleanbox.CheckedChanged += new System.EventHandler(this.lblcleanbox_CheckedChanged);
            // 
            // txtClean
            // 
            this.txtClean.AutoSize = true;
            this.txtClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClean.Location = new System.Drawing.Point(16, 141);
            this.txtClean.Name = "txtClean";
            this.txtClean.Size = new System.Drawing.Size(78, 16);
            this.txtClean.TabIndex = 26;
            this.txtClean.Text = "Clean subs:";
            // 
            // lblhotkeycheck
            // 
            this.lblhotkeycheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhotkeycheck.Location = new System.Drawing.Point(183, 353);
            this.lblhotkeycheck.Name = "lblhotkeycheck";
            this.lblhotkeycheck.Size = new System.Drawing.Size(79, 20);
            this.lblhotkeycheck.TabIndex = 25;
            this.lblhotkeycheck.Text = "click me to enable";
            this.lblhotkeycheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblhotkeycheck.UseVisualStyleBackColor = true;
            this.lblhotkeycheck.CheckedChanged += new System.EventHandler(this.lblhotkeycheck_CheckedChanged);
            // 
            // txtMoviemode
            // 
            this.txtMoviemode.AutoSize = true;
            this.txtMoviemode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoviemode.Location = new System.Drawing.Point(20, 356);
            this.txtMoviemode.Name = "txtMoviemode";
            this.txtMoviemode.Size = new System.Drawing.Size(129, 13);
            this.txtMoviemode.TabIndex = 24;
            this.txtMoviemode.Text = "---> key to enable hotkeys";
            this.toolTip3.SetToolTip(this.txtMoviemode, "(recommended!)\r\nA button you can press so that you dont unpause and\r\npause the su" +
        "btitles everytime you press space\r\nDefault = insert");
            // 
            // lblHotkeys
            // 
            this.lblHotkeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotkeys.Location = new System.Drawing.Point(183, 327);
            this.lblHotkeys.Name = "lblHotkeys";
            this.lblHotkeys.Size = new System.Drawing.Size(79, 20);
            this.lblHotkeys.TabIndex = 23;
            this.lblHotkeys.Text = "click me to enable";
            this.lblHotkeys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHotkeys.UseVisualStyleBackColor = true;
            this.lblHotkeys.CheckedChanged += new System.EventHandler(this.lblHotkeys_CheckedChanged);
            // 
            // txtHotkeys
            // 
            this.txtHotkeys.AutoSize = true;
            this.txtHotkeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotkeys.Location = new System.Drawing.Point(14, 331);
            this.txtHotkeys.Name = "txtHotkeys";
            this.txtHotkeys.Size = new System.Drawing.Size(104, 16);
            this.txtHotkeys.TabIndex = 22;
            this.txtHotkeys.Text = "Global Hotkeys:";
            this.toolTip3.SetToolTip(this.txtHotkeys, "(recommended!)\r\nWill hook windows api so that hotkeys will function even\r\nwhen th" +
        "is program isn\'t in focus");
            // 
            // txtCenterSubs
            // 
            this.txtCenterSubs.AutoSize = true;
            this.txtCenterSubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCenterSubs.Location = new System.Drawing.Point(14, 304);
            this.txtCenterSubs.Name = "txtCenterSubs";
            this.txtCenterSubs.Size = new System.Drawing.Size(84, 16);
            this.txtCenterSubs.TabIndex = 21;
            this.txtCenterSubs.Text = "Center Subs:";
            this.toolTip2.SetToolTip(this.txtCenterSubs, "by enabling this the subtitles wil always be centered on screen\r\n    -might have " +
        "a small performance impact, most likely unoticeble\r\n");
            // 
            // lblCenterSub
            // 
            this.lblCenterSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenterSub.Location = new System.Drawing.Point(183, 300);
            this.lblCenterSub.Name = "lblCenterSub";
            this.lblCenterSub.Size = new System.Drawing.Size(79, 20);
            this.lblCenterSub.TabIndex = 20;
            this.lblCenterSub.Text = "click me to enable";
            this.lblCenterSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCenterSub.UseVisualStyleBackColor = true;
            this.lblCenterSub.CheckedChanged += new System.EventHandler(this.lblCenterSub_CheckedChanged);
            // 
            // txtSecs
            // 
            this.txtSecs.AutoSize = true;
            this.txtSecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecs.Location = new System.Drawing.Point(180, 255);
            this.txtSecs.Name = "txtSecs";
            this.txtSecs.Size = new System.Drawing.Size(83, 16);
            this.txtSecs.TabIndex = 19;
            this.txtSecs.Text = "Miliseconds:";
            // 
            // lblSeconds
            // 
            this.lblSeconds.Location = new System.Drawing.Point(183, 274);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(79, 20);
            this.lblSeconds.TabIndex = 14;
            // 
            // txtStartpos
            // 
            this.txtStartpos.AutoSize = true;
            this.txtStartpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartpos.Location = new System.Drawing.Point(14, 275);
            this.txtStartpos.Name = "txtStartpos";
            this.txtStartpos.Size = new System.Drawing.Size(89, 16);
            this.txtStartpos.TabIndex = 13;
            this.txtStartpos.Text = "Start Position:";
            this.toolTip1.SetToolTip(this.txtStartpos, resources.GetString("txtStartpos.ToolTip"));
            // 
            // txtMisc
            // 
            this.txtMisc.AutoSize = true;
            this.txtMisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMisc.ForeColor = System.Drawing.Color.Gold;
            this.txtMisc.Location = new System.Drawing.Point(12, 229);
            this.txtMisc.Name = "txtMisc";
            this.txtMisc.Size = new System.Drawing.Size(63, 25);
            this.txtMisc.TabIndex = 12;
            this.txtMisc.Text = "Misc:";
            // 
            // btnDefault
            // 
            this.btnDefault.ForeColor = System.Drawing.Color.Black;
            this.btnDefault.Location = new System.Drawing.Point(189, 210);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(74, 23);
            this.btnDefault.TabIndex = 11;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // lblSave
            // 
            this.lblSave.ForeColor = System.Drawing.Color.Black;
            this.lblSave.Location = new System.Drawing.Point(170, 416);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(93, 23);
            this.lblSave.TabIndex = 10;
            this.lblSave.Text = "Save and exit!";
            this.lblSave.UseVisualStyleBackColor = true;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "y(|):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "x(-):";
            // 
            // lblX
            // 
            this.lblX.Location = new System.Drawing.Point(110, 105);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(41, 20);
            this.lblX.TabIndex = 6;
            // 
            // lblY
            // 
            this.lblY.Location = new System.Drawing.Point(221, 105);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(41, 20);
            this.lblY.TabIndex = 5;
            // 
            // lblSize
            // 
            this.lblSize.Location = new System.Drawing.Point(222, 73);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(41, 20);
            this.lblSize.TabIndex = 4;
            // 
            // txtPos
            // 
            this.txtPos.AutoSize = true;
            this.txtPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPos.Location = new System.Drawing.Point(14, 106);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(64, 16);
            this.txtPos.TabIndex = 3;
            this.txtPos.Text = "Font Pos:";
            // 
            // txtSize
            // 
            this.txtSize.AutoSize = true;
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(14, 73);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(66, 16);
            this.txtSize.TabIndex = 2;
            this.txtSize.Text = "Font Size:";
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(222, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSettings
            // 
            this.txtSettings.AutoSize = true;
            this.txtSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSettings.ForeColor = System.Drawing.Color.Gold;
            this.txtSettings.Location = new System.Drawing.Point(12, 22);
            this.txtSettings.Name = "txtSettings";
            this.txtSettings.Size = new System.Drawing.Size(96, 25);
            this.txtSettings.TabIndex = 0;
            this.txtSettings.Text = "Settings:";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Starting in the middle of a movie:";
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 200;
            this.toolTip2.AutoPopDelay = 10000;
            this.toolTip2.InitialDelay = 200;
            this.toolTip2.ReshowDelay = 40;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Centering subtitles?";
            // 
            // lblUpdater
            // 
            this.lblUpdater.Tick += new System.EventHandler(this.lblUpdater_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(88, 382);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(180, 38);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "To Pause click or press space";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // toolTip3
            // 
            this.toolTip3.AutomaticDelay = 200;
            this.toolTip3.AutoPopDelay = 10000;
            this.toolTip3.InitialDelay = 200;
            this.toolTip3.ReshowDelay = 40;
            this.toolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip3.ToolTipTitle = "Hotkeys:";
            // 
            // btnFwd
            // 
            this.btnFwd.Location = new System.Drawing.Point(275, 382);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(32, 37);
            this.btnFwd.TabIndex = 8;
            this.btnFwd.Text = "->";
            this.btnFwd.UseVisualStyleBackColor = true;
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // btnBwd
            // 
            this.btnBwd.Location = new System.Drawing.Point(50, 382);
            this.btnBwd.Name = "btnBwd";
            this.btnBwd.Size = new System.Drawing.Size(32, 37);
            this.btnBwd.TabIndex = 9;
            this.btnBwd.Text = "<-";
            this.btnBwd.UseVisualStyleBackColor = true;
            this.btnBwd.Click += new System.EventHandler(this.btnBwd_Click);
            // 
            // txtSkipammount
            // 
            this.txtSkipammount.AutoSize = true;
            this.txtSkipammount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSkipammount.Location = new System.Drawing.Point(14, 171);
            this.txtSkipammount.Name = "txtSkipammount";
            this.txtSkipammount.Size = new System.Drawing.Size(96, 16);
            this.txtSkipammount.TabIndex = 28;
            this.txtSkipammount.Text = "Skip ammount:";
            // 
            // lblSkipInSeconds
            // 
            this.lblSkipInSeconds.Location = new System.Drawing.Point(221, 167);
            this.lblSkipInSeconds.Name = "lblSkipInSeconds";
            this.lblSkipInSeconds.Size = new System.Drawing.Size(41, 20);
            this.lblSkipInSeconds.TabIndex = 29;
            this.lblSkipInSeconds.TextChanged += new System.EventHandler(this.lblSkipInSeconds_TextChanged);
            // 
            // txtSecondsss
            // 
            this.txtSecondsss.AutoSize = true;
            this.txtSecondsss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondsss.Location = new System.Drawing.Point(186, 171);
            this.txtSecondsss.Name = "txtSecondsss";
            this.txtSecondsss.Size = new System.Drawing.Size(26, 16);
            this.txtSecondsss.TabIndex = 30;
            this.txtSecondsss.Text = "(s):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SubToChrome.Properties.Resources.Uten_navn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.btnBwd);
            this.Controls.Add(this.lblSettingsPanel);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnPreload);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnFwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lblSettingsPanel.ResumeLayout(false);
            this.lblSettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnOpenFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnPreload;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel lblSettingsPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label txtSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblX;
        private System.Windows.Forms.TextBox lblY;
        private System.Windows.Forms.TextBox lblSize;
        private System.Windows.Forms.Label txtPos;
        private System.Windows.Forms.Label txtSize;
        private System.Windows.Forms.Button lblSave;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Label txtStartpos;
        private System.Windows.Forms.Label txtMisc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label txtSecs;
        private System.Windows.Forms.TextBox lblSeconds;
        private System.Windows.Forms.Label txtCenterSubs;
        private System.Windows.Forms.CheckBox lblCenterSub;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Timer lblUpdater;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.CheckBox lblHotkeys;
        private System.Windows.Forms.Label txtHotkeys;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Label txtMoviemode;
        private System.Windows.Forms.CheckBox lblhotkeycheck;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Button btnBwd;
        private System.Windows.Forms.CheckBox lblcleanbox;
        private System.Windows.Forms.Label txtClean;
        private System.Windows.Forms.Label txtSecondsss;
        private System.Windows.Forms.TextBox lblSkipInSeconds;
        private System.Windows.Forms.Label txtSkipammount;
    }
}

