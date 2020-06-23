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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var k = new Que();
            k.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPayment newForm = new AddPayment();
            newForm.ShowDialog();
            bankDataSet.AcceptChanges();
        }

        private void наГоловнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Hide();
                Main newForm = new Main();
                newForm.ShowDialog();
                this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientKvitan f = new ClientKvitan();
            f.Show();
        }

        List<string> t = new List<string>();
        public static string name;
        private void User_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);

            sqlconn.Open();
            SqlCommand Cmd = new SqlCommand("SELECT CLastName, CName, CPatronymic FROM Client WHERE Id_client=@a;", sqlconn);
            Cmd.Parameters.AddWithValue("@a", UserPassword.id);
            SqlDataAdapter ad = new SqlDataAdapter(Cmd);
            ad.Fill(ds);
            sqlconn.Close();
            
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                        t.Add(cell.ToString());
                }
            }

            label2.Text = t[0]+" " + t[1] +" "+ t[2];
            name = label2.Text;

            List<string> t1 = new List<string>();
            DataSet ds1 = new DataSet();
            SqlConnection sqlcon = new SqlConnection(UserBank.ConnectionString);

            sqlcon.Open();
            SqlCommand quer = new SqlCommand("SELECT Id_agreement FROM Agreement WHERE Id_client=@a", sqlcon);
            quer.Parameters.AddWithValue("@a", UserPassword.id);
            SqlDataAdapter ad1 = new SqlDataAdapter(quer);
            ad1.Fill(ds1);
            sqlcon.Close();

            foreach (DataTable dt in ds1.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                        t1.Add(cell.ToString());
                }
            }
           
            if (t1.Count == 0)
            {
                button3.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
                button4.Enabled = true;
                List<string> t2 = new List<string>();
                DataSet ds2 = new DataSet();

                sqlcon.Open();
                SqlCommand que = new SqlCommand("SELECT FORMAT (PDateTo, 'dd.MM.yyyy') FROM Payment WHERE Id_agreement=@a AND PDate IS NULL ", sqlcon);
                que.Parameters.AddWithValue("@a", Convert.ToInt32(t1[0]));
                SqlDataAdapter ad2 = new SqlDataAdapter(que);
                ad2.Fill(ds2);
                sqlcon.Close();

                foreach (DataTable dt in ds2.Tables)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        var cells = row.ItemArray;
                        foreach (object cell in cells)
                            t2.Add(cell.ToString());
                    }
                }
                if (t2.Count != 0)
                {
                    label3.Text = "Нагадуємо, що платіж має поступити до " + t2[0];
                    button2.Enabled = true ;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet d2 = new DataSet();
            List<string> s = new List<string>();
            SqlConnection sqlcon = new SqlConnection(UserBank.ConnectionString);
            sqlcon.Open();
            SqlCommand que = new SqlCommand("SELECT Id_agreement FROM Agreement WHERE Id_client=@a AND ASumm!=0", sqlcon);
            que.Parameters.AddWithValue("@a", UserPassword.id);
            SqlDataAdapter ad2 = new SqlDataAdapter(que);
            ad2.Fill(d2);
            sqlcon.Close();

            foreach (DataTable dt in d2.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                        s.Add(cell.ToString());
                }
            }

            EmployeeAgree.id_agr=Convert.ToInt32(s[0]);
            var j = new Agreement();
            j.Show();
        }
    }
}
