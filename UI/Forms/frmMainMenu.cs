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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudent frmStudent = new frmStudent();
            frmStudent.Show();
            this.Hide();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLesson_Click(object sender, EventArgs e)
        {
            frmLasson frmLesson = new frmLasson();
            frmLesson.Show();
            this.Hide();
        }

        private void btneacher_Click(object sender, EventArgs e)
        {
            frmTeacher frmTeacher = new frmTeacher();
            frmTeacher.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
            this.Hide();
        }
    }
}
