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
    public partial class UserBankPassword : Form
    {
        public UserBankPassword()
        {
            InitializeComponent();
        }

        public int y = 3;

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "1234")
            {
                this.Hide();
                UserBank newForm = new UserBank();
                newForm.ShowDialog();
                this.Close();
            }
            else
            {
                if (y != 0)
                {
                    --y;
                    MessageBox.Show("Перевірте правильність паролю \n Залишилось " + y + " спроб", "Неправильний пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (y == 0)
                {
                    MessageBox.Show("Перевірте правильність паролю \n Залишилось " + y + " спроб", "Неправильний пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                    Main newForm = new Main();
                    newForm.ShowDialog();
                    this.Close();
                }


            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main newForm = new Main();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
