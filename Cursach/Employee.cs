using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursach
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void наГоловнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main newForm = new Main();
            newForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Queue_employ newForm = new Queue_employ();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var b = new EmployeeAgree();
            b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var n = new EditAddInsurance();
            n.Show();
        }
    }
}
