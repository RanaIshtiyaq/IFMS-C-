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
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void showForm(Form f)
        {
            pnDash.Controls.Clear();
            f.TopLevel = false;
            pnDash.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }


        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase pr = new Purchase();
            showForm(pr);
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyPurchase cp = new CompanyPurchase();
            showForm(cp);
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Product pr = new Product();
            showForm(pr);
        }

        private void productTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductType pty = new ProductType();
            showForm(pty);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            showForm(lg);
            
        }

        private void weightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Weight wt = new Weight();
            showForm(wt);
        }

        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicle vh = new Vehicle();
            showForm(vh);
        }

        private void saleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sale sl = new Sale();
            showForm(sl);
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            showForm(emp);
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpAttendance eat = new EmpAttendance();
            showForm(eat);
        }

        private void slipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleRep vp = new VehicleRep();
            showForm(vp);
        }

        private void weightSlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeightRep wr = new WeightRep();
            showForm(wr);
        }

        private void saleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaleRep sr = new SaleRep();
            showForm(sr);
        }

        private void purchaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PurchaseRep pr = new PurchaseRep();
            showForm(pr);
        }

        private void empAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpAtten eatr = new EmpAtten();
            showForm(eatr);
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeRep emr = new EmployeeRep();
            showForm(emr);
        }

    }
}
