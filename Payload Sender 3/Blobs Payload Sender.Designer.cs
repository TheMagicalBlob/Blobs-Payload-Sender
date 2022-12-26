
namespace Payload_Sender
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
            IPLabel = new System.Windows.Forms.Label();
            IPBox = new System.Windows.Forms.TextBox();
            PortBox = new System.Windows.Forms.TextBox();
            PortLabel = new System.Windows.Forms.Label();
            PayloadPathBox = new System.Windows.Forms.TextBox();
            BrowseButton = new System.Windows.Forms.Button();
            MinimizeBtn = new System.Windows.Forms.Button();
            CloseBtn = new System.Windows.Forms.Button();
            ThemeBtn = new System.Windows.Forms.Button();
            Box = new System.Windows.Forms.GroupBox();
            BuildLabel = new System.Windows.Forms.Label();
            SendButton = new System.Windows.Forms.Button();
            Box.SuspendLayout();
            SuspendLayout();
            // 
            // IPLabel
            // 
            IPLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            IPLabel.ForeColor = System.Drawing.Color.Fuchsia;
            IPLabel.Location = new System.Drawing.Point(4, 41);
            IPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            IPLabel.Name = "IPLabel";
            IPLabel.Size = new System.Drawing.Size(122, 18);
            IPLabel.TabIndex = 0;
            IPLabel.Text = "I.P. Address:";
            IPLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(MouseDownFunc);
            IPLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(MoveForm);
            IPLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(MouseUpFunc);
            // 
            // IPBox
            // 
            IPBox.BackColor = System.Drawing.Color.Black;
            IPBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            IPBox.ForeColor = System.Drawing.Color.Fuchsia;
            IPBox.Location = new System.Drawing.Point(125, 45);
            IPBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            IPBox.Name = "IPBox";
            IPBox.Size = new System.Drawing.Size(85, 13);
            IPBox.TabIndex = 1;
            IPBox.Text = "        Enter IP";
            IPBox.TextChanged += new System.EventHandler(IPBox_TextChanged);
            // 
            // PortBox
            // 
            PortBox.BackColor = System.Drawing.Color.Black;
            PortBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            PortBox.ForeColor = System.Drawing.Color.Fuchsia;
            PortBox.Location = new System.Drawing.Point(49, 25);
            PortBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            PortBox.Name = "PortBox";
            PortBox.Size = new System.Drawing.Size(34, 13);
            PortBox.TabIndex = 2;
            PortBox.Text = "9090";
            PortBox.TextChanged += new System.EventHandler(PortBox_TextChanged);
            // 
            // PortLabel
            // 
            PortLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            PortLabel.ForeColor = System.Drawing.Color.Fuchsia;
            PortLabel.Location = new System.Drawing.Point(4, 21);
            PortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            PortLabel.Name = "PortLabel";
            PortLabel.Size = new System.Drawing.Size(47, 18);
            PortLabel.TabIndex = 3;
            PortLabel.Text = "Port:";
            PortLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            PortLabel.Click += new System.EventHandler(PortLabel_Click);
            PortLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(MouseDownFunc);
            PortLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(MoveForm);
            PortLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(MouseUpFunc);
            // 
            // PayloadPathBox
            // 
            PayloadPathBox.AllowDrop = true;
            PayloadPathBox.BackColor = System.Drawing.Color.Black;
            PayloadPathBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PayloadPathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            PayloadPathBox.ForeColor = System.Drawing.Color.Fuchsia;
            PayloadPathBox.Location = new System.Drawing.Point(8, 58);
            PayloadPathBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            PayloadPathBox.Name = "PayloadPathBox";
            PayloadPathBox.Size = new System.Drawing.Size(194, 16);
            PayloadPathBox.TabIndex = 4;
            PayloadPathBox.Text = "        (Payload Path Here)";
            PayloadPathBox.TextChanged += new System.EventHandler(PayloadPathBox_TextChanged);
            // 
            // BrowseButton
            // 
            BrowseButton.BackColor = System.Drawing.Color.Black;
            BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BrowseButton.ForeColor = System.Drawing.Color.Fuchsia;
            BrowseButton.Location = new System.Drawing.Point(118, 8);
            BrowseButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new System.Drawing.Size(52, 23);
            BrowseButton.TabIndex = 5;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = false;
            BrowseButton.Click += new System.EventHandler(BrowseButton_Click);
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MinimizeBtn.ForeColor = System.Drawing.Color.Fuchsia;
            MinimizeBtn.Location = new System.Drawing.Point(169, 0);
            MinimizeBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new System.Drawing.Size(23, 23);
            MinimizeBtn.TabIndex = 7;
            MinimizeBtn.Text = "--";
            MinimizeBtn.UseVisualStyleBackColor = true;
            MinimizeBtn.Click += new System.EventHandler(MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CloseBtn.ForeColor = System.Drawing.Color.Fuchsia;
            CloseBtn.Location = new System.Drawing.Point(192, 0);
            CloseBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new System.Drawing.Size(23, 23);
            CloseBtn.TabIndex = 8;
            CloseBtn.Text = "X";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += new System.EventHandler(CloseBtn_Click);
            // 
            // ThemeBtn
            // 
            ThemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ThemeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            ThemeBtn.ForeColor = System.Drawing.Color.Fuchsia;
            ThemeBtn.Location = new System.Drawing.Point(0, 0);
            ThemeBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            ThemeBtn.Name = "ThemeBtn";
            ThemeBtn.Size = new System.Drawing.Size(43, 23);
            ThemeBtn.TabIndex = 14;
            ThemeBtn.Text = "Theme";
            ThemeBtn.UseVisualStyleBackColor = true;
            ThemeBtn.Click += new System.EventHandler(ThemeBtn_Click);
            // 
            // Box
            // 
            Box.Controls.Add(PortBox);
            Box.Controls.Add(PortLabel);
            Box.Controls.Add(BrowseButton);
            Box.Controls.Add(IPLabel);
            Box.Controls.Add(BuildLabel);
            Box.Controls.Add(IPBox);
            Box.Controls.Add(PayloadPathBox);
            Box.Controls.Add(SendButton);
            Box.ForeColor = System.Drawing.Color.Fuchsia;
            Box.Location = new System.Drawing.Point(0, 18);
            Box.Name = "Box";
            Box.Size = new System.Drawing.Size(215, 82);
            Box.TabIndex = 26;
            Box.TabStop = false;
            Box.MouseDown += new System.Windows.Forms.MouseEventHandler(MouseDownFunc);
            Box.MouseMove += new System.Windows.Forms.MouseEventHandler(MoveForm);
            Box.MouseUp += new System.Windows.Forms.MouseEventHandler(MouseUpFunc);
            // 
            // BuildLabel
            // 
            BuildLabel.BackColor = System.Drawing.Color.Transparent;
            BuildLabel.Font = new System.Drawing.Font("Verdana", 5.75F);
            BuildLabel.ForeColor = System.Drawing.Color.Fuchsia;
            BuildLabel.Location = new System.Drawing.Point(1, 8);
            BuildLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            BuildLabel.Name = "BuildLabel";
            BuildLabel.Size = new System.Drawing.Size(26, 10);
            BuildLabel.TabIndex = 23;
            BuildLabel.Text = "1.7.1";
            // 
            // SendButton
            // 
            SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SendButton.ForeColor = System.Drawing.Color.Fuchsia;
            SendButton.Location = new System.Drawing.Point(172, 8);
            SendButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            SendButton.Name = "SendButton";
            SendButton.Size = new System.Drawing.Size(42, 23);
            SendButton.TabIndex = 6;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += new System.EventHandler(SendButton_Click);
            // 
            // Payload_Sender
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(215, 99);
            Controls.Add(ThemeBtn);
            Controls.Add(CloseBtn);
            Controls.Add(MinimizeBtn);
            Controls.Add(Box);
            ForeColor = System.Drawing.Color.Fuchsia;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "Payload_Sender";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Payload Sender (Blob)";
            MouseDown += new System.Windows.Forms.MouseEventHandler(MouseDownFunc);
            MouseMove += new System.Windows.Forms.MouseEventHandler(MoveForm);
            MouseUp += new System.Windows.Forms.MouseEventHandler(MouseUpFunc);
            Box.ResumeLayout(false);
            Box.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PayloadPathBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button ThemeBtn;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.Label BuildLabel;
        private System.Windows.Forms.Label ResetLabel;
        private System.Windows.Forms.Button SendButton;
    }
}

