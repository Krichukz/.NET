using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ToolTip tt;
        public Form1()
        {
            InitializeComponent();
            LogFile.LogWrite("Inicializeta forma.");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("TextBoxi ir tukši! :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LogFile.LogWrite($"Textboxi nav aizpilditi!");
            }
            else
            {

                decimal skt1 = decimal.Parse(textBox1.Text);
                decimal skt2 = decimal.Parse(textBox2.Text);
                decimal rez = skt1 * skt2;
                label3.Visible = true;
                label3.Text = $"{rez}";
                LogFile.LogWrite($"Veikta aprekinasana: {skt1} * {skt2} ir = {rez}!");
            }

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            tt = new ToolTip();
            tt.InitialDelay = 0;
            tt.IsBalloon = true;
            tt.Show(string.Empty, textBox1);
            tt.Show("Ievadiet skaitli forma - : 3 vai -3 vai 3,3", textBox1, 0);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            tt.Dispose();
        }

     
    }
}
