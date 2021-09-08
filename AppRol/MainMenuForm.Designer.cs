
namespace AppRol
{
    partial class MainMenuForm
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
            this.createBtn = new System.Windows.Forms.Button();
            this.viewTeamBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(30, 88);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(416, 41);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // viewTeamBtn
            // 
            this.viewTeamBtn.Location = new System.Drawing.Point(30, 26);
            this.viewTeamBtn.Name = "viewTeamBtn";
            this.viewTeamBtn.Size = new System.Drawing.Size(416, 41);
            this.viewTeamBtn.TabIndex = 1;
            this.viewTeamBtn.Text = "My Team";
            this.viewTeamBtn.UseVisualStyleBackColor = true;
            this.viewTeamBtn.Click += new System.EventHandler(this.viewTeamBtn_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 273);
            this.Controls.Add(this.viewTeamBtn);
            this.Controls.Add(this.createBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(492, 320);
            this.MinimumSize = new System.Drawing.Size(492, 320);
            this.Name = "MainMenuForm";
            this.Text = "AppRol";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button viewTeamBtn;
    }
}

