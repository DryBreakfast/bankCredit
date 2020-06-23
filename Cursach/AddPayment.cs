using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cursach
{
    public partial class AddPayment : Form
    {
        public AddPayment()
        {
            InitializeComponent();
        }
        List<string> t = new List<string>();
        private void AddPayment_Load(object sender, EventArgs e)
        {
            textBox1.Text = UserPassword.id.ToString();
            string g = DateTime.Now.ToString();
            g = DateTime.Parse(g).ToShortDateString();
            textBox2.Text = g;

            
            SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
            SqlDataAdapter query = new SqlDataAdapter("SELECT Payment.PDateTo, Payment.PPenya, Payment.Id_agreement, Agreement.ASumm, Credit.CrRersent, Payment.Id_payment FROM Payment, Agreement,Credit WHERE Agreement.Id_client=" + UserPassword.id + " AND Agreement.Id_agreement=Payment.Id_agreement AND Agreement.Id_credit=Credit.Id_credit AND Payment.PDate IS NULL;", sqlconn);
            
            DataSet ds = new DataSet();
            query.Fill(ds);
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                        t.Add(cell.ToString());
                }
            }
            t[0] = DateTime.Parse(t[0]).ToShortDateString();
            textBox3.Text=t[0];
            if (t[1] != null) textBox4.Text = Convert.ToString(Convert.ToDouble(t[1]));
            else textBox4.Text = "0";
            textBox5.Text = t[2];
            textBox7.Text = Convert.ToString(Convert.ToDouble(t[3]));
            textBox9.Text = t[4];
            textBox8.Text = Convert.ToString(Math.Round(Convert.ToDouble(textBox7.Text) + (Convert.ToDouble(textBox7.Text) * Convert.ToDouble(textBox9.Text)/100) + Convert.ToDouble(textBox4.Text),2));
            textBox6.Text = textBox8.Text;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(textBox6.Text)>Convert.ToDouble(textBox8.Text))
            {
                MessageBox.Show(
                        "Сума до сплати більша, ніж загальна сума заборгованості",
                        "Помилка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
            }
            else if (Convert.ToDouble(textBox6.Text) < Convert.ToDouble(textBox4.Text) + (Convert.ToDouble(textBox7.Text) * Convert.ToDouble(textBox9.Text) / 100))
            {
                MessageBox.Show(
                        "Сума до сплати має бути більша, ніж покриття відсотка та пені (>"+ Convert.ToDouble(textBox4.Text) + (Convert.ToDouble(textBox7.Text) * Convert.ToDouble(textBox9.Text) / 100) + ")",
                        "Помилка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
            }
            else
            {
                DialogResult h=MessageBox.Show("Підтвердити сплату?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                if (h == DialogResult.Yes)
                {
                    SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
                    sqlconn.Open();
                    SqlCommand query = new SqlCommand("UPDATE Payment SET PDate=current_timestamp, PDateTo=@To, PSumm=@Summ, PPenya=@Penya, Id_agreement=@Id WHERE Id_payment=" + t[5].ToString(), sqlconn);
                    
                    query.Parameters.AddWithValue("@To", Convert.ToDateTime(textBox3.Text));
                    query.Parameters.AddWithValue("@Summ", Convert.ToDecimal(textBox6.Text));
                    query.Parameters.AddWithValue("@Penya", Convert.ToDecimal(textBox4.Text));
                    query.Parameters.AddWithValue("@Id", Convert.ToInt32(textBox5.Text));
                    query.ExecuteNonQuery();
                    sqlconn.Close();
                    Close();
                    bankDataSet.AcceptChanges();
                    if(Convert.ToDouble(textBox6.Text) == Convert.ToDouble(textBox8.Text))
                    {

                        SqlConnection sqLconn = new SqlConnection(UserBank.ConnectionString);
                        sqLconn.Open();
                        SqlCommand qUery = new SqlCommand("UPDATE Agreement SET ASumm=0 WHERE Id_agreement=" + textBox5.Text + ";", sqLconn);
                        qUery.ExecuteNonQuery();
                        sqLconn.Close();

                        MessageBox.Show(
                        "Сплату проведено успішно, квитанцію надішлено, кредит погашено \nДякуємо!",
                       "Інформація",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                        bankDataSet.AcceptChanges();
                    }
                    else
                    {

                        var ostatok = (Convert.ToDouble(textBox7.Text) - (Convert.ToDouble(textBox6.Text) - Convert.ToDouble(textBox4.Text) - (Convert.ToDouble(textBox7.Text) * Convert.ToDouble(textBox9.Text) / 100))).ToString();
                        string f = "";
                        foreach (char i in ostatok)
                            if (i == ',') f += '.';
                            else f += i;

                        SqlConnection sql = new SqlConnection(UserBank.ConnectionString);
                        sql.Open();
                        SqlCommand quer = new SqlCommand("UPDATE Agreement SET ASumm=" + f + " WHERE Id_agreement=" + textBox5.Text + ";", sql);

                        quer.ExecuteNonQuery();
                        sql.Close();


                        var l = (Convert.ToDateTime(textBox3.Text)).AddMonths(1);

                        SqlConnection sqlConn = new SqlConnection(UserBank.ConnectionString);
                        sqlConn.Open();
                        SqlCommand Query = new SqlCommand(" INSERT INTO Payment(PDate, PDateTo, PSumm, PPenya, Id_agreement) VALUES (null, @To, null, 0, @Id) ", sqlConn);

                        Query.Parameters.AddWithValue("@To", l);
                        Query.Parameters.AddWithValue("@Id", textBox5.Text);
                        Query.ExecuteNonQuery();
                        sqlConn.Close();

                        MessageBox.Show(
                        "Сплату проведено успішно, квитанцію надішлено\nНаступний платіж має поступити до " + (Convert.ToDateTime(textBox3.Text)).AddMonths(1) + "\nДякуємо!",
                       "Інформація",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1);
                        bankDataSet.AcceptChanges();
                    }
                }  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
