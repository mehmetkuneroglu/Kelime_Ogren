using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kelime_Ogren
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
            numericUpDown3.Value = 7;

           
        }
        public void bildirim()

        {
            string kelime = textBox1.Text + "  =  " + textBox2.Text;                       
            Kelime_Ogren.ShowBalloonTip(7000, "", kelime, ToolTipIcon.Info);
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int interval1 = 1000;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                
                    timer1.Interval = (interval1 * Convert.ToInt32(numericUpDown3.Value))
                        + (60000 * Convert.ToInt32(numericUpDown2.Value)) + (3600000 * Convert.ToInt32(numericUpDown1.Value));
                    bildirim();
                    timer1.Start();
            }
            else
            {
                MessageBox.Show("Lütfen öğrenmek istediğniz kelime ve karşılığını giriniz.", "Kelime Öğren", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
