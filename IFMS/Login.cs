using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = string.Format("select * from admin where User_Name='" + tbUserName.Text + "' AND Password='" + tbPasword.Text + "' ");
                queryClass.con.Open();
                OleDbCommand cmd = new OleDbCommand(qry, queryClass.con);
                OleDbDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Dashbord db = new Dashbord();
                    db.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }

                queryClass.con.Close();
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm You Want to Close Login Form", "Close Login Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
                this.Close();
        }
    }
}
