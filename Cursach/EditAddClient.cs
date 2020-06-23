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
    public partial class EditAddClient : Form
    {
        private readonly int id;
        public EditAddClient()
        {
            InitializeComponent();
        }

        public EditAddClient(int id, string num, string last, string name, string per, string adress, string nomer, string work, decimal money) : this()
        {

            this.id = id;
            cId_passportTextBox.Text = num;
            cLastNameTextBox.Text = last;
            cNameTextBox.Text = name;
            cPatronymicTextBox.Text = per;
            cAdressTextBox.Text = adress;
            cPhoneTextBox.Text = nomer;
            cWorkTextBox.Text = work;
            cSalaryTextBox.Text = Convert.ToString(Convert.ToDouble(money));
        }



        private void EditAddClient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserBank.edit)
            {
                SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
                sqlconn.Open();
                SqlCommand query = new SqlCommand("UPDATE Client SET CId_passport=@Passport, CLastName=@Last, CName=@Name, CPatronymic=@Patr, CAdress=@Adres, CPhone=@Ph, CWork=@Work, CSalary=@Sal WHERE Id_client=" + id.ToString() + ";", sqlconn);

                query.Parameters.AddWithValue("@Passport", cId_passportTextBox.Text);
                query.Parameters.AddWithValue("@Last", cLastNameTextBox.Text);
                query.Parameters.AddWithValue("@Name", cNameTextBox.Text);
                query.Parameters.AddWithValue("@Patr", cPatronymicTextBox.Text);
                query.Parameters.AddWithValue("@Adres", cAdressTextBox.Text);
                query.Parameters.AddWithValue("@Ph", cPhoneTextBox.Text);
                query.Parameters.AddWithValue("@Work", cWorkTextBox.Text);
                query.Parameters.AddWithValue("@Sal", Convert.ToDecimal(cSalaryTextBox.Text));
                query.ExecuteNonQuery();
                sqlconn.Close();
                bankDataSet.AcceptChanges();
            }
            else
            {
                SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
                sqlconn.Open();
                SqlCommand query = new SqlCommand("INSERT INTO Client( CId_passport, CLastName, CName, CPatronymic, CAdress, CPhone, CWork, CSalary) VALUES ( @Passport, @Last, @Name, @Patr, @Adres, @Ph, @Work, @Sal)", sqlconn);
                
                query.Parameters.AddWithValue("@Passport", cId_passportTextBox.Text);
                query.Parameters.AddWithValue("@Last", cLastNameTextBox.Text);
                query.Parameters.AddWithValue("@Name", cNameTextBox.Text);
                query.Parameters.AddWithValue("@Patr", cPatronymicTextBox.Text);
                query.Parameters.AddWithValue("@Adres", cAdressTextBox.Text);
                query.Parameters.AddWithValue("@Ph", cPhoneTextBox.Text);
                query.Parameters.AddWithValue("@Work", cWorkTextBox.Text);
                query.Parameters.AddWithValue("@Sal", cSalaryTextBox.Text);
                query.ExecuteNonQuery();
                sqlconn.Close();
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
