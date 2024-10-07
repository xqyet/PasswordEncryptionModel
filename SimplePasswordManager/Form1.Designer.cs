namespace SimplePasswordManager
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
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSavePassword = new System.Windows.Forms.Button();
            this.btnLoadPasswords = new System.Windows.Forms.Button();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.listViewPasswords = new System.Windows.Forms.ListView();
            this.columnWebsite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWebsite
            // 
            this.txtWebsite.BackColor = System.Drawing.Color.Black;
            this.txtWebsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWebsite.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtWebsite.ForeColor = System.Drawing.Color.Gray;
            this.txtWebsite.Location = new System.Drawing.Point(12, 52); // Moved down due to title bar
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(300, 26);
            this.txtWebsite.TabIndex = 0;
            this.txtWebsite.Text = "Website";
            this.txtWebsite.GotFocus += new System.EventHandler(this.RemovePlaceholderText);
            this.txtWebsite.LostFocus += new System.EventHandler(this.AddPlaceholderText);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Black;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(12, 84);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 26);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Username";
            this.txtUsername.GotFocus += new System.EventHandler(this.RemovePlaceholderText);
            this.txtUsername.LostFocus += new System.EventHandler(this.AddPlaceholderText);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(12, 116);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Password";
            this.txtPassword.GotFocus += new System.EventHandler(this.RemovePlaceholderText);
            this.txtPassword.LostFocus += new System.EventHandler(this.AddPlaceholderText);
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.BackColor = System.Drawing.Color.Black;
            this.btnSavePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePassword.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnSavePassword.ForeColor = System.Drawing.Color.Lime;
            this.btnSavePassword.Location = new System.Drawing.Point(12, 148);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(300, 30);
            this.btnSavePassword.TabIndex = 3;
            this.btnSavePassword.Text = "Save Password";
            this.btnSavePassword.UseVisualStyleBackColor = false;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // btnLoadPasswords
            // 
            this.btnLoadPasswords.BackColor = System.Drawing.Color.Black;
            this.btnLoadPasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPasswords.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnLoadPasswords.ForeColor = System.Drawing.Color.Lime;
            this.btnLoadPasswords.Location = new System.Drawing.Point(12, 184);
            this.btnLoadPasswords.Name = "btnLoadPasswords";
            this.btnLoadPasswords.Size = new System.Drawing.Size(300, 30);
            this.btnLoadPasswords.TabIndex = 4;
            this.btnLoadPasswords.Text = "Load Passwords";
            this.btnLoadPasswords.UseVisualStyleBackColor = false;
            this.btnLoadPasswords.Click += new System.EventHandler(this.btnLoadPasswords_Click);
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.BackColor = System.Drawing.Color.Black;
            this.btnGeneratePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneratePassword.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnGeneratePassword.ForeColor = System.Drawing.Color.Lime;
            this.btnGeneratePassword.Location = new System.Drawing.Point(12, 220);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(300, 30);
            this.btnGeneratePassword.TabIndex = 5;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = false;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // listViewPasswords
            // 
            this.listViewPasswords.BackColor = System.Drawing.Color.Black;
            this.listViewPasswords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewPasswords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnWebsite,
            this.columnUsername,
            this.columnPassword});
            this.listViewPasswords.Font = new System.Drawing.Font("Consolas", 12F);
            this.listViewPasswords.ForeColor = System.Drawing.Color.Lime;
            this.listViewPasswords.FullRowSelect = true;
            this.listViewPasswords.HideSelection = false;
            this.listViewPasswords.Location = new System.Drawing.Point(12, 256);
            this.listViewPasswords.Name = "listViewPasswords";
            this.listViewPasswords.Size = new System.Drawing.Size(600, 200);
            this.listViewPasswords.TabIndex = 6;
            this.listViewPasswords.UseCompatibleStateImageBehavior = false;
            this.listViewPasswords.View = System.Windows.Forms.View.Details;
            // 
            // columnWebsite
            // 
            this.columnWebsite.Text = "Website";
            this.columnWebsite.Width = 200;
            // 
            // columnUsername
            // 
            this.columnUsername.Text = "Username";
            this.columnUsername.Width = 200;
            // 
            // columnPassword
            // 
            this.columnPassword.Text = "Password";
            this.columnPassword.Width = 200;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Black; // Changed to black
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(624, 28); // Adjust height if necessary
            this.panelTitleBar.TabIndex = 7;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            this.panelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseMove);
            this.panelTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Lime; // Changed to lime
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(624, 28);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "USB-Mobile Encrypted Password Manager";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; // Align to the left
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Consolas", 8F);
            this.lblFooter.ForeColor = System.Drawing.Color.White; // Set footer text color to white
            this.lblFooter.Location = new System.Drawing.Point(500, 460); // Position at the bottom right
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(92, 13);
            this.lblFooter.TabIndex = 9;
            this.lblFooter.Text = "xqyet @ 2024";
            this.lblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // Add controls to the form
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.listViewPasswords);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.btnLoadPasswords);
            this.Controls.Add(this.btnSavePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.lblFooter);

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(624, 480);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Simple Password Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSavePassword;
        private System.Windows.Forms.Button btnLoadPasswords;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.ListView listViewPasswords;
        private System.Windows.Forms.ColumnHeader columnWebsite;
        private System.Windows.Forms.ColumnHeader columnUsername;
        private System.Windows.Forms.ColumnHeader columnPassword;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFooter;
    }
}
