
namespace SuperMarketManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UserNameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.LoginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ClearLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserNameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.UserNameTextBox.HintText = "";
            this.UserNameTextBox.isPassword = false;
            this.UserNameTextBox.LineFocusedColor = System.Drawing.Color.Black;
            this.UserNameTextBox.LineIdleColor = System.Drawing.Color.Orchid;
            this.UserNameTextBox.LineMouseHoverColor = System.Drawing.Color.Black;
            this.UserNameTextBox.LineThickness = 3;
            this.UserNameTextBox.Location = new System.Drawing.Point(139, 166);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(208, 27);
            this.UserNameTextBox.TabIndex = 1;
            this.UserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orchid;
            this.label2.Location = new System.Drawing.Point(24, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orchid;
            this.label3.Location = new System.Drawing.Point(24, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "PASSWORD";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PasswordTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.PasswordTextBox.HintText = "";
            this.PasswordTextBox.isPassword = false;
            this.PasswordTextBox.LineFocusedColor = System.Drawing.Color.Black;
            this.PasswordTextBox.LineIdleColor = System.Drawing.Color.Orchid;
            this.PasswordTextBox.LineMouseHoverColor = System.Drawing.Color.Black;
            this.PasswordTextBox.LineThickness = 3;
            this.PasswordTextBox.Location = new System.Drawing.Point(139, 222);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(208, 27);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordTextBox.OnValueChanged += new System.EventHandler(this.PasswordTextBox_OnValueChanged);
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.RoleComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleComboBox.ForeColor = System.Drawing.Color.Orchid;
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Items.AddRange(new object[] {
            "MANAGER",
            "SELLER"});
            this.RoleComboBox.Location = new System.Drawing.Point(139, 273);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(208, 29);
            this.RoleComboBox.TabIndex = 7;
            this.RoleComboBox.Text = "Select Role";
            // 
            // LoginButton
            // 
            this.LoginButton.ActiveBorderThickness = 1;
            this.LoginButton.ActiveCornerRadius = 20;
            this.LoginButton.ActiveFillColor = System.Drawing.Color.Orchid;
            this.LoginButton.ActiveForecolor = System.Drawing.Color.Black;
            this.LoginButton.ActiveLineColor = System.Drawing.Color.Orchid;
            this.LoginButton.BackColor = System.Drawing.SystemColors.Control;
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.ButtonText = "LOGIN";
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.IdleBorderThickness = 1;
            this.LoginButton.IdleCornerRadius = 20;
            this.LoginButton.IdleFillColor = System.Drawing.Color.Orchid;
            this.LoginButton.IdleForecolor = System.Drawing.Color.Black;
            this.LoginButton.IdleLineColor = System.Drawing.Color.SeaShell;
            this.LoginButton.Location = new System.Drawing.Point(388, 188);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(248, 52);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ClearLabel
            // 
            this.ClearLabel.AutoSize = true;
            this.ClearLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLabel.ForeColor = System.Drawing.Color.Orchid;
            this.ClearLabel.Location = new System.Drawing.Point(450, 245);
            this.ClearLabel.Name = "ClearLabel";
            this.ClearLabel.Size = new System.Drawing.Size(52, 19);
            this.ClearLabel.TabIndex = 9;
            this.ClearLabel.Text = "Clear";
            this.ClearLabel.Click += new System.EventHandler(this.ClearLabel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(638, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "x";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // guna2GradientCircleButton1
            // 
            this.guna2GradientCircleButton1.CheckedState.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.CustomImages.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton1.HoverState.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(-111, -126);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.ShadowDecoration.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(865, 285);
            this.guna2GradientCircleButton1.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Orchid;
            this.label9.Font = new System.Drawing.Font("Algerian", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(232, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 39);
            this.label9.TabIndex = 16;
            this.label9.Text = "RODOSTO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Orchid;
            this.label10.Font = new System.Drawing.Font("Algerian", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(186, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(273, 39);
            this.label10.TabIndex = 15;
            this.label10.Text = "SUPERMARKET";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orchid;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(585, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Version 1.0";
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.Orchid;
            this.ExitLabel.Location = new System.Drawing.Point(524, 245);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(38, 19);
            this.ExitLabel.TabIndex = 18;
            this.ExitLabel.Text = "Exit";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 363);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.guna2GradientCircleButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ClearLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PasswordTextBox;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginButton;
        private System.Windows.Forms.Label ClearLabel;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ExitLabel;
    }
}

