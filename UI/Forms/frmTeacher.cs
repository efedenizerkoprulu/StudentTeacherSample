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
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
            teacherService=InstanceFactory.GetInstance<TeacherMenager>();
        }

        private void DataGridWiewSettings()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "Öğretmenin ID";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Email Adresi";
            dataGridView1.Columns[4].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[5].HeaderText = "Göreve Başlama Tarihi";
        }

        private void Clear()
        {
            txtEmail.Text = "";
            txtTeacherID.Text = "";
            txtTeacherName.Text = "";
            txtTeacherSurname.Text = "";
            mskTeacherPhone.Text = "";
            dtTeacherStartedDate.Text = "";
        }
        ITeacherService teacherService;
        Teacher teacher = new Teacher();
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            teacher.Name = txtTeacherName.Text;
            teacher.Surname = txtTeacherSurname.Text;
            teacher.Email = txtEmail.Text;
            teacher.Phone = mskTeacherPhone.Text;
            teacher.StartedDate = dtTeacherStartedDate.Value;
            try
            {
                teacherService.AddTeacher(teacher);
                dataGridView1.DataSource = teacherService.ListTeachers().Data;
            }
            catch (VaildEmailAdressException ValidEmail)
            {
                MessageBox.Show(ValidEmail.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Clear(); }
        }

        private void mskTeacherPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //lblIsTurkey.Text = teacherMenager.IsStartedWithTurkeyNumber(mskTeacherPhone.Text).Message;
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teacherService.ListTeachers().Data;
            DataGridWiewSettings();
        }

        private void mskTeacherPhone_TextChanged(object sender, EventArgs e)
        {
            lblIsTurkey.Text = teacherService.IsStartedWithTurkeyNumber(mskTeacherPhone.Text).Message;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTeacherID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTeacherName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTeacherSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mskTeacherPhone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dtTeacherStartedDate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            var getStudent = teacherService.GetTeacher(int.Parse(txtTeacherID.Text)).Data;

            try
            {
                teacherService.DeleteTeacher(getStudent);
                dataGridView1.DataSource = teacherService.ListTeachers().Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Clear(); }
        }

        private void btnClearArea_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            var getTeacher = teacherService.GetTeacher(int.Parse(txtTeacherID.Text)).Data;

            getTeacher.Name = txtTeacherName.Text;
            getTeacher.Surname=txtTeacherSurname.Text;
            getTeacher.Email = txtEmail.Text;
            getTeacher.Phone = mskTeacherPhone.Text;
            getTeacher.StartedDate = dtTeacherStartedDate.Value;

            try
            {
                teacherService.UpdateTeacher(getTeacher);
                dataGridView1.DataSource = teacherService.ListTeachers().Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Clear(); }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
