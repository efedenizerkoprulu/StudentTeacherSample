using business.Abstract;
using business.Concrete;
using business.DependencyReolvers.Ninject;
using Core.Exceptions;
using DataAccess.Concrete.EntityFremework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
            studentService=InstanceFactory.GetInstance<StudentManager>();
        }

       private void DatagridviewSettings()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "Öğrencinin ID";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Email Adresi";
            dataGridView1.Columns[4].HeaderText = "Öğrencinin Sınıfı";
            dataGridView1.Columns[5].HeaderText = "Öğrencinin Numarası";
        }

        private void Clear()
        {
            txtEmail.Text = "";
            txtIStudentD.Text = "";
            txtStudentClass.Text = "";
            txtStudentName.Text = "";
            txtStudentNumber.Text = "";
            txtStudentSurname.Text = "";
        }

        IStudentService studentService;
        Student student = new Student();
        private void frmStudent_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = studentService.ListStudents().Data;
            DatagridviewSettings();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            student.Name = txtStudentName.Text;
            student.Surname = txtStudentSurname.Text;
            student.Email = txtEmail.Text;
            student.StudentClass = txtStudentClass.Text;
            student.StudentNo=txtStudentNumber.Text;
         
            try
            {
                studentService.AddStudent(student);
                dataGridView1.DataSource = studentService.ListStudents().Data;
            }
            catch (VaildEmailAdressException VaildEMail)
            {
                MessageBox.Show(VaildEMail.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Clear();
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            var StudentData = studentService.GetStudent(int.Parse(txtIStudentD.Text)).Data;
            StudentData.Name = txtStudentName.Text;
            StudentData.Surname = txtStudentSurname.Text;
            StudentData.Email = txtEmail.Text;
            StudentData.StudentClass = txtStudentClass.Text;
            StudentData.StudentNo = txtStudentNumber.Text;
            
            try
            {
                studentService.UpdateStudent(StudentData);
                dataGridView1.DataSource = studentService.ListStudents().Data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Clear();
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                var StudentData = studentService.GetStudent(int.Parse(txtIStudentD.Text)).Data;
                studentService.DeleteStudent(StudentData);
                dataGridView1.DataSource = studentService.ListStudents().Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Clear();
            }
        }

        private void btnClearArea_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIStudentD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtStudentName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtStudentSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtStudentClass.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtStudentNumber.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
