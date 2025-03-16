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
    public partial class Form6 : Form
    {
        public static int score;
        public Form6(int curentScore)
        {
            InitializeComponent();
            score = curentScore;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (TrueD.Checked)
            {
                score = 20;
                MessageBox.Show("Benar");
                Form7 f = new Form7();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Salah");
                Form7 f = new Form7();
                f.Show();
                this.Hide();
            }
        }
    }
}
