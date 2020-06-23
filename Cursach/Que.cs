using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursach
{
    public partial class Que : Form
    {
        public Que()
        {
            InitializeComponent();
        }

        public static List<string> Queu = new List<string>();

        private void UpdateQueu()
        {
            String[] f1 = Queu.ToArray();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(f1);
        }

        private void Que_Load(object sender, EventArgs e)
        {
            UpdateQueu();
            if (Queu.IndexOf(UserPassword.id.ToString() + " " + User.name) >= 0)
                button1.Enabled = false;
            else
            {
                List<string> t = new List<string>();
                DataSet ds = new DataSet();
                SqlConnection sqlcon = new SqlConnection(UserBank.ConnectionString);
                sqlcon.Open();
                SqlCommand que = new SqlCommand("SELECT Id_client FROM Agreement WHERE Id_client=@a AND (ASumm!=0 OR Id_client NOT IN(SELECT Id_client FROM Agreement))", sqlcon);
                que.Parameters.AddWithValue("@a", UserPassword.id);
                SqlDataAdapter ad = new SqlDataAdapter(que);
                ad.Fill(ds);
                sqlcon.Close();

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
                    button1.Enabled = true;
                else button1.Enabled = false;
            }
            
            label2.Text = Queu.Count.ToString();
            label3.Text = "Ви у черзі: "+(Queu.IndexOf(UserPassword.id.ToString() + " " + User.name) + 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Записатися у чергу?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (h == DialogResult.Yes)
            {
                Queu.Add(UserPassword.id.ToString()+" "+ User.name);
                label3.Text = "Ви у черзі: " + (Queu.IndexOf(UserPassword.id.ToString()+" "+ User.name)+1).ToString();
                button1.Enabled = false;
                UpdateQueu();
            }  
        }

        private void Que_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("queue.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Queu);
            }
        }
    }
}
