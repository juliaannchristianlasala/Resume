namespace PDF_RESUME
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ctostringbtn = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.bdaylabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.pnumlabel = new System.Windows.Forms.Label();
            this.haddresslabel = new System.Windows.Forms.Label();
            this.jhschoollabel = new System.Windows.Forms.Label();
            this.hssyearlabel = new System.Windows.Forms.Label();
            this.csyearlabel = new System.Windows.Forms.Label();
            this.collegelabel = new System.Windows.Forms.Label();
            this.shschoollabel = new System.Windows.Forms.Label();
            this.shssyearlabel = new System.Windows.Forms.Label();
            this.pdfcreatorlabel = new System.Windows.Forms.Label();
            this.bgpicbox1 = new System.Windows.Forms.PictureBox();
            this.bgpicbox2 = new System.Windows.Forms.PictureBox();
            this.bgpicbox3 = new System.Windows.Forms.PictureBox();
            this.sandqlabel = new System.Windows.Forms.Label();
            this.skill1label = new System.Windows.Forms.Label();
            this.skill2label = new System.Windows.Forms.Label();
            this.skill3label = new System.Windows.Forms.Label();
            this.skill4label = new System.Windows.Forms.Label();
            this.bgpicbox4 = new System.Windows.Forms.PictureBox();
            this.awardslabel = new System.Windows.Forms.Label();
            this.award1label = new System.Windows.Forms.Label();
            this.award2label = new System.Windows.Forms.Label();
            this.award3label = new System.Windows.Forms.Label();
            this.award4label = new System.Windows.Forms.Label();
            this.pdfconverterbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bgpicbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgpicbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgpicbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgpicbox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ctostringbtn
            // 
            this.ctostringbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.ctostringbtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ctostringbtn.Location = new System.Drawing.Point(733, 15);
            this.ctostringbtn.Name = "ctostringbtn";
            this.ctostringbtn.Size = new System.Drawing.Size(195, 47);
            this.ctostringbtn.TabIndex = 0;
            this.ctostringbtn.Text = "Show Information";
            this.ctostringbtn.UseVisualStyleBackColor = false;
            this.ctostringbtn.Click += new System.EventHandler(this.ctostringbtn_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.BackColor = System.Drawing.Color.White;
            this.namelabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namelabel.Location = new System.Drawing.Point(23, 74);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(59, 20);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "Name:";
            // 
            // bdaylabel
            // 
            this.bdaylabel.AutoSize = true;
            this.bdaylabel.BackColor = System.Drawing.Color.White;
            this.bdaylabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bdaylabel.Location = new System.Drawing.Point(23, 102);
            this.bdaylabel.Name = "bdaylabel";
            this.bdaylabel.Size = new System.Drawing.Size(80, 20);
            this.bdaylabel.TabIndex = 2;
            this.bdaylabel.Text = "Birthday:";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.BackColor = System.Drawing.Color.White;
            this.emaillabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emaillabel.Location = new System.Drawing.Point(23, 131);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(59, 20);
            this.emaillabel.TabIndex = 3;
            this.emaillabel.Text = "Email:";
            // 
            // pnumlabel
            // 
            this.pnumlabel.AutoSize = true;
            this.pnumlabel.BackColor = System.Drawing.Color.White;
            this.pnumlabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnumlabel.Location = new System.Drawing.Point(23, 160);
            this.pnumlabel.Name = "pnumlabel";
            this.pnumlabel.Size = new System.Drawing.Size(128, 20);
            this.pnumlabel.TabIndex = 4;
            this.pnumlabel.Text = "Phone Number:";
            // 
            // haddresslabel
            // 
            this.haddresslabel.AutoSize = true;
            this.haddresslabel.BackColor = System.Drawing.Color.White;
            this.haddresslabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.haddresslabel.Location = new System.Drawing.Point(23, 187);
            this.haddresslabel.Name = "haddresslabel";
            this.haddresslabel.Size = new System.Drawing.Size(124, 20);
            this.haddresslabel.TabIndex = 5;
            this.haddresslabel.Text = "Home Address:";
            // 
            // jhschoollabel
            // 
            this.jhschoollabel.AutoSize = true;
            this.jhschoollabel.BackColor = System.Drawing.Color.Gainsboro;
            this.jhschoollabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jhschoollabel.Location = new System.Drawing.Point(23, 228);
            this.jhschoollabel.Name = "jhschoollabel";
            this.jhschoollabel.Size = new System.Drawing.Size(161, 20);
            this.jhschoollabel.TabIndex = 6;
            this.jhschoollabel.Text = "Junior High School:";
            // 
            // hssyearlabel
            // 
            this.hssyearlabel.AutoSize = true;
            this.hssyearlabel.BackColor = System.Drawing.Color.Gainsboro;
            this.hssyearlabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hssyearlabel.Location = new System.Drawing.Point(23, 256);
            this.hssyearlabel.Name = "hssyearlabel";
            this.hssyearlabel.Size = new System.Drawing.Size(103, 20);
            this.hssyearlabel.TabIndex = 7;
            this.hssyearlabel.Text = "School Year:";
            // 
            // csyearlabel
            // 
            this.csyearlabel.AutoSize = true;
            this.csyearlabel.BackColor = System.Drawing.Color.Gainsboro;
            this.csyearlabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.csyearlabel.Location = new System.Drawing.Point(23, 368);
            this.csyearlabel.Name = "csyearlabel";
            this.csyearlabel.Size = new System.Drawing.Size(103, 20);
            this.csyearlabel.TabIndex = 8;
            this.csyearlabel.Text = "School Year:";
            // 
            // collegelabel
            // 
            this.collegelabel.AutoSize = true;
            this.collegelabel.BackColor = System.Drawing.Color.Gainsboro;
            this.collegelabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.collegelabel.Location = new System.Drawing.Point(23, 341);
            this.collegelabel.Name = "collegelabel";
            this.collegelabel.Size = new System.Drawing.Size(69, 20);
            this.collegelabel.TabIndex = 9;
            this.collegelabel.Text = "College:";
            // 
            // shschoollabel
            // 
            this.shschoollabel.AutoSize = true;
            this.shschoollabel.BackColor = System.Drawing.Color.Gainsboro;
            this.shschoollabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shschoollabel.Location = new System.Drawing.Point(23, 284);
            this.shschoollabel.Name = "shschoollabel";
            this.shschoollabel.Size = new System.Drawing.Size(160, 20);
            this.shschoollabel.TabIndex = 10;
            this.shschoollabel.Text = "Senior High School:";
            // 
            // shssyearlabel
            // 
            this.shssyearlabel.AutoSize = true;
            this.shssyearlabel.BackColor = System.Drawing.Color.Gainsboro;
            this.shssyearlabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shssyearlabel.Location = new System.Drawing.Point(23, 313);
            this.shssyearlabel.Name = "shssyearlabel";
            this.shssyearlabel.Size = new System.Drawing.Size(103, 20);
            this.shssyearlabel.TabIndex = 11;
            this.shssyearlabel.Text = "School Year:";
            this.shssyearlabel.Click += new System.EventHandler(this.shssyearlabel_Click);
            // 
            // pdfcreatorlabel
            // 
            this.pdfcreatorlabel.AutoSize = true;
            this.pdfcreatorlabel.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pdfcreatorlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pdfcreatorlabel.Location = new System.Drawing.Point(8, 13);
            this.pdfcreatorlabel.Name = "pdfcreatorlabel";
            this.pdfcreatorlabel.Size = new System.Drawing.Size(413, 46);
            this.pdfcreatorlabel.TabIndex = 12;
            this.pdfcreatorlabel.Text = "PDF Resume Creator";
            // 
            // bgpicbox1
            // 
            this.bgpicbox1.BackColor = System.Drawing.Color.White;
            this.bgpicbox1.Location = new System.Drawing.Point(14, 68);
            this.bgpicbox1.Name = "bgpicbox1";
            this.bgpicbox1.Size = new System.Drawing.Size(914, 147);
            this.bgpicbox1.TabIndex = 13;
            this.bgpicbox1.TabStop = false;
            // 
            // bgpicbox2
            // 
            this.bgpicbox2.BackColor = System.Drawing.Color.Gainsboro;
            this.bgpicbox2.Location = new System.Drawing.Point(14, 220);
            this.bgpicbox2.Name = "bgpicbox2";
            this.bgpicbox2.Size = new System.Drawing.Size(914, 174);
            this.bgpicbox2.TabIndex = 14;
            this.bgpicbox2.TabStop = false;
            // 
            // bgpicbox3
            // 
            this.bgpicbox3.BackColor = System.Drawing.Color.White;
            this.bgpicbox3.Location = new System.Drawing.Point(14, 400);
            this.bgpicbox3.Name = "bgpicbox3";
            this.bgpicbox3.Size = new System.Drawing.Size(914, 145);
            this.bgpicbox3.TabIndex = 15;
            this.bgpicbox3.TabStop = false;
            // 
            // sandqlabel
            // 
            this.sandqlabel.AutoSize = true;
            this.sandqlabel.BackColor = System.Drawing.Color.White;
            this.sandqlabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sandqlabel.Location = new System.Drawing.Point(23, 409);
            this.sandqlabel.Name = "sandqlabel";
            this.sandqlabel.Size = new System.Drawing.Size(204, 20);
            this.sandqlabel.TabIndex = 16;
            this.sandqlabel.Text = "Skillls and Qualifications:";
            // 
            // skill1label
            // 
            this.skill1label.AutoSize = true;
            this.skill1label.BackColor = System.Drawing.Color.White;
            this.skill1label.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skill1label.Location = new System.Drawing.Point(23, 434);
            this.skill1label.Name = "skill1label";
            this.skill1label.Size = new System.Drawing.Size(0, 20);
            this.skill1label.TabIndex = 17;
            // 
            // skill2label
            // 
            this.skill2label.AutoSize = true;
            this.skill2label.BackColor = System.Drawing.Color.White;
            this.skill2label.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skill2label.Location = new System.Drawing.Point(23, 460);
            this.skill2label.Name = "skill2label";
            this.skill2label.Size = new System.Drawing.Size(0, 20);
            this.skill2label.TabIndex = 18;
            // 
            // skill3label
            // 
            this.skill3label.AutoSize = true;
            this.skill3label.BackColor = System.Drawing.Color.White;
            this.skill3label.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skill3label.Location = new System.Drawing.Point(23, 487);
            this.skill3label.Name = "skill3label";
            this.skill3label.Size = new System.Drawing.Size(0, 20);
            this.skill3label.TabIndex = 19;
            // 
            // skill4label
            // 
            this.skill4label.AutoSize = true;
            this.skill4label.BackColor = System.Drawing.Color.White;
            this.skill4label.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skill4label.Location = new System.Drawing.Point(23, 514);
            this.skill4label.Name = "skill4label";
            this.skill4label.Size = new System.Drawing.Size(0, 20);
            this.skill4label.TabIndex = 20;
            // 
            // bgpicbox4
            // 
            this.bgpicbox4.BackColor = System.Drawing.Color.Gainsboro;
            this.bgpicbox4.Location = new System.Drawing.Point(14, 551);
            this.bgpicbox4.Name = "bgpicbox4";
            this.bgpicbox4.Size = new System.Drawing.Size(914, 147);
            this.bgpicbox4.TabIndex = 21;
            this.bgpicbox4.TabStop = false;
            // 
            // awardslabel
            // 
            this.awardslabel.AutoSize = true;
            this.awardslabel.BackColor = System.Drawing.Color.Gainsboro;
            this.awardslabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.awardslabel.Location = new System.Drawing.Point(23, 560);
            this.awardslabel.Name = "awardslabel";
            this.awardslabel.Size = new System.Drawing.Size(241, 20);
            this.awardslabel.TabIndex = 22;
            this.awardslabel.Text = "Certificates and Achievements:";
            // 
            // award1label
            // 
            this.award1label.AutoSize = true;
            this.award1label.BackColor = System.Drawing.Color.Gainsboro;
            this.award1label.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.award1label.Location = new System.Drawing.Point(23, 586);
            this.award1label.Name = "award1label";
            this.award1label.Size = new System.Drawing.Size(0, 20);
            this.award1label.TabIndex = 23;
            // 
            // award2label
            // 
            this.award2label.AutoSize = true;
            this.award2label.BackColor = System.Drawing.Color.Gainsboro;
            this.award2label.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.award2label.Location = new System.Drawing.Point(23, 613);
            this.award2label.Name = "award2label";
            this.award2label.Size = new System.Drawing.Size(0, 20);
            this.award2label.TabIndex = 24;
            // 
            // award3label
            // 
            this.award3label.AutoSize = true;
            this.award3label.BackColor = System.Drawing.Color.Gainsboro;
            this.award3label.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.award3label.Location = new System.Drawing.Point(23, 641);
            this.award3label.Name = "award3label";
            this.award3label.Size = new System.Drawing.Size(0, 20);
            this.award3label.TabIndex = 25;
            // 
            // award4label
            // 
            this.award4label.AutoSize = true;
            this.award4label.BackColor = System.Drawing.Color.Gainsboro;
            this.award4label.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.award4label.Location = new System.Drawing.Point(23, 668);
            this.award4label.Name = "award4label";
            this.award4label.Size = new System.Drawing.Size(0, 20);
            this.award4label.TabIndex = 26;
            // 
            // pdfconverterbutton
            // 
            this.pdfconverterbutton.BackColor = System.Drawing.Color.White;
            this.pdfconverterbutton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pdfconverterbutton.Location = new System.Drawing.Point(371, 745);
            this.pdfconverterbutton.Name = "pdfconverterbutton";
            this.pdfconverterbutton.Size = new System.Drawing.Size(211, 46);
            this.pdfconverterbutton.TabIndex = 27;
            this.pdfconverterbutton.Text = "Convert to PDF";
            this.pdfconverterbutton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 713);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "This information from JSON file will be converted in to PDF file.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 801);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pdfconverterbutton);
            this.Controls.Add(this.award4label);
            this.Controls.Add(this.award3label);
            this.Controls.Add(this.award2label);
            this.Controls.Add(this.award1label);
            this.Controls.Add(this.awardslabel);
            this.Controls.Add(this.bgpicbox4);
            this.Controls.Add(this.skill4label);
            this.Controls.Add(this.skill3label);
            this.Controls.Add(this.skill2label);
            this.Controls.Add(this.skill1label);
            this.Controls.Add(this.sandqlabel);
            this.Controls.Add(this.bgpicbox3);
            this.Controls.Add(this.pdfcreatorlabel);
            this.Controls.Add(this.shssyearlabel);
            this.Controls.Add(this.shschoollabel);
            this.Controls.Add(this.collegelabel);
            this.Controls.Add(this.csyearlabel);
            this.Controls.Add(this.hssyearlabel);
            this.Controls.Add(this.jhschoollabel);
            this.Controls.Add(this.haddresslabel);
            this.Controls.Add(this.pnumlabel);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.bdaylabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.ctostringbtn);
            this.Controls.Add(this.bgpicbox1);
            this.Controls.Add(this.bgpicbox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF RESUME CREATOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bgpicbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgpicbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgpicbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgpicbox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ctostringbtn;
        private Label namelabel;
        private Label bdaylabel;
        private Label emaillabel;
        private Label pnumlabel;
        private Label haddresslabel;
        private Label jhschoollabel;
        private Label hssyearlabel;
        private Label csyearlabel;
        private Label collegelabel;
        private Label shschoollabel;
        private Label shssyearlabel;
        private Label pdfcreatorlabel;
        private PictureBox bgpicbox1;
        private PictureBox bgpicbox2;
        private PictureBox bgpicbox3;
        private Label sandqlabel;
        private Label skill1label;
        private Label skill2label;
        private Label skill3label;
        private Label skill4label;
        private PictureBox bgpicbox4;
        private Label awardslabel;
        private Label award1label;
        private Label award2label;
        private Label award3label;
        private Label award4label;
        private Button pdfconverterbutton;
        private Label label1;
    }
}