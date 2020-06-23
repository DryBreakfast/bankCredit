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
    public partial class Agreement : Form
    {
        public Agreement()
        {
            InitializeComponent();
        }

        private void Agreement_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            DataSet ds3 = new DataSet();
            SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);

            sqlconn.Open();
            SqlCommand Cmd = new SqlCommand("SELECT Id_agreement, ADateFrom, ADateTo, ASumm, APenya FROM Agreement WHERE Id_agreement=@a", sqlconn);
            Cmd.Parameters.AddWithValue("@a", EmployeeAgree.id_agr);
            SqlDataAdapter ad = new SqlDataAdapter(Cmd);
            ad.Fill(ds);
            sqlconn.Close();

            sqlconn.Open();
            SqlCommand Cmd1 = new SqlCommand("SELECT Client.CLastName, Client.CName, Client.CPatronymic FROM Client,Agreement WHERE Agreement.Id_agreement=@a AND Agreement.Id_client=Client.Id_client", sqlconn);
            Cmd1.Parameters.AddWithValue("@a", EmployeeAgree.id_agr);
            SqlDataAdapter ad2 = new SqlDataAdapter(Cmd1);
            ad2.Fill(ds1);
            sqlconn.Close();

            sqlconn.Open();
            SqlCommand Cmd2 = new SqlCommand("SELECT Employee.EmLastName, Employee.EmName, Employee.EmPatronymic, Employee.EmPosition FROM Employee,Agreement WHERE Agreement.Id_agreement=@a AND Agreement.Id_employee=Employee.Id_employee", sqlconn);
            Cmd2.Parameters.AddWithValue("@a", EmployeeAgree.id_agr);
            SqlDataAdapter ad3 = new SqlDataAdapter(Cmd2);
            ad3.Fill(ds2);
            sqlconn.Close();

            sqlconn.Open();
            SqlCommand Cmd3 = new SqlCommand("SELECT Credit.CrName, Credit.CrRersent FROM Agreement, Credit WHERE Agreement.Id_agreement=@a AND Agreement.Id_credit=Credit.Id_credit", sqlconn);
            Cmd3.Parameters.AddWithValue("@a", EmployeeAgree.id_agr);
            SqlDataAdapter ad4 = new SqlDataAdapter(Cmd3);
            ad4.Fill(ds3);
            sqlconn.Close();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Cursach.CreditAgreement.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables[0]));
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", ds1.Tables[0]));
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", ds2.Tables[0]));
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet4", ds3.Tables[0]));
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
