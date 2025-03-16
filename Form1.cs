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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((String.Equals(this.txtUser.Text, "admin")) && (String.Equals(this.txtPw.Text, "1234")))
            {
                Form2 f = new Form2(initialScore);
                f.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("User name/Password salah", "Error");
            }
        }
    }
    }
