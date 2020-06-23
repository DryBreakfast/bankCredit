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
    public partial class Queue_employ : Form
    {
        public Queue_employ()
        {
            InitializeComponent();
        }

        public static string client;

        private void button1_Click(object sender, EventArgs e)
        {
            client = Que.Queu[0];
            var g = new AddAgreement();
            g.Show();
            UpdateQueu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client = listBox1.Text;
            if (listBox1.Text != "")
            {
                var g = new AddAgreement();
                g.Show();
                UpdateQueu();
            }
        }

        private void UpdateQueu()
        {
            String[] f1 = Que.Queu.ToArray();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(f1);
        }

        private void Queue_employ_Load(object sender, EventArgs e)
        {
            UpdateQueu();
            label2.Text = Que.Queu.Count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Text != "")
            {
                DialogResult h = MessageBox.Show("Ви точно хочете видалити цей запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (h == DialogResult.Yes)
                {
                    client = listBox1.Text;
                    Que.Queu.Remove(client);
                    UpdateQueu();
                }   
            }
        }

        private void Queue_employ_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("queue.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Que.Queu);
            }
        }
    }
}
