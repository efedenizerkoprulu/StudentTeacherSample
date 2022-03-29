using business.Abstract;
using business.Concrete;
using business.DependencyReolvers.Ninject;
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
    public partial class frmLasson : Form
    {
        public frmLasson()
        {
            InitializeComponent();
            lessonService = InstanceFactory.GetInstance<ILessonService>();

        }

        private void DataGridViewSettings()
        {
            dataGridView1.Columns[0].HeaderText = "Ders ID";
            dataGridView1.Columns[1].HeaderText = "Derse Girecek Öğretmen";
            dataGridView1.Columns[2].HeaderText = "Dersin Adı";
            dataGridView1.Columns[3].Visible = false;
        }

        private void Clear()
        {
            txtILessonID.Text = "";
            txtLessonName.Text = "";
            cbTeacherName.Text = " Öğretmen Seç";
        }

        ILessonService lessonService;
        Lesson lesson = new Lesson();

        private void frmLasson_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lessonService.ListLessons().Data;
            cbTeacherName.DataSource = lessonService.GetTeacherName().Data;
            cbTeacherName.DisplayMember = "Name";
            cbTeacherName.ValueMember = "ID";

            DataGridViewSettings();
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            lesson.ID = 0;
            lesson.Name = txtLessonName.Text;;
            lesson.TeacherID = Convert.ToInt32(cbTeacherName.SelectedValue);
            try
            {
                lessonService.AddLesson(lesson);
                dataGridView1.DataSource = lessonService.ListLessons().Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Clear(); }
        }

        private void cbTeacherName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            try
            {
                lessonService.PassiveData(int.Parse(txtILessonID.Text));
                dataGridView1.DataSource = lessonService.ListLessons().Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Clear(); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtILessonID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbTeacherName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtLessonName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnClearArea_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdateLesson_Click(object sender, EventArgs e)
        {

            var getLesson = lessonService.GetLesson(int.Parse(txtILessonID.Text)).Data;
            getLesson.Name = txtLessonName.Text;
            getLesson.TeacherID = Convert.ToInt32(cbTeacherName.SelectedValue);

            try
            {
                lessonService.UpdateLesson(getLesson);
                dataGridView1.DataSource = lessonService.ListLessons().Data;

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
