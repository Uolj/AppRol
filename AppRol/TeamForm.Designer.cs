namespace AppRol
{
    partial class TeamForm
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
            this.teamListBox = new System.Windows.Forms.ListBox();
            this.eraseBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teamListBox
            // 
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.ItemHeight = 16;
            this.teamListBox.Location = new System.Drawing.Point(24, 22);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(283, 164);
            this.teamListBox.TabIndex = 0;
            // 
            // eraseBtn
            // 
            this.eraseBtn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eraseBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.eraseBtn.Location = new System.Drawing.Point(346, 122);
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(107, 40);
            this.eraseBtn.TabIndex = 1;
            this.eraseBtn.Text = "ERASE";
            this.eraseBtn.UseVisualStyleBackColor = true;
            this.eraseBtn.Click += new System.EventHandler(this.eraseBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.viewBtn.Location = new System.Drawing.Point(346, 48);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(107, 40);
            this.viewBtn.TabIndex = 2;
            this.viewBtn.Text = "DISPLAY ";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 210);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.eraseBtn);
            this.Controls.Add(this.teamListBox);
            this.Name = "TeamForm";
            this.Text = "TeamForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.Button eraseBtn;
        private System.Windows.Forms.Button viewBtn;
    }
}