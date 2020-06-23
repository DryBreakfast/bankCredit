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
    public partial class EmployeePassword : Form
    {
        public EmployeePassword()
        {
            InitializeComponent();
        }

        public static int id;
        List<string> t = new List<string>();
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(textBox1.Text);

            DataSet ds = new DataSet();
            SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);

            sqlconn.Open();
            SqlCommand Cmd = new SqlCommand("SELECT Id_employee FROM Employee WHERE Id_employee=@a;", sqlconn);
            Cmd.Parameters.AddWithValue("@a", EmployeePassword.id);
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
                MessageBox.Show("Ви не є нашим працівником", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (textBox2.Text == "1234")
                {
                    this.Hide();
                    Employee newForm = new Employee();
                    newForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неправильний пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
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
