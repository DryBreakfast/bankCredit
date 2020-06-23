using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursach
{
    public partial class AddAgreement : Form
    {
        public AddAgreement()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddAgreement_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(UserBank.ConnectionString);
            SqlDataAdapter qu = new SqlDataAdapter("SELECT CONCAT( Id_credit, CONCAT(' ',CrName)) AS Cl FROM Credit;", sqlcon);
            DataTable t2 = new DataTable();
            qu.Fill(t2);
            comboBox4.DataSource = t2;
            comboBox4.DisplayMember = "Cl";
            comboBox4.ValueMember = "Cl";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
            sqlconn.Open();
            SqlCommand query = new SqlCommand(" INSERT INTO Agreement( ADateFrom, ADateTo, AType, ASumm, APenya, Id_client, Id_employee, Id_credit) VALUES ( @From, @To, @Typ, @Sum, @Pen, @Id1, @Id2, @Id3) ", sqlconn);

            query.Parameters.AddWithValue("@From", aDateFromDateTimePicker.Value);
            query.Parameters.AddWithValue("@To", aDateToDateTimePicker.Value);
            query.Parameters.AddWithValue("@Typ", comboBox1.Text);
            query.Parameters.AddWithValue("@Sum", aSummTextBox.Text);
            query.Parameters.AddWithValue("@Pen", aPenyaTextBox.Text);
            query.Parameters.AddWithValue("@Id1", Queue_employ.client.Split(' ')[0]);
            query.Parameters.AddWithValue("@Id2", EmployeePassword.id);
            query.Parameters.AddWithValue("@Id3", comboBox4.Text.Split(' ')[0]);
            query.ExecuteNonQuery();
            sqlconn.Close();
            bankDataSet.AcceptChanges();

            Que.Queu.Remove(Queue_employ.client);

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
            MessageBox.Show("Договір №"+t[0]+" оформлений, дякуємо\nПерший платіж має поступити до "+ aDateFromDateTimePicker.Value.AddMonths(1), "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            Close();
        }

        private void AddAgreement_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("queue.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Que.Queu);
            }
        }
    }
}
