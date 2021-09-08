
namespace AppRol
{
    partial class PjCreationForm
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
            this.speciesCombo = new System.Windows.Forms.ComboBox();
            this.archetypeCombo = new System.Windows.Forms.ComboBox();
            this.speciesLbl = new System.Windows.Forms.Label();
            this.archetypeLbl = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.agilityLbl = new System.Windows.Forms.Label();
            this.bodyAttributesBox = new System.Windows.Forms.GroupBox();
            this.constitutionTxtBox = new System.Windows.Forms.TextBox();
            this.strengthTxtBox = new System.Windows.Forms.TextBox();
            this.dexterityTxtBox = new System.Windows.Forms.TextBox();
            this.agilityTxtBox = new System.Windows.Forms.TextBox();
            this.constitutionLbl = new System.Windows.Forms.Label();
            this.strengthLbl = new System.Windows.Forms.Label();
            this.dexterityLbl = new System.Windows.Forms.Label();
            this.mindAttributesBox = new System.Windows.Forms.GroupBox();
            this.knowledgeTxtBox = new System.Windows.Forms.TextBox();
            this.willTxtBox = new System.Windows.Forms.TextBox();
            this.charismaTxtBox = new System.Windows.Forms.TextBox();
            this.perceptionTxtBox = new System.Windows.Forms.TextBox();
            this.knowledgeLbl = new System.Windows.Forms.Label();
            this.willLbl = new System.Windows.Forms.Label();
            this.charismaLbl = new System.Windows.Forms.Label();
            this.perceptionLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.bodyTxtBox = new System.Windows.Forms.TextBox();
            this.mindTxtBox = new System.Windows.Forms.TextBox();
            this.bodyLbl = new System.Windows.Forms.Label();
            this.mindLbl = new System.Windows.Forms.Label();
            this.archCommentaryTxtBox = new System.Windows.Forms.RichTextBox();
            this.speciesCommentaryTxtBox = new System.Windows.Forms.RichTextBox();
            this.essenceLbl = new System.Windows.Forms.Label();
            this.essenceAmount = new System.Windows.Forms.Label();
            this.bodyAttributesBox.SuspendLayout();
            this.mindAttributesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // speciesCombo
            // 
            this.speciesCombo.BackColor = System.Drawing.Color.ForestGreen;
            this.speciesCombo.ForeColor = System.Drawing.Color.Cornsilk;
            this.speciesCombo.FormattingEnabled = true;
            this.speciesCombo.Location = new System.Drawing.Point(54, 97);
            this.speciesCombo.Name = "speciesCombo";
            this.speciesCombo.Size = new System.Drawing.Size(146, 24);
            this.speciesCombo.TabIndex = 1;
            this.speciesCombo.SelectedIndexChanged += new System.EventHandler(this.specieCombo_SelectedIndexChanged);
            // 
            // archetypeCombo
            // 
            this.archetypeCombo.BackColor = System.Drawing.Color.DarkCyan;
            this.archetypeCombo.FormattingEnabled = true;
            this.archetypeCombo.Location = new System.Drawing.Point(217, 97);
            this.archetypeCombo.Name = "archetypeCombo";
            this.archetypeCombo.Size = new System.Drawing.Size(146, 24);
            this.archetypeCombo.TabIndex = 2;
            this.archetypeCombo.SelectedIndexChanged += new System.EventHandler(this.archetypeCombo_SelectedIndexChanged);
            // 
            // speciesLbl
            // 
            this.speciesLbl.AutoSize = true;
            this.speciesLbl.Location = new System.Drawing.Point(54, 74);
            this.speciesLbl.Name = "speciesLbl";
            this.speciesLbl.Size = new System.Drawing.Size(58, 17);
            this.speciesLbl.TabIndex = 3;
            this.speciesLbl.Text = "Species";
            // 
            // archetypeLbl
            // 
            this.archetypeLbl.AutoSize = true;
            this.archetypeLbl.Location = new System.Drawing.Point(217, 74);
            this.archetypeLbl.Name = "archetypeLbl";
            this.archetypeLbl.Size = new System.Drawing.Size(72, 17);
            this.archetypeLbl.TabIndex = 4;
            this.archetypeLbl.Text = "Archetype";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(998, 582);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 31);
            this.okBtn.TabIndex = 5;
            this.okBtn.Text = "OK!";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(51, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(45, 17);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "Name";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(54, 30);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(309, 22);
            this.nameTxtBox.TabIndex = 7;
            // 
            // agilityLbl
            // 
            this.agilityLbl.AutoSize = true;
            this.agilityLbl.Location = new System.Drawing.Point(6, 30);
            this.agilityLbl.Name = "agilityLbl";
            this.agilityLbl.Size = new System.Drawing.Size(45, 17);
            this.agilityLbl.TabIndex = 9;
            this.agilityLbl.Text = "Agility";
            // 
            // bodyAttributesBox
            // 
            this.bodyAttributesBox.Controls.Add(this.constitutionTxtBox);
            this.bodyAttributesBox.Controls.Add(this.strengthTxtBox);
            this.bodyAttributesBox.Controls.Add(this.dexterityTxtBox);
            this.bodyAttributesBox.Controls.Add(this.agilityTxtBox);
            this.bodyAttributesBox.Controls.Add(this.constitutionLbl);
            this.bodyAttributesBox.Controls.Add(this.strengthLbl);
            this.bodyAttributesBox.Controls.Add(this.dexterityLbl);
            this.bodyAttributesBox.Controls.Add(this.agilityLbl);
            this.bodyAttributesBox.Location = new System.Drawing.Point(54, 169);
            this.bodyAttributesBox.Name = "bodyAttributesBox";
            this.bodyAttributesBox.Size = new System.Drawing.Size(200, 147);
            this.bodyAttributesBox.TabIndex = 10;
            this.bodyAttributesBox.TabStop = false;
            this.bodyAttributesBox.Text = "Body Attributes";
            // 
            // constitutionTxtBox
            // 
            this.constitutionTxtBox.Location = new System.Drawing.Point(150, 104);
            this.constitutionTxtBox.Name = "constitutionTxtBox";
            this.constitutionTxtBox.Size = new System.Drawing.Size(31, 22);
            this.constitutionTxtBox.TabIndex = 16;
            this.constitutionTxtBox.Text = "1";
            // 
            // strengthTxtBox
            // 
            this.strengthTxtBox.Location = new System.Drawing.Point(150, 78);
            this.strengthTxtBox.Name = "strengthTxtBox";
            this.strengthTxtBox.Size = new System.Drawing.Size(31, 22);
            this.strengthTxtBox.TabIndex = 15;
            this.strengthTxtBox.Text = "1";
            // 
            // dexterityTxtBox
            // 
            this.dexterityTxtBox.Location = new System.Drawing.Point(150, 50);
            this.dexterityTxtBox.Name = "dexterityTxtBox";
            this.dexterityTxtBox.Size = new System.Drawing.Size(31, 22);
            this.dexterityTxtBox.TabIndex = 14;
            this.dexterityTxtBox.Text = "1";
            // 
            // agilityTxtBox
            // 
            this.agilityTxtBox.Location = new System.Drawing.Point(150, 25);
            this.agilityTxtBox.Name = "agilityTxtBox";
            this.agilityTxtBox.Size = new System.Drawing.Size(31, 22);
            this.agilityTxtBox.TabIndex = 13;
            this.agilityTxtBox.Text = "1";
            // 
            // constitutionLbl
            // 
            this.constitutionLbl.AutoSize = true;
            this.constitutionLbl.Location = new System.Drawing.Point(6, 109);
            this.constitutionLbl.Name = "constitutionLbl";
            this.constitutionLbl.Size = new System.Drawing.Size(82, 17);
            this.constitutionLbl.TabIndex = 12;
            this.constitutionLbl.Text = "Constitution";
            // 
            // strengthLbl
            // 
            this.strengthLbl.AutoSize = true;
            this.strengthLbl.Location = new System.Drawing.Point(6, 83);
            this.strengthLbl.Name = "strengthLbl";
            this.strengthLbl.Size = new System.Drawing.Size(62, 17);
            this.strengthLbl.TabIndex = 11;
            this.strengthLbl.Text = "Strength";
            // 
            // dexterityLbl
            // 
            this.dexterityLbl.AutoSize = true;
            this.dexterityLbl.Location = new System.Drawing.Point(6, 57);
            this.dexterityLbl.Name = "dexterityLbl";
            this.dexterityLbl.Size = new System.Drawing.Size(63, 17);
            this.dexterityLbl.TabIndex = 10;
            this.dexterityLbl.Text = "Dexterity";
            // 
            // mindAttributesBox
            // 
            this.mindAttributesBox.Controls.Add(this.knowledgeTxtBox);
            this.mindAttributesBox.Controls.Add(this.willTxtBox);
            this.mindAttributesBox.Controls.Add(this.charismaTxtBox);
            this.mindAttributesBox.Controls.Add(this.perceptionTxtBox);
            this.mindAttributesBox.Controls.Add(this.knowledgeLbl);
            this.mindAttributesBox.Controls.Add(this.willLbl);
            this.mindAttributesBox.Controls.Add(this.charismaLbl);
            this.mindAttributesBox.Controls.Add(this.perceptionLbl);
            this.mindAttributesBox.Location = new System.Drawing.Point(274, 169);
            this.mindAttributesBox.Name = "mindAttributesBox";
            this.mindAttributesBox.Size = new System.Drawing.Size(200, 147);
            this.mindAttributesBox.TabIndex = 11;
            this.mindAttributesBox.TabStop = false;
            this.mindAttributesBox.Text = "Mind Attributes";
            // 
            // knowledgeTxtBox
            // 
            this.knowledgeTxtBox.Location = new System.Drawing.Point(150, 104);
            this.knowledgeTxtBox.Name = "knowledgeTxtBox";
            this.knowledgeTxtBox.Size = new System.Drawing.Size(31, 22);
            this.knowledgeTxtBox.TabIndex = 16;
            this.knowledgeTxtBox.Text = "1";
            // 
            // willTxtBox
            // 
            this.willTxtBox.Location = new System.Drawing.Point(150, 78);
            this.willTxtBox.Name = "willTxtBox";
            this.willTxtBox.Size = new System.Drawing.Size(31, 22);
            this.willTxtBox.TabIndex = 15;
            this.willTxtBox.Text = "1";
            // 
            // charismaTxtBox
            // 
            this.charismaTxtBox.Location = new System.Drawing.Point(150, 50);
            this.charismaTxtBox.Name = "charismaTxtBox";
            this.charismaTxtBox.Size = new System.Drawing.Size(31, 22);
            this.charismaTxtBox.TabIndex = 14;
            this.charismaTxtBox.Text = "1";
            // 
            // perceptionTxtBox
            // 
            this.perceptionTxtBox.Location = new System.Drawing.Point(150, 25);
            this.perceptionTxtBox.Name = "perceptionTxtBox";
            this.perceptionTxtBox.Size = new System.Drawing.Size(31, 22);
            this.perceptionTxtBox.TabIndex = 13;
            this.perceptionTxtBox.Text = "1";
            // 
            // knowledgeLbl
            // 
            this.knowledgeLbl.AutoSize = true;
            this.knowledgeLbl.Location = new System.Drawing.Point(6, 109);
            this.knowledgeLbl.Name = "knowledgeLbl";
            this.knowledgeLbl.Size = new System.Drawing.Size(77, 17);
            this.knowledgeLbl.TabIndex = 12;
            this.knowledgeLbl.Text = "Knowledge";
            // 
            // willLbl
            // 
            this.willLbl.AutoSize = true;
            this.willLbl.Location = new System.Drawing.Point(6, 83);
            this.willLbl.Name = "willLbl";
            this.willLbl.Size = new System.Drawing.Size(30, 17);
            this.willLbl.TabIndex = 11;
            this.willLbl.Text = "Will";
            // 
            // charismaLbl
            // 
            this.charismaLbl.AutoSize = true;
            this.charismaLbl.Location = new System.Drawing.Point(6, 57);
            this.charismaLbl.Name = "charismaLbl";
            this.charismaLbl.Size = new System.Drawing.Size(67, 17);
            this.charismaLbl.TabIndex = 10;
            this.charismaLbl.Text = "Charisma";
            // 
            // perceptionLbl
            // 
            this.perceptionLbl.AutoSize = true;
            this.perceptionLbl.Location = new System.Drawing.Point(6, 30);
            this.perceptionLbl.Name = "perceptionLbl";
            this.perceptionLbl.Size = new System.Drawing.Size(76, 17);
            this.perceptionLbl.TabIndex = 9;
            this.perceptionLbl.Text = "Perception";
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.submitBtn.Location = new System.Drawing.Point(399, 87);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 34);
            this.submitBtn.TabIndex = 12;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // bodyTxtBox
            // 
            this.bodyTxtBox.BackColor = System.Drawing.Color.SaddleBrown;
            this.bodyTxtBox.ForeColor = System.Drawing.Color.OldLace;
            this.bodyTxtBox.Location = new System.Drawing.Point(204, 141);
            this.bodyTxtBox.Name = "bodyTxtBox";
            this.bodyTxtBox.Size = new System.Drawing.Size(31, 22);
            this.bodyTxtBox.TabIndex = 14;
            this.bodyTxtBox.Text = "1";
            // 
            // mindTxtBox
            // 
            this.mindTxtBox.BackColor = System.Drawing.Color.Indigo;
            this.mindTxtBox.ForeColor = System.Drawing.Color.FloralWhite;
            this.mindTxtBox.Location = new System.Drawing.Point(424, 141);
            this.mindTxtBox.Name = "mindTxtBox";
            this.mindTxtBox.Size = new System.Drawing.Size(31, 22);
            this.mindTxtBox.TabIndex = 15;
            this.mindTxtBox.Text = "1";
            // 
            // bodyLbl
            // 
            this.bodyLbl.AutoSize = true;
            this.bodyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bodyLbl.Location = new System.Drawing.Point(60, 141);
            this.bodyLbl.Name = "bodyLbl";
            this.bodyLbl.Size = new System.Drawing.Size(51, 17);
            this.bodyLbl.TabIndex = 16;
            this.bodyLbl.Text = "BODY";
            // 
            // mindLbl
            // 
            this.mindLbl.AutoSize = true;
            this.mindLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mindLbl.ForeColor = System.Drawing.Color.Indigo;
            this.mindLbl.Location = new System.Drawing.Point(280, 141);
            this.mindLbl.Name = "mindLbl";
            this.mindLbl.Size = new System.Drawing.Size(46, 17);
            this.mindLbl.TabIndex = 17;
            this.mindLbl.Text = "MIND";
            // 
            // archCommentaryTxtBox
            // 
            this.archCommentaryTxtBox.Enabled = false;
            this.archCommentaryTxtBox.Location = new System.Drawing.Point(274, 322);
            this.archCommentaryTxtBox.Name = "archCommentaryTxtBox";
            this.archCommentaryTxtBox.Size = new System.Drawing.Size(200, 90);
            this.archCommentaryTxtBox.TabIndex = 18;
            this.archCommentaryTxtBox.Text = "";
            // 
            // speciesCommentaryTxtBox
            // 
            this.speciesCommentaryTxtBox.Enabled = false;
            this.speciesCommentaryTxtBox.Location = new System.Drawing.Point(54, 322);
            this.speciesCommentaryTxtBox.Name = "speciesCommentaryTxtBox";
            this.speciesCommentaryTxtBox.Size = new System.Drawing.Size(200, 90);
            this.speciesCommentaryTxtBox.TabIndex = 19;
            this.speciesCommentaryTxtBox.Text = "";
            // 
            // essenceLbl
            // 
            this.essenceLbl.AutoSize = true;
            this.essenceLbl.Location = new System.Drawing.Point(396, 30);
            this.essenceLbl.Name = "essenceLbl";
            this.essenceLbl.Size = new System.Drawing.Size(66, 17);
            this.essenceLbl.TabIndex = 20;
            this.essenceLbl.Text = "Essence:";
            // 
            // essenceAmount
            // 
            this.essenceAmount.AutoSize = true;
            this.essenceAmount.Location = new System.Drawing.Point(469, 30);
            this.essenceAmount.Name = "essenceAmount";
            this.essenceAmount.Size = new System.Drawing.Size(0, 17);
            this.essenceAmount.TabIndex = 21;
            // 
            // PjCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 427);
            this.Controls.Add(this.essenceAmount);
            this.Controls.Add(this.essenceLbl);
            this.Controls.Add(this.speciesCommentaryTxtBox);
            this.Controls.Add(this.archCommentaryTxtBox);
            this.Controls.Add(this.mindLbl);
            this.Controls.Add(this.bodyLbl);
            this.Controls.Add(this.mindTxtBox);
            this.Controls.Add(this.bodyTxtBox);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.mindAttributesBox);
            this.Controls.Add(this.bodyAttributesBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.archetypeLbl);
            this.Controls.Add(this.speciesLbl);
            this.Controls.Add(this.archetypeCombo);
            this.Controls.Add(this.speciesCombo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(543, 474);
            this.MinimumSize = new System.Drawing.Size(543, 474);
            this.Name = "PjCreationForm";
            this.Text = "Create your PJ";
            this.bodyAttributesBox.ResumeLayout(false);
            this.bodyAttributesBox.PerformLayout();
            this.mindAttributesBox.ResumeLayout(false);
            this.mindAttributesBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox speciesCombo;
        private System.Windows.Forms.ComboBox archetypeCombo;
        private System.Windows.Forms.Label speciesLbl;
        private System.Windows.Forms.Label archetypeLbl;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label agilityLbl;
        private System.Windows.Forms.GroupBox bodyAttributesBox;
        private System.Windows.Forms.TextBox constitutionTxtBox;
        private System.Windows.Forms.TextBox strengthTxtBox;
        private System.Windows.Forms.TextBox dexterityTxtBox;
        private System.Windows.Forms.TextBox agilityTxtBox;
        private System.Windows.Forms.Label constitutionLbl;
        private System.Windows.Forms.Label strengthLbl;
        private System.Windows.Forms.Label dexterityLbl;
        private System.Windows.Forms.GroupBox mindAttributesBox;
        private System.Windows.Forms.TextBox knowledgeTxtBox;
        private System.Windows.Forms.TextBox willTxtBox;
        private System.Windows.Forms.TextBox charismaTxtBox;
        private System.Windows.Forms.TextBox perceptionTxtBox;
        private System.Windows.Forms.Label knowledgeLbl;
        private System.Windows.Forms.Label willLbl;
        private System.Windows.Forms.Label charismaLbl;
        private System.Windows.Forms.Label perceptionLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox bodyTxtBox;
        private System.Windows.Forms.TextBox mindTxtBox;
        private System.Windows.Forms.Label bodyLbl;
        private System.Windows.Forms.Label mindLbl;
        private System.Windows.Forms.RichTextBox archCommentaryTxtBox;
        private System.Windows.Forms.RichTextBox speciesCommentaryTxtBox;
        private System.Windows.Forms.Label essenceLbl;
        private System.Windows.Forms.Label essenceAmount;
    }
}