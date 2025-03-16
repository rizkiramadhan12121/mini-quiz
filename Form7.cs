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
    public partial class Form7 : Form
    {
        public static int score;
        public Form7(int curentScore)
        {
            InitializeComponent();
            score = curentScore;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (TrueC.Checked)
            {
                score = 20
                MessageBox.Show("Benar");
                Form8 f = new Form8();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Salah");
                Form8 f = new Form8();
                f.Show();
                this.Hide();
            }
        }
    }
}
