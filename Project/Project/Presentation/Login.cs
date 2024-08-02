using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Data_Access;
using Project.Business_Logic;

namespace Project.Presentation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        FileHandler handler = new FileHandler();


        private void OpenAccountsForm()
        {
            Accounts accountsForm = new Accounts();
            Hide();
            accountsForm.Show();
        }

        private void OpenRegistrationForm()
        {
            Registration registrationForm = new Registration();
            Hide();
            registrationForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Uname.Text;
            string password = Pass.Text;

            if (handler.Login(username, password))
            {
                OpenAccountsForm();
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password\nPlease try again.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenRegistrationForm();
        }
    }
}
