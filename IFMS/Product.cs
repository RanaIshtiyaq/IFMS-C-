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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        public void show()
        {
            try
            {
                queryClass.selectds("Select * from Product");
                dgvProdct.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void pbPrNam_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrname.Visible == true) dgvPrname.Visible = false;
                else
                {
                    dgvPrname.Visible = true; tbProduct_Type.Focus();
                    queryClass.selectds("Select Product_Type from Product_Type");
                    dgvPrname.DataSource = queryClass.ds.Tables[0];
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = string.Format("Insert into Product(Product_Type,Product_Name,Description)values('" + tbProduct_Type.Text + "','" + tbProduct_Name.Text + "','" + tbDesicription.Text + "')");
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

        private void dgvPrname_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbProduct_Type.Text = dgvPrname.Rows[e.RowIndex].Cells[0].Value.ToString();
                dgvPrname.Visible = false;
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
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
                        string qry = string.Format("update Product set Product_Type='" + tbProduct_Type.Text + "',Product_Name='" + tbProduct_Name.Text + "',Description='" + tbDesicription.Text + "' where ID=@i");
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
                        string qry = string.Format("delete from Product where ID=@i");
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
            btnSave.Enabled = true; queryClass.clrearC(this);
        }

        private void dgvProdct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                queryClass.id = Convert.ToInt32(dgvProdct.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Do not select header");
            }
        }

        private void dgvProdct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSave.Enabled = false;
                tbProduct_Type.Text = dgvProdct.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbProduct_Name.Text = dgvProdct.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbDesicription.Text = dgvProdct.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void tbProduct_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
           queryClass.valLatr(e);
        }

        private void tbProduct_Type_TextChanged(object sender, EventArgs e)
        {
            try
            {
                queryClass.selectds("Select Product_Type from Product_Type where Product_Type LIKE '%" + tbProduct_Type.Text + "%'");
                dgvPrname.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void tbProduct_Type_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr( e);
        }

        private void tbDesicription_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valRegNo(e);
        }
    }
}
