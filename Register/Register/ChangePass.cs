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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\\repos\\Register\\Register\\bin\\Debug\\db_users.mdb; Persist Security Info = False; ");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void ChangePass_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string NewPassword = "UPDATE tbl_users SET Password = '" + txtPass.Text + "', Username = '" + txtUser.Text + "', Email = '"+txtEmail.Text+"' WHERE Username = '"+txtUser.Text+"'";
            
            OleDbCommand command = new OleDbCommand(NewPassword, con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The password has been changed with success.","", MessageBoxButtons.OK );
        }

        private void btnRegPage_Click(object sender, EventArgs e)
        {
            new Welcome().Show();
            this.Close();
        }
    }
}
