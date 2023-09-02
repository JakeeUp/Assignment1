namespace GUI101
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGo = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.chkHungry = new System.Windows.Forms.CheckBox();
            this.chk_List = new System.Windows.Forms.CheckedListBox();
            this.cmbCar = new System.Windows.Forms.ComboBox();
            this.dtp_ApptDate = new System.Windows.Forms.DateTimePicker();
            this.label_Appt = new System.Windows.Forms.Label();
            this.lstTeam = new System.Windows.Forms.ListBox();
            this.mskCode = new System.Windows.Forms.MaskedTextBox();
            this.mthCalMeeting = new System.Windows.Forms.MonthCalendar();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.prgGoal = new System.Windows.Forms.ProgressBar();
            this.radCowboys = new System.Windows.Forms.RadioButton();
            this.radBengals = new System.Windows.Forms.RadioButton();
            this.radChargers = new System.Windows.Forms.RadioButton();
            this.radBBQ = new System.Windows.Forms.RadioButton();
            this.radPasta = new System.Windows.Forms.RadioButton();
            this.grpTeams = new System.Windows.Forms.GroupBox();
            this.grpFood = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipsAndTricksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pushButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayGoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkHungryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpTeams.SuspendLayout();
            this.grpFood.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGo.Location = new System.Drawing.Point(45, 272);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(195, 55);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "GO!";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutput.Location = new System.Drawing.Point(45, 76);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(193, 190);
            this.txtOutput.TabIndex = 1;
            // 
            // chkHungry
            // 
            this.chkHungry.AutoSize = true;
            this.chkHungry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkHungry.Location = new System.Drawing.Point(291, 76);
            this.chkHungry.Name = "chkHungry";
            this.chkHungry.Size = new System.Drawing.Size(138, 24);
            this.chkHungry.TabIndex = 2;
            this.chkHungry.Text = "Are you hungry?";
            this.chkHungry.UseVisualStyleBackColor = true;
            // 
            // chk_List
            // 
            this.chk_List.FormattingEnabled = true;
            this.chk_List.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.chk_List.Location = new System.Drawing.Point(291, 119);
            this.chk_List.Name = "chk_List";
            this.chk_List.Size = new System.Drawing.Size(150, 114);
            this.chk_List.TabIndex = 3;
            // 
            // cmbCar
            // 
            this.cmbCar.FormattingEnabled = true;
            this.cmbCar.Items.AddRange(new object[] {
            "Toyota",
            "Honda",
            "Ford",
            "Mitsubishi"});
            this.cmbCar.Location = new System.Drawing.Point(447, 165);
            this.cmbCar.Name = "cmbCar";
            this.cmbCar.Size = new System.Drawing.Size(151, 28);
            this.cmbCar.TabIndex = 4;
            // 
            // dtp_ApptDate
            // 
            this.dtp_ApptDate.Location = new System.Drawing.Point(17, 353);
            this.dtp_ApptDate.Name = "dtp_ApptDate";
            this.dtp_ApptDate.Size = new System.Drawing.Size(250, 27);
            this.dtp_ApptDate.TabIndex = 5;
            // 
            // label_Appt
            // 
            this.label_Appt.AutoSize = true;
            this.label_Appt.BackColor = System.Drawing.SystemColors.Control;
            this.label_Appt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Appt.Location = new System.Drawing.Point(64, 330);
            this.label_Appt.Name = "label_Appt";
            this.label_Appt.Size = new System.Drawing.Size(149, 20);
            this.label_Appt.TabIndex = 6;
            this.label_Appt.Text = "Date of appointment";
            // 
            // lstTeam
            // 
            this.lstTeam.FormattingEnabled = true;
            this.lstTeam.ItemHeight = 20;
            this.lstTeam.Items.AddRange(new object[] {
            "team1",
            "team2",
            "team3"});
            this.lstTeam.Location = new System.Drawing.Point(291, 263);
            this.lstTeam.Name = "lstTeam";
            this.lstTeam.Size = new System.Drawing.Size(96, 64);
            this.lstTeam.TabIndex = 7;
            // 
            // mskCode
            // 
            this.mskCode.Location = new System.Drawing.Point(447, 206);
            this.mskCode.Name = "mskCode";
            this.mskCode.PasswordChar = '*';
            this.mskCode.Size = new System.Drawing.Size(162, 27);
            this.mskCode.TabIndex = 8;
            // 
            // mthCalMeeting
            // 
            this.mthCalMeeting.Location = new System.Drawing.Point(399, 245);
            this.mthCalMeeting.Name = "mthCalMeeting";
            this.mthCalMeeting.TabIndex = 9;
            // 
            // numScore
            // 
            this.numScore.Location = new System.Drawing.Point(399, 513);
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(150, 27);
            this.numScore.TabIndex = 10;
            this.numScore.ValueChanged += new System.EventHandler(this.numScore_ValueChanged);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(4, 544);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(383, 193);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 11;
            this.picLogo.TabStop = false;
            this.toolTip1.SetToolTip(this.picLogo, "RandomImages");
            // 
            // prgGoal
            // 
            this.prgGoal.BackColor = System.Drawing.Color.Red;
            this.prgGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.prgGoal.Location = new System.Drawing.Point(330, 464);
            this.prgGoal.Name = "prgGoal";
            this.prgGoal.Size = new System.Drawing.Size(295, 43);
            this.prgGoal.TabIndex = 12;
            // 
            // radCowboys
            // 
            this.radCowboys.AutoSize = true;
            this.radCowboys.BackColor = System.Drawing.SystemColors.ControlText;
            this.radCowboys.ForeColor = System.Drawing.Color.Cyan;
            this.radCowboys.Location = new System.Drawing.Point(6, 26);
            this.radCowboys.Name = "radCowboys";
            this.radCowboys.Size = new System.Drawing.Size(90, 24);
            this.radCowboys.TabIndex = 13;
            this.radCowboys.TabStop = true;
            this.radCowboys.Text = "Cowboys";
            this.radCowboys.UseVisualStyleBackColor = false;
            this.radCowboys.CheckedChanged += new System.EventHandler(this.radCowboys_CheckedChanged);
            // 
            // radBengals
            // 
            this.radBengals.AutoSize = true;
            this.radBengals.BackColor = System.Drawing.SystemColors.ControlText;
            this.radBengals.Location = new System.Drawing.Point(8, 59);
            this.radBengals.Name = "radBengals";
            this.radBengals.Size = new System.Drawing.Size(82, 24);
            this.radBengals.TabIndex = 13;
            this.radBengals.TabStop = true;
            this.radBengals.Text = "Bengals";
            this.radBengals.UseVisualStyleBackColor = false;
            // 
            // radChargers
            // 
            this.radChargers.AutoSize = true;
            this.radChargers.BackColor = System.Drawing.SystemColors.ControlText;
            this.radChargers.Location = new System.Drawing.Point(8, 89);
            this.radChargers.Name = "radChargers";
            this.radChargers.Size = new System.Drawing.Size(88, 24);
            this.radChargers.TabIndex = 13;
            this.radChargers.TabStop = true;
            this.radChargers.Text = "Chargers";
            this.radChargers.UseVisualStyleBackColor = false;
            // 
            // radBBQ
            // 
            this.radBBQ.AutoSize = true;
            this.radBBQ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radBBQ.Location = new System.Drawing.Point(6, 35);
            this.radBBQ.Name = "radBBQ";
            this.radBBQ.Size = new System.Drawing.Size(59, 24);
            this.radBBQ.TabIndex = 14;
            this.radBBQ.TabStop = true;
            this.radBBQ.Text = "BBQ";
            this.radBBQ.UseVisualStyleBackColor = true;
            this.radBBQ.CheckedChanged += new System.EventHandler(this.radBBQ_CheckedChanged);
            // 
            // radPasta
            // 
            this.radPasta.AutoSize = true;
            this.radPasta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radPasta.Location = new System.Drawing.Point(6, 65);
            this.radPasta.Name = "radPasta";
            this.radPasta.Size = new System.Drawing.Size(64, 24);
            this.radPasta.TabIndex = 14;
            this.radPasta.TabStop = true;
            this.radPasta.Text = "Pasta";
            this.radPasta.UseVisualStyleBackColor = true;
            this.radPasta.CheckedChanged += new System.EventHandler(this.radBBQ_CheckedChanged);
            // 
            // grpTeams
            // 
            this.grpTeams.Controls.Add(this.radCowboys);
            this.grpTeams.Controls.Add(this.radChargers);
            this.grpTeams.Controls.Add(this.radBengals);
            this.grpTeams.Location = new System.Drawing.Point(117, 410);
            this.grpTeams.Name = "grpTeams";
            this.grpTeams.Size = new System.Drawing.Size(203, 128);
            this.grpTeams.TabIndex = 15;
            this.grpTeams.TabStop = false;
            this.grpTeams.Text = "NFL Teams";
            this.toolTip1.SetToolTip(this.grpTeams, "NFL TEAMS");
            // 
            // grpFood
            // 
            this.grpFood.Controls.Add(this.radBBQ);
            this.grpFood.Controls.Add(this.radPasta);
            this.grpFood.Location = new System.Drawing.Point(11, 410);
            this.grpFood.Name = "grpFood";
            this.grpFood.Size = new System.Drawing.Size(98, 125);
            this.grpFood.TabIndex = 16;
            this.grpFood.TabStop = false;
            this.grpFood.Text = "FOOD";
            this.toolTip1.SetToolTip(this.grpFood, "Different types of food");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.pushButtonsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.editToolStripMenuItem.Text = "Open";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forumsToolStripMenuItem,
            this.detailToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // forumsToolStripMenuItem
            // 
            this.forumsToolStripMenuItem.Name = "forumsToolStripMenuItem";
            this.forumsToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.forumsToolStripMenuItem.Text = "Forums";
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.detailToolStripMenuItem.Text = "Detail";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.tipsAndTricksToolStripMenuItem,
            this.whatsNewToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // tipsAndTricksToolStripMenuItem
            // 
            this.tipsAndTricksToolStripMenuItem.Name = "tipsAndTricksToolStripMenuItem";
            this.tipsAndTricksToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.tipsAndTricksToolStripMenuItem.Text = "Tips and Tricks";
            // 
            // whatsNewToolStripMenuItem
            // 
            this.whatsNewToolStripMenuItem.Name = "whatsNewToolStripMenuItem";
            this.whatsNewToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.whatsNewToolStripMenuItem.Text = "Whats New?";
            // 
            // pushButtonsToolStripMenuItem
            // 
            this.pushButtonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayGoToolStripMenuItem,
            this.checkHungryToolStripMenuItem});
            this.pushButtonsToolStripMenuItem.Name = "pushButtonsToolStripMenuItem";
            this.pushButtonsToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.pushButtonsToolStripMenuItem.Text = "Push Buttons";
            // 
            // displayGoToolStripMenuItem
            // 
            this.displayGoToolStripMenuItem.Name = "displayGoToolStripMenuItem";
            this.displayGoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.displayGoToolStripMenuItem.Text = "Display Go";
            this.displayGoToolStripMenuItem.Click += new System.EventHandler(this.displayGoToolStripMenuItem_Click);
            // 
            // checkHungryToolStripMenuItem
            // 
            this.checkHungryToolStripMenuItem.Name = "checkHungryToolStripMenuItem";
            this.checkHungryToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.checkHungryToolStripMenuItem.Text = "check Hungry";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnColor.Location = new System.Drawing.Point(447, 96);
            this.btnColor.Name = "btnColor";
            this.btnColor.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnColor.Size = new System.Drawing.Size(170, 53);
            this.btnColor.TabIndex = 18;
            this.btnColor.Text = "Select";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelect.Location = new System.Drawing.Point(89, 761);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(220, 42);
            this.btnSelect.TabIndex = 19;
            this.btnSelect.Text = "Select Image";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(4, 822);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(383, 27);
            this.txtFileName.TabIndex = 20;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNum.Location = new System.Drawing.Point(699, 56);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(138, 159);
            this.lblNum.TabIndex = 21;
            this.lblNum.Text = "#";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(760, 206);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 29);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStop.Location = new System.Drawing.Point(882, 204);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(116, 29);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReset.Location = new System.Drawing.Point(831, 245);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(760, 44);
            this.progressBar1.Maximum = 500;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(241, 29);
            this.progressBar1.TabIndex = 24;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNum2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNum2.Location = new System.Drawing.Point(909, 56);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(138, 159);
            this.lblNum2.TabIndex = 21;
            this.lblNum2.Text = "#";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(699, 338);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 161);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(340, 128);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(6, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(340, 128);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.Black;
            this.lblTemp.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTemp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTemp.Location = new System.Drawing.Point(634, 723);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(324, 45);
            this.lblTemp.TabIndex = 26;
            this.lblTemp.Text = "Fahrenheit To Celsius";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(634, 675);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(324, 27);
            this.txtInput.TabIndex = 27;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1113, 898);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.grpFood);
            this.Controls.Add(this.grpTeams);
            this.Controls.Add(this.prgGoal);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.numScore);
            this.Controls.Add(this.mthCalMeeting);
            this.Controls.Add(this.mskCode);
            this.Controls.Add(this.lstTeam);
            this.Controls.Add(this.label_Appt);
            this.Controls.Add(this.dtp_ApptDate);
            this.Controls.Add(this.cmbCar);
            this.Controls.Add(this.chk_List);
            this.Controls.Add(this.chkHungry);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpTeams.ResumeLayout(false);
            this.grpTeams.PerformLayout();
            this.grpFood.ResumeLayout(false);
            this.grpFood.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGo;
        private TextBox txtOutput;
        private CheckBox chkHungry;
        private CheckedListBox chk_List;
        private ComboBox cmbCar;
        private DateTimePicker dtp_ApptDate;
        private Label label_Appt;
        private ListBox lstTeam;
        private MaskedTextBox mskCode;
        private MonthCalendar mthCalMeeting;
        private NumericUpDown numScore;
        private PictureBox picLogo;
        private ProgressBar prgGoal;
        private RadioButton radCowboys;
        private RadioButton radBengals;
        private RadioButton radChargers;
        private RadioButton radBBQ;
        private RadioButton radPasta;
        private GroupBox grpTeams;
        private GroupBox grpFood;
        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem forumsToolStripMenuItem;
        private ToolStripMenuItem detailToolStripMenuItem;
        private ToolStripMenuItem viewHelpToolStripMenuItem;
        private ToolStripMenuItem tipsAndTricksToolStripMenuItem;
        private ToolStripMenuItem whatsNewToolStripMenuItem;
        private ToolStripMenuItem pushButtonsToolStripMenuItem;
        private ToolStripMenuItem displayGoToolStripMenuItem;
        private ToolStripMenuItem checkHungryToolStripMenuItem;
        private ColorDialog colorDialog1;
        private OpenFileDialog openFileDialog1;
        private Button btnColor;
        private Button btnSelect;
        private TextBox txtFileName;
        private Label lblNum;
        private System.Windows.Forms.Timer timer1;
        private Button btnStart;
        private Button btnStop;
        private Button btnReset;
        private ProgressBar progressBar1;
        private Label lblNum2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private CheckBox checkBox1;
        private Button button1;
        private TabPage tabPage2;
        private Label lblTemp;
        private TextBox txtInput;
    }
}