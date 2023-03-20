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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
          /*  // Create object from the second form (Welcome Form) 
            WelcForm formRegister = new WelcForm();
            // Hide Login Form 
            this.Hide();
            formRegister.FormClosed += (s, args) => this.Close();
            // Display Welcome Form 
            formRegister.Show(); */ 
          if (textBoxUser.Text == "")
            {
                MessageBox.Show("Please enter the username");
            }
          else if(textBoxPass.Text=="")
            {
                MessageBox.Show("Please enter the password");

            }
          else
            {

                if ((textBoxUser.Text == "hafsa" && textBoxPass.Text == "123") || (textBoxUser.Text == "amany" && textBoxPass.Text == "456"))
                {
                    // Create object from the second form (Welcome Form) 
                    WelcForm formRegister = new WelcForm();
                    // Hide Login Form 
                    this.Hide();
                    formRegister.FormClosed += (s, args) => this.Close();
                    // Display Welcome Form 
                    formRegister.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
