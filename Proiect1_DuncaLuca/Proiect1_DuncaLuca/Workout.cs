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
    public partial class Workout: Form
    {
        public Workout()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonChest_Click(object sender, EventArgs e)
        {
            Chest chest = new Chest();

            chest.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Back back = new Back();
            back.Show();
        }

        private void buttonArms_Click(object sender, EventArgs e)
        {
            Arms arms = new Arms();
            arms.Show();
        }

        private void buttonCardio_Click(object sender, EventArgs e)
        {
            Cardio cardio = new Cardio();
            cardio.Show();
        }

        private void buttonLegs_Click(object sender, EventArgs e)
        {
            Legs legs = new Legs();
            legs.Show();
        }

        private void buttonAbs_Click(object sender, EventArgs e)
        {
            Abs abs = new Abs();
            abs.Show();
        }
    }
}
