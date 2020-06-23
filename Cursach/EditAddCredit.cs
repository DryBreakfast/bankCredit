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
    public partial class EditAddCredit : Form
    {
        private readonly int id;
        public EditAddCredit()
        {
            InitializeComponent();
        }

        public EditAddCredit(int id, string name, string last, string per, string cause) : this()
        {
            this.id = id;
            crNameTextBox.Text = name;
            switch (last)
            {
                case "Онкольний":
                    comboBox1.SelectedIndex = 0;
                    break;
                case "Овернайт":
                    comboBox1.SelectedIndex = 1;
                    break;
                case "Надстроковий":
                    comboBox1.SelectedIndex = 2;
                    break;
                case "Короткостроковий":
                    comboBox1.SelectedIndex = 3;
                    break;
                case "Середньостроковий":
                    comboBox1.SelectedIndex = 4;
                    break;
                case "Довгостроковий":
                    comboBox1.SelectedIndex = 5;
                    break;
                default:
                    comboBox1.SelectedIndex = 4;
                    break;
            }
            crRersentTextBox.Text = per.ToString();
            crCauseTextBox.Text = cause;
        }


        private void EditAddCredit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typ = "";
            if (comboBox1.SelectedIndex == 0)
            {
                typ = "Онкольний";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                typ = "Овернайт";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                typ = "Надстроковий";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                typ = "Короткостроковий";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                typ = "Середньостроковий";
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                typ = "Довгостроковий";
            }
            if (UserBank.edit)
            {
                SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
                sqlconn.Open();
                SqlCommand query = new SqlCommand("UPDATE Credit SET CrName=@Name, CrType=@Type, CrRersent=@Persent, CrCause=@Cause WHERE Id_credit=" + id.ToString()+";", sqlconn);

                query.Parameters.AddWithValue("@Name", crNameTextBox.Text);
                query.Parameters.AddWithValue("@Type", typ);
                query.Parameters.AddWithValue("@Persent", crRersentTextBox.Text);
                query.Parameters.AddWithValue("@Cause", crCauseTextBox.Text);
                query.ExecuteNonQuery();
                sqlconn.Close();
                bankDataSet.AcceptChanges();
            }
            else
            {
                SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
                sqlconn.Open();
                SqlCommand query = new SqlCommand(" INSERT INTO Credit( CrName, CrType, CrRersent, CrCause) VALUES ( @Name, @Type, @Persent, @Cause) ", sqlconn);

                query.Parameters.AddWithValue("@Name", crNameTextBox.Text);
                query.Parameters.AddWithValue("@Type", typ);
                query.Parameters.AddWithValue("@Persent", crRersentTextBox.Text);
                query.Parameters.AddWithValue("@Cause", crCauseTextBox.Text);
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
