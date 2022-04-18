namespace Register
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegPage = new System.Windows.Forms.Button();
            this.btnChangePassPage = new System.Windows.Forms.Button();
            this.btnLogPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Papyrus", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(391, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(473, 151);
            this.label3.TabIndex = 15;
            this.label3.Text = "Welcome!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnRegPage
            // 
            this.btnRegPage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegPage.Font = new System.Drawing.Font("Papyrus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegPage.ForeColor = System.Drawing.Color.Red;
            this.btnRegPage.Location = new System.Drawing.Point(26, 12);
            this.btnRegPage.Name = "btnRegPage";
            this.btnRegPage.Size = new System.Drawing.Size(229, 77);
            this.btnRegPage.TabIndex = 16;
            this.btnRegPage.Text = "Registration";
            this.btnRegPage.UseVisualStyleBackColor = false;
            this.btnRegPage.Click += new System.EventHandler(this.btnRegPage_Click);
            // 
            // btnChangePassPage
            // 
            this.btnChangePassPage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangePassPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassPage.Font = new System.Drawing.Font("Papyrus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassPage.ForeColor = System.Drawing.Color.Red;
            this.btnChangePassPage.Location = new System.Drawing.Point(460, 12);
            this.btnChangePassPage.Name = "btnChangePassPage";
            this.btnChangePassPage.Size = new System.Drawing.Size(277, 77);
            this.btnChangePassPage.TabIndex = 17;
            this.btnChangePassPage.Text = "Change Password";
            this.btnChangePassPage.UseVisualStyleBackColor = false;
            this.btnChangePassPage.Click += new System.EventHandler(this.btnChangePassPage_Click);
            // 
            // btnLogPage
            // 
            this.btnLogPage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogPage.Font = new System.Drawing.Font("Papyrus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogPage.ForeColor = System.Drawing.Color.Red;
            this.btnLogPage.Location = new System.Drawing.Point(237, 12);
            this.btnLogPage.Name = "btnLogPage";
            this.btnLogPage.Size = new System.Drawing.Size(229, 77);
            this.btnLogPage.TabIndex = 18;
            this.btnLogPage.Text = "Login";
            this.btnLogPage.UseVisualStyleBackColor = false;
            this.btnLogPage.Click += new System.EventHandler(this.btnLogPage_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1269, 660);
            this.Controls.Add(this.btnLogPage);
            this.Controls.Add(this.btnChangePassPage);
            this.Controls.Add(this.btnRegPage);
            this.Controls.Add(this.label3);
            this.Name = "Welcome";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegPage;
        private System.Windows.Forms.Button btnChangePassPage;
        private System.Windows.Forms.Button btnLogPage;
    }
}