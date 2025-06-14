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
    public partial class Legs: Form
    {
        public Legs()
        {
            InitializeComponent();
            checkBox1.CheckedChanged += WorkoutAtHome;
            checkBox2.CheckedChanged += WorkoutAtHome;
            checkBox3.CheckedChanged += WorkoutAtHome;
            checkBox4.CheckedChanged += WorkoutAtHome;

            checkBox5.CheckedChanged += WorkoutAtGym;
            checkBox6.CheckedChanged += WorkoutAtGym;
            checkBox7.CheckedChanged += WorkoutAtGym;
        }

        private void Legs_Load(object sender, EventArgs e)
        {

        }
        private void WorkoutAtGym(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
            {
                MessageBox.Show("Kangaroo phase");
            }
        }

        private void WorkoutAtHome(object sender, EventArgs e)
        {
            if (checkBox5.Checked && checkBox6.Checked && checkBox7.Checked)
            {
                MessageBox.Show("There is no legs at home");
            }
        }
    }
}
