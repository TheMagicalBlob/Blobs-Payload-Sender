
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
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TcpLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.redGreenBlueLabel = new System.Windows.Forms.Label();
            this.propertyEditorLabel = new System.Windows.Forms.Label();
            this.separatorLine0 = new PayloadSender.Payload_Sender.Label();
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
            this.IPBox.Location = new System.Drawing.Point(49, 84);
            this.IPBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(107, 21);
            this.IPBox.TabIndex = 1;
            this.IPBox.Text = "Enter IP";
            this.IPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IPBox.TextChanged += new System.EventHandler(this.IPBox_TextChanged);
            // 
            // PortBox
            // 
            this.PortBox.BackColor = System.Drawing.Color.Black;
            this.PortBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.PortBox.ForeColor = System.Drawing.Color.Fuchsia;
            this.PortBox.Location = new System.Drawing.Point(3, 84);
            this.PortBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(42, 21);
            this.PortBox.TabIndex = 2;
            this.PortBox.Text = "9090";
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
            this.PayloadPathBox.Location = new System.Drawing.Point(3, 112);
            this.PayloadPathBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PayloadPathBox.Name = "PayloadPathBox";
            this.PayloadPathBox.Size = new System.Drawing.Size(258, 23);
            this.PayloadPathBox.TabIndex = 4;
            this.PayloadPathBox.Text = "(Payload Path Here)                ";
            this.PayloadPathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PayloadPathBox.TextChanged += new System.EventHandler(this.PayloadPathBox_TextChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.Black;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.BrowseButton.Location = new System.Drawing.Point(266, 112);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(52, 23);
            this.BrowseButton.TabIndex = 5;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.MinimizeBtn.Location = new System.Drawing.Point(274, 3);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(23, 23);
            this.MinimizeBtn.TabIndex = 7;
            this.MinimizeBtn.Text = "--";
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.ExitBtn.Location = new System.Drawing.Point(297, 3);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(23, 23);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ThemeBtn
            // 
            this.ThemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.ThemeBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.ThemeBtn.Location = new System.Drawing.Point(275, 29);
            this.ThemeBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ThemeBtn.Name = "ThemeBtn";
            this.ThemeBtn.Size = new System.Drawing.Size(44, 23);
            this.ThemeBtn.TabIndex = 14;
            this.ThemeBtn.Text = "Theme";
            this.ThemeBtn.UseVisualStyleBackColor = true;
            this.ThemeBtn.Click += new System.EventHandler(this.ThemeBtn_Click);
            // 
            // BuildLabel
            // 
            this.BuildLabel.BackColor = System.Drawing.Color.Transparent;
            this.BuildLabel.Font = new System.Drawing.Font("Verdana", 5.75F);
            this.BuildLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.BuildLabel.Location = new System.Drawing.Point(217, 5);
            this.BuildLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BuildLabel.Name = "BuildLabel";
            this.BuildLabel.Size = new System.Drawing.Size(54, 10);
            this.BuildLabel.TabIndex = 23;
            this.BuildLabel.Text = "2.12.7";
            this.BuildLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SendButton
            // 
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.SendButton.Location = new System.Drawing.Point(160, 83);
            this.SendButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(42, 23);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "Send";
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
            this.ThemeBox.Hash = 0;
            this.ThemeBox.Location = new System.Drawing.Point(6, 191);
            this.ThemeBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ThemeBox.MaxLength = 8;
            this.ThemeBox.Name = "ThemeBox";
            this.ThemeBox.Size = new System.Drawing.Size(100, 16);
            this.ThemeBox.TabIndex = 24;
            this.ThemeBox.Text = "0x";
            this.ThemeBox.TextChanged += new System.EventHandler(this.ThemeBox_TextChanged);
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.BackColor = System.Drawing.Color.Black;
            this.ApplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.ApplyBtn.Location = new System.Drawing.Point(138, 190);
            this.ApplyBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(52, 23);
            this.ApplyBtn.TabIndex = 25;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = false;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.Black;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.ResetBtn.Location = new System.Drawing.Point(138, 219);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(52, 23);
            this.ResetBtn.TabIndex = 26;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.TitleLabel.Location = new System.Drawing.Point(1, 4);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(133, 22);
            this.TitleLabel.TabIndex = 27;
            this.TitleLabel.Text = "Payload Sender";
            // 
            // TcpLabel
            // 
            this.TcpLabel.BackColor = System.Drawing.Color.Transparent;
            this.TcpLabel.Font = new System.Drawing.Font("Verdana", 6.5F);
            this.TcpLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.TcpLabel.Location = new System.Drawing.Point(126, 3);
            this.TcpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TcpLabel.Name = "TcpLabel";
            this.TcpLabel.Size = new System.Drawing.Size(29, 16);
            this.TcpLabel.TabIndex = 28;
            this.TcpLabel.Text = "(tcp)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.Window;
            this.numericUpDown1.Location = new System.Drawing.Point(6, 230);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 16);
            this.numericUpDown1.TabIndex = 29;
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
            this.numericUpDown2.ForeColor = System.Drawing.SystemColors.Window;
            this.numericUpDown2.Location = new System.Drawing.Point(46, 230);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(38, 16);
            this.numericUpDown2.TabIndex = 30;
            this.numericUpDown2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown3.ForeColor = System.Drawing.SystemColors.Window;
            this.numericUpDown3.Location = new System.Drawing.Point(85, 230);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(38, 16);
            this.numericUpDown3.TabIndex = 31;
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
            this.redGreenBlueLabel.Location = new System.Drawing.Point(9, 213);
            this.redGreenBlueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redGreenBlueLabel.Name = "redGreenBlueLabel";
            this.redGreenBlueLabel.Size = new System.Drawing.Size(95, 16);
            this.redGreenBlueLabel.TabIndex = 32;
            this.redGreenBlueLabel.Text = "Red   Green   Blue";
            // 
            // propertyEditorLabel
            // 
            this.propertyEditorLabel.BackColor = System.Drawing.Color.Transparent;
            this.propertyEditorLabel.Font = new System.Drawing.Font("Verdana", 6.5F);
            this.propertyEditorLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.propertyEditorLabel.Location = new System.Drawing.Point(9, 163);
            this.propertyEditorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.propertyEditorLabel.Name = "propertyEditorLabel";
            this.propertyEditorLabel.Size = new System.Drawing.Size(86, 18);
            this.propertyEditorLabel.TabIndex = 33;
            this.propertyEditorLabel.Text = "Property Editor";
            // 
            // separatorLine0
            // 
            this.separatorLine0.BackColor = System.Drawing.Color.Transparent;
            this.separatorLine0.Font = new System.Drawing.Font("Verdana", 6.5F);
            this.separatorLine0.ForeColor = System.Drawing.Color.Fuchsia;
            this.separatorLine0.IsSeparatorLine = true;
            this.separatorLine0.Location = new System.Drawing.Point(6, 141);
            this.separatorLine0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.separatorLine0.Name = "separatorLine0";
            this.separatorLine0.Size = new System.Drawing.Size(86, 13);
            this.separatorLine0.StretchToFitForm = true;
            this.separatorLine0.TabIndex = 34;
            this.separatorLine0.Text = "------------------------------------";
            // 
            // Payload_Sender
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(322, 255);
            this.Controls.Add(this.separatorLine0);
            this.Controls.Add(this.propertyEditorLabel);
            this.Controls.Add(this.redGreenBlueLabel);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.TcpLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ApplyBtn);
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
        private System.Windows.Forms.Label ResetLabel;
        private System.Windows.Forms.Button SendButton;
        private PayloadSender.Payload_Sender.RGBBox ThemeBox;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TcpLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label redGreenBlueLabel;
        private System.Windows.Forms.Label propertyEditorLabel;
        private PayloadSender.Payload_Sender.Label separatorLine0;
    }
}

