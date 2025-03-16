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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            int totalScore = Form2.score + Form3.score + Form4.score + Form5.score + Form6.score;
            //total skor
            labelHasil.Text = $"Nilai: {totalScore}";
            // remed/tidak remed
            if (totalScore <= 60)
            {
                labelKata.Text = "Anda Remedial";
            }
            else
            {
                labelKata.Text = "Tidak Perlu Remedial";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
