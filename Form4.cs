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
    public partial class Form4 : Form
    {
      public static int score;
        public Form4(int curentScore)
        {
            InitializeComponent();
            score = curentScore;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (TrueB.Checked)
            {
                score = 20
                MessageBox.Show("Benar");
                Form5 f = new Form5();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Salah");
                Form5 f = new Form5();
                f.Show();
                this.Hide();
            }
        }
    }
}
