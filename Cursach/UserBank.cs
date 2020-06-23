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
    public partial class UserBank : Form
    {
        public static bool edit;
        public const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ХНУРЭ\2 курс\Cursach\Cursach\Bank.mdf;Integrated Security=True";
        public UserBank()
        {
            InitializeComponent();
        }

        String[] list1 = new String [] { "Номер паспорту", "Прізвище", "Ім'я", "По батькові", "Домашня адреса", "Номер телефону", "Місце роботи", "Заробітна плата" };
        String[] list2 = new String[] { "Прізвище", "Ім'я", "По батькові", "Посада", "Номер телефону", "Домашня адреса" };
        String[] list3 = new String[] { "Назва", "Тип", "Відсоткова ставка", "Додаткові умови" };
        String[] list4 = new String[] { "Дата (з)", "Дата (по)", "Тип", "Сума", "Пеня", "Клієнт", "Працівник", "Кредит" };
        String[] list5 = new String[] { "Номер договору", "Фірма", "Сума", "Форма" };
        String[] list6 = new String[] { "Дата сплати", "Строк сплати", "Сума", "Пеня", "Номер договору" };
        public void Client()
        {
            ArrayList empty = new ArrayList();
            dataGridView1.DataSource = empty;
            label1.Text = "КЛІЄНТИ";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Client;", sqlconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].HeaderText = "Код клієнта";
            dataGridView1.Columns[1].HeaderText = "Номер паспорту";
            dataGridView1.Columns[2].HeaderText = "Прізвище";
            dataGridView1.Columns[3].HeaderText = "Ім'я";
            dataGridView1.Columns[4].HeaderText = "По батькові";
            dataGridView1.Columns[5].HeaderText = "Домашня адреса";
            dataGridView1.Columns[6].HeaderText = "Номер телефону";
            dataGridView1.Columns[7].HeaderText = "Місце роботи";
            dataGridView1.Columns[8].HeaderText = "Заробітна плата";
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(list1);
            змінитиToolStripMenuItem.Enabled = true;
            додатиToolStripMenuItem.Enabled = true;
        }
        public void Employee()
        {
            ArrayList empty = new ArrayList();
            dataGridView1.DataSource = empty;
            label1.Text = "ПРАЦІВНИКИ";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employee;", sqlconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].HeaderText = "Код працівника";
            dataGridView1.Columns[1].HeaderText = "Прізвище";
            dataGridView1.Columns[2].HeaderText = "Ім'я";
            dataGridView1.Columns[3].HeaderText = "По батькові";
            dataGridView1.Columns[4].HeaderText = "Посада";
            dataGridView1.Columns[5].HeaderText = "Номер телефону";
            dataGridView1.Columns[6].HeaderText = "Домашня адреса";
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(list2);
            SqlDataAdapter que = new SqlDataAdapter("SELECT DISTINCT EmPosition FROM Employee;", sqlconn);
            DataTable t1 = new DataTable();
            que.Fill(t1);
            comboBox1.DataSource = t1;
            comboBox1.DisplayMember = "EmPosition";
            змінитиToolStripMenuItem.Enabled = true;
            додатиToolStripMenuItem.Enabled = true;
        }
        public void Credit()
        {
            ArrayList empty = new ArrayList();
            dataGridView1.DataSource = empty;
            label1.Text = "КРЕДИТИ";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Credit;", sqlconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Назва";
            dataGridView1.Columns[2].HeaderText = "Тип";
            dataGridView1.Columns[3].HeaderText = "Відсоткова ставка";
            dataGridView1.Columns[4].HeaderText = "Додаткові умови";
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(list3);
            змінитиToolStripMenuItem.Enabled = true;
            додатиToolStripMenuItem.Enabled = true;
        }

        public void Agreement()
        {
            ArrayList empty = new ArrayList();
            dataGridView1.DataSource = empty;
            label1.Text = "КРЕДИТНІ ДОГОВОРИ";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Agreement;", sqlconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].HeaderText = "Номер договору";
            dataGridView1.Columns[1].HeaderText = "Дата (з)";
            dataGridView1.Columns[2].HeaderText = "Дата (по)";
            dataGridView1.Columns[3].HeaderText = "Тип";
            dataGridView1.Columns[4].HeaderText = "Сума";
            dataGridView1.Columns[5].HeaderText = "Пеня";
            dataGridView1.Columns[6].HeaderText = "Клієнт";
            dataGridView1.Columns[7].HeaderText = "Працівник";
            dataGridView1.Columns[8].HeaderText = "Кредит";
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(list4);
            змінитиToolStripMenuItem.Enabled = true;
            додатиToolStripMenuItem.Enabled = true;
        }

        public void Insurance()
        {
            ArrayList empty = new ArrayList();
            dataGridView1.DataSource = empty;
            label1.Text = "СТРАХУВАННЯ";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Insurance;", sqlconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Номер договору";
            dataGridView1.Columns[1].HeaderText = "Фірма";
            dataGridView1.Columns[2].HeaderText = "Сума";
            dataGridView1.Columns[3].HeaderText = "Форма";
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(list5);
            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            SqlDataAdapter quer = new SqlDataAdapter("SELECT DISTINCT IFirm FROM Insurance;", sqlcon);
            DataTable t = new DataTable();
            quer.Fill(t);
            comboBox3.DataSource = t;
            comboBox3.DisplayMember = "IFirm";
            
            SqlDataAdapter que = new SqlDataAdapter("SELECT DISTINCT IForm FROM Insurance;", sqlcon);
            DataTable t1 = new DataTable();
            que.Fill(t1);
            comboBox4.DataSource = t1;
            comboBox4.DisplayMember = "IForm";
            змінитиToolStripMenuItem.Enabled = true;
            додатиToolStripMenuItem.Enabled = true;
        }

        public void Payment()
        {
            ArrayList empty = new ArrayList();
            dataGridView1.DataSource = empty;
            label1.Text = "ПЛАТЕЖІ";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Payment;", sqlconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Дата сплати";
            dataGridView1.Columns[2].HeaderText = "Строк сплати";
            dataGridView1.Columns[3].HeaderText = "Сума";
            dataGridView1.Columns[4].HeaderText = "Пеня";
            dataGridView1.Columns[5].HeaderText = "Номер договору";
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(list6);
            змінитиToolStripMenuItem.Enabled = false;
            додатиToolStripMenuItem.Enabled = false;            
        }

        private void UserBank_Load_1(object sender, EventArgs e)
        {
            Client();
            dataGridView1.AutoGenerateColumns = true;
        }
        private void клієнтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            редагуватиToolStripMenuItem.Enabled = true;
            Client();
            if (textBox2.Visible == true)
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                button3.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
            if (label11.Visible == true)
            {
                label11.Visible = false;
                button3.Visible = false;
                comboBox1.Visible = false;
            }
            if (textBox8.Visible == true)
            {
                label15.Visible = false;
                label14.Visible = false;
                label13.Visible = false;
                label12.Visible = false;
                button3.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                comboBox2.Visible = false;
            }
            if (label16.Visible == true)
            {
                label16.Visible = false;
                label17.Visible = false;
                button3.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
            }
            if (label18.Visible == true)
            {
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                button3.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
            if (label8.Visible == true)
            {
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                button3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                dateTimePicker3.Visible = false;
                dateTimePicker4.Visible = false;
            }

        }

        private void працівникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            редагуватиToolStripMenuItem.Enabled = true;
            Employee();
            if (textBox2.Visible == true)
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                button3.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
            if (label11.Visible == true)
            {
                label11.Visible = false;
                button3.Visible = false;
                comboBox1.Visible = false;
            }
            if (textBox8.Visible == true)
            {
                label15.Visible = false;
                label14.Visible = false;
                label13.Visible = false;
                label12.Visible = false;
                button3.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                comboBox2.Visible = false;
            }
            if (label16.Visible == true)
            {
                label16.Visible = false;
                label17.Visible = false;
                button3.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
            }
            if (label18.Visible == true)
            {
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                button3.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
            if (label8.Visible == true)
            {
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                button3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                dateTimePicker3.Visible = false;
                dateTimePicker4.Visible = false;
            }

        }

        private void кредитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            редагуватиToolStripMenuItem.Enabled = true;
            Credit();
            if (textBox2.Visible == true)
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                button3.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
            if (label11.Visible == true)
            {
                label11.Visible = false;
                button3.Visible = false;
                comboBox1.Visible = false;
            }
            if (textBox8.Visible == true)
            {
                label15.Visible = false;
                label14.Visible = false;
                label13.Visible = false;
                label12.Visible = false;
                button3.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                comboBox2.Visible = false;
            }
            if (label16.Visible == true)
            {
                label16.Visible = false;
                label17.Visible = false;
                button3.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
            }
            if (label18.Visible == true)
            {
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                button3.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
            if (label8.Visible == true)
            {
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                button3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                dateTimePicker3.Visible = false;
                dateTimePicker4.Visible = false;
            }
        }

        private void кредитніДоговориToolStripMenuItem_Click(object sender, EventArgs e)
        {
            редагуватиToolStripMenuItem.Enabled = true;
            Agreement();
            if (textBox2.Visible == true)
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                button3.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
            if (label11.Visible == true)
            {
                label11.Visible = false;
                button3.Visible = false;
                comboBox1.Visible = false;
            }
            if (textBox8.Visible == true)
            {
                label15.Visible = false;
                label14.Visible = false;
                label13.Visible = false;
                label12.Visible = false;
                button3.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                comboBox2.Visible = false;
            }
            if (label16.Visible == true)
            {
                label16.Visible = false;
                label17.Visible = false;
                button3.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
            }
            if (label18.Visible == true)
            {
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                button3.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
            if (label8.Visible == true)
            {
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                button3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                dateTimePicker3.Visible = false;
                dateTimePicker4.Visible = false;
            }
        }

        private void страхуванняToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            редагуватиToolStripMenuItem.Enabled = true;
            Insurance();
            if (textBox2.Visible == true)
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                button3.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
            if (label11.Visible == true)
            {
                label11.Visible = false;
                button3.Visible = false;
                comboBox1.Visible = false;
            }
            if (textBox8.Visible == true)
            {
                label15.Visible = false;
                label14.Visible = false;
                label13.Visible = false;
                label12.Visible = false;
                button3.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                comboBox2.Visible = false;
            }
            if (label16.Visible == true)
            {
                label16.Visible = false;
                label17.Visible = false;
                button3.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
            }
            if (label18.Visible == true)
            {
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                button3.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
            if (label8.Visible == true)
            {
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                button3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                dateTimePicker3.Visible = false;
                dateTimePicker4.Visible = false;
            }
        }

        private void платежіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            редагуватиToolStripMenuItem.Enabled = true;
            Payment();
            if (textBox2.Visible == true)
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                button3.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
            if (label11.Visible == true)
            {
                label11.Visible = false;
                button3.Visible = false;
                comboBox1.Visible = false;
            }
            if (textBox8.Visible == true)
            {
                label15.Visible = false;
                label14.Visible = false;
                label13.Visible = false;
                label12.Visible = false;
                button3.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                comboBox2.Visible = false;
            }
            if (label16.Visible == true)
            {
                label16.Visible = false;
                label17.Visible = false;
                button3.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
            }
            if (label18.Visible == true)
            {
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                button3.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
            if (label8.Visible == true)
            {
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                button3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                dateTimePicker3.Visible = false;
                dateTimePicker4.Visible = false;
            }
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label1.Text == "КЛІЄНТИ")
            {
                DialogResult h = MessageBox.Show("Ви точно хочете видалити цей запис?","Підтвердження",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
                if (h == DialogResult.Yes)
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlCommand query = new SqlCommand("DELETE FROM Client WHERE Id_client=" + Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value) + ";", sqlconn);
                    query.ExecuteNonQuery();
                    sqlconn.Close();
                    Client();
                    bankDataSet.AcceptChanges();
                }
            }
            else if (label1.Text == "ПРАЦІВНИКИ")
            {

                DialogResult h = MessageBox.Show("Ви точно хочете видалити цей запис?","Підтвердження",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
                if (h == DialogResult.Yes)
                {
                    string g = "Клерк";
                    var t = new List<string>();
                    SqlConnection sqlcon = new SqlConnection(ConnectionString);
                    sqlcon.Open();
                    SqlCommand query = new SqlCommand("SELECT Id_employee FROM Employee WHERE EmPosition=@a AND Id_employee=(SELECT MAX(Id_employee) FROM Employee);", sqlcon);
                    query.Parameters.AddWithValue("@a", g);

                    query.ExecuteNonQuery();
                    sqlcon.Close();

                    SqlDataAdapter quer = new SqlDataAdapter(query);
                    
                    DataSet ds = new DataSet();
                    quer.Fill(ds);
                    foreach (DataTable dt in ds.Tables)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            var cells = row.ItemArray;
                            foreach (object cell in cells)
                                t.Add(cell.ToString());
                        }
                    }


                    SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
                    sqlconn.Open();
                    SqlCommand que = new SqlCommand("UPDATE Agreement SET Id_employee=" + t[0] + " WHERE Id_employee=@a ; ", sqlconn);
                    que.Parameters.AddWithValue("@a", Convert.ToInt32(dataGridView1[0, dataGridView1.SelectedCells[0].RowIndex].Value));
                    que.ExecuteNonQuery();
                    sqlconn.Close();
                    bankDataSet.AcceptChanges();


                    sqlconn.Open();
                    SqlCommand query1 = new SqlCommand("DELETE FROM Employee WHERE Id_employee=" + Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value) + ";", sqlconn);
                    query1.ExecuteNonQuery();
                    sqlconn.Close();
                    Employee();
                    bankDataSet.AcceptChanges();
                }
            }
            else if (label1.Text == "КРЕДИТИ")
            {
                DialogResult h = MessageBox.Show(
                        "Ви точно хочете видалити цей запис?",
                        "Підтвердження",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button2);
                if (h == DialogResult.Yes)
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlCommand query = new SqlCommand("DELETE FROM Credit WHERE Id_credit=" + Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value) + ";", sqlconn);
                    query.ExecuteNonQuery();
                    sqlconn.Close();
                    Credit();
                    bankDataSet.AcceptChanges();
                }
            }
            else if (label1.Text == "КРЕДИТНІ ДОГОВОРИ")
            {
                DialogResult h = MessageBox.Show(
                        "Ви точно хочете видалити цей запис?",
                        "Підтвердження",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button2);
                if (h == DialogResult.Yes)
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlCommand query = new SqlCommand("DELETE FROM Agreement WHERE Id_agreement=" + Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value) + ";", sqlconn);
                    query.ExecuteNonQuery();
                    sqlconn.Close();
                    Agreement();
                    bankDataSet.AcceptChanges();
                }
            }
            else if (label1.Text == "СТРАХУВАННЯ")
            {
                DialogResult h = MessageBox.Show(
                        "Ви точно хочете видалити цей запис?",
                        "Підтвердження",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button2);
                if (h == DialogResult.Yes)
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlCommand query = new SqlCommand("DELETE FROM Insurance WHERE Id_agreement=" + Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value) + ";", sqlconn);
                    query.ExecuteNonQuery();
                    sqlconn.Close();
                    Insurance();
                    bankDataSet.AcceptChanges();
                }
            }
            else if (label1.Text == "ПЛАТЕЖІ")
            {
                DialogResult h = MessageBox.Show(
                        "Ви точно хочете видалити цей запис?",
                        "Підтвердження",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button2);
                if (h == DialogResult.Yes)
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlCommand query = new SqlCommand("DELETE FROM Payment WHERE Id_payment=" + Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value) + ";", sqlconn);
                    query.ExecuteNonQuery();
                    sqlconn.Close();
                    Payment();
                    bankDataSet.AcceptChanges();
                }
            }
            bankDataSet.AcceptChanges();
        }

        private void змінитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit = true;
            if (label1.Text == "КЛІЄНТИ")
            {
                var edt = new EditAddClient(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value),
                    dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString(),
                    dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString(),
                    dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString(),
                    dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString(),
                    dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString(),
                    dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString(),
                    dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString(),
                    Convert.ToDecimal(Convert.ToDouble(dataGridView1[8, dataGridView1.CurrentRow.Index].Value)));
                edt.ShowDialog();
                bankDataSet.AcceptChanges();
                Client();
            }
            else if (label1.Text == "ПРАЦІВНИКИ")
            {
                var edt = new EditAddEmployee(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value),
                    dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString(),
                    dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString(),
                    dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString(),
                    dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString(),
                    dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString(),
                    dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString());
                edt.ShowDialog();
                bankDataSet.AcceptChanges();
                Employee();
            }
            else if (label1.Text == "КРЕДИТИ")
            {
                var edt = new EditAddCredit(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value),
                    dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString(),
                    dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString(),
                    dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString(),
                    dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString());
                edt.ShowDialog();
                bankDataSet.AcceptChanges();
                Credit();
            }
            else if (label1.Text == "КРЕДИТНІ ДОГОВОРИ")
            {
                var edt = new EditAddAgreement(Convert.ToInt32(dataGridView1[0, dataGridView1.SelectedCells[0].RowIndex].Value),
                     Convert.ToDateTime(dataGridView1[1, dataGridView1.SelectedCells[0].RowIndex].Value),
                     Convert.ToDateTime(dataGridView1[2, dataGridView1.SelectedCells[0].RowIndex].Value),
                     dataGridView1[3, dataGridView1.SelectedCells[0].RowIndex].Value.ToString(),
                     Convert.ToDecimal(Convert.ToDouble(dataGridView1[4, dataGridView1.SelectedCells[0].RowIndex].Value)),
                     Convert.ToDecimal(Convert.ToDouble(dataGridView1[5, dataGridView1.SelectedCells[0].RowIndex].Value)),
                     Convert.ToInt32(dataGridView1[6, dataGridView1.SelectedCells[0].RowIndex].Value),
                     Convert.ToInt32(dataGridView1[7, dataGridView1.SelectedCells[0].RowIndex].Value),
                     Convert.ToInt32(dataGridView1[8, dataGridView1.SelectedCells[0].RowIndex].Value));
                edt.ShowDialog();
                agreementTableAdapter.Update(bankDataSet);
                insuranceTableAdapter.Update(bankDataSet);
                bankDataSet.AcceptChanges();
                Agreement();
            }
            else if (label1.Text == "СТРАХУВАННЯ")
            {
                var edt = new EditAddInsurance(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value),
                    dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString(),
                    Convert.ToDecimal(Convert.ToDouble(dataGridView1[2, dataGridView1.CurrentRow.Index].Value)),
                    dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString());
                edt.ShowDialog();
                bankDataSet.AcceptChanges();
                Insurance();
            }

            bankDataSet.AcceptChanges();
        }

        private void наГоловнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main newForm = new Main();
            newForm.ShowDialog();
            this.Close();
        }

        private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit = false;
            clientTableAdapter.Update(bankDataSet);
            employeeTableAdapter.Update(bankDataSet);
            creditTableAdapter.Update(bankDataSet);
            agreementTableAdapter.Update(bankDataSet);
            insuranceTableAdapter.Update(bankDataSet);

            if (label1.Text == "КЛІЄНТИ")
            {
                EditAddClient newForm = new EditAddClient();
                newForm.ShowDialog();
                Client();
                bankDataSet.AcceptChanges();
            }
            else if (label1.Text == "ПРАЦІВНИКИ")
            {
                EditAddEmployee newForm = new EditAddEmployee();
                newForm.ShowDialog();
                Employee();
                bankDataSet.AcceptChanges();
            }
            else if (label1.Text == "КРЕДИТИ")
            {
                EditAddCredit newForm = new EditAddCredit();
                newForm.ShowDialog();
                Credit();
                bankDataSet.AcceptChanges();
            }
            else if (label1.Text == "КРЕДИТНІ ДОГОВОРИ")
            {
                EditAddAgreement newForm = new EditAddAgreement();
                newForm.ShowDialog();
                bankDataSet.AcceptChanges();
                Agreement();
                agreementTableAdapter.Update(bankDataSet);
                insuranceTableAdapter.Update(bankDataSet);
                EditAddInsurance newForm1 = new EditAddInsurance();
                newForm1.ShowDialog();
                bankDataSet.AcceptChanges();
            }
            else if (label1.Text == "СТРАХУВАННЯ")
            {
                agreementTableAdapter.Update(bankDataSet);
                EditAddInsurance newForm1 = new EditAddInsurance();
                newForm1.ShowDialog();
                Insurance();
                bankDataSet.AcceptChanges();
            }
            bankDataSet.AcceptChanges();

        }

        private void занятістьПрацівниківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            редагуватиToolStripMenuItem.Enabled = false;
            label1.Text = "ЗАНЯТІСТЬ ПРАЦІВНИКІВ";

            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlDataAdapter query = new SqlDataAdapter("SELECT DISTINCT Employee.Id_employee , Employee.EmLastName, Employee.EmName, Employee.EmPatronymic, COUNT(Agreement.Id_employee) FROM Employee JOIN Agreement ON Agreement.Id_employee=Employee.Id_employee GROUP BY Employee.Id_employee, Employee.EmLastName, Employee.EmName, Employee.EmPatronymic;", sqlconn);
            ArrayList empty = new ArrayList();
            dataGridView1.DataSource = empty;
            DataTable dt = new DataTable();
            query.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Номер працівника";
            dataGridView1.Columns[1].HeaderText = "Прізвище";
            dataGridView1.Columns[2].HeaderText = "Ім'я";
            dataGridView1.Columns[3].HeaderText = "По батькові";
            dataGridView1.Columns[4].HeaderText = "Кількість оформлених договорів";
            bankDataSet.AcceptChanges();
        }

        private void UserBank_FormClosing(object sender, FormClosingEventArgs e)
        {
            bankDataSet.AcceptChanges();
            clientTableAdapter.Update(bankDataSet);
            employeeTableAdapter.Update(bankDataSet);
            creditTableAdapter.Update(bankDataSet);
            agreementTableAdapter.Update(bankDataSet);
            insuranceTableAdapter.Update(bankDataSet);
            paymentTableAdapter.Update(bankDataSet);
        }

        private void типиКредитівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            редагуватиToolStripMenuItem.Enabled = false;
            label1.Text = "ТИПИ КРЕДИТІВ";

            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlDataAdapter query = new SqlDataAdapter("SELECT Credit.CrType AS [Тип кредиту], COUNT(Agreement.Id_credit) AS [Кількість] FROM Agreement, Credit WHERE Agreement.Id_credit=Credit.Id_credit GROUP BY Credit.CrType ", sqlconn);
            ArrayList empty = new ArrayList();
            dataGridView1.DataSource = empty;
            DataTable dt = new DataTable();
            query.Fill(dt);
            dataGridView1.DataSource = dt;

            bankDataSet.AcceptChanges();
        }

        private void загальнаЗаборгованністьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            редагуватиToolStripMenuItem.Enabled = false;
            label1.Text = "ЗАГАЛЬНА ЗАБОРГОВАНІСТЬ";

            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlDataAdapter query = new SqlDataAdapter("SELECT Client.Id_client, Client.CLastName, Client.CName, Client.CPatronymic, cast(ROUND(SUM(Agreement.ASumm+(Agreement.ASumm*Credit.CrRersent/100)),2) as numeric(36,2)) FROM Client, Agreement, Credit WHERE Agreement.Id_client=Client.Id_client AND Agreement.Id_credit=Credit.Id_credit GROUP BY Client.Id_client, Client.CLastName, Client.CName, Client.CPatronymic;", sqlconn);
            ArrayList empty = new ArrayList();
            dataGridView1.DataSource = empty;
            DataTable dt = new DataTable();
            query.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Номер клієнта";
            dataGridView1.Columns[1].HeaderText = "Прізвище";
            dataGridView1.Columns[2].HeaderText = "Ім'я";
            dataGridView1.Columns[3].HeaderText = "По батькові";
            dataGridView1.Columns[4].HeaderText = "Загалом";
            bankDataSet.AcceptChanges();
        }

        private void простроченіКредитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            редагуватиToolStripMenuItem.Enabled = false;
            label1.Text = "ПРОСТРОЧЕНІ КРЕДИТИ";

            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlDataAdapter query = new SqlDataAdapter("SELECT Agreement.Id_agreement, Client.Id_client, Client.CName, Client.CLastName, Client.CPatronymic, Agreement.ASumm FROM Client, Agreement, Payment WHERE Agreement.Id_client=Client.Id_client AND Agreement.Id_agreement=Payment.Id_agreement AND Payment.PDateTo<current_timestamp AND Payment.PDate IS NULL", sqlconn);
            ArrayList empty = new ArrayList();
            dataGridView1.DataSource = empty;
            DataTable dt = new DataTable();
            query.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Номер договору";
            dataGridView1.Columns[1].HeaderText = "Номер клієнта";
            dataGridView1.Columns[2].HeaderText = "Ім'я";
            dataGridView1.Columns[3].HeaderText = "Прізвище";
            dataGridView1.Columns[4].HeaderText = "По батькові";
            dataGridView1.Columns[5].HeaderText = "Сума кредиту";
            bankDataSet.AcceptChanges();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }
        

        private void button2_Click(object sender, EventArgs e)
        {

            if (label1.Text == "КЛІЄНТИ")
            {
                if (textBox2.Visible == false)
                {
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    button3.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                }
                else
                {
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    button3.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    Client();
                }
            }
            else if (label1.Text == "ПРАЦІВНИКИ")
            {
                if (label11.Visible == false)
                {
                    label11.Visible = true;
                    button3.Visible = true;
                    comboBox1.Visible = true;
                }
                else
                {
                    label11.Visible = false;
                    button3.Visible = false;
                    comboBox1.Visible = false;
                    Employee();
                }
            }
            else if (label1.Text == "КРЕДИТИ")
            {
                if (textBox8.Visible == false)
                {
                    label15.Visible = true;
                    label14.Visible = true;
                    label13.Visible = true;
                    label12.Visible = true;
                    button3.Visible = true;
                    textBox8.Visible = true;
                    textBox9.Visible = true;
                    comboBox2.Visible = true;
                }
                else
                {
                    label15.Visible = false;
                    label14.Visible = false;
                    label13.Visible = false;
                    label12.Visible = false;
                    button3.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    comboBox2.Visible = false;
                    Credit();
                }
            }
            else if (label1.Text == "КРЕДИТНІ ДОГОВОРИ")
            {
                if (textBox4.Visible == false)
                {
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    button3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    comboBox6.Visible = true;
                    comboBox7.Visible = true;
                    dateTimePicker3.Visible = true;
                    dateTimePicker4.Visible = true;
                }
                else
                {
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    button3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    comboBox6.Visible = false;
                    comboBox7.Visible = false;
                    dateTimePicker3.Visible = false;
                    dateTimePicker4.Visible = false;
                    Agreement();
                }
            }
            else if (label1.Text == "СТРАХУВАННЯ")
            {
                if (label16.Visible == false)
                {
                    label16.Visible = true;
                    label17.Visible = true;
                    button3.Visible = true;
                    comboBox3.Visible = true;
                    comboBox4.Visible = true;
                }
                else
                {
                    label16.Visible = false;
                    label17.Visible = false;
                    button3.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    Insurance();
                }
            }
            else if (label1.Text == "ПЛАТЕЖІ")
            {
                if (label18.Visible == false)
                {
                    label18.Visible = true;
                    label19.Visible = true;
                    label20.Visible = true;
                    button3.Visible = true;
                    dateTimePicker1.Visible = true;
                    dateTimePicker2.Visible = true;
                }
                else
                {
                    label18.Visible = false;
                    label19.Visible = false;
                    label20.Visible = false;
                    button3.Visible = false;
                    dateTimePicker1.Visible = false;
                    dateTimePicker2.Visible = false;
                    Payment();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "КЛІЄНТИ")
            {
                decimal a, b;
                if (textBox2.Text == "" || textBox2.Text == null)
                    a = 0;
                else a = Convert.ToDecimal(textBox2.Text);
                if (textBox3.Text == "" || textBox3.Text == null)
                    b = 99999999;
                else b = Convert.ToDecimal(textBox3.Text);

                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlCommand query = new SqlCommand("SELECT * FROM Client WHERE (CSalary>@a AND CSalary<@b);", sqlconn);
                query.Parameters.AddWithValue("@a", a);
                query.Parameters.AddWithValue("@b", b);
                query.ExecuteNonQuery();
                sqlconn.Close();

                SqlDataAdapter quer = new SqlDataAdapter(query);
                ArrayList empty = new ArrayList();
                dataGridView1.DataSource = empty;
                DataTable dt = new DataTable();
                quer.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns[0].Visible = true;
                dataGridView1.Columns[0].HeaderText = "Код клієнта";
                dataGridView1.Columns[1].HeaderText = "Номер паспорту";
                dataGridView1.Columns[2].HeaderText = "Прізвище";
                dataGridView1.Columns[3].HeaderText = "Ім'я";
                dataGridView1.Columns[4].HeaderText = "По батькові";
                dataGridView1.Columns[5].HeaderText = "Домашня адреса";
                dataGridView1.Columns[6].HeaderText = "Номер телефону";
                dataGridView1.Columns[7].HeaderText = "Місце роботи";
                dataGridView1.Columns[8].HeaderText = "Заробітна плата";

            }
            else if (label1.Text == "ПРАЦІВНИКИ")
            {
                string a;
                if (comboBox1.Text == null || comboBox1.Text == " " || comboBox1.Text == "")
                    a = "";
                else a = comboBox1.Text;

                if (a == "")
                {
                    Employee();
                    return;
                }
                else
                {
                     SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlCommand query = new SqlCommand("SELECT * FROM Employee WHERE EmPosition=@a;", sqlconn);
                    query.Parameters.AddWithValue("@a", a);

                    query.ExecuteNonQuery();
                    sqlconn.Close();

                    SqlDataAdapter quer = new SqlDataAdapter(query);
                    ArrayList empty = new ArrayList();
                    dataGridView1.DataSource = empty;
                    DataTable dt = new DataTable();
                    quer.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

                dataGridView1.Columns[0].Visible = true;
                dataGridView1.Columns[0].HeaderText = "Код працівника";
                dataGridView1.Columns[1].HeaderText = "Прізвище";
                dataGridView1.Columns[2].HeaderText = "Ім'я";
                dataGridView1.Columns[3].HeaderText = "По батькові";
                dataGridView1.Columns[4].HeaderText = "Посада";
                dataGridView1.Columns[5].HeaderText = "Номер телефону";
                dataGridView1.Columns[6].HeaderText = "Домашня адреса";
            }
            else if (label1.Text == "КРЕДИТИ")
            {
                string a;
                int c, d;
                if (comboBox2.Text == null || comboBox2.Text == " ")
                    a = "";
                else a = comboBox2.Text;
                if (textBox8.Text == null || textBox8.Text == "")
                    c = 0;
                else c = Convert.ToInt32(textBox8.Text);
                if (textBox9.Text == null || textBox9.Text == "")
                    d = 100;
                else d = Convert.ToInt32(textBox9.Text);

                if (a == "")
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlCommand query = new SqlCommand("SELECT * FROM Credit WHERE CrRersent>=@c AND CrRersent<@d;", sqlconn);
                    query.Parameters.AddWithValue("@c", c);
                    query.Parameters.AddWithValue("@d", d);
                    query.ExecuteNonQuery();
                    sqlconn.Close();

                    SqlDataAdapter quer = new SqlDataAdapter(query);
                    ArrayList empty = new ArrayList();
                    dataGridView1.DataSource = empty;
                    DataTable dt = new DataTable();
                    quer.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlCommand query = new SqlCommand("SELECT * FROM Credit WHERE (CrRersent>@c AND CrRersent<@d) AND (CrType = @a);", sqlconn);
                    query.Parameters.AddWithValue("@c", c);
                    query.Parameters.AddWithValue("@d", d);
                    query.Parameters.AddWithValue("@a", a);
                    query.ExecuteNonQuery();
                    sqlconn.Close();

                    SqlDataAdapter quer = new SqlDataAdapter(query);
                    ArrayList empty = new ArrayList();
                    dataGridView1.DataSource = empty;
                    DataTable dt = new DataTable();
                    quer.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Назва";
                dataGridView1.Columns[2].HeaderText = "Тип";
                dataGridView1.Columns[3].HeaderText = "Відсоткова ставка";
                dataGridView1.Columns[4].HeaderText = "Додаткові умови";

            }
            else if (label1.Text == "КРЕДИТНІ ДОГОВОРИ")
            {
                string a=comboBox6.Text;
                string b;
                decimal c, d,f,g;
                if (comboBox7.Text == null || comboBox7.Text == " "||comboBox7.Text=="Тип")
                    b = "";
                else b = comboBox7.Text;
                if (textBox4.Text == null || textBox4.Text == "")
                    c = 0;
                else c = Convert.ToDecimal(textBox4.Text);
                if (textBox5.Text == null || textBox5.Text == "")
                    d = 99999999999;
                else d = Convert.ToDecimal(textBox5.Text);
                if (textBox7.Text == null || textBox7.Text == "")
                    f = 0;
                else f = Convert.ToDecimal(textBox7.Text);
                if (textBox6.Text == null || textBox6.Text == "")
                    g = 99999999999;
                else g = Convert.ToDecimal(textBox6.Text);

                var h = dateTimePicker4.Value;
                var i = dateTimePicker3.Value;

                if(a=="Дата (з)")
                {
                    if (b == "")
                    {
                        SqlConnection sqlconn = new SqlConnection(ConnectionString);
                        sqlconn.Open();
                        SqlCommand query = new SqlCommand("SELECT * FROM Agreement WHERE (ADateFrom BETWEEN @h AND @i) AND (ASumm>@c AND ASumm<@d) AND (APenya>@f AND APenya<@g);", sqlconn);
                        query.Parameters.AddWithValue("@c", c);
                        query.Parameters.AddWithValue("@d", d);
                        query.Parameters.AddWithValue("@i", i);
                        query.Parameters.AddWithValue("@h", h);
                        query.Parameters.AddWithValue("@a", a);
                        query.Parameters.AddWithValue("@f", f);
                        query.Parameters.AddWithValue("@g", g);
                        query.ExecuteNonQuery();
                        sqlconn.Close();

                        SqlDataAdapter quer = new SqlDataAdapter(query);
                        ArrayList empty = new ArrayList();
                        dataGridView1.DataSource = empty;
                        DataTable dt = new DataTable();
                        quer.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        SqlConnection sqlconn = new SqlConnection(ConnectionString);
                        sqlconn.Open();
                        SqlCommand query = new SqlCommand("SELECT * FROM Agreement WHERE (ADateFrom BETWEEN @h AND @i) AND AType=@b AND (ASumm>@c AND ASumm<@d) AND (APenya>@f AND APenya<@g);", sqlconn);
                        query.Parameters.AddWithValue("@c", c);
                        query.Parameters.AddWithValue("@d", d);
                        query.Parameters.AddWithValue("@i", i);
                        query.Parameters.AddWithValue("@h", h);
                        query.Parameters.AddWithValue("@a", a);
                        query.Parameters.AddWithValue("@f", f);
                        query.Parameters.AddWithValue("@g", g);
                        query.Parameters.AddWithValue("@b", b);
                        query.ExecuteNonQuery();
                        sqlconn.Close();

                        SqlDataAdapter quer = new SqlDataAdapter(query);
                        ArrayList empty = new ArrayList();
                        dataGridView1.DataSource = empty;
                        DataTable dt = new DataTable();
                        quer.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    
                }
                else if (a == "Дата (по)")
                {
                    if (b == "")
                    {
                        SqlConnection sqlconn = new SqlConnection(ConnectionString);
                        sqlconn.Open();
                        SqlCommand query = new SqlCommand("SELECT * FROM Agreement WHERE (ADateTo BETWEEN @h AND @i) AND (ASumm>@c AND ASumm<@d) AND (APenya>@f AND APenya<@g);", sqlconn);
                        query.Parameters.AddWithValue("@c", c);
                        query.Parameters.AddWithValue("@d", d);
                        query.Parameters.AddWithValue("@i", i);
                        query.Parameters.AddWithValue("@h", h);
                        query.Parameters.AddWithValue("@a", a);
                        query.Parameters.AddWithValue("@f", f);
                        query.Parameters.AddWithValue("@g", g);
                        query.ExecuteNonQuery();
                        sqlconn.Close();

                        SqlDataAdapter quer = new SqlDataAdapter(query);
                        ArrayList empty = new ArrayList();
                        dataGridView1.DataSource = empty;
                        DataTable dt = new DataTable();
                        quer.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        SqlConnection sqlconn = new SqlConnection(ConnectionString);
                        sqlconn.Open();
                        SqlCommand query = new SqlCommand("SELECT * FROM Agreement WHERE (ADateTo BETWEEN @h AND @i) AND AType=@b AND (ASumm>@c AND ASumm<@d) AND (APenya>@f AND APenya<@g);", sqlconn);
                        query.Parameters.AddWithValue("@c", c);
                        query.Parameters.AddWithValue("@d", d);
                        query.Parameters.AddWithValue("@i", i);
                        query.Parameters.AddWithValue("@h", h);
                        query.Parameters.AddWithValue("@a", a);
                        query.Parameters.AddWithValue("@f", f);
                        query.Parameters.AddWithValue("@g", g);
                        query.Parameters.AddWithValue("@b", b);
                        query.ExecuteNonQuery();
                        sqlconn.Close();

                        SqlDataAdapter quer = new SqlDataAdapter(query);
                        ArrayList empty = new ArrayList();
                        dataGridView1.DataSource = empty;
                        DataTable dt = new DataTable();
                        quer.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }


                dataGridView1.Columns[0].Visible = true;
                dataGridView1.Columns[0].HeaderText = "Номер договору";
                dataGridView1.Columns[1].HeaderText = "Дата (з)";
                dataGridView1.Columns[2].HeaderText = "Дата (по)";
                dataGridView1.Columns[3].HeaderText = "Тип";
                dataGridView1.Columns[4].HeaderText = "Сума";
                dataGridView1.Columns[5].HeaderText = "Пеня";
                dataGridView1.Columns[6].HeaderText = "Клієнт";
                dataGridView1.Columns[7].HeaderText = "Працівник";
                dataGridView1.Columns[8].HeaderText = "Кредит";
            }
            else if (label1.Text == "СТРАХУВАННЯ")
            {
                string a;
                string c;
                if (comboBox3.Text == null || comboBox3.Text == " ")
                    a = "";
                else a = comboBox3.Text;
                if (comboBox4.Text == null || comboBox4.Text == " ")
                    c = "";
                else c = comboBox4.Text;

                if (a == "" && c == "")
                {
                    Insurance();
                    return;
                }
                else if (a != "" && c == "")
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlCommand query = new SqlCommand("SELECT * FROM Insurance WHERE IFirm=@a;", sqlconn);
                    query.Parameters.AddWithValue("@a", a);
                    query.ExecuteNonQuery();
                    sqlconn.Close();

                    SqlDataAdapter quer = new SqlDataAdapter(query);
                    ArrayList empty = new ArrayList();
                    dataGridView1.DataSource = empty;
                    DataTable dt = new DataTable();
                    quer.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (a == "" && c != "")
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlCommand query = new SqlCommand("SELECT * FROM Insurance WHERE IForm=@a;", sqlconn);
                    query.Parameters.AddWithValue("@a", c);
                    query.ExecuteNonQuery();
                    sqlconn.Close();

                    SqlDataAdapter quer = new SqlDataAdapter(query);
                    ArrayList empty = new ArrayList();
                    dataGridView1.DataSource = empty;
                    DataTable dt = new DataTable();
                    quer.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (a != "" && c != "")
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlCommand query = new SqlCommand("SELECT * FROM Insurance WHERE IFirm=@a AND IForm=@c;", sqlconn);
                    query.Parameters.AddWithValue("@a", a);
                    query.Parameters.AddWithValue("@c", c);
                    query.ExecuteNonQuery();
                    sqlconn.Close();

                    SqlDataAdapter quer = new SqlDataAdapter(query);
                    ArrayList empty = new ArrayList();
                    dataGridView1.DataSource = empty;
                    DataTable dt = new DataTable();
                    quer.Fill(dt);
                    dataGridView1.DataSource = dt;
                }


                dataGridView1.Columns[0].Visible = true;
                dataGridView1.Columns[0].HeaderText = "Номер договору";
                dataGridView1.Columns[1].HeaderText = "Фірма";
                dataGridView1.Columns[2].HeaderText = "Сума";
                dataGridView1.Columns[3].HeaderText = "Форма";
            }
            else if (label1.Text == "ПЛАТЕЖІ")
            {
                var a = dateTimePicker1.Value;
                var c = dateTimePicker2.Value;

                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlCommand query = new SqlCommand("SELECT * FROM Payment WHERE PDateTo BETWEEN @date1 AND @date2;", sqlconn);
                query.Parameters.AddWithValue("@date1", a);
                query.Parameters.AddWithValue("@date2", c);
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
        }

        private void всіКредитніДоговориToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopAgreements newForm = new TopAgreements();
            newForm.Show();
        }

        private void заборгованністьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prybil newForm = new Prybil();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                dataGridView1.SelectedRows[dataGridView1.SelectedRows.Count - 1].Selected = false;
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[dataGridView1.SelectedRows.Count - 1].Index;
            }
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; ++i)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[comboBox5.SelectedIndex + 1].Value.ToString().Contains(textBox1.Text))
                {
                    if (dataGridView1.Rows[i].Visible == true)
                    {
                        dataGridView1.Rows[i].Selected = true;
                    }
                }
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[dataGridView1.SelectedRows.Count - 1].Index;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(label1.Text=="КРЕДИТНІ ДОГОВОРИ")
            {
                EmployeeAgree.id_agr = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                var k = new Agreement();
                k.Show();
            }
            else if(label1.Text == "ПЛАТЕЖІ" && dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString()!="")
            {
                ClientKvitan.id_pay = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                List<string> t5 = new List<string>();
                SqlConnection sqlcon = new SqlConnection(UserBank.ConnectionString);
                SqlDataAdapter quer = new SqlDataAdapter("SELECT Id_client FROM Agreement WHERE Id_agreement="+ Convert.ToInt32(dataGridView1[5, dataGridView1.CurrentRow.Index].Value), sqlcon);

                DataSet ds = new DataSet();
                quer.Fill(ds);
                foreach (DataTable dt in ds.Tables)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        var cells = row.ItemArray;
                        foreach (object cell in cells)
                            t5.Add(cell.ToString());
                    }
                }
                UserPassword.id = Convert.ToInt32(t5[0]);
                var k = new Kvitan();
                k.Show();
            }
        }
    }
}
