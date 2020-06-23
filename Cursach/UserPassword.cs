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
    public partial class UserPassword : Form
    {
        public static int id;
        List<string> t = new List<string>();
        public UserPassword()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            id = Convert.ToInt32(textBox1.Text);

            DataSet ds = new DataSet();
            SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);

            sqlconn.Open();
            SqlCommand Cmd = new SqlCommand("SELECT Id_client FROM Client WHERE Id_client=@a;", sqlconn);
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

            if (t.Count == 0)
            {
                MessageBox.Show("Ви не є нашим клієнтом", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (textBox2.Text == "1234")
                {
                    this.Hide();
                    User newForm = new User();
                    newForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неправильний пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            
        }
        

        private void label3_Click(object sender, EventArgs e)
        {
            NewClient newForm = new NewClient();
            newForm.ShowDialog();
        }

        private void UserPassword_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click_1(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main newForm = new Main();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
