
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
            this.IPLabel = new System.Windows.Forms.Label();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PayloadPathBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.PinkBtn = new System.Windows.Forms.Button();
            this.PorpleBtn = new System.Windows.Forms.Button();
            this.ThemeBtn = new System.Windows.Forms.Button();
            this.OrangBtn = new System.Windows.Forms.Button();
            this.BlueBtn = new System.Windows.Forms.Button();
            this.LimeBtn = new System.Windows.Forms.Button();
            this.RedBtn = new System.Windows.Forms.Button();
            this.YellowBtn = new System.Windows.Forms.Button();
            this.AquaButton = new System.Windows.Forms.Button();
            this.LimeGreenBtn = new System.Windows.Forms.Button();
            this.bb1 = new System.Windows.Forms.Button();
            this.bb2 = new System.Windows.Forms.Button();
            this.bb3 = new System.Windows.Forms.Button();
            this.Box = new System.Windows.Forms.GroupBox();
            this.BuildLabel = new System.Windows.Forms.Label();
            this.Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPLabel
            // 
            this.IPLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.25F, System.Drawing.FontStyle.Bold);
            this.IPLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.IPLabel.Location = new System.Drawing.Point(4, 31);
            this.IPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(116, 29);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "I.P. Address:";
            // 
            // IPBox
            // 
            this.IPBox.BackColor = System.Drawing.Color.Black;
            this.IPBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IPBox.ForeColor = System.Drawing.Color.Fuchsia;
            this.IPBox.Location = new System.Drawing.Point(118, 42);
            this.IPBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(85, 13);
            this.IPBox.TabIndex = 1;
            this.IPBox.Text = "192.168.1";
            this.IPBox.TextChanged += new System.EventHandler(this.IPBox_TextChanged);
            // 
            // PortBox
            // 
            this.PortBox.BackColor = System.Drawing.Color.Black;
            this.PortBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PortBox.ForeColor = System.Drawing.Color.Fuchsia;
            this.PortBox.Location = new System.Drawing.Point(47, 15);
            this.PortBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(34, 16);
            this.PortBox.TabIndex = 2;
            this.PortBox.Text = "9020";
            this.PortBox.TextChanged += new System.EventHandler(this.PortBox_TextChanged);
            // 
            // PortLabel
            // 
            this.PortLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.25F, System.Drawing.FontStyle.Bold);
            this.PortLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.PortLabel.Location = new System.Drawing.Point(2, 8);
            this.PortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(49, 25);
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
            this.PayloadPathBox.Location = new System.Drawing.Point(8, 61);
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
            // PinkBtn
            // 
            this.PinkBtn.BackColor = System.Drawing.Color.Black;
            this.PinkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PinkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinkBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.PinkBtn.Location = new System.Drawing.Point(17, 89);
            this.PinkBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PinkBtn.Name = "PinkBtn";
            this.PinkBtn.Size = new System.Drawing.Size(20, 23);
            this.PinkBtn.TabIndex = 11;
            this.PinkBtn.UseVisualStyleBackColor = false;
            this.PinkBtn.Click += new System.EventHandler(this.PinkBtn_Click);
            // 
            // PorpleBtn
            // 
            this.PorpleBtn.BackColor = System.Drawing.Color.Black;
            this.PorpleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PorpleBtn.ForeColor = System.Drawing.Color.DarkViolet;
            this.PorpleBtn.Location = new System.Drawing.Point(36, 89);
            this.PorpleBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PorpleBtn.Name = "PorpleBtn";
            this.PorpleBtn.Size = new System.Drawing.Size(20, 23);
            this.PorpleBtn.TabIndex = 12;
            this.PorpleBtn.UseVisualStyleBackColor = false;
            this.PorpleBtn.Click += new System.EventHandler(this.PorpleBtn_Click);
            // 
            // ThemeBtn
            // 
            this.ThemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.ThemeBtn.Location = new System.Drawing.Point(0, 0);
            this.ThemeBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ThemeBtn.Name = "ThemeBtn";
            this.ThemeBtn.Size = new System.Drawing.Size(52, 23);
            this.ThemeBtn.TabIndex = 14;
            this.ThemeBtn.Text = "Theme";
            this.ThemeBtn.UseVisualStyleBackColor = true;
            this.ThemeBtn.Click += new System.EventHandler(this.ThemeBtn_Click);
            // 
            // OrangBtn
            // 
            this.OrangBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrangBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.OrangBtn.Location = new System.Drawing.Point(97, 89);
            this.OrangBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OrangBtn.Name = "OrangBtn";
            this.OrangBtn.Size = new System.Drawing.Size(20, 23);
            this.OrangBtn.TabIndex = 13;
            this.OrangBtn.UseVisualStyleBackColor = true;
            this.OrangBtn.Click += new System.EventHandler(this.OrangeBtn_Click);
            // 
            // BlueBtn
            // 
            this.BlueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlueBtn.ForeColor = System.Drawing.Color.Blue;
            this.BlueBtn.Location = new System.Drawing.Point(76, 89);
            this.BlueBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BlueBtn.Name = "BlueBtn";
            this.BlueBtn.Size = new System.Drawing.Size(20, 23);
            this.BlueBtn.TabIndex = 16;
            this.BlueBtn.UseVisualStyleBackColor = true;
            this.BlueBtn.Click += new System.EventHandler(this.BlueBtn_Click);
            // 
            // LimeBtn
            // 
            this.LimeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimeBtn.ForeColor = System.Drawing.Color.Lime;
            this.LimeBtn.Location = new System.Drawing.Point(56, 89);
            this.LimeBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LimeBtn.Name = "LimeBtn";
            this.LimeBtn.Size = new System.Drawing.Size(20, 23);
            this.LimeBtn.TabIndex = 15;
            this.LimeBtn.UseVisualStyleBackColor = true;
            this.LimeBtn.Click += new System.EventHandler(this.CrimsonBtn_Click);
            // 
            // RedBtn
            // 
            this.RedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedBtn.ForeColor = System.Drawing.Color.Red;
            this.RedBtn.Location = new System.Drawing.Point(137, 89);
            this.RedBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RedBtn.Name = "RedBtn";
            this.RedBtn.Size = new System.Drawing.Size(20, 23);
            this.RedBtn.TabIndex = 18;
            this.RedBtn.UseVisualStyleBackColor = true;
            this.RedBtn.Click += new System.EventHandler(this.RedBtn_Click);
            // 
            // YellowBtn
            // 
            this.YellowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YellowBtn.ForeColor = System.Drawing.Color.Gold;
            this.YellowBtn.Location = new System.Drawing.Point(117, 89);
            this.YellowBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.YellowBtn.Name = "YellowBtn";
            this.YellowBtn.Size = new System.Drawing.Size(20, 23);
            this.YellowBtn.TabIndex = 17;
            this.YellowBtn.UseVisualStyleBackColor = true;
            this.YellowBtn.Click += new System.EventHandler(this.YellowBtn_Click);
            // 
            // AquaButton
            // 
            this.AquaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AquaButton.ForeColor = System.Drawing.Color.Aqua;
            this.AquaButton.Location = new System.Drawing.Point(157, 89);
            this.AquaButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AquaButton.Name = "AquaButton";
            this.AquaButton.Size = new System.Drawing.Size(20, 23);
            this.AquaButton.TabIndex = 21;
            this.AquaButton.UseVisualStyleBackColor = true;
            this.AquaButton.Click += new System.EventHandler(this.AquaButton_Click);
            // 
            // LimeGreenBtn
            // 
            this.LimeGreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimeGreenBtn.ForeColor = System.Drawing.Color.LimeGreen;
            this.LimeGreenBtn.Location = new System.Drawing.Point(177, 89);
            this.LimeGreenBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LimeGreenBtn.Name = "LimeGreenBtn";
            this.LimeGreenBtn.Size = new System.Drawing.Size(20, 23);
            this.LimeGreenBtn.TabIndex = 22;
            this.LimeGreenBtn.UseVisualStyleBackColor = true;
            this.LimeGreenBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // bb1
            // 
            this.bb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bb1.ForeColor = System.Drawing.Color.Cyan;
            this.bb1.Location = new System.Drawing.Point(70, 0);
            this.bb1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bb1.Name = "bb1";
            this.bb1.Size = new System.Drawing.Size(20, 23);
            this.bb1.TabIndex = 23;
            this.bb1.UseVisualStyleBackColor = true;
            this.bb1.Visible = false;
            this.bb1.Click += new System.EventHandler(this.buttonButton_Click);
            // 
            // bb2
            // 
            this.bb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bb2.ForeColor = System.Drawing.Color.Red;
            this.bb2.Location = new System.Drawing.Point(90, 0);
            this.bb2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bb2.Name = "bb2";
            this.bb2.Size = new System.Drawing.Size(20, 23);
            this.bb2.TabIndex = 24;
            this.bb2.UseVisualStyleBackColor = true;
            this.bb2.Visible = false;
            this.bb2.Click += new System.EventHandler(this.noButtonButton_Click);
            // 
            // bb3
            // 
            this.bb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bb3.ForeColor = System.Drawing.Color.Indigo;
            this.bb3.Location = new System.Drawing.Point(110, 0);
            this.bb3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bb3.Name = "bb3";
            this.bb3.Size = new System.Drawing.Size(21, 23);
            this.bb3.TabIndex = 25;
            this.bb3.UseVisualStyleBackColor = true;
            this.bb3.Visible = false;
            this.bb3.Click += new System.EventHandler(this.bb3_Click);
            // 
            // Box
            // 
            this.Box.Controls.Add(this.BrowseButton);
            this.Box.Controls.Add(this.IPLabel);
            this.Box.Controls.Add(this.PortBox);
            this.Box.Controls.Add(this.LimeGreenBtn);
            this.Box.Controls.Add(this.IPBox);
            this.Box.Controls.Add(this.AquaButton);
            this.Box.Controls.Add(this.PayloadPathBox);
            this.Box.Controls.Add(this.RedBtn);
            this.Box.Controls.Add(this.SendButton);
            this.Box.Controls.Add(this.YellowBtn);
            this.Box.Controls.Add(this.BlueBtn);
            this.Box.Controls.Add(this.LimeBtn);
            this.Box.Controls.Add(this.PinkBtn);
            this.Box.Controls.Add(this.PorpleBtn);
            this.Box.Controls.Add(this.OrangBtn);
            this.Box.Controls.Add(this.PortLabel);
            this.Box.ForeColor = System.Drawing.Color.Fuchsia;
            this.Box.Location = new System.Drawing.Point(0, 18);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(214, 81);
            this.Box.TabIndex = 26;
            this.Box.TabStop = false;
            // 
            // BuildLabel
            // 
            this.BuildLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12.25F);
            this.BuildLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.BuildLabel.Location = new System.Drawing.Point(81, 0);
            this.BuildLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BuildLabel.Name = "BuildLabel";
            this.BuildLabel.Size = new System.Drawing.Size(36, 22);
            this.BuildLabel.TabIndex = 23;
            this.BuildLabel.Text = "1.4.3";
            // 
            // Payload_Sender
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(214, 98);
            this.Controls.Add(this.BuildLabel);
            this.Controls.Add(this.bb1);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.bb2);
            this.Controls.Add(this.bb3);
            this.Controls.Add(this.ThemeBtn);
            this.Controls.Add(this.Box);
            this.ForeColor = System.Drawing.Color.Fuchsia;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button PinkBtn;
        private System.Windows.Forms.Button PorpleBtn;
        private System.Windows.Forms.Button ThemeBtn;
        private System.Windows.Forms.Button OrangBtn;
        private System.Windows.Forms.Button BlueBtn;
        private System.Windows.Forms.Button LimeBtn;
        private System.Windows.Forms.Button RedBtn;
        private System.Windows.Forms.Button YellowBtn;
        private System.Windows.Forms.Button AquaButton;
        private System.Windows.Forms.Button LimeGreenBtn;
        private System.Windows.Forms.Button bb1;
        private System.Windows.Forms.Button bb2;
        private System.Windows.Forms.Button bb3;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.Label BuildLabel;
    }
}

