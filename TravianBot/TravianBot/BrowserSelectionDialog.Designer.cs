namespace TravianBot
{
    partial class BrowserSelectionDialog
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
            // BrowserSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 154);
            this.Controls.Add(this.uiButtonForCancel);
            this.Controls.Add(this.uiButtonForConfirm);
            this.Controls.Add(this.uiLabelForSelectBrowser);
            this.Controls.Add(this.uiComboBoxForSelectBrowser);
            this.Name = "BrowserSelection";
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
    }
}

