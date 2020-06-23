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
    public partial class EditAddEmployee : Form
    {
        private readonly int id;
        public EditAddEmployee()
        {
            InitializeComponent();
        }

        public EditAddEmployee(int id, string last, string name, string patr, string pos, string nomer, string adres) : this()
        {
            this.id = id;
            emLastNameTextBox.Text = last;
            emNameTextBox.Text = name;
            emPatronymicTextBox.Text = patr;
            emPositionTextBox.Text = pos;
            emPhoneTextBox.Text = nomer;
            emAdressTextBox.Text = adres;
        }

        private void EditAddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserBank.edit)
            {
                SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
                sqlconn.Open();
                SqlCommand query = new SqlCommand("UPDATE Employee SET EmLastName=@Last, EmName=@Name, EmPatronymic=@Patr, EmPosition=@Pos, EmPhone=@Ph, EmAdress=@Adres WHERE Id_employee=" + id.ToString() + ";", sqlconn);

                query.Parameters.AddWithValue("@Last", emLastNameTextBox.Text);
                query.Parameters.AddWithValue("@Name", emNameTextBox.Text);
                query.Parameters.AddWithValue("@Patr", emPatronymicTextBox.Text);
                query.Parameters.AddWithValue("@Pos", emPositionTextBox.Text);
                query.Parameters.AddWithValue("@Ph", emPhoneTextBox.Text);
                query.Parameters.AddWithValue("@Adres", emAdressTextBox.Text);
                query.ExecuteNonQuery();
                sqlconn.Close();
                bankDataSet.AcceptChanges();
            }
            else
            {
                SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
                sqlconn.Open();
                SqlCommand query = new SqlCommand(" INSERT INTO Employee(EmLastName, EmName, EmPatronymic, EmPosition, EmPhone, EmAdress) VALUES ( @Last, @Name, @Patr, @Pos, @Ph, @Adres) ", sqlconn);

                query.Parameters.AddWithValue("@Last", emLastNameTextBox.Text);
                query.Parameters.AddWithValue("@Name", emNameTextBox.Text);
                query.Parameters.AddWithValue("@Patr", emPatronymicTextBox.Text);
                query.Parameters.AddWithValue("@Pos", emPositionTextBox.Text);
                query.Parameters.AddWithValue("@Ph", emPhoneTextBox.Text);
                query.Parameters.AddWithValue("@Adres", emAdressTextBox.Text);
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
