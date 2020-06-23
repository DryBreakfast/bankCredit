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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserBankPassword newForm = new UserBankPassword();
            newForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserPassword newForm = new UserPassword();
            newForm.ShowDialog();
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
            sqlconn.Open();
            SqlCommand query = new SqlCommand("UPDATE Payment SET Payment.Id_agreement = Agreement.Id_agreement, Payment.PPenya=DATEDIFF(day, Payment.PDateTo,current_timestamp )*Agreement.APenya FROM Payment LEFT JOIN Agreement ON Payment.Id_agreement = Agreement.Id_agreement WHERE Payment.Id_agreement = Agreement.Id_agreement AND Payment.PDate IS NULL AND current_timestamp>Payment.PDateTo", sqlconn);
            query.ExecuteNonQuery();
            sqlconn.Close();
            bankDataSet.AcceptChanges();

            if (new FileInfo("queue.txt").Length != 0)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream("queue.txt", FileMode.OpenOrCreate))
                {
                    Que.Queu = (List<string>)formatter.Deserialize(fs);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeePassword newForm = new EmployeePassword();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
