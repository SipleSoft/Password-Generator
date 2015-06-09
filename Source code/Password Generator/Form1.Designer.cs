namespace Password_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GeneratedPassword = new System.Windows.Forms.TextBox();
            this.Numbers = new System.Windows.Forms.CheckBox();
            this.SmallCapLetters = new System.Windows.Forms.CheckBox();
            this.BigCapLetters = new System.Windows.Forms.CheckBox();
            this.AllSpecialChars = new System.Windows.Forms.CheckBox();
            this.BasicSpecialChars = new System.Windows.Forms.CheckBox();
            this.specialChar17 = new System.Windows.Forms.CheckBox();
            this.specialChar8 = new System.Windows.Forms.CheckBox();
            this.trimmedSmallCaps = new System.Windows.Forms.CheckBox();
            this.trimmedBigCaps = new System.Windows.Forms.CheckBox();
            this.generate = new System.Windows.Forms.Button();
            this.labelPassLength = new System.Windows.Forms.Label();
            this.passwordLength = new System.Windows.Forms.TextBox();
            this.Copy = new System.Windows.Forms.Button();
            this.DataType = new System.Windows.Forms.GroupBox();
            this.DataType.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneratedPassword
            // 
            this.GeneratedPassword.BackColor = System.Drawing.Color.Black;
            this.GeneratedPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GeneratedPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GeneratedPassword.ForeColor = System.Drawing.Color.Red;
            this.GeneratedPassword.Location = new System.Drawing.Point(191, 12);
            this.GeneratedPassword.Name = "GeneratedPassword";
            this.GeneratedPassword.ReadOnly = true;
            this.GeneratedPassword.Size = new System.Drawing.Size(362, 23);
            this.GeneratedPassword.TabIndex = 100;
            this.GeneratedPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Numbers
            // 
            this.Numbers.AutoSize = true;
            this.Numbers.Checked = true;
            this.Numbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Numbers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Numbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(121)))));
            this.Numbers.Location = new System.Drawing.Point(17, 28);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(95, 17);
            this.Numbers.TabIndex = 1;
            this.Numbers.Text = "Numbers [0-9]";
            this.Numbers.UseVisualStyleBackColor = true;
            // 
            // SmallCapLetters
            // 
            this.SmallCapLetters.AutoSize = true;
            this.SmallCapLetters.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SmallCapLetters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(121)))));
            this.SmallCapLetters.Location = new System.Drawing.Point(17, 51);
            this.SmallCapLetters.Name = "SmallCapLetters";
            this.SmallCapLetters.Size = new System.Drawing.Size(130, 17);
            this.SmallCapLetters.TabIndex = 2;
            this.SmallCapLetters.Text = "Small cap letters [a-z]";
            this.SmallCapLetters.UseVisualStyleBackColor = true;
            // 
            // BigCapLetters
            // 
            this.BigCapLetters.AutoSize = true;
            this.BigCapLetters.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BigCapLetters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(121)))));
            this.BigCapLetters.Location = new System.Drawing.Point(17, 74);
            this.BigCapLetters.Name = "BigCapLetters";
            this.BigCapLetters.Size = new System.Drawing.Size(122, 17);
            this.BigCapLetters.TabIndex = 3;
            this.BigCapLetters.Text = "Big cap letters [A-Z]";
            this.BigCapLetters.UseVisualStyleBackColor = true;
            // 
            // AllSpecialChars
            // 
            this.AllSpecialChars.AutoSize = true;
            this.AllSpecialChars.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AllSpecialChars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(121)))));
            this.AllSpecialChars.Location = new System.Drawing.Point(153, 28);
            this.AllSpecialChars.Name = "AllSpecialChars";
            this.AllSpecialChars.Size = new System.Drawing.Size(138, 17);
            this.AllSpecialChars.TabIndex = 4;
            this.AllSpecialChars.Text = "All special chars [#...$]";
            this.AllSpecialChars.UseVisualStyleBackColor = true;
            // 
            // BasicSpecialChars
            // 
            this.BasicSpecialChars.AutoSize = true;
            this.BasicSpecialChars.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BasicSpecialChars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(121)))));
            this.BasicSpecialChars.Location = new System.Drawing.Point(153, 51);
            this.BasicSpecialChars.Name = "BasicSpecialChars";
            this.BasicSpecialChars.Size = new System.Drawing.Size(146, 17);
            this.BasicSpecialChars.TabIndex = 5;
            this.BasicSpecialChars.Text = "Basic special chars [!...?]";
            this.BasicSpecialChars.UseVisualStyleBackColor = true;
            // 
            // specialChar17
            // 
            this.specialChar17.AutoSize = true;
            this.specialChar17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.specialChar17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(121)))));
            this.specialChar17.Location = new System.Drawing.Point(153, 74);
            this.specialChar17.Name = "specialChar17";
            this.specialChar17.Size = new System.Drawing.Size(127, 17);
            this.specialChar17.TabIndex = 6;
            this.specialChar17.Text = "17 special characters";
            this.specialChar17.UseVisualStyleBackColor = true;
            // 
            // specialChar8
            // 
            this.specialChar8.AutoSize = true;
            this.specialChar8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.specialChar8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(121)))));
            this.specialChar8.Location = new System.Drawing.Point(305, 28);
            this.specialChar8.Name = "specialChar8";
            this.specialChar8.Size = new System.Drawing.Size(121, 17);
            this.specialChar8.TabIndex = 7;
            this.specialChar8.Text = "8 special characters";
            this.specialChar8.UseVisualStyleBackColor = true;
            // 
            // trimmedSmallCaps
            // 
            this.trimmedSmallCaps.AutoSize = true;
            this.trimmedSmallCaps.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trimmedSmallCaps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(121)))));
            this.trimmedSmallCaps.Location = new System.Drawing.Point(305, 51);
            this.trimmedSmallCaps.Name = "trimmedSmallCaps";
            this.trimmedSmallCaps.Size = new System.Drawing.Size(92, 17);
            this.trimmedSmallCaps.TabIndex = 8;
            this.trimmedSmallCaps.Text = "Trimmed [a-z]";
            this.trimmedSmallCaps.UseVisualStyleBackColor = true;
            // 
            // trimmedBigCaps
            // 
            this.trimmedBigCaps.AutoSize = true;
            this.trimmedBigCaps.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trimmedBigCaps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(121)))));
            this.trimmedBigCaps.Location = new System.Drawing.Point(305, 74);
            this.trimmedBigCaps.Name = "trimmedBigCaps";
            this.trimmedBigCaps.Size = new System.Drawing.Size(94, 17);
            this.trimmedBigCaps.TabIndex = 9;
            this.trimmedBigCaps.Text = "Trimmed [A-Z]";
            this.trimmedBigCaps.UseVisualStyleBackColor = true;
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate.ForeColor = System.Drawing.Color.Green;
            this.generate.Location = new System.Drawing.Point(110, 41);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 10;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // labelPassLength
            // 
            this.labelPassLength.AutoSize = true;
            this.labelPassLength.BackColor = System.Drawing.Color.Transparent;
            this.labelPassLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(130)))), ((int)(((byte)(121)))));
            this.labelPassLength.Location = new System.Drawing.Point(12, 22);
            this.labelPassLength.Name = "labelPassLength";
            this.labelPassLength.Size = new System.Drawing.Size(92, 13);
            this.labelPassLength.TabIndex = 11;
            this.labelPassLength.Text = "Password Length:";
            // 
            // passwordLength
            // 
            this.passwordLength.BackColor = System.Drawing.Color.Black;
            this.passwordLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordLength.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLength.ForeColor = System.Drawing.Color.Red;
            this.passwordLength.Location = new System.Drawing.Point(110, 12);
            this.passwordLength.MaxLength = 3;
            this.passwordLength.Name = "passwordLength";
            this.passwordLength.Size = new System.Drawing.Size(75, 23);
            this.passwordLength.TabIndex = 0;
            this.passwordLength.Text = "1";
            this.passwordLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordLength_KeyDown);
            this.passwordLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordLength_KeyPress);
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy.ForeColor = System.Drawing.Color.Green;
            this.Copy.Location = new System.Drawing.Point(191, 41);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(128, 23);
            this.Copy.TabIndex = 13;
            this.Copy.Text = "Copy to Clipboard";
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // DataType
            // 
            this.DataType.BackColor = System.Drawing.Color.Transparent;
            this.DataType.Controls.Add(this.specialChar8);
            this.DataType.Controls.Add(this.Numbers);
            this.DataType.Controls.Add(this.SmallCapLetters);
            this.DataType.Controls.Add(this.BigCapLetters);
            this.DataType.Controls.Add(this.AllSpecialChars);
            this.DataType.Controls.Add(this.BasicSpecialChars);
            this.DataType.Controls.Add(this.specialChar17);
            this.DataType.Controls.Add(this.trimmedSmallCaps);
            this.DataType.Controls.Add(this.trimmedBigCaps);
            this.DataType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DataType.ForeColor = System.Drawing.Color.DarkGreen;
            this.DataType.Location = new System.Drawing.Point(12, 70);
            this.DataType.Name = "DataType";
            this.DataType.Size = new System.Drawing.Size(541, 115);
            this.DataType.TabIndex = 17;
            this.DataType.TabStop = false;
            this.DataType.Text = "Data Taype";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(570, 203);
            this.Controls.Add(this.DataType);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.passwordLength);
            this.Controls.Add(this.labelPassLength);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.GeneratedPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.DataType.ResumeLayout(false);
            this.DataType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GeneratedPassword;
        private System.Windows.Forms.CheckBox Numbers;
        private System.Windows.Forms.CheckBox SmallCapLetters;
        private System.Windows.Forms.CheckBox BigCapLetters;
        private System.Windows.Forms.CheckBox AllSpecialChars;
        private System.Windows.Forms.CheckBox BasicSpecialChars;
        private System.Windows.Forms.CheckBox specialChar17;
        private System.Windows.Forms.CheckBox specialChar8;
        private System.Windows.Forms.CheckBox trimmedSmallCaps;
        private System.Windows.Forms.CheckBox trimmedBigCaps;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label labelPassLength;
        private new System.Windows.Forms.TextBox passwordLength;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.GroupBox DataType;
    }
}

