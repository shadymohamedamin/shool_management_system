using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qur_an_App
{
    public partial class WelcForm : Form
    {
        public WelcForm()
        {
            InitializeComponent();
        }

       

        private void pictureBoxStudents_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BackButtonWelcome_Click(object sender, EventArgs e)
        {
            // Create Ogject 
            LogInForm frm = new LogInForm();
            // Show new form 
            frm.Show();
            // hide the current form 
            this.Hide();

        }

        private void pictureBoxStudents_Click_1(object sender, EventArgs e)
        {
            StudentInfo info = new StudentInfo();
            // Hide Welcome form 
            this.Hide();
            info.FormClosed += (s, args) => this.Close();
            // Display Welcome Form 
            info.Show();
        }

        private void WelcForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxFees_Click(object sender, EventArgs e)
        {

            feesForm fees = new feesForm();
            // Hide Welcome form 
            this.Hide();
            fees.FormClosed += (s, args) => this.Close();
            // Display Welcome Form 
            fees.Show();
        }

        private void pictureBoxGrades_Click(object sender, EventArgs e)
        {
            StudentDegreeForm StuDeg = new StudentDegreeForm();
            // Hide Welcome form 
            this.Hide();
           StuDeg.FormClosed += (s, args) => this.Close();
            // Display Welcome Form 
            StuDeg.Show();
        }

        private void pictureBoxEvents_Click(object sender, EventArgs e)
        {
            EventsForm formevent = new EventsForm();
            // Hide Welcome form 
            this.Hide();
            formevent.FormClosed += (s, args) => this.Close();
            // Display Welcome Form 
            formevent.Show();
        }

        private void pictureBoxTeachers_Click(object sender, EventArgs e)
        {
            TeacherForm teach = new TeacherForm();
            // Hide Welcome form 
            this.Hide();
            teach.FormClosed += (s, args) => this.Close();
            // Display Welcome Form 
            teach.Show();
        }
    }
}
