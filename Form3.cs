using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramMiniquiz
{
    public partial class Form3 : Form
    {
        public static int score;
        public Form3(int curentScore)
        {
            InitializeComponent();
            score = curentScore;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (optionA.Checked)
            {
                timer1.Stop();
                score = 20;
                MessageBox.Show("Benar, Skor +20");
                Form4 f = new Form4();
                f.Show();
                this.Hide();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Salah, Skor -20");
                Form4 f = new Form4();
                f.Show();
                this.Hide();
            }
        }
    }
}
