namespace TravianBot
{
    partial class StartDialog
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
            this.uiComboBoxForSelectBrowser = new System.Windows.Forms.ComboBox();
            this.uiLabelForSelectBrowser = new System.Windows.Forms.Label();
            this.uiButtonForConfirm = new System.Windows.Forms.Button();
            this.uiButtonForCancel = new System.Windows.Forms.Button();
            this.uiLabelForUsername = new System.Windows.Forms.Label();
            this.uiLabelForPassword = new System.Windows.Forms.Label();
            this.uiTextBoxForUsername = new System.Windows.Forms.TextBox();
            this.uiTextBoxForPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uiComboBoxForSelectBrowser
            // 
            this.uiComboBoxForSelectBrowser.FormattingEnabled = true;
            this.uiComboBoxForSelectBrowser.Items.AddRange(new object[] {
            "Google Chrome",
            "Firefox"});
            this.uiComboBoxForSelectBrowser.Location = new System.Drawing.Point(257, 10);
            this.uiComboBoxForSelectBrowser.Name = "uiComboBoxForSelectBrowser";
            this.uiComboBoxForSelectBrowser.Size = new System.Drawing.Size(182, 21);
            this.uiComboBoxForSelectBrowser.TabIndex = 0;
            // 
            // uiLabelForSelectBrowser
            // 
            this.uiLabelForSelectBrowser.AutoSize = true;
            this.uiLabelForSelectBrowser.Location = new System.Drawing.Point(12, 13);
            this.uiLabelForSelectBrowser.Name = "uiLabelForSelectBrowser";
            this.uiLabelForSelectBrowser.Size = new System.Drawing.Size(239, 13);
            this.uiLabelForSelectBrowser.TabIndex = 1;
            this.uiLabelForSelectBrowser.Text = "Please choose your browser, you want to choose";
            // 
            // uiButtonForConfirm
            // 
            this.uiButtonForConfirm.Location = new System.Drawing.Point(12, 119);
            this.uiButtonForConfirm.Name = "uiButtonForConfirm";
            this.uiButtonForConfirm.Size = new System.Drawing.Size(75, 23);
            this.uiButtonForConfirm.TabIndex = 2;
            this.uiButtonForConfirm.Text = "Confirm";
            this.uiButtonForConfirm.UseVisualStyleBackColor = true;
            this.uiButtonForConfirm.Click += new System.EventHandler(this.uiButtonForConfirm_Click);
            // 
            // uiButtonForCancel
            // 
            this.uiButtonForCancel.Location = new System.Drawing.Point(363, 119);
            this.uiButtonForCancel.Name = "uiButtonForCancel";
            this.uiButtonForCancel.Size = new System.Drawing.Size(75, 23);
            this.uiButtonForCancel.TabIndex = 3;
            this.uiButtonForCancel.Text = "Cancel";
            this.uiButtonForCancel.UseVisualStyleBackColor = true;
            this.uiButtonForCancel.Click += new System.EventHandler(this.uiButtonForCancel_Click);
            // 
            // uiLabelForUsername
            // 
            this.uiLabelForUsername.AutoSize = true;
            this.uiLabelForUsername.Location = new System.Drawing.Point(12, 46);
            this.uiLabelForUsername.Name = "uiLabelForUsername";
            this.uiLabelForUsername.Size = new System.Drawing.Size(55, 13);
            this.uiLabelForUsername.TabIndex = 4;
            this.uiLabelForUsername.Text = "Username";
            // 
            // uiLabelForPassword
            // 
            this.uiLabelForPassword.AutoSize = true;
            this.uiLabelForPassword.Location = new System.Drawing.Point(12, 83);
            this.uiLabelForPassword.Name = "uiLabelForPassword";
            this.uiLabelForPassword.Size = new System.Drawing.Size(53, 13);
            this.uiLabelForPassword.TabIndex = 5;
            this.uiLabelForPassword.Text = "Password";
            // 
            // uiTextBoxForUsername
            // 
            this.uiTextBoxForUsername.Location = new System.Drawing.Point(257, 46);
            this.uiTextBoxForUsername.Name = "uiTextBoxForUsername";
            this.uiTextBoxForUsername.Size = new System.Drawing.Size(181, 20);
            this.uiTextBoxForUsername.TabIndex = 6;
            // 
            // uiTextBoxForPassword
            // 
            this.uiTextBoxForPassword.Location = new System.Drawing.Point(257, 83);
            this.uiTextBoxForPassword.Name = "uiTextBoxForPassword";
            this.uiTextBoxForPassword.Size = new System.Drawing.Size(181, 20);
            this.uiTextBoxForPassword.TabIndex = 7;
            // 
            // StartDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 154);
            this.Controls.Add(this.uiTextBoxForPassword);
            this.Controls.Add(this.uiTextBoxForUsername);
            this.Controls.Add(this.uiLabelForPassword);
            this.Controls.Add(this.uiLabelForUsername);
            this.Controls.Add(this.uiButtonForCancel);
            this.Controls.Add(this.uiButtonForConfirm);
            this.Controls.Add(this.uiLabelForSelectBrowser);
            this.Controls.Add(this.uiComboBoxForSelectBrowser);
            this.Name = "StartDialog";
            this.Text = "TravianBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uiComboBoxForSelectBrowser;
        private System.Windows.Forms.Label uiLabelForSelectBrowser;
        private System.Windows.Forms.Button uiButtonForConfirm;
        private System.Windows.Forms.Button uiButtonForCancel;
        private System.Windows.Forms.Label uiLabelForUsername;
        private System.Windows.Forms.Label uiLabelForPassword;
        private System.Windows.Forms.TextBox uiTextBoxForUsername;
        private System.Windows.Forms.TextBox uiTextBoxForPassword;
    }
}

