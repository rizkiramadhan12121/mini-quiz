using System;
using System.Windows.Forms;

namespace ProgramMiniquiz
{
    public partial class Form2 : Form
    {
        public static int score;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Navigasi ke Form3
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide(); // Sembunyikan formulir saat ini (Form2)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Navigasi ke Form1
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); //Sembunyikan formulir saat ini (Form2)
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
