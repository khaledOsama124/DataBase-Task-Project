using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Task_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void ResetBtn_Click(object sender,EventArgs e)
        {
            UNnameTb1.Text = "";
            PasswordTb.Text = "";


        }
        private void LoginBtn_click(object sender,EventArgs e)
        {
            if(UNnameTb1.Text== "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }else if(UNnameTb1.Text== "Admin" && PasswordTb.Text=="password") 
            {
                Employees obj = new Employees();
                obj.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("wrong user Name Or Password");
                UNnameTb1.Text = "";
                PasswordTb.Text = "";
            }
        }

        
    }
}
