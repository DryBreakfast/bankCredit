using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursach
{
    public partial class TopAgreements : Form
    {
        public TopAgreements()
        {
            InitializeComponent();
        }

        private void TopAgreements_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
            sqlconn.Open();
            SqlCommand Cmd = new SqlCommand("SELECT TOP(5) Id_agreement, ADateFrom,  ADateTo , AType, ASumm, APenya, Id_client,Id_employee,Id_credit FROM Agreement ORDER BY ASumm DESC", sqlconn);
            SqlDataAdapter ad = new SqlDataAdapter(Cmd);
            ad.Fill(ds);
            sqlconn.Close();
            

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Cursach.Agreem.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables[0]));
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
