using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect1_DuncaLuca
{
    public partial class Abs: Form
    {
        public Abs()
        {
            InitializeComponent();

            checkBox4.CheckedChanged += WorkoutAtHome;
            checkBox5.CheckedChanged += WorkoutAtHome;
            checkBox6.CheckedChanged += WorkoutAtHome;
            checkBox7.CheckedChanged += WorkoutAtHome;

            checkBox1.CheckedChanged += WorkoutAtGym;
            checkBox2.CheckedChanged += WorkoutAtGym;
            checkBox3.CheckedChanged += WorkoutAtGym;
        }

        private void Abs_Load(object sender, EventArgs e)
        {

        }
        private void WorkoutAtHome(object sender, EventArgs e)
        {
            if (checkBox4.Checked && checkBox5.Checked && checkBox6.Checked && checkBox7.Checked)
            {
                MessageBox.Show("Do you feel the burn?");
            }
        }
        private void WorkoutAtGym(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("Rock solid");
            }
        }
    }
}
