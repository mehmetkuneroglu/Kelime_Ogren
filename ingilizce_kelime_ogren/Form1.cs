using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizce_kelime_ogren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            bildirim();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 23;
            numericUpDown2.Maximum = 59;
            numericUpDown3.Maximum = 59;
            numericUpDown3.Minimum = 0;
            numericUpDown2.Minimum = 0;
            numericUpDown1.Minimum = 0;
            numericUpDown4.Minimum = 3;
            numericUpDown4.Maximum = 60;
            numericUpDown4.Value = 6;
            numericUpDown3.Value = 7;
        }
        public void bildirim()

        {
            string kelime = textBox1.Text + "  =  " + textBox2.Text;
            Kelime_Ogren.ShowBalloonTip(6000, "", kelime, ToolTipIcon.Info);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {


                int interval1 = 1000;
                if (numericUpDown3.Value <= numericUpDown4.Value && numericUpDown2.Value == 0 && numericUpDown1.Value == 0)
                {
                    MessageBox.Show("Lütfen gösterim süresinden yüksek bir zaman aralığı belirleyin", "Kelime Öğren", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    timer1.Interval = (interval1 * Convert.ToInt32(numericUpDown3.Value))
                        + (60000 * Convert.ToInt32(numericUpDown2.Value)) + (3600000 * Convert.ToInt32(numericUpDown1.Value));
                    bildirim();
                    timer1.Start();
                }
            }
            else
            {
                MessageBox.Show("Lütfen öğrenmek istediğniz kelime ve karşılığını giriniz.", "Kelime Öğren", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
