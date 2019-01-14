namespace WindowsFormsApp11
{
    partial class Survey
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
            this.firstnamebox = new System.Windows.Forms.TextBox();
            this.fathernamebox = new System.Windows.Forms.TextBox();
            this.lastnamebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deserializebox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.citybox = new System.Windows.Forms.TextBox();
            this.phonebox = new System.Windows.Forms.TextBox();
            this.countrybox = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstnamebox
            // 
            this.firstnamebox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.firstnamebox.Location = new System.Drawing.Point(311, 88);
            this.firstnamebox.Name = "firstnamebox";
            this.firstnamebox.Size = new System.Drawing.Size(233, 20);
            this.firstnamebox.TabIndex = 0;
            this.firstnamebox.Text = "First name";
            this.firstnamebox.Enter += new System.EventHandler(this.citybox_Enter);
            this.firstnamebox.Leave += new System.EventHandler(this.citybox_Leave);
            // 
            // fathernamebox
            // 
            this.fathernamebox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.fathernamebox.Location = new System.Drawing.Point(311, 140);
            this.fathernamebox.Name = "fathernamebox";
            this.fathernamebox.Size = new System.Drawing.Size(233, 20);
            this.fathernamebox.TabIndex = 2;
            this.fathernamebox.Text = "Father name";
            this.fathernamebox.Enter += new System.EventHandler(this.citybox_Enter);
            this.fathernamebox.Leave += new System.EventHandler(this.citybox_Leave);
            // 
            // lastnamebox
            // 
            this.lastnamebox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lastnamebox.Location = new System.Drawing.Point(311, 114);
            this.lastnamebox.Name = "lastnamebox";
            this.lastnamebox.Size = new System.Drawing.Size(233, 20);
            this.lastnamebox.TabIndex = 3;
            this.lastnamebox.Text = "Last name";
            this.lastnamebox.Enter += new System.EventHandler(this.citybox_Enter);
            this.lastnamebox.Leave += new System.EventHandler(this.citybox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(239, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Father name";
            // 
            // deserializebox
            // 
            this.deserializebox.Location = new System.Drawing.Point(286, 21);
            this.deserializebox.Name = "deserializebox";
            this.deserializebox.Size = new System.Drawing.Size(291, 20);
            this.deserializebox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Country";
            // 
            // citybox
            // 
            this.citybox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.citybox.Location = new System.Drawing.Point(311, 216);
            this.citybox.Name = "citybox";
            this.citybox.Size = new System.Drawing.Size(233, 20);
            this.citybox.TabIndex = 11;
            this.citybox.Text = "City";
            this.citybox.Enter += new System.EventHandler(this.citybox_Enter);
            this.citybox.Leave += new System.EventHandler(this.citybox_Leave);
            // 
            // phonebox
            // 
            this.phonebox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.phonebox.Location = new System.Drawing.Point(311, 242);
            this.phonebox.Name = "phonebox";
            this.phonebox.Size = new System.Drawing.Size(233, 20);
            this.phonebox.TabIndex = 10;
            this.phonebox.Text = "Phone";
            this.phonebox.Enter += new System.EventHandler(this.citybox_Enter);
            this.phonebox.Leave += new System.EventHandler(this.citybox_Leave);
            // 
            // countrybox
            // 
            this.countrybox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.countrybox.Location = new System.Drawing.Point(311, 190);
            this.countrybox.Name = "countrybox";
            this.countrybox.Size = new System.Drawing.Size(233, 20);
            this.countrybox.TabIndex = 9;
            this.countrybox.Text = "Country";
            this.countrybox.Enter += new System.EventHandler(this.citybox_Enter);
            this.countrybox.Leave += new System.EventHandler(this.citybox_Leave);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(611, 19);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(85, 23);
            this.btnok.TabIndex = 15;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Deserialize";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Date of birth";
            // 
            // dateofbirth
            // 
            this.dateofbirth.Location = new System.Drawing.Point(344, 301);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(200, 20);
            this.dateofbirth.TabIndex = 18;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(344, 359);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 19;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(422, 359);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 20;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Gender";
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.Location = new System.Drawing.Point(193, 415);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(417, 23);
            this.btnshowinfo.TabIndex = 22;
            this.btnshowinfo.Text = "Show result";
            this.btnshowinfo.UseVisualStyleBackColor = true;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // Survey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.citybox);
            this.Controls.Add(this.phonebox);
            this.Controls.Add(this.countrybox);
            this.Controls.Add(this.deserializebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastnamebox);
            this.Controls.Add(this.fathernamebox);
            this.Controls.Add(this.firstnamebox);
            this.Name = "Survey";
            this.Text = "Survey";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstnamebox;
        private System.Windows.Forms.TextBox fathernamebox;
        private System.Windows.Forms.TextBox lastnamebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deserializebox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox citybox;
        private System.Windows.Forms.TextBox phonebox;
        private System.Windows.Forms.TextBox countrybox;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateofbirth;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnshowinfo;
    }
}

