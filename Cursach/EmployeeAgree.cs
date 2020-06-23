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
    public partial class EmployeeAgree : Form
    {
        public EmployeeAgree()
        {
            InitializeComponent();
        }

        private void EmployeeAgree_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            Agreement();
        }

        public void Agreement()
        {
            ArrayList empty = new ArrayList();
            dataGridView1.DataSource = empty;
            SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Agreement.Id_agreement, Agreement.ADateFrom, Agreement.ADateTo, Agreement.AType, Agreement.ASumm, Agreement.APenya, CONCAT(Agreement.Id_client,CONCAT(' ', CONCAT(Client.CLastName,CONCAT(' ',CONCAT(Client.CName,CONCAT(' ', Client.CPatronymic)))))), CONCAT(Agreement.Id_employee,CONCAT(' ', CONCAT(Employee.EmLastName,CONCAT(' ',CONCAT(Employee.EmName,CONCAT(' ', Employee.EmPatronymic)))))), CONCAT(Agreement.Id_credit,CONCAT(' ',Credit.CrName)) FROM Agreement, Client, Employee, Credit WHERE Agreement.Id_client=Client.Id_client AND Agreement.Id_credit=Credit.Id_credit AND Agreement.Id_employee=Employee.Id_employee;", sqlconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Agreement();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList empty = new ArrayList();
            dataGridView1.DataSource = empty;
            SqlConnection sqlconn = new SqlConnection(UserBank.ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Agreement.Id_agreement, Agreement.ADateFrom, Agreement.ADateTo, Agreement.AType, Agreement.ASumm, Agreement.APenya, CONCAT(Agreement.Id_client,CONCAT(' ', CONCAT(Client.CLastName,CONCAT(' ',CONCAT(Client.CName,CONCAT(' ', Client.CPatronymic)))))), CONCAT(Agreement.Id_employee,CONCAT(' ', CONCAT(Employee.EmLastName,CONCAT(' ',CONCAT(Employee.EmName,CONCAT(' ', Employee.EmPatronymic)))))), CONCAT(Agreement.Id_credit,CONCAT(' ',Credit.CrName)) FROM Agreement, Client, Employee, Credit WHERE Agreement.Id_client=Client.Id_client AND Agreement.Id_credit=Credit.Id_credit AND Agreement.Id_employee=Employee.Id_employee AND Agreement.Id_employee="+EmployeePassword.id, sqlconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                dataGridView1.SelectedRows[dataGridView1.SelectedRows.Count - 1].Selected = false;
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[dataGridView1.SelectedRows.Count - 1].Index;
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; ++i)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[comboBox5.SelectedIndex].Value.ToString().Contains(textBox1.Text))
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

        public static int id_agr;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id_agr = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            var k = new Agreement();
            k.Show();
        }
    }
}
