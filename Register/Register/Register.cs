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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Length == 0)
            {
                MessageBox.Show("Password field cannot be empty!" + MessageBoxButtons.OK);
                txtPass.Text = "";
                txtConfirmPass.Text = "";
            }
            if (txtPass.Text.Length < 10)
            {
                MessageBox.Show("The password does not have the required number of characters.");
                txtPass.Text = "";
                txtConfirmPass.Text = "";
            }
            
            // just disable the button if this fields are empty, no need for messages :)
            if(txtUser.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty.", "Registration failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // nu ai nevoie de check-ul asta daca dupa fiecare if de mai sus ai fi facut return;
            // in cazul acela, daca ajungea codul aici, erai sigur ca conditiile au fost indeplinite.
            if (txtPass.Text == txtConfirmPass.Text && txtPass.Text.Length > 10 && txtConfirmPass.Text.Length > 10)
            {
                
                
                    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\repos\\Register\\Register\\bin\\Debug\\db_users.mdb;Persist Security Info=False;");
                    OleDbCommand cmd = new OleDbCommand();
                    OleDbDataAdapter da = new OleDbDataAdapter();
                    con.Open();

// din nou concatenare de string, mare grija la sql injection. De obicei se folosesc parametrii iar aceea vor fi verificati automat si 
//nu poate user-ul sa scrie mizerii.
                    string register = "INSERT INTO tbl_users VALUES ('" + txtEmail.Text + "','" + txtUser.Text + "', '"+ txtPass.Text+"')";
                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    txtEmail.Text = "";
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtConfirmPass.Text = "";
                    MessageBox.Show("Your account has been successfully created.", "Registration success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
            }
            else if( txtPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Passwords don't match, Please Re-Enter!", "Registration failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = "";
                txtConfirmPass.Text = "";
                txtPass.Focus();   
            }
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnRegPage_Click(object sender, EventArgs e)
        {
            new Welcome().Show();
            this.Hide();
        }
    }
}
