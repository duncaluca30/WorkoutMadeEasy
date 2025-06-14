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
    public partial class Arms: Form
    {
        public Arms()
        {
            InitializeComponent();
            checkBox1.CheckedChanged += WorkoutAtHome;
            checkBox2.CheckedChanged += WorkoutAtHome;
            checkBox3.CheckedChanged += WorkoutAtHome;

            checkBox4.CheckedChanged += Workout1B;
            checkBox5.CheckedChanged += Workout1B;
            checkBox6.CheckedChanged += Workout1B;

            checkBox7.CheckedChanged += Workout2B;
            checkBox8.CheckedChanged += Workout2B;
            checkBox9.CheckedChanged += Workout2B;

            checkBox10.CheckedChanged += Workout2T;
            checkBox11.CheckedChanged += Workout2T;
            checkBox12.CheckedChanged += Workout2T;

            checkBox13.CheckedChanged += Workout1T;
            checkBox14.CheckedChanged += Workout1T;
            checkBox15.CheckedChanged += Workout1T;

            checkBox16.CheckedChanged += WorkoutFA;
            checkBox17.CheckedChanged += WorkoutFA;
            checkBox18.CheckedChanged += WorkoutFA;


        }

        private void Arms_Load(object sender, EventArgs e)
        {

        }
        private void WorkoutAtHome(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("Now do it 1000 times");
            }
        }
        private void Workout1B(object sender, EventArgs e)
        {
            if (checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                MessageBox.Show("Biceps loading...");
            }
        }
        private void Workout2B(object sender, EventArgs e)
        {
            if (checkBox7.Checked && checkBox8.Checked && checkBox9.Checked)
            {
                MessageBox.Show("Bicepsosaurus is that you?");
            }
        }
        private void Workout2T(object sender, EventArgs e)
        {
            if (checkBox10.Checked && checkBox11.Checked && checkBox12.Checked)
            {
                MessageBox.Show("Is it just me or the gym looks smaller?");
            }
        }

        private void Workout1T(object sender, EventArgs e)
        {
            if (checkBox13.Checked && checkBox14.Checked && checkBox15.Checked)
            {
                MessageBox.Show("You look like you can \"push your weight\"");
            }
        }
        private void WorkoutFA(object sender, EventArgs e)
        {
            if (checkBox16.Checked && checkBox17.Checked && checkBox18.Checked)
            {
                MessageBox.Show("Just don't start breaking things");
            }
        }
    }
}
