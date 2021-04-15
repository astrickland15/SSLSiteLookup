namespace SSLSiteTest
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
            this.Sites = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Sites
            // 
            this.Sites.Location = new System.Drawing.Point(56, 29);
            this.Sites.Multiline = true;
            this.Sites.Name = "Sites";
            this.Sites.Size = new System.Drawing.Size(466, 354);
            this.Sites.TabIndex = 0;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(588, 109);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 1;
            this.check.Text = "Check Sites";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(56, 411);
            this.progressBar.Minimum = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(466, 23);
            this.progressBar.TabIndex = 2;
            this.progressBar.Value = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.check);
            this.Controls.Add(this.Sites);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Sites;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

