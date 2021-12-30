
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
            this.IPLabel = new System.Windows.Forms.Label();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PayloadPathBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ThemeBtn = new System.Windows.Forms.Button();
            this.Box = new System.Windows.Forms.GroupBox();
            this.BuildLabel = new System.Windows.Forms.Label();
            this.Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPLabel
            // 
            this.IPLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.IPLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.IPLabel.Location = new System.Drawing.Point(1, 36);
            this.IPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(122, 18);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "I.P. Address:";
            // 
            // IPBox
            // 
            this.IPBox.BackColor = System.Drawing.Color.Black;
            this.IPBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IPBox.ForeColor = System.Drawing.Color.Fuchsia;
            this.IPBox.Location = new System.Drawing.Point(122, 40);
            this.IPBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(85, 13);
            this.IPBox.TabIndex = 1;
            this.IPBox.Text = "192.168.137.";
            this.IPBox.TextChanged += new System.EventHandler(this.IPBox_TextChanged);
            // 
            // PortBox
            // 
            this.PortBox.BackColor = System.Drawing.Color.Black;
            this.PortBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PortBox.ForeColor = System.Drawing.Color.Fuchsia;
            this.PortBox.Location = new System.Drawing.Point(48, 21);
            this.PortBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(34, 13);
            this.PortBox.TabIndex = 2;
            this.PortBox.Text = "9020";
            this.PortBox.TextChanged += new System.EventHandler(this.PortBox_TextChanged);
            // 
            // PortLabel
            // 
            this.PortLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.PortLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.PortLabel.Location = new System.Drawing.Point(1, 18);
            this.PortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(47, 18);
            this.PortLabel.TabIndex = 3;
            this.PortLabel.Text = "Port:";
            this.PortLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PayloadPathBox
            // 
            this.PayloadPathBox.BackColor = System.Drawing.Color.Black;
            this.PayloadPathBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PayloadPathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.PayloadPathBox.ForeColor = System.Drawing.Color.Fuchsia;
            this.PayloadPathBox.Location = new System.Drawing.Point(8, 58);
            this.PayloadPathBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PayloadPathBox.Name = "PayloadPathBox";
            this.PayloadPathBox.Size = new System.Drawing.Size(194, 16);
            this.PayloadPathBox.TabIndex = 4;
            this.PayloadPathBox.Text = "(Payload Path Here)        ";
            this.PayloadPathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PayloadPathBox.TextChanged += new System.EventHandler(this.PayloadPathBox_TextChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.Black;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.BrowseButton.Location = new System.Drawing.Point(112, 11);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(52, 23);
            this.BrowseButton.TabIndex = 5;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.SendButton.Location = new System.Drawing.Point(167, 11);
            this.SendButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(42, 23);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.MinimizeBtn.Location = new System.Drawing.Point(167, 0);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(23, 23);
            this.MinimizeBtn.TabIndex = 7;
            this.MinimizeBtn.Text = "--";
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.CloseBtn.Location = new System.Drawing.Point(190, 0);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(23, 23);
            this.CloseBtn.TabIndex = 8;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ThemeBtn
            // 
            this.ThemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.ThemeBtn.Location = new System.Drawing.Point(0, 0);
            this.ThemeBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ThemeBtn.Name = "ThemeBtn";
            this.ThemeBtn.Size = new System.Drawing.Size(51, 23);
            this.ThemeBtn.TabIndex = 14;
            this.ThemeBtn.Text = "Theme";
            this.ThemeBtn.UseVisualStyleBackColor = true;
            this.ThemeBtn.Click += new System.EventHandler(this.ThemeBtn_Click);
            // 
            // Box
            // 
            this.Box.Controls.Add(this.PortBox);
            this.Box.Controls.Add(this.PortLabel);
            this.Box.Controls.Add(this.BrowseButton);
            this.Box.Controls.Add(this.IPLabel);
            this.Box.Controls.Add(this.BuildLabel);
            this.Box.Controls.Add(this.IPBox);
            this.Box.Controls.Add(this.PayloadPathBox);
            this.Box.Controls.Add(this.SendButton);
            this.Box.ForeColor = System.Drawing.Color.Fuchsia;
            this.Box.Location = new System.Drawing.Point(0, 18);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(214, 82);
            this.Box.TabIndex = 26;
            this.Box.TabStop = false;
            // 
            // BuildLabel
            // 
            this.BuildLabel.BackColor = System.Drawing.Color.Transparent;
            this.BuildLabel.Font = new System.Drawing.Font("Verdana", 5.75F);
            this.BuildLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.BuildLabel.Location = new System.Drawing.Point(0, 8);
            this.BuildLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BuildLabel.Name = "BuildLabel";
            this.BuildLabel.Size = new System.Drawing.Size(28, 10);
            this.BuildLabel.TabIndex = 23;
            this.BuildLabel.Text = "1.5.0";
            // 
            // Payload_Sender
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(214, 100);
            this.Controls.Add(this.ThemeBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.Box);
            this.ForeColor = System.Drawing.Color.Fuchsia;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Payload_Sender";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuck Off, Dicksneeze";
            this.Box.ResumeLayout(false);
            this.Box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PayloadPathBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button ThemeBtn;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.Label BuildLabel;
    }
}

