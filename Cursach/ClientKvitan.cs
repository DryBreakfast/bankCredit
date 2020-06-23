using System;
using System.Collections;
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
    public partial class ClientKvitan : Form
    {
        public ClientKvitan()
        {
            InitializeComponent();
        }

        private void ClientKvitan_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
            sqlconn.Open();
            SqlCommand query = new SqlCommand("SELECT Payment.Id_payment, Payment.PDate,Payment.PDateTo, Payment.PSumm, Payment.PPenya, Payment.Id_agreement FROM Payment,Agreement WHERE Agreement.Id_agreement=Payment.Id_agreement AND PDate IS NOT NULL AND Agreement.Id_client=@a;", sqlconn);
            query.Parameters.AddWithValue("@a", UserPassword.id);
            query.ExecuteNonQuery();
            sqlconn.Close();

            SqlDataAdapter quer = new SqlDataAdapter(query);
            ArrayList empty = new ArrayList();
            dataGridView1.DataSource = empty;
            DataTable dt = new DataTable();
            quer.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Дата сплати";
            dataGridView1.Columns[2].HeaderText = "Строк сплати";
            dataGridView1.Columns[3].HeaderText = "Сума";
            dataGridView1.Columns[4].HeaderText = "Пеня";
            dataGridView1.Columns[5].HeaderText = "Номер договору";
        }

        public static int id_pay;
        

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id_pay = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            var u = new Kvitan();
            u.Show();
        }
    }
}
