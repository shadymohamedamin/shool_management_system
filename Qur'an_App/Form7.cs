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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }
        string teacerName, gender, clas, dateOfBirth;
        long teacherId, mobile;
        double salary;
        int age;

        private void DeleteButton_Click(object sender, EventArgs e) // Delete  teacher information
        {
            teacerName = nameTextBox.Text;
            gender = genderTextBox.Text;
            clas = classTextBox.Text;
            dateOfBirth = dateOfBirthDateTimePicker.Value.ToString("yyyy-MM-dd");
            teacherId = long.Parse(teacherIdTextBox.Text);
            mobile = long.Parse(mobileTextBox.Text);
            salary = double.Parse(salaryTextBox.Text);
            age = int.Parse(ageeTextBox.Text);

            this.teachersTableAdapter.DeleteTeacher(teacherId, teacerName, gender, mobile, clas, salary, age, dateOfBirth);
            this.teachersTableAdapter.Fill(this.schoolSystemDataSet.Teachers);
            teachersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.schoolSystemDataSet);
        }

        private void teacherIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBybutton_Click(object sender, EventArgs e)  ///search by name of teacher
        {
            this.teachersTableAdapter.SearchByName(this.schoolSystemDataSet.Teachers, searchByNametextBox1.Text);
        }

        private void SortBySalarybutton_Click(object sender, EventArgs e)
        {
            this.teachersTableAdapter.SortBySalary(this.schoolSystemDataSet.Teachers);
        }

        private void dateTimePicker1DateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BackButtonTeach_Click(object sender, EventArgs e)
        {
            WelcForm frm = new WelcForm();
            frm.Show();
            this.Hide();
        }

        private void teachersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teachersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolSystemDataSet);

        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolSystemDataSet.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.schoolSystemDataSet.Teachers);

        }

        private void Addbutton_Click(object sender, EventArgs e)    //Insert teacher information
        {
            teacerName = textBoxName.Text;

                gender = "";
            bool isChecked = radioButton1Male.Checked;
            if (isChecked)
                gender = radioButton1Male.Text;
            else
                gender = radioButton2Female.Text;
            clas = comboBox1Class.SelectedItem.ToString();
            dateOfBirth = dateTimePicker1DateOfBirth.Value.ToString("yyyy-MM-dd");
            teacherId = long.Parse(textBoxId.Text);
            mobile = long.Parse(textBoxMobile.Text);
            salary = double.Parse(textBoxSalary.Text);
            age = int.Parse(textBoxAge.Text);

            this.teachersTableAdapter.InsertTeacher(teacherId,teacerName,gender,mobile,clas,salary,age,dateOfBirth);
            this.teachersTableAdapter.Fill(this.schoolSystemDataSet.Teachers);
            teachersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.schoolSystemDataSet);
        }
    }
}
