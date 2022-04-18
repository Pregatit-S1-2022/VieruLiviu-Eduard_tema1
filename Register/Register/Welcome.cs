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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            
            
        }
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\\repos\\Register\\Register\\bin\\Debug\\db_users.mdb; Persist Security Info = False; ");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void toolReg_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegPage_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void btnLogPage_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnChangePassPage_Click(object sender, EventArgs e)
        {
            new ChangePass().Show();
            this.Hide();
        }
    }
}
