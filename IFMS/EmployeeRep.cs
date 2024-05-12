using Microsoft.Reporting.WinForms;
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
    public partial class EmployeeRep : Form
    {
        public EmployeeRep()
        {
            InitializeComponent();
        }
        private DataSet5 GetDataonload()
        {

            queryClass.con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Employee ", queryClass.con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet5 ds = new DataSet5();
            da.Fill(ds, "DataTable1");
            return ds;
        }
        private DataSet5 GetData()
        {
            queryClass.con.Close();
            queryClass.con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Employee where ID  LIKE '%" + tbSearch.Text + "%'", queryClass.con);

            cmd.Parameters.AddWithValue("@i", tbSearch.Text);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet5 ds = new DataSet5();
            da.Fill(ds, "DataTable1");
            return ds;
        }

        private void EmployeeRep_Load(object sender, EventArgs e)
        {
            DataSet5 ds = GetDataonload(); queryClass.con.Close();
            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);

            this.reportViewer1.RefreshReport();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet5 ds = GetData(); queryClass.con.Close();
                ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }
    }
}
