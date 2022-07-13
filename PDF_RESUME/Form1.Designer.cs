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
            this.ctostringbtn = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctostringbtn
            // 
            this.ctostringbtn.Location = new System.Drawing.Point(23, 494);
            this.ctostringbtn.Name = "ctostringbtn";
            this.ctostringbtn.Size = new System.Drawing.Size(124, 47);
            this.ctostringbtn.TabIndex = 0;
            this.ctostringbtn.Text = "convert";
            this.ctostringbtn.UseVisualStyleBackColor = true;
            this.ctostringbtn.Click += new System.EventHandler(this.ctostringbtn_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(23, 87);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(52, 20);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 566);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.ctostringbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ctostringbtn;
        private Label namelabel;
    }
}