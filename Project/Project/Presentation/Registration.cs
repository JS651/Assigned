using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Data_Access;

namespace Project.Presentation
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
        FileHandler handler = new FileHandler();

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login Login = new Login();
            this.Hide();
            Login.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (handler.Register(Uname.Text, Pass.Text) == "True")
            {
                MessageBox.Show("Registration Successfull");
            }
            else
            {
                MessageBox.Show("Username/Password has no been given.\nPlease try again.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
