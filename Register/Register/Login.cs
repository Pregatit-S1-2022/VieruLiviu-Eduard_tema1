using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Register
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\repos\\Register\\Register\\bin\\Debug\\db_users.mdb;Persist Security Info=False;");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnRegPage_Click(object sender, EventArgs e)
        {
            new Welcome().Show();
            this.Hide();
        }

        private void chkRemember_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            if (chkRemember.Checked == true)
            {            
                txtUser.Text = "SELECT username = '" + txtUser.Text + "' FROM tbl_users";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            
            // cand folosesti string concatenation pentru query din baza de date, risti sql injections. Adica, un user rau poate sa scrie
            // la in txtUser: mimo OR 1=1;-- conditie care nu mai verifica nici un user :) . Sau daca vrea sa iti faca rau, 
            // m; drop table tbl_users --
            
            // plus ca logica asta ar trebui sa fie intr-un serviciu si nu direct in cod behind din pagina
            string login = "SELECT * FROM tbl_users WHERE Username = '"+txtUser.Text+"' and Password = '"+txtPass.Text+"'";
            cmd = new OleDbCommand(login, con);  
            OleDbDataReader dr = cmd.ExecuteReader();

            if(dr.Read() == true)
            {
                new dashboard().Show();
                this.Hide();
                MessageBox.Show("Hello, " + txtPass.Text + "!","Authentification successful!", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ChangePass().Show();
            this.Hide();
        }
    }
}
