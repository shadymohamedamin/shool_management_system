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
    public partial class feesForm : Form
    {
        public feesForm()
        {
            InitializeComponent();
        }
        int amount, pay ,notPay;
        long studentId;
        string date;



        private void BackButtonFees_Click(object sender, EventArgs e)
        {
            WelcForm frm = new WelcForm();
            frm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void feesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.feesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolSystemDataSet);

        }

        private void DeleteFeesbutton2_Click(object sender, EventArgs e)
        {
            amount = int.Parse(amountTextBox.Text);
            pay = int.Parse(payTextBox.Text);
            notPay = int.Parse(notPayTextBox.Text);
            studentId = long.Parse(studentIdTextBox.Text);
            date = dateDateTimePicker.Value.ToString("yyyy-MM-dd");
            this.feesTableAdapter.DeleteFees(studentId, amount, pay, notPay, date);
            this.feesTableAdapter.Fill(this.schoolSystemDataSet.Fees);
            feesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.schoolSystemDataSet);
        }

        private void SortByNotPaybutton1_Click(object sender, EventArgs e)
        {
            this.feesTableAdapter.SortByNotPay(this.schoolSystemDataSet.Fees);
        }

        private void feesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolSystemDataSet.Fees' table. You can move, or remove it, as needed.
            this.feesTableAdapter.Fill(this.schoolSystemDataSet.Fees);

        }

        private void Addbutton8_Click(object sender, EventArgs e) ////Add Fees
        {
            amount = int.Parse(amounttextBox2.Text);
            pay = int.Parse(PaytextBox3.Text);
            notPay = int.Parse(NotPaytextBox4.Text);
            studentId = long.Parse(stIdtextBox1.Text);
            date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            this.feesTableAdapter.InsertFees(studentId, amount, pay, notPay, date);
            this.feesTableAdapter.Fill(this.schoolSystemDataSet.Fees);
            feesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.schoolSystemDataSet);
        }
    }
}
