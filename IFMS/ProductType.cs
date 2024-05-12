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
    public partial class ProductType : Form
    {
        public ProductType()
        {
            InitializeComponent();
        }
        public void show()
        {
            try
            {
                queryClass.selectds("Select * from Product_Type");
                dgvPrType.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = string.Format("Insert into Product_Type(Product_Type)values('" + tbProduct_Type.Text + "')");
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

        private void ProductType_Load(object sender, EventArgs e)
        {
            show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true; queryClass.clrearC(this);
        }

        private void dgvPrType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                queryClass.id = Convert.ToInt32(dgvPrType.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Do not select header");
            }
        }

        private void dgvPrType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSave.Enabled = false;
                tbProduct_Type.Text = dgvPrType.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
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
                        string qry = string.Format("update Product_Type set Product_Type='" + tbProduct_Type.Text + "' where ID=@i");
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
                        string qry = string.Format("delete from Product_Type where ID=@i");
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

        private void tbProduct_Type_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }
    }
}
