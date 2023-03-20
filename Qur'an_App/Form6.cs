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
    public partial class StudentInfo : Form
    {
        
        string name,clas,addres,gender, 
                Name,Clas,Address, Gender;  //student parameters used in class
        long id, Id;
            int age,fees, Age, Fees;

        long mobile , Mobile;  
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void BackButtonStu_Click(object sender, EventArgs e)
        {
            WelcForm frm = new WelcForm();
            frm.Show();
            this.Hide();
        }

        private void studentInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolSystemDataSet);

        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolSystemDataSet.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.schoolSystemDataSet.StudentInfo);

        }

        private void NoumberOfstudents_Click(object sender, EventArgs e) /// count number of students
        {
            int numberOfStudents;
            numberOfStudents = (int)this.studentInfoTableAdapter.CountNoOfStudents();
            MessageBox.Show(" Number Of Students = " + numberOfStudents);
        }

        private void SortByClassbutton1_Click(object sender, EventArgs e)///Sort By Class
        {
            this.studentInfoTableAdapter.SortByClass(this.schoolSystemDataSet.StudentInfo);
        }

        private void BackButtonEvents_Click(object sender, EventArgs e)
        {

        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            id = long.Parse(textBoxId.Text);
            age = int.Parse(textBoxAge.Text);
            addres = textBoxAddress.Text;
            clas = comboBox1Class.Text;
            mobile = long.Parse(textBoxMobil.Text);
            fees = int.Parse(textBoxFees.Text);
            gender = "";
            bool isChecked = Male.Checked;
            if (isChecked)
                gender = Male.Text;
            else
                gender = Female.Text;

            this.studentInfoTableAdapter.Add(id, name, age, gender, addres, clas, mobile, fees);
            this.studentInfoTableAdapter.Fill(this.schoolSystemDataSet.StudentInfo);
            studentInfoBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.schoolSystemDataSet);
        }

        private void Delet_Click(object sender, EventArgs e) ///Delete Student Data
        {
            id = long.Parse(studentIdTextBox.Text);
            name = nameTextBox.Text;
            age = int.Parse(ageTextBox.Text);
            gender = genderTextBox.Text;
            mobile = long.Parse(mobilTextBox.Text);
            fees = int.Parse(feesTextBox.Text);
            addres = addressTextBox.Text;
            clas = classTextBox.Text;
            this.studentInfoTableAdapter.Delete1(id, name, age, gender, addres, clas, mobile, fees);
            this.studentInfoTableAdapter.Fill(this.schoolSystemDataSet.StudentInfo);
            studentInfoBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.schoolSystemDataSet);

        }

        private void SortByNmebutton_Click(object sender, EventArgs e)       ///////Sort Students by Nme
        {
            this.studentInfoTableAdapter.SortByName(this.schoolSystemDataSet.StudentInfo);

        }

        private void SearchBybutton_Click(object sender, EventArgs e)  ////////SearchByName
        {
            this.studentInfoTableAdapter.SearchByName(this.schoolSystemDataSet.StudentInfo, textBoxSearchByName.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Updatebutton_Click(object sender, EventArgs e)  //////Update student information
        {

            ///from add
            Name = textBoxName.Text;
            Id = long.Parse(textBoxId.Text); ///
            Age = int.Parse(textBoxAge.Text);
            Address = textBoxAddress.Text;
            Clas = comboBox1Class.Text;
            Mobile = long.Parse(textBoxMobil.Text);
            Fees = int.Parse(textBoxFees.Text);
            Gender = "";
            bool isChecked = Male.Checked;
            if (isChecked)
                Gender = Male.Text;
            else
                Gender = Female.Text;


            /////from delete
            id = long.Parse(studentIdTextBox.Text);
            name = nameTextBox.Text;
            age = int.Parse(ageTextBox.Text);
            gender = genderTextBox.Text;
            mobile = long.Parse(mobilTextBox.Text);
            fees = int.Parse(feesTextBox.Text);
            addres = addressTextBox.Text;
            clas = classTextBox.Text;
           
            this.studentInfoTableAdapter.UpdateData(Id,Name,Age,Gender,Address,Clas,Mobile,Fees,
                                                      id, name, age, gender, addres, clas, mobile, fees);
            this.studentInfoTableAdapter.Fill(this.schoolSystemDataSet.StudentInfo);
            studentInfoBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.schoolSystemDataSet);
        }

        private void SearchByClassbutton_Click(object sender, EventArgs e)      //////SearchByClass
        {
            this.studentInfoTableAdapter.SearchByClass(this.schoolSystemDataSet.StudentInfo, textBoxSearch.Text);
        }

        private void feesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
