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
    public partial class Form8 : Form
    {
        public static int score;
        public Form8(int curentScore)
        {
            InitializeComponent();
            score = curentScore;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Navigasi ke Form9
            Form9 form9 = new Form9(score);
            form9.Show();
            this.Hide(); // Sembunyikan formulir saat ini (Form2)
        }
    }
}
