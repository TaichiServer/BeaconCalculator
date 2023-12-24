using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeaconCalculator
{
    public partial class BeaconCalculator : Form
    {
        public BeaconCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox13.Text) || String.IsNullOrEmpty(textBox15.Text))
            {
                //メッセージボックスを表示する
                MessageBox.Show("X座標かZ座標が入力されていません。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                int migiuex, migiuez, migisitax, migisitaz, hidarisitax, hidarisitaz, hidariuex, hidariuez;
                hidarisitax = Convert.ToInt32(textBox13.Text);
                hidarisitaz = Convert.ToInt32(textBox15.Text);
                hidariuex = hidarisitax;
                hidariuez = hidarisitaz - 127;
                migiuex = hidariuex + 127;
                migiuez = hidariuez;
                migisitax = migiuex;
                migisitaz = migiuez + 127;
                textBox9.Text = Convert.ToString(hidarisitax + 50);
                textBox7.Text = Convert.ToString(hidarisitaz - 50);
                textBox1.Text = Convert.ToString(hidariuex + 50);
                textBox3.Text = Convert.ToString(hidariuez + 50);
                textBox6.Text = Convert.ToString(migiuex - 50);
                textBox4.Text = Convert.ToString(migiuez + 50);
                textBox12.Text = Convert.ToString(migisitax - 50);
                textBox10.Text = Convert.ToString(migisitaz - 50);
            }
        }
    }
}
