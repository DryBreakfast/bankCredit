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
    public partial class EditAddAgreement : Form
    {
        private readonly int id;
        public EditAddAgreement()
        {
            InitializeComponent();
        }

        

        public EditAddAgreement(int id, DateTime from, DateTime to, string type, decimal money,decimal pen, int id1,int id2,int id3) : this()
        {

            this.id = id;
            aDateFromDateTimePicker.Value = from;
            aDateToDateTimePicker.Value = to;
            switch (type)
            {
                case "Готівкою":
                    comboBox1.SelectedIndex = 0;
                    break;
                case "На кредитну карту":
                    comboBox1.SelectedIndex = 1;
                    break;
                case "Кредитна лінія":
                    comboBox1.SelectedIndex = 2;
                    break;
                default:
                    comboBox1.SelectedIndex = 0;
                    break;
            }
            List<string> t1 = new List<string>();
            DataSet ds = new DataSet();
            SqlConnection sql = new SqlConnection(UserBank.ConnectionString);

            sql.Open();
            SqlCommand Cmd = new SqlCommand("SELECT CONCAT( Agreement.Id_client, CONCAT(' ',CONCAT(Client.CLastName,CONCAT(' ',Client.CName)))) AS Cl FROM Client,Agreement WHERE Client.Id_client=Agreement.Id_client AND Agreement.Id_client=@a", sql);
            Cmd.Parameters.AddWithValue("@a", id1);
            SqlDataAdapter ad = new SqlDataAdapter(Cmd);
            ad.Fill(ds);
            sql.Close();

            sql.Open();
            SqlCommand Cmd1 = new SqlCommand("SELECT CONCAT( Employee.Id_employee, CONCAT(' ',CONCAT(Employee.EmLastName,CONCAT(' ',Employee.EmName)))) AS Cl FROM Employee WHERE Id_employee=@a", sql);
            Cmd1.Parameters.AddWithValue("@a", id2);
            ad = new SqlDataAdapter(Cmd1);
            ad.Fill(ds);
            sql.Close();

            sql.Open();
            SqlCommand Cmd2 = new SqlCommand("SELECT CONCAT( Credit.Id_credit, CONCAT(' ',Credit.CrName)) AS Cl FROM Credit WHERE Id_credit=@a", sql);
            Cmd2.Parameters.AddWithValue("@a", id3);
            ad = new SqlDataAdapter(Cmd2);
            ad.Fill(ds);
            sql.Close();
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                        t1.Add(cell.ToString());
                }
            }

            aSummTextBox.Text = money.ToString();
            aPenyaTextBox.Text = pen.ToString();
            comboBox2.Text = t1[0];
            comboBox3.Text = t1[1];
            comboBox4.Text = t1[2];
        }

        List<string> list1 = new List<string>();
        List<string> list2 = new List<string>();
        List<string> list3 = new List<string>();
        String[] f1 = new String[] { };
        String[] f2 = new String[] { };
        String[] f3 = new String[] { };

        private void EditAddAgreement_Load(object sender, EventArgs e)
        {
            if (UserBank.edit)
            {
                comboBox2.DataSource = null;
                comboBox3.DataSource = null;
                comboBox4.DataSource = null;
                SqlConnection sqlcon = new SqlConnection(UserBank.ConnectionString);
                SqlDataAdapter quer = new SqlDataAdapter("SELECT CONCAT( Agreement.Id_client, CONCAT(' ',CONCAT(Client.CLastName,CONCAT(' ',Client.CName)))) AS Cl FROM Client,Agreement WHERE Client.Id_client=Agreement.Id_client;", sqlcon);
                DataTable t = new DataTable();
                quer.Fill(t);
                    foreach (DataRow row in t.Rows)
                    {
                        var cells = row.ItemArray;
                        foreach (object cell in cells)
                            list1.Add(cell.ToString());
                    }
                f1 = list1.ToArray();
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(f1);
                //comboBox2.DataSource = t;
                //comboBox2.DisplayMember = "Cl";
                //comboBox2.ValueMember = "Cl";

                SqlDataAdapter query = new SqlDataAdapter("SELECT CONCAT( Id_employee, CONCAT(' ',CONCAT(EmLastName,CONCAT(' ',EmName)))) AS Cl FROM Employee;", sqlcon);
                DataTable t1 = new DataTable();
                query.Fill(t1);
                foreach (DataRow row in t1.Rows)
                {
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                        list2.Add(cell.ToString());
                }
                f2 = list2.ToArray();
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(f2);

                SqlDataAdapter qu = new SqlDataAdapter("SELECT CONCAT( Id_credit, CONCAT(' ',CrName)) AS Cl FROM Credit;", sqlcon);
                DataTable t2 = new DataTable();
                qu.Fill(t2);
                foreach (DataRow row in t2.Rows)
                {
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                        list3.Add(cell.ToString());
                }
                f3 = list3.ToArray();
                comboBox4.Items.Clear();
                comboBox4.Items.AddRange(f3);
            }
            else
            {
                SqlConnection sqlcon = new SqlConnection(UserBank.ConnectionString);
                SqlDataAdapter quer = new SqlDataAdapter("SELECT CONCAT( Id_client, CONCAT(' ',CONCAT(CLastName,CONCAT(' ',CName)))) AS Cl FROM Client WHERE Client.Id_client NOT IN(SELECT Id_client FROM Agreement);", sqlcon);
                DataTable t = new DataTable();
                quer.Fill(t);
                comboBox2.DataSource = t;
                comboBox2.DisplayMember = "Cl";
                comboBox2.ValueMember = "Cl";

                SqlDataAdapter query = new SqlDataAdapter("SELECT CONCAT( Id_employee, CONCAT(' ',CONCAT(EmLastName,CONCAT(' ',EmName)))) AS Cl FROM Employee;", sqlcon);
                DataTable t1 = new DataTable();
                query.Fill(t1);
                comboBox3.DataSource = t1;
                comboBox3.DisplayMember = "Cl";
                comboBox3.ValueMember = "Cl";

                SqlDataAdapter qu = new SqlDataAdapter("SELECT CONCAT( Id_credit, CONCAT(' ',CrName)) AS Cl FROM Credit;", sqlcon);
                DataTable t2 = new DataTable();
                qu.Fill(t2);
                comboBox4.DataSource = t2;
                comboBox4.DisplayMember = "Cl";
                comboBox4.ValueMember = "Cl";
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typ = "";
            if (comboBox1.SelectedIndex == 0)
            {
                typ = "Готівкою";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                typ = "На кредитну карту";
            }
            if (UserBank.edit)
            {
                SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
                sqlconn.Open();
                SqlCommand query = new SqlCommand("UPDATE Agreement SET ADateFrom=@From, ADateTo=@To, AType=@Typ, ASumm=@Sum, APenya=@Pen, Id_client=@Id1, Id_employee=@Id2, Id_credit=@Id3 WHERE Id_agreement=" + id.ToString() + ";", sqlconn);

                query.Parameters.AddWithValue("@From", aDateFromDateTimePicker.Value);
                query.Parameters.AddWithValue("@To", aDateToDateTimePicker.Value);
                query.Parameters.AddWithValue("@Typ", typ);
                query.Parameters.AddWithValue("@Sum", Convert.ToDecimal(aSummTextBox.Text));
                query.Parameters.AddWithValue("@Pen", Convert.ToDecimal(aPenyaTextBox.Text));
                query.Parameters.AddWithValue("@Id1", comboBox2.Text.Split(' ')[0]);
                query.Parameters.AddWithValue("@Id2", comboBox3.Text.Split(' ')[0]);
                query.Parameters.AddWithValue("@Id3", comboBox4.Text.Split(' ')[0]);
                query.ExecuteNonQuery();
                sqlconn.Close();
                bankDataSet.AcceptChanges();
            }
            else
            {

                SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
                sqlconn.Open();
                SqlCommand query = new SqlCommand(" INSERT INTO Agreement( ADateFrom, ADateTo, AType, ASumm, APenya, Id_client, Id_employee, Id_credit) VALUES ( @From, @To, @Typ, @Sum, @Pen, @Id1, @Id2, @Id3) ", sqlconn);

                query.Parameters.AddWithValue("@From", aDateFromDateTimePicker.Value);
                query.Parameters.AddWithValue("@To", aDateToDateTimePicker.Value);
                query.Parameters.AddWithValue("@Typ", typ);
                query.Parameters.AddWithValue("@Sum", aSummTextBox.Text);
                query.Parameters.AddWithValue("@Pen", aPenyaTextBox.Text);
                query.Parameters.AddWithValue("@Id1", comboBox2.Text.Split(' ')[0]);
                query.Parameters.AddWithValue("@Id2", comboBox3.Text.Split(' ')[0]);
                query.Parameters.AddWithValue("@Id3", comboBox4.Text.Split(' ')[0]);
                query.ExecuteNonQuery();
                sqlconn.Close();
                bankDataSet.AcceptChanges();

                var t = new List<string>();
                SqlConnection sqlcon = new SqlConnection(UserBank.ConnectionString);
                SqlDataAdapter quer = new SqlDataAdapter("SELECT MAX(Id_agreement) FROM Agreement", sqlcon);

                DataSet ds = new DataSet();
                quer.Fill(ds);
                foreach (DataTable dt in ds.Tables)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        var cells = row.ItemArray;
                        foreach (object cell in cells)
                            t.Add(cell.ToString());
                    }
                }

                SqlConnection sqlConn = new SqlConnection(UserBank.ConnectionString);
                sqlConn.Open();
                SqlCommand Query = new SqlCommand(" INSERT INTO Payment(PDate, PDateTo, PSumm, PPenya, Id_agreement) VALUES (null, @To, null, 0, @Id) ", sqlConn);

                Query.Parameters.AddWithValue("@To", aDateFromDateTimePicker.Value.AddMonths(1));
                Query.Parameters.AddWithValue("@Id", Convert.ToInt32(t[0]));
                Query.ExecuteNonQuery();
                sqlConn.Close();
                bankDataSet.AcceptChanges();

            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
