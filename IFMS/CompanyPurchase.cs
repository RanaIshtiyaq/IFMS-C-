using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFMS
{
    public partial class CompanyPurchase : Form
    {
        public CompanyPurchase()
        {
            InitializeComponent();
        }
        public void show()
        {
            try
            {
                queryClass.selectds("Select * from CompanyPurchase");
                dgvCompanyPurchase.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void CompanyPurchase_Load(object sender, EventArgs e)
        {
            show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = string.Format("Insert into CompanyPurchase(Party_Tex_No,Company_Name,Cell_No,City,Address)values('" + tbParty_Tex_No.Text + "','" + tbCompany_Name.Text + "','" + tbCell_No.Text + "','" + tbCity.Text + "','" + tbAddress.Text + "')");
                queryClass.insert(qry);
                show();
                queryClass.clrearC(this);
                MessageBox.Show("One record added", "Record Added", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Inser Query Problem or May Empty Field", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (queryClass.id == 0) { MessageBox.Show("Double click on record for update"); }
                else
                {
                    DialogResult iExit = MessageBox.Show("Are you sure, You want to UPDATE record", "Want Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (iExit == DialogResult.Yes)
                    {
                        btnSave.Enabled = true;
                        string qry = string.Format("update CompanyPurchase set Party_Tex_No='" + tbParty_Tex_No.Text + "',Company_Name='" + tbCompany_Name.Text + "',Cell_No='" + tbCell_No.Text + "',City='" + tbCity.Text + "',Address='" + tbAddress.Text + "' where ID=@i");
                        queryClass.update(qry);
                        show();
                        queryClass.clrearC(this);
                    }
                }
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (queryClass.id == 0) { MessageBox.Show("Click on record for delete"); }
                else
                {
                    DialogResult iExit = MessageBox.Show("Are you sure, You want to DELETE record", "Want Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (iExit == DialogResult.Yes)
                    {
                        string qry = string.Format("delete from CompanyPurchase where ID=@i");
                        queryClass.Delete(qry);
                        show();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            queryClass.clrearC(this); btnSave.Enabled = true;
        }

        private void dgvCompanyPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                queryClass.id = Convert.ToInt32(dgvCompanyPurchase.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Do not select header");
            }
        }

        private void dgvCompanyPurchase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSave.Enabled = false;
                tbParty_Tex_No.Text = dgvCompanyPurchase.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbCompany_Name.Text = dgvCompanyPurchase.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbCell_No.Text = dgvCompanyPurchase.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbCity.Text = dgvCompanyPurchase.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbAddress.Text = dgvCompanyPurchase.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tbCompany_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbCell_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum( e);
        }

        private void tbCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr( e);
        }

        private void tbParty_Tex_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valRegNo(e);
        }

        private void tbAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valadr(e);
        }

        private void tbCell_No_TextChanged(object sender, EventArgs e)
        {
            queryClass.valCellh(tbCell_No);
        }
    }
}
