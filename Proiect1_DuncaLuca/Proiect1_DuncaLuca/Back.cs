using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proiect1_DuncaLuca
{
    public partial class Back: Form
    {
        public Back()
        {
            InitializeComponent();
            checkBox1.CheckedChanged += Workout1;
            checkBox2.CheckedChanged += Workout1;
            checkBox3.CheckedChanged += Workout1;

            checkBox4.CheckedChanged += Workout2;
            checkBox5.CheckedChanged += Workout2;
            checkBox6.CheckedChanged += Workout2;
        }
        private void Workout1(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("Nice! Tommorrow you will feel like the train ran over you!");
            }
        }
        private void Workout2(object sender, EventArgs e)
        {
            if (checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                MessageBox.Show("Starting to look like a real Dorito!");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Load(object sender, EventArgs e)
        {

        }
    }
}
