using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SimplePasswordManager
{
    public partial class Form1 : Form
    {
        // Fields to capture mouse position for dragging
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Form1()
        {
            InitializeComponent();
        }

        // This event runs when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Initialize or load data when form loads
        }

        // Remove placeholder when textbox gains focus
        private void RemovePlaceholderText(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox != null && txtBox.ForeColor == Color.Gray)
            {
                txtBox.Text = "";
                txtBox.ForeColor = Color.Lime;
            }
        }

        // Add placeholder when textbox loses focus
        private void AddPlaceholderText(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox != null && string.IsNullOrWhiteSpace(txtBox.Text))
            {
                if (txtBox.Name == "txtWebsite")
                {
                    txtBox.Text = "Website";
                }
                else if (txtBox.Name == "txtUsername")
                {
                    txtBox.Text = "Username";
                }
                else if (txtBox.Name == "txtPassword")
                {
                    txtBox.Text = "Password";
                }
                txtBox.ForeColor = Color.Gray;
            }
        }

        // Save Password Button Click event handler
        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            string website = txtWebsite.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Use PasswordManager class (assuming you've implemented it) to save encrypted password
            PasswordManager.SavePassword(website, username, password);

            MessageBox.Show("Password Saved!");
        }

        // Load Password Button Click event handler
        private void btnLoadPasswords_Click(object sender, EventArgs e)
        {
            List<PasswordEntry> passwords = PasswordManager.LoadPasswords();

            // Clear list view before adding items
            listViewPasswords.Items.Clear();

            foreach (var entry in passwords)
            {
                var listViewItem = new ListViewItem(new[]
                {
                    entry.Website, entry.Username, EncryptionHelper.Decrypt(entry.EncryptedPassword, "your-secret-key")
                });
                listViewPasswords.Items.Add(listViewItem);
            }
        }

        // Generate Password Button Click event handler
        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            // Generate a simple random password (you can implement more complex logic)
            txtPassword.Text = GenerateRandomPassword();
        }

        // Simple Random Password Generator
        private string GenerateRandomPassword()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 12).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        // MouseDown event for dragging the form using the title bar
  // MouseDown event for dragging the form using the title bar
private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
{
    dragging = true;
    dragCursorPoint = new Point(e.X, e.Y); // Capture where the mouse was clicked in the panel
    dragFormPoint = this.Location;         // Capture the form's current position
}

// MouseMove event for dragging the form
private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
{
    if (dragging)
    {
        Point newCursorPosition = new Point(e.X, e.Y);
        this.Location = new Point(dragFormPoint.X + (Cursor.Position.X - dragCursorPoint.X),
                                  dragFormPoint.Y + (Cursor.Position.Y - dragCursorPoint.Y));
    }
}

// MouseUp event to stop dragging the form
private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
{
    dragging = false;
}
    }
}
