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
    public partial class Kvitan : Form
    {
        public Kvitan()
        {
            InitializeComponent();
        }

        private void Kvitan_Load(object sender, EventArgs e)
        {
            int id = UserPassword.id;
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);

            sqlconn.Open();
            //SqlCommand Cmd = new SqlCommand("SELECT Payment.Id_payment, Payment.PDate, Payment.PSumm, Payment.PPenya FROM Payment, Client, Agreement WHERE Payment.Id_agreement=Agreement.Id_agreement AND Agreement.Id_client=@a AND Payment.PDate=(SELECT MAX(PDate) FROM Payment) AND Payment.PDate IS NOT NULL", sqlconn);
            SqlCommand Cmd = new SqlCommand("SELECT Payment.Id_payment, Payment.PDate, Payment.PSumm, Payment.PPenya FROM Payment, Client, Agreement WHERE Payment.Id_payment=@b", sqlconn);
            Cmd.Parameters.AddWithValue("@a", id);
            Cmd.Parameters.AddWithValue("@b", ClientKvitan.id_pay);
            SqlDataAdapter ad = new SqlDataAdapter(Cmd);
            ad.Fill(ds);
            sqlconn.Close();

            sqlconn.Open();
            SqlCommand Cmd1 = new SqlCommand("SELECT CLastName, CName,CPatronymic, Id_client FROM Client WHERE Id_client=@a", sqlconn);
            Cmd1.Parameters.AddWithValue("@a", id);
            SqlDataAdapter ad2 = new SqlDataAdapter(Cmd1);
            ad2.Fill(ds1);
            sqlconn.Close();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Cursach.Report1.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables[0]));
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", ds1.Tables[0]));
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
