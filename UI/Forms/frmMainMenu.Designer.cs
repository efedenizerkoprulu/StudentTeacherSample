namespace UI.Forms
{
    partial class frmMainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnLesson = new System.Windows.Forms.Button();
            this.btneacher = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(391, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(347, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "This is a SampLe Project";
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Location = new System.Drawing.Point(347, 115);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(231, 56);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Go Student Form";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnLesson
            // 
            this.btnLesson.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLesson.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLesson.ForeColor = System.Drawing.Color.White;
            this.btnLesson.Location = new System.Drawing.Point(347, 177);
            this.btnLesson.Name = "btnLesson";
            this.btnLesson.Size = new System.Drawing.Size(231, 56);
            this.btnLesson.TabIndex = 3;
            this.btnLesson.Text = "Go Lesson Form";
            this.btnLesson.UseVisualStyleBackColor = false;
            this.btnLesson.Click += new System.EventHandler(this.btnLesson_Click);
            // 
            // btneacher
            // 
            this.btneacher.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btneacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneacher.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btneacher.ForeColor = System.Drawing.Color.White;
            this.btneacher.Location = new System.Drawing.Point(347, 239);
            this.btneacher.Name = "btneacher";
            this.btneacher.Size = new System.Drawing.Size(231, 56);
            this.btneacher.TabIndex = 4;
            this.btneacher.Text = "Go Teacher Form";
            this.btneacher.UseVisualStyleBackColor = false;
            this.btneacher.Click += new System.EventHandler(this.btneacher_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(890, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(29, 34);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(368, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gizlilik Politikamız ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(943, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btneacher);
            this.Controls.Add(this.btnLesson);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnStudent;
        private Button btnLesson;
        private Button btneacher;
        private Label lblClose;
        private Label label3;
    }
}