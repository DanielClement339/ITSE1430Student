namespace CharacterCreator.WinForms
{
    partial class CharacterForm
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
            this._lbName = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._cbProfession = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._cbRace = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._nudStrength = new System.Windows.Forms.NumericUpDown();
            this._nudIntelligence = new System.Windows.Forms.NumericUpDown();
            this._nudConstitution = new System.Windows.Forms.NumericUpDown();
            this._nudAgility = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._nudCharisma = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._nudStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudConstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudCharisma)).BeginInit();
            this.SuspendLayout();
            // 
            // _lbName
            // 
            this._lbName.AutoSize = true;
            this._lbName.Location = new System.Drawing.Point(13, 13);
            this._lbName.Name = "_lbName";
            this._lbName.Size = new System.Drawing.Size(35, 13);
            this._lbName.TabIndex = 0;
            this._lbName.Text = "Name";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(77, 12);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(121, 20);
            this._txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Profession";
            // 
            // _cbProfession
            // 
            this._cbProfession.FormattingEnabled = true;
            this._cbProfession.Location = new System.Drawing.Point(77, 38);
            this._cbProfession.Name = "_cbProfession";
            this._cbProfession.Size = new System.Drawing.Size(121, 21);
            this._cbProfession.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Race";
            // 
            // _cbRace
            // 
            this._cbRace.FormattingEnabled = true;
            this._cbRace.Location = new System.Drawing.Point(77, 68);
            this._cbRace.Name = "_cbRace";
            this._cbRace.Size = new System.Drawing.Size(121, 21);
            this._cbRace.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Strength";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Intelligence";
            // 
            // _nudStrength
            // 
            this._nudStrength.Location = new System.Drawing.Point(77, 132);
            this._nudStrength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudStrength.Name = "_nudStrength";
            this._nudStrength.Size = new System.Drawing.Size(50, 20);
            this._nudStrength.TabIndex = 8;
            this._nudStrength.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _nudIntelligence
            // 
            this._nudIntelligence.Location = new System.Drawing.Point(77, 160);
            this._nudIntelligence.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudIntelligence.Name = "_nudIntelligence";
            this._nudIntelligence.Size = new System.Drawing.Size(50, 20);
            this._nudIntelligence.TabIndex = 9;
            this._nudIntelligence.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _nudConstitution
            // 
            this._nudConstitution.Location = new System.Drawing.Point(231, 160);
            this._nudConstitution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudConstitution.Name = "_nudConstitution";
            this._nudConstitution.Size = new System.Drawing.Size(50, 20);
            this._nudConstitution.TabIndex = 13;
            this._nudConstitution.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _nudAgility
            // 
            this._nudAgility.Location = new System.Drawing.Point(231, 132);
            this._nudAgility.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudAgility.Name = "_nudAgility";
            this._nudAgility.Size = new System.Drawing.Size(50, 20);
            this._nudAgility.TabIndex = 12;
            this._nudAgility.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Constitution";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Agility";
            // 
            // _nudCharisma
            // 
            this._nudCharisma.Location = new System.Drawing.Point(387, 132);
            this._nudCharisma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudCharisma.Name = "_nudCharisma";
            this._nudCharisma.Size = new System.Drawing.Size(50, 20);
            this._nudCharisma.TabIndex = 16;
            this._nudCharisma.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Charisma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Character Attributes ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Description";
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(97, 209);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(340, 229);
            this._txtDescription.TabIndex = 19;
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(281, 456);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 20;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(362, 456);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 21;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 491);
            this.ControlBox = false;
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._nudCharisma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._nudConstitution);
            this.Controls.Add(this._nudAgility);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._nudIntelligence);
            this.Controls.Add(this._nudStrength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cbRace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cbProfession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._lbName);
            this.Name = "CharacterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.CharacterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._nudStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudConstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudCharisma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lbName;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbProfession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _cbRace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown _nudStrength;
        private System.Windows.Forms.NumericUpDown _nudIntelligence;
        private System.Windows.Forms.NumericUpDown _nudConstitution;
        private System.Windows.Forms.NumericUpDown _nudAgility;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown _nudCharisma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
    }
}