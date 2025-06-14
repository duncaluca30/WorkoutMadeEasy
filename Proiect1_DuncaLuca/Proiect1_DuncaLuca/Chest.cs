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
    public partial class Chest: Form
    {
        public Chest()
        {
            InitializeComponent();
            checkBox1.CheckedChanged += Workout1;
            checkBox2.CheckedChanged += Workout1;
            checkBox3.CheckedChanged += Workout1;

            checkBox4.CheckedChanged += Workout2;
            checkBox5.CheckedChanged += Workout2;
            checkBox6.CheckedChanged += Workout2;

            checkBox7.CheckedChanged += Workout1;
            checkBox8.CheckedChanged += Workout1;
            checkBox9.CheckedChanged += Workout1;

            checkBox10.CheckedChanged += Workout2;
            checkBox11.CheckedChanged += Workout2;
            checkBox12.CheckedChanged += Workout2;
        }

        private void textBoxCW2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Workout1(object sender, EventArgs e)
        {
            if ((checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                || (checkBox7.Checked && checkBox8.Checked && checkBox9.Checked))
            {
                MessageBox.Show("U are doing amazing sweetie!");
            }
        }
        private void Workout2(object sender, EventArgs e)
        {
            if ((checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)||
                (checkBox10.Checked && checkBox11.Checked && checkBox12.Checked))
            {
                MessageBox.Show("U are still here? I think you are the promissed one!");
            }
        }

    }
}
