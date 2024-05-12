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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        public void show()
        {
            try
            {
                queryClass.selectds("Select * from Employee");
                dgvEmployee.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            show();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                queryClass.id = Convert.ToInt32(dgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Do not select header");
            }
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSave.Enabled = false;
                tbEmployee_Name.Text = dgvEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbDesignation.Text = dgvEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbSalary.Text = dgvEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbAllowance.Text = dgvEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbCell_No.Text = dgvEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbAddress.Text = dgvEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = string.Format("Insert into Employee(Employee_Name,Designation,Salary,Allowance,Cell_No,Address)values('" + tbEmployee_Name.Text + "','" + tbDesignation.Text + "','" + tbSalary.Text + "','" + tbAllowance.Text + "','" + tbCell_No.Text + "','" + tbAddress.Text + "')");
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
                        string qry = string.Format("update Employee set Employee_Name='" + tbEmployee_Name.Text + "',Designation='" + tbDesignation.Text + "',Salary='" + tbSalary.Text + "',Allowance='" + tbAllowance.Text + "',Cell_No='" + tbCell_No.Text + "',Address='" + tbAddress.Text + "' where ID=@i  ");
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
                        string qry = string.Format("delete from Employee where ID=@i");
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
            queryClass.clrearC(this);
            btnSave.Enabled = true;
        }

        private void tbEmployee_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbDesignation_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum(e);
        }

        private void tbAllowance_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum( e);
        }

        private void tbCell_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum( e);
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
