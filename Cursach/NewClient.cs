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
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();
        }
        

        private void NewClient_Load(object sender, EventArgs e)
        {

        }

        List<string> t = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            var a = cId_passportTextBox.Text;
            DataSet ds = new DataSet();
            SqlConnection sql = new SqlConnection(UserBank.ConnectionString);

            sql.Open();
            SqlCommand Cmd = new SqlCommand("SELECT CId_passport FROM Client WHERE CId_passport=@a;", sql);
            Cmd.Parameters.AddWithValue("@a", Convert.ToInt32(cId_passportTextBox.Text));
            SqlDataAdapter ad = new SqlDataAdapter(Cmd);
            ad.Fill(ds);
            sql.Close();
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
                SqlConnection sqlcon = new SqlConnection(UserBank.ConnectionString);
                sqlcon.Open();
                SqlCommand query = new SqlCommand("INSERT INTO Client( CId_passport, CLastName, CName, CPatronymic, CAdress, CPhone, CWork, CSalary) VALUES ( @Passport, @Last, @Name, @Patr, @Adres, @Ph, @Work, @Sal)", sqlcon);

                query.Parameters.AddWithValue("@Passport", cId_passportTextBox.Text);
                query.Parameters.AddWithValue("@Last", cLastNameTextBox.Text);
                query.Parameters.AddWithValue("@Name", cNameTextBox.Text);
                query.Parameters.AddWithValue("@Patr", cPatronymicTextBox.Text);
                query.Parameters.AddWithValue("@Adres", cAdressTextBox.Text);
                query.Parameters.AddWithValue("@Ph", cPhoneTextBox.Text);
                query.Parameters.AddWithValue("@Work", cWorkTextBox.Text);
                query.Parameters.AddWithValue("@Sal", cSalaryTextBox.Text);
                query.ExecuteNonQuery();
                sqlcon.Close();
                bankDataSet.AcceptChanges();

                DataSet dt1 = new DataSet();
                var t1 = new List<string>();
                sqlcon.Open();
                SqlCommand quer = new SqlCommand("SELECT Id_client FROM Client WHERE CId_passport=@a", sqlcon);
                quer.Parameters.AddWithValue("@a", a);
                SqlDataAdapter ad1 = new SqlDataAdapter(quer);
                ad1.Fill(dt1);
                sqlcon.Close();
                foreach (DataTable dt in dt1.Tables)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        var cells = row.ItemArray;
                        foreach (object cell in cells)
                            t1.Add(cell.ToString());
                    }
                }

                MessageBox.Show("Вітаємо!\nВаш код - "+t1[0]+"\nПароль - 1234", "Реєстрація пройшла успішно", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Close();
            }
            else
            {
                MessageBox.Show("Ви є нашим клієнтом, або неправильно ввели номер паспорту", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
