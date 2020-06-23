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
    public partial class EditAddInsurance : Form
    {
        public EditAddInsurance()
        {
            InitializeComponent();
        }
        

        public EditAddInsurance(int id,string name, decimal summ, string form) : this()
        {
            if (UserBank.edit)
            {            
                iFirmTextBox.Text = name;
                iSummaTextBox.Text = summ.ToString();
                iFormTextBox.Text = form;
                comboBox1.Text = id.ToString();
            }
            
        }

        private void EditAddInsurance_Load(object sender, EventArgs e)
        {
            if (UserBank.edit)
            {
                label1.Visible = false;
                comboBox1.Visible = false;
            }
            else
            {

                SqlConnection sqlcon = new SqlConnection(UserBank.ConnectionString);
                SqlDataAdapter quer = new SqlDataAdapter("SELECT DISTINCT Id_agreement FROM Agreement WHERE Id_agreement NOT IN(SELECT Id_agreement FROM Insurance);", sqlcon);
                DataTable t = new DataTable();
                quer.Fill(t);
                comboBox1.DataSource = t;
                comboBox1.DisplayMember = "Id_agreement";
                label1.Visible = true;
                comboBox1.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserBank.edit)
            {
                SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
                sqlconn.Open();
                SqlCommand query = new SqlCommand("UPDATE Insurance SET IFirm=@Name, ISumma=@Summ, IForm=@Form WHERE Id_agreement=" + comboBox1.Text + ";", sqlconn);

                query.Parameters.AddWithValue("@Name", iFirmTextBox.Text);
                query.Parameters.AddWithValue("@Summ", iSummaTextBox.Text);
                query.Parameters.AddWithValue("@Form", iFormTextBox.Text);
                query.ExecuteNonQuery();
                sqlconn.Close();
                bankDataSet.AcceptChanges();
            }
            else
            {
                SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
                sqlconn.Open();
                SqlCommand query = new SqlCommand(" INSERT INTO Insurance( Id_agreement, IFirm, ISumma, IForm) VALUES ( @Name, @Type, @Persent, @Cause) ", sqlconn);

                query.Parameters.AddWithValue("@Name", comboBox1.Text);
                query.Parameters.AddWithValue("@Type", iFirmTextBox.Text);
                query.Parameters.AddWithValue("@Persent", iSummaTextBox.Text);
                query.Parameters.AddWithValue("@Cause", iFormTextBox.Text);
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
