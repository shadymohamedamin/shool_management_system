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
    public partial class StudentDegreeForm : Form
    {
        public StudentDegreeForm()
        {
            InitializeComponent();
        }
        //Variables used
        string stName, revAmount, date, StudentName, RevAmount, Date;
        long studentId, StudentId;
        double quran, tagwd, tohfa, practBook, Quran, Tagwed, Tohfa,PractBook;

        private void searchtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxDegreebutton1_Click(object sender, EventArgs e)
        {
            this.studentDegreesTableAdapter.BigDegree(this.schoolSystemDataSet.StudentDegrees);
        }

        int age, Age;
        private void ShowAverageDegreesbutton1_Click(object sender, EventArgs e)////AverageOfQuranDegrees
        {
            double average;

            average = (double)this.studentDegreesTableAdapter.AverageOfQuranDegrees();
            MessageBox.Show("Average Quran Degrees= " + average);
        }

       

        private void textBoxQuran_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deletebutton3_Click(object sender, EventArgs e) //////////Delete student Degrees
        {
            stName = nameTextBox.Text;
            revAmount = rev_AmountTextBox.Text;
            date = dateDateTimePicker.Value.ToString("yyyy-MM-dd");
            studentId = long.Parse(studentIdTextBox.Text);
            age = int.Parse(ageTextBox.Text);
            quran = double.Parse(quranTextBox.Text);
            tagwd = double.Parse(tagwedTextBox.Text);
            tohfa = double.Parse(alTofaaTextBox.Text);
            practBook = double.Parse(practiceBookTextBox.Text);

            this.studentDegreesTableAdapter.DeleteDegree(studentId, stName, age, revAmount, quran, tagwd, tohfa, practBook, date);
            this.studentDegreesTableAdapter.Fill(this.schoolSystemDataSet.StudentDegrees);
            studentDegreesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.schoolSystemDataSet);
        }

        private void tagwedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void alTofaaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SortByQuranbutton4_Click(object sender, EventArgs e)   //////////////sort by quran degree
        {
            this.studentDegreesTableAdapter.SortByQuran(this.schoolSystemDataSet.StudentDegrees);
        }

        private void Updatebutton2_Click(object sender, EventArgs e)  //////////Update tudent Degree 
        {
            //From Add
            stName = textBoxName.Text;
            revAmount = comboBoxRevAmount.SelectedItem.ToString();
            date = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            studentId = long.Parse(textBoxId.Text);
            age = int.Parse(textBoxAge.Text);
            quran = double.Parse(qurannumericUpDown1.Text);
            tagwd = double.Parse(TagwadenumericUpDown2.Text);
            tohfa = double.Parse(tohfAnumericUpDown3.Text);
            practBook = double.Parse(booknumericUpDown1.Text);

            //From Delete 
            StudentName = nameTextBox.Text;
            RevAmount = rev_AmountTextBox.Text;
            Date = dateDateTimePicker.Value.ToString("yyyy-MM-dd");
            StudentId = long.Parse(studentIdTextBox.Text);
            Age = int.Parse(ageTextBox.Text);
            Quran = double.Parse(quranTextBox.Text);
            Tagwed = double.Parse(tagwedTextBox.Text);
            Tohfa = double.Parse(alTofaaTextBox.Text);
            PractBook = double.Parse(practiceBookTextBox.Text);
            this.studentDegreesTableAdapter.UpdateDegree(studentId,stName,age,revAmount,quran,tagwd,tohfa,practBook,date,
                                                         StudentId,StudentName,Age,RevAmount,Quran,Tagwed,Tohfa,PractBook,Date);
            this.studentDegreesTableAdapter.Fill(this.schoolSystemDataSet.StudentDegrees);
            studentDegreesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.schoolSystemDataSet);

        }

        private void SearchByNamebutton5_Click(object sender, EventArgs e) ///////search by name
        {
            this.studentDegreesTableAdapter.SearchByStName(this.schoolSystemDataSet.StudentDegrees, searchtextBox1.Text);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolSystemDataSet.StudentDegrees' table. You can move, or remove it, as needed.
            this.studentDegreesTableAdapter.Fill(this.schoolSystemDataSet.StudentDegrees);

        }

        private void BackButtonStuDeg_Click(object sender, EventArgs e)
        {
            WelcForm frm = new WelcForm();
            frm.Show();
            this.Hide();
        }

        private void studentDegreesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentDegreesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolSystemDataSet);

        }


        private void Addbutton_Click(object sender, EventArgs e)   /////////insert student Degrees
        {
            stName = textBoxName.Text;
            revAmount = comboBoxRevAmount.SelectedItem.ToString();
            date = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            studentId = long.Parse(textBoxId.Text);
            age = int.Parse(textBoxAge.Text);
            quran = double.Parse(qurannumericUpDown1.Text);
            tagwd = double.Parse(TagwadenumericUpDown2.Text);
            tohfa = double.Parse(tohfAnumericUpDown3.Text);
            practBook = double.Parse(booknumericUpDown1.Text);

            this.studentDegreesTableAdapter.InsertDegree(studentId, stName, age, revAmount, quran, tagwd, tohfa, practBook, date);
            this.studentDegreesTableAdapter.Fill(this.schoolSystemDataSet.StudentDegrees);
            studentDegreesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.schoolSystemDataSet);
        }
    }
}
