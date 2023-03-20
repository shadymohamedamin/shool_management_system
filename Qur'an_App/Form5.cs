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
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
        }
        string eventDate, eventNme, eventTime, description;
        int id;

        private void BackButtonEvents_Click(object sender, EventArgs e)
        {
            WelcForm frm = new WelcForm();
            frm.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SortByDatebutton1_Click(object sender, EventArgs e)     //////////SortByDate
        {
            this.eventsTableAdapter.SortByDate(this.schoolSystemDataSet.Events);
        }

        private void Deletbutton4_Click(object sender, EventArgs e)
        {
            eventDate = dateIdDateTimePicker.Value.ToString("yyy-MM-dd");
            eventNme = eventNameTextBox.Text;
            eventTime = timeDateTimePicker.Value.ToString("HH:mm:yy");                  ///Value.ToString("HH:mm:ss");
            description = descriptionTextBox.Text;
            id = int.Parse(idTextBox.Text);
            this.eventsTableAdapter.DeleteQuery(eventDate, eventTime, eventNme, description,id);///////////
            this.eventsTableAdapter.Fill(this.schoolSystemDataSet.Events);
            eventsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.schoolSystemDataSet);
        }

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void eventNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBydatebutton3_Click(object sender, EventArgs e)
        {

        }

        private void timeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void eventNameTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void eventsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eventsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolSystemDataSet);

        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolSystemDataSet.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.schoolSystemDataSet.Events);

        }

        private void Addbutton1_Click(object sender, EventArgs e)  //////////// insert event
        {
            eventDate = DatedateTimePicker2.Value.ToString("yyy-MM-dd");
            eventNme = EventNamecomboBox1.Text;
            eventTime = TimedateTimePicker3.Value.ToString("HH:mm:ss");
            description = DescriptioncomboBox2.SelectedItem.ToString();

            this.eventsTableAdapter.InsertEvent(eventDate,eventTime,eventNme,description);
            this.eventsTableAdapter.Fill(this.schoolSystemDataSet.Events);
            eventsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.schoolSystemDataSet);

        }
    }
}
