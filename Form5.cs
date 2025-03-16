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
    public partial class Form5 : Form
    {
        public static int score;
        public Form5(int curentScore)
        {
            InitializeComponent();
            score = curentScore;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (TrueA.Checked)
            {
                score = 20
                MessageBox.Show("Benar");
                Form6 f = new Form6();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Salah");
                Form6 f = new Form6();
                f.Show();
                this.Hide();
            }
        }
    }
}
