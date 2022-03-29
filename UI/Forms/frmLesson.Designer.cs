namespace UI.Forms
{
    partial class frmLasson
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClearArea = new System.Windows.Forms.Button();
            this.btnDeleteLesson = new System.Windows.Forms.Button();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.btnUpdateLesson = new System.Windows.Forms.Button();
            this.txtILessonID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLessonName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbTeacherName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(737, 427);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 427);
            this.panel3.TabIndex = 6;
            // 
            // btnClearArea
            // 
            this.btnClearArea.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClearArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearArea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearArea.ForeColor = System.Drawing.Color.White;
            this.btnClearArea.Location = new System.Drawing.Point(282, 223);
            this.btnClearArea.Name = "btnClearArea";
            this.btnClearArea.Size = new System.Drawing.Size(174, 41);
            this.btnClearArea.TabIndex = 15;
            this.btnClearArea.Text = "Alanları Temizle";
            this.btnClearArea.UseVisualStyleBackColor = false;
            this.btnClearArea.Click += new System.EventHandler(this.btnClearArea_Click);
            // 
            // btnDeleteLesson
            // 
            this.btnDeleteLesson.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDeleteLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLesson.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteLesson.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLesson.Location = new System.Drawing.Point(90, 223);
            this.btnDeleteLesson.Name = "btnDeleteLesson";
            this.btnDeleteLesson.Size = new System.Drawing.Size(174, 41);
            this.btnDeleteLesson.TabIndex = 14;
            this.btnDeleteLesson.Text = "Ders Sil";
            this.btnDeleteLesson.UseVisualStyleBackColor = false;
            this.btnDeleteLesson.Click += new System.EventHandler(this.btnDeleteLesson_Click);
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAddLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLesson.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddLesson.ForeColor = System.Drawing.Color.White;
            this.btnAddLesson.Location = new System.Drawing.Point(90, 176);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(174, 41);
            this.btnAddLesson.TabIndex = 13;
            this.btnAddLesson.Text = "Ders Ekle";
            this.btnAddLesson.UseVisualStyleBackColor = false;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // btnUpdateLesson
            // 
            this.btnUpdateLesson.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUpdateLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateLesson.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateLesson.ForeColor = System.Drawing.Color.White;
            this.btnUpdateLesson.Location = new System.Drawing.Point(282, 176);
            this.btnUpdateLesson.Name = "btnUpdateLesson";
            this.btnUpdateLesson.Size = new System.Drawing.Size(174, 41);
            this.btnUpdateLesson.TabIndex = 12;
            this.btnUpdateLesson.Text = "Dersi Güncelle";
            this.btnUpdateLesson.UseVisualStyleBackColor = false;
            this.btnUpdateLesson.Click += new System.EventHandler(this.btnUpdateLesson_Click);
            // 
            // txtILessonID
            // 
            this.txtILessonID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtILessonID.Enabled = false;
            this.txtILessonID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtILessonID.Location = new System.Drawing.Point(259, 48);
            this.txtILessonID.Name = "txtILessonID";
            this.txtILessonID.Size = new System.Drawing.Size(186, 31);
            this.txtILessonID.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(168, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ders ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(496, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 42);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lesson Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Derse Girecek Öğretmen";
            // 
            // txtLessonName
            // 
            this.txtLessonName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLessonName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLessonName.Location = new System.Drawing.Point(259, 85);
            this.txtLessonName.Name = "txtLessonName";
            this.txtLessonName.Size = new System.Drawing.Size(186, 31);
            this.txtLessonName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Adı:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.cbTeacherName);
            this.panel2.Controls.Add(this.btnClearArea);
            this.panel2.Controls.Add(this.btnDeleteLesson);
            this.panel2.Controls.Add(this.btnAddLesson);
            this.panel2.Controls.Add(this.btnUpdateLesson);
            this.panel2.Controls.Add(this.txtILessonID);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtLessonName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(737, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 427);
            this.panel2.TabIndex = 5;
            // 
            // cbTeacherName
            // 
            this.cbTeacherName.DisplayMember = "ID";
            this.cbTeacherName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTeacherName.FormattingEnabled = true;
            this.cbTeacherName.Location = new System.Drawing.Point(259, 119);
            this.cbTeacherName.Name = "cbTeacherName";
            this.cbTeacherName.Size = new System.Drawing.Size(186, 33);
            this.cbTeacherName.TabIndex = 16;
            this.cbTeacherName.Text = "Öğretmen Seç";
            this.cbTeacherName.ValueMember = "Name";
            this.cbTeacherName.SelectedIndexChanged += new System.EventHandler(this.cbTeacherName_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 81);
            this.panel1.TabIndex = 4;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1150, 14);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(43, 49);
            this.lblClose.TabIndex = 17;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // frmLasson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 508);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLasson";
            this.Text = "frmLasson";
            this.Load += new System.EventHandler(this.frmLasson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel3;
        private Button btnClearArea;
        private Button btnDeleteLesson;
        private Button btnAddLesson;
        private Button btnUpdateLesson;
        private TextBox txtILessonID;
        private Label label6;
        private Label label7;
        private Label label2;
        private TextBox txtLessonName;
        private Label label1;
        private Panel panel2;
        private ComboBox cbTeacherName;
        private Panel panel1;
        private Label lblClose;
    }
}