using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n_01419012_Project1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            if (conn.connect())
            {
                if(conn.checkUser(txtBoxLogin.Text, txtBoxPassword.Text))
                {
                    conn.close();
                    Form formMan = new FormManage();
                    formMan.Show();
                    this.Hide();
                }
                else MessageBox.Show("You enter invalid login or password.\nPlease enter again.");
                txtBoxLogin.Clear();
                txtBoxPassword.Clear();
            }
        }
        private void txtBoxLogin_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
