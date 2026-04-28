
namespace PayloadSender
{
    partial class Payload_Sender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payload_Sender));
            this.IPBox = new System.Windows.Forms.TextBox();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.PayloadPathBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ThemeBtn = new System.Windows.Forms.Button();
            this.BuildLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.ThemeBox = new PayloadSender.Payload_Sender.RGBBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.redGreenBlueLabel = new System.Windows.Forms.Label();
            this.separatorLine0 = new PayloadSender.Payload_Sender.Label();
            this.separatorLine1 = new PayloadSender.Payload_Sender.Label();
            this.propertyEditorLabel = new System.Windows.Forms.Label();
            this.ArrowBoxesApplyBtn = new System.Windows.Forms.Button();
            this.ThemeBoxApplyBtn = new System.Windows.Forms.Button();
            this.label1 = new PayloadSender.Payload_Sender.Label();
            this.hashLabel = new System.Windows.Forms.Label();
            this.sendElfdrCheckBox = new System.Windows.Forms.CheckBox();
            this.PS5Btn = new System.Windows.Forms.Button();
            this.PS4Btn = new System.Windows.Forms.Button();
            this.elfElfdrBtn = new System.Windows.Forms.Button();
            this.binElfdrBtn = new System.Windows.Forms.Button();
            this.TcpLabel = new System.Windows.Forms.Label();
            this.arrowLabel = new System.Windows.Forms.Label();
            this.tempStatusLabel = new System.Windows.Forms.Label();
            this.toggleDebugServerBtn = new System.Windows.Forms.Button();
            this.scaleBtn = new System.Windows.Forms.Button();
            this.ElfdrPortBox = new System.Windows.Forms.TextBox();
            this.elfdrPortBoxLabel = new System.Windows.Forms.Label();
            this.portBoxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // IPBox
            // 
            this.IPBox.BackColor = System.Drawing.Color.Black;
            this.IPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IPBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.IPBox.ForeColor = System.Drawing.Color.Fuchsia;
            this.IPBox.Location = new System.Drawing.Point(92, 130);
            this.IPBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(107, 21);
            this.IPBox.TabIndex = 3;
            this.IPBox.Text = "192.168.1";
            this.IPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IPBox.TextChanged += new System.EventHandler(this.IPBox_TextChanged);
            // 
            // PortBox
            // 
            this.PortBox.BackColor = System.Drawing.Color.Black;
            this.PortBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.PortBox.ForeColor = System.Drawing.Color.Fuchsia;
            this.PortBox.Location = new System.Drawing.Point(48, 130);
            this.PortBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(42, 21);
            this.PortBox.TabIndex = 2;
            this.PortBox.Text = "9021";
            this.PortBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PortBox.TextChanged += new System.EventHandler(this.PortBox_TextChanged);
            // 
            // PayloadPathBox
            // 
            this.PayloadPathBox.AllowDrop = true;
            this.PayloadPathBox.BackColor = System.Drawing.Color.Black;
            this.PayloadPathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PayloadPathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.PayloadPathBox.ForeColor = System.Drawing.Color.Fuchsia;
            this.PayloadPathBox.Location = new System.Drawing.Point(4, 155);
            this.PayloadPathBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PayloadPathBox.Name = "PayloadPathBox";
            this.PayloadPathBox.Size = new System.Drawing.Size(258, 23);
            this.PayloadPathBox.TabIndex = 4;
            this.PayloadPathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PayloadPathBox.TextChanged += new System.EventHandler(this.PayloadPathBox_TextChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.Black;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.BrowseButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.BrowseButton.Location = new System.Drawing.Point(266, 155);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(117, 23);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse for Payload...";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.MinimizeBtn.Location = new System.Drawing.Point(339, 3);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(23, 23);
            this.MinimizeBtn.TabIndex = 7;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.Text = "--";
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.ExitBtn.Location = new System.Drawing.Point(361, 3);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(23, 23);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // ThemeBtn
            // 
            this.ThemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.ThemeBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.ThemeBtn.Location = new System.Drawing.Point(341, 32);
            this.ThemeBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ThemeBtn.Name = "ThemeBtn";
            this.ThemeBtn.Size = new System.Drawing.Size(43, 23);
            this.ThemeBtn.TabIndex = 10;
            this.ThemeBtn.Text = "Theme";
            this.ThemeBtn.UseVisualStyleBackColor = true;
            this.ThemeBtn.Click += new System.EventHandler(this.ThemeBtn_Click);
            // 
            // BuildLabel
            // 
            this.BuildLabel.BackColor = System.Drawing.Color.Transparent;
            this.BuildLabel.Font = new System.Drawing.Font("Verdana", 5.75F);
            this.BuildLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.BuildLabel.Location = new System.Drawing.Point(281, 5);
            this.BuildLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BuildLabel.Name = "BuildLabel";
            this.BuildLabel.Size = new System.Drawing.Size(54, 10);
            this.BuildLabel.TabIndex = 23;
            this.BuildLabel.Text = "ver.";
            this.BuildLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SendButton
            // 
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.SendButton.Location = new System.Drawing.Point(201, 130);
            this.SendButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(61, 21);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send File";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ThemeBox
            // 
            this.ThemeBox.AllowDrop = true;
            this.ThemeBox.BackColor = System.Drawing.Color.Black;
            this.ThemeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThemeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ThemeBox.ForeColor = System.Drawing.Color.Fuchsia;
            this.ThemeBox.Location = new System.Drawing.Point(7, 229);
            this.ThemeBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ThemeBox.MaxLength = 8;
            this.ThemeBox.Name = "ThemeBox";
            this.ThemeBox.Size = new System.Drawing.Size(64, 16);
            this.ThemeBox.TabIndex = 11;
            this.ThemeBox.Text = "0xFF00FF";
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.Black;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.ResetBtn.Location = new System.Drawing.Point(332, 205);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(52, 49);
            this.ResetBtn.TabIndex = 17;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.TitleLabel.Location = new System.Drawing.Point(2, 4);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(133, 22);
            this.TitleLabel.TabIndex = 27;
            this.TitleLabel.Text = "Payload Sender";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.ForeColor = System.Drawing.Color.Fuchsia;
            this.numericUpDown1.Location = new System.Drawing.Point(143, 222);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 16);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown2.ForeColor = System.Drawing.Color.Fuchsia;
            this.numericUpDown2.Location = new System.Drawing.Point(184, 222);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(38, 16);
            this.numericUpDown2.TabIndex = 14;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown3.ForeColor = System.Drawing.Color.Fuchsia;
            this.numericUpDown3.Location = new System.Drawing.Point(224, 222);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(38, 16);
            this.numericUpDown3.TabIndex = 15;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown3.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // redGreenBlueLabel
            // 
            this.redGreenBlueLabel.BackColor = System.Drawing.Color.Transparent;
            this.redGreenBlueLabel.Font = new System.Drawing.Font("Verdana", 6.5F);
            this.redGreenBlueLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.redGreenBlueLabel.Location = new System.Drawing.Point(150, 205);
            this.redGreenBlueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redGreenBlueLabel.Name = "redGreenBlueLabel";
            this.redGreenBlueLabel.Size = new System.Drawing.Size(108, 14);
            this.redGreenBlueLabel.TabIndex = 32;
            this.redGreenBlueLabel.Text = "Red     Green    Blue";
            // 
            // separatorLine0
            // 
            this.separatorLine0.BackColor = System.Drawing.Color.Transparent;
            this.separatorLine0.Font = new System.Drawing.Font("Verdana", 6.5F);
            this.separatorLine0.ForeColor = System.Drawing.Color.Fuchsia;
            this.separatorLine0.IsSeparatorLine = true;
            this.separatorLine0.Location = new System.Drawing.Point(6, 178);
            this.separatorLine0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.separatorLine0.Name = "separatorLine0";
            this.separatorLine0.Size = new System.Drawing.Size(291, 13);
            this.separatorLine0.StretchToFitForm = true;
            this.separatorLine0.TabIndex = 34;
            this.separatorLine0.Text = "------------------------------------";
            // 
            // separatorLine1
            // 
            this.separatorLine1.BackColor = System.Drawing.Color.Transparent;
            this.separatorLine1.Font = new System.Drawing.Font("Verdana", 6.5F);
            this.separatorLine1.ForeColor = System.Drawing.Color.Fuchsia;
            this.separatorLine1.IsSeparatorLine = true;
            this.separatorLine1.Location = new System.Drawing.Point(39, 22);
            this.separatorLine1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.separatorLine1.Name = "separatorLine1";
            this.separatorLine1.Size = new System.Drawing.Size(258, 13);
            this.separatorLine1.StretchToFitForm = true;
            this.separatorLine1.TabIndex = 35;
            this.separatorLine1.Text = "------------------------------------";
            // 
            // propertyEditorLabel
            // 
            this.propertyEditorLabel.BackColor = System.Drawing.Color.Transparent;
            this.propertyEditorLabel.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Bold);
            this.propertyEditorLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.propertyEditorLabel.Location = new System.Drawing.Point(3, 190);
            this.propertyEditorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.propertyEditorLabel.Name = "propertyEditorLabel";
            this.propertyEditorLabel.Size = new System.Drawing.Size(105, 18);
            this.propertyEditorLabel.TabIndex = 36;
            this.propertyEditorLabel.Text = "Theme Editor";
            // 
            // ArrowBoxesApplyBtn
            // 
            this.ArrowBoxesApplyBtn.BackColor = System.Drawing.Color.Black;
            this.ArrowBoxesApplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArrowBoxesApplyBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.ArrowBoxesApplyBtn.Location = new System.Drawing.Point(270, 216);
            this.ArrowBoxesApplyBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ArrowBoxesApplyBtn.Name = "ArrowBoxesApplyBtn";
            this.ArrowBoxesApplyBtn.Size = new System.Drawing.Size(43, 26);
            this.ArrowBoxesApplyBtn.TabIndex = 16;
            this.ArrowBoxesApplyBtn.Text = "Apply";
            this.ArrowBoxesApplyBtn.UseVisualStyleBackColor = false;
            this.ArrowBoxesApplyBtn.Click += new System.EventHandler(this.ArrowBoxesApplyBtn_Click);
            // 
            // ThemeBoxApplyBtn
            // 
            this.ThemeBoxApplyBtn.BackColor = System.Drawing.Color.Black;
            this.ThemeBoxApplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeBoxApplyBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.ThemeBoxApplyBtn.Location = new System.Drawing.Point(75, 224);
            this.ThemeBoxApplyBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ThemeBoxApplyBtn.Name = "ThemeBoxApplyBtn";
            this.ThemeBoxApplyBtn.Size = new System.Drawing.Size(43, 26);
            this.ThemeBoxApplyBtn.TabIndex = 12;
            this.ThemeBoxApplyBtn.Text = "Apply";
            this.ThemeBoxApplyBtn.UseVisualStyleBackColor = false;
            this.ThemeBoxApplyBtn.Click += new System.EventHandler(this.ThemeBoxApplyBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 6.5F);
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.IsSeparatorLine = true;
            this.label1.Location = new System.Drawing.Point(124, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 69);
            this.label1.StretchToFitForm = false;
            this.label1.TabIndex = 40;
            this.label1.Text = "------------------------------------";
            // 
            // hashLabel
            // 
            this.hashLabel.BackColor = System.Drawing.Color.Transparent;
            this.hashLabel.Font = new System.Drawing.Font("Verdana", 6.5F);
            this.hashLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.hashLabel.Location = new System.Drawing.Point(5, 213);
            this.hashLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hashLabel.Name = "hashLabel";
            this.hashLabel.Size = new System.Drawing.Size(39, 14);
            this.hashLabel.TabIndex = 41;
            this.hashLabel.Text = "Hash";
            // 
            // sendElfdrCheckBox
            // 
            this.sendElfdrCheckBox.AutoSize = true;
            this.sendElfdrCheckBox.Location = new System.Drawing.Point(7, 35);
            this.sendElfdrCheckBox.Name = "sendElfdrCheckBox";
            this.sendElfdrCheckBox.Size = new System.Drawing.Size(97, 17);
            this.sendElfdrCheckBox.TabIndex = 5;
            this.sendElfdrCheckBox.Text = "Send Elfdr First";
            this.sendElfdrCheckBox.UseVisualStyleBackColor = true;
            this.sendElfdrCheckBox.CheckedChanged += new System.EventHandler(this.sendElfdrCheckBox_CheckedChanged);
            // 
            // PS5Btn
            // 
            this.PS5Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PS5Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.PS5Btn.ForeColor = System.Drawing.Color.Fuchsia;
            this.PS5Btn.Location = new System.Drawing.Point(7, 80);
            this.PS5Btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PS5Btn.Name = "PS5Btn";
            this.PS5Btn.Size = new System.Drawing.Size(77, 25);
            this.PS5Btn.TabIndex = 9;
            this.PS5Btn.Text = "Playstation 5";
            this.PS5Btn.UseVisualStyleBackColor = true;
            this.PS5Btn.Click += new System.EventHandler(this.PS5Btn_Click);
            // 
            // PS4Btn
            // 
            this.PS4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PS4Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.PS4Btn.ForeColor = System.Drawing.Color.Fuchsia;
            this.PS4Btn.Location = new System.Drawing.Point(7, 54);
            this.PS4Btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PS4Btn.Name = "PS4Btn";
            this.PS4Btn.Size = new System.Drawing.Size(77, 25);
            this.PS4Btn.TabIndex = 6;
            this.PS4Btn.Text = "Playstation 4";
            this.PS4Btn.UseVisualStyleBackColor = true;
            this.PS4Btn.Click += new System.EventHandler(this.PS4Btn_Click);
            // 
            // elfElfdrBtn
            // 
            this.elfElfdrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elfElfdrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.elfElfdrBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.elfElfdrBtn.Location = new System.Drawing.Point(105, 56);
            this.elfElfdrBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elfElfdrBtn.Name = "elfElfdrBtn";
            this.elfElfdrBtn.Size = new System.Drawing.Size(30, 21);
            this.elfElfdrBtn.TabIndex = 7;
            this.elfElfdrBtn.Text = ".elf";
            this.elfElfdrBtn.UseVisualStyleBackColor = true;
            this.elfElfdrBtn.Click += new System.EventHandler(this.elfElfdrBtn_Click);
            // 
            // binElfdrBtn
            // 
            this.binElfdrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.binElfdrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.binElfdrBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.binElfdrBtn.Location = new System.Drawing.Point(136, 56);
            this.binElfdrBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.binElfdrBtn.Name = "binElfdrBtn";
            this.binElfdrBtn.Size = new System.Drawing.Size(30, 21);
            this.binElfdrBtn.TabIndex = 8;
            this.binElfdrBtn.Text = ".bin";
            this.binElfdrBtn.UseVisualStyleBackColor = true;
            this.binElfdrBtn.Click += new System.EventHandler(this.binElfdrBtn_Click);
            // 
            // TcpLabel
            // 
            this.TcpLabel.BackColor = System.Drawing.Color.Transparent;
            this.TcpLabel.Font = new System.Drawing.Font("Verdana", 6.5F);
            this.TcpLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.TcpLabel.Location = new System.Drawing.Point(127, 3);
            this.TcpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TcpLabel.Name = "TcpLabel";
            this.TcpLabel.Size = new System.Drawing.Size(29, 16);
            this.TcpLabel.TabIndex = 28;
            this.TcpLabel.Text = "(tcp)";
            // 
            // arrowLabel
            // 
            this.arrowLabel.BackColor = System.Drawing.Color.Transparent;
            this.arrowLabel.Font = new System.Drawing.Font("Verdana", 6.5F);
            this.arrowLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.arrowLabel.Location = new System.Drawing.Point(84, 60);
            this.arrowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.arrowLabel.Name = "arrowLabel";
            this.arrowLabel.Size = new System.Drawing.Size(22, 12);
            this.arrowLabel.TabIndex = 48;
            this.arrowLabel.Text = "-->";
            // 
            // tempStatusLabel
            // 
            this.tempStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempStatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tempStatusLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.tempStatusLabel.Location = new System.Drawing.Point(264, 130);
            this.tempStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tempStatusLabel.Name = "tempStatusLabel";
            this.tempStatusLabel.Size = new System.Drawing.Size(120, 24);
            this.tempStatusLabel.TabIndex = 49;
            this.tempStatusLabel.Text = "Error\r\n(sent more than filesize?!)";
            this.tempStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toggleDebugServerBtn
            // 
            this.toggleDebugServerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleDebugServerBtn.Font = new System.Drawing.Font("Verdana", 6.5F);
            this.toggleDebugServerBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.toggleDebugServerBtn.Location = new System.Drawing.Point(293, 32);
            this.toggleDebugServerBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.toggleDebugServerBtn.Name = "toggleDebugServerBtn";
            this.toggleDebugServerBtn.Size = new System.Drawing.Size(46, 20);
            this.toggleDebugServerBtn.TabIndex = 50;
            this.toggleDebugServerBtn.TabStop = false;
            this.toggleDebugServerBtn.Text = "Start Local Server";
            this.toggleDebugServerBtn.UseVisualStyleBackColor = true;
            this.toggleDebugServerBtn.Click += new System.EventHandler(this.toggleDebugServerBtn_Click);
            // 
            // scaleBtn
            // 
            this.scaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.scaleBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.scaleBtn.Location = new System.Drawing.Point(320, 56);
            this.scaleBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.scaleBtn.Name = "scaleBtn";
            this.scaleBtn.Size = new System.Drawing.Size(64, 20);
            this.scaleBtn.TabIndex = 51;
            this.scaleBtn.TabStop = false;
            this.scaleBtn.Text = "scale";
            this.scaleBtn.UseVisualStyleBackColor = true;
            this.scaleBtn.Click += new System.EventHandler(this.scaleBtn_Click);
            // 
            // ElfdrPortBox
            // 
            this.ElfdrPortBox.BackColor = System.Drawing.Color.Black;
            this.ElfdrPortBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ElfdrPortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.ElfdrPortBox.ForeColor = System.Drawing.Color.Fuchsia;
            this.ElfdrPortBox.Location = new System.Drawing.Point(4, 130);
            this.ElfdrPortBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ElfdrPortBox.Name = "ElfdrPortBox";
            this.ElfdrPortBox.Size = new System.Drawing.Size(42, 21);
            this.ElfdrPortBox.TabIndex = 1;
            this.ElfdrPortBox.Text = "9020";
            this.ElfdrPortBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ElfdrPortBox.TextChanged += new System.EventHandler(this.ElfdrPortBox_TextChanged);
            // 
            // elfdrPortBoxLabel
            // 
            this.elfdrPortBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.elfdrPortBoxLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 6.25F);
            this.elfdrPortBoxLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.elfdrPortBoxLabel.Location = new System.Drawing.Point(14, 117);
            this.elfdrPortBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.elfdrPortBoxLabel.Name = "elfdrPortBoxLabel";
            this.elfdrPortBoxLabel.Size = new System.Drawing.Size(23, 14);
            this.elfdrPortBoxLabel.TabIndex = 53;
            this.elfdrPortBoxLabel.Text = "elfdr";
            // 
            // portBoxLabel
            // 
            this.portBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.portBoxLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 6.25F);
            this.portBoxLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.portBoxLabel.Location = new System.Drawing.Point(51, 116);
            this.portBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portBoxLabel.Name = "portBoxLabel";
            this.portBoxLabel.Size = new System.Drawing.Size(37, 14);
            this.portBoxLabel.TabIndex = 54;
            this.portBoxLabel.Text = "payload";
            // 
            // Payload_Sender
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(387, 257);
            this.Controls.Add(this.ElfdrPortBox);
            this.Controls.Add(this.portBoxLabel);
            this.Controls.Add(this.elfdrPortBoxLabel);
            this.Controls.Add(this.scaleBtn);
            this.Controls.Add(this.toggleDebugServerBtn);
            this.Controls.Add(this.tempStatusLabel);
            this.Controls.Add(this.elfElfdrBtn);
            this.Controls.Add(this.arrowLabel);
            this.Controls.Add(this.binElfdrBtn);
            this.Controls.Add(this.PS5Btn);
            this.Controls.Add(this.PS4Btn);
            this.Controls.Add(this.sendElfdrCheckBox);
            this.Controls.Add(this.hashLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThemeBoxApplyBtn);
            this.Controls.Add(this.ArrowBoxesApplyBtn);
            this.Controls.Add(this.propertyEditorLabel);
            this.Controls.Add(this.separatorLine1);
            this.Controls.Add(this.separatorLine0);
            this.Controls.Add(this.redGreenBlueLabel);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.TcpLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ThemeBox);
            this.Controls.Add(this.ThemeBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.BuildLabel);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.PayloadPathBox);
            this.Controls.Add(this.SendButton);
            this.ForeColor = System.Drawing.Color.Fuchsia;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Payload_Sender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payload Sender (Blob)";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        
        
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.TextBox PayloadPathBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ThemeBtn;
        private System.Windows.Forms.Label BuildLabel;
        private System.Windows.Forms.Button SendButton;
        private PayloadSender.Payload_Sender.RGBBox ThemeBox;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label redGreenBlueLabel;
        private PayloadSender.Payload_Sender.Label separatorLine0;
        private Label separatorLine1;
        private System.Windows.Forms.Label propertyEditorLabel;
        private System.Windows.Forms.Button ArrowBoxesApplyBtn;
        private System.Windows.Forms.Button ThemeBoxApplyBtn;
        private Label label1;
        private System.Windows.Forms.Label hashLabel;
        private System.Windows.Forms.CheckBox sendElfdrCheckBox;
        private System.Windows.Forms.Button PS5Btn;
        private System.Windows.Forms.Button PS4Btn;
        private System.Windows.Forms.Button elfElfdrBtn;
        private System.Windows.Forms.Button binElfdrBtn;
        private System.Windows.Forms.Label TcpLabel;
        private System.Windows.Forms.Label arrowLabel;
        private System.Windows.Forms.Label tempStatusLabel;
        private System.Windows.Forms.Button toggleDebugServerBtn;
        private System.Windows.Forms.Button scaleBtn;
        private System.Windows.Forms.TextBox ElfdrPortBox;
        private System.Windows.Forms.Label elfdrPortBoxLabel;
        private System.Windows.Forms.Label portBoxLabel;
    }
}

