namespace Proiect1_DuncaLuca
{
    partial class Workout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxWorkout = new System.Windows.Forms.TextBox();
            this.buttonChest = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonArms = new System.Windows.Forms.Button();
            this.buttonLegs = new System.Windows.Forms.Button();
            this.buttonAbs = new System.Windows.Forms.Button();
            this.buttonCardio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxWorkout
            // 
            this.textBoxWorkout.BackColor = System.Drawing.Color.Coral;
            this.textBoxWorkout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWorkout.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWorkout.Location = new System.Drawing.Point(226, 39);
            this.textBoxWorkout.Name = "textBoxWorkout";
            this.textBoxWorkout.ReadOnly = true;
            this.textBoxWorkout.Size = new System.Drawing.Size(198, 27);
            this.textBoxWorkout.TabIndex = 0;
            this.textBoxWorkout.Text = "Pick a workout champ!";
            this.textBoxWorkout.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonChest
            // 
            this.buttonChest.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChest.Location = new System.Drawing.Point(87, 101);
            this.buttonChest.Name = "buttonChest";
            this.buttonChest.Size = new System.Drawing.Size(100, 56);
            this.buttonChest.TabIndex = 1;
            this.buttonChest.Text = "Chest";
            this.buttonChest.UseVisualStyleBackColor = true;
            this.buttonChest.Click += new System.EventHandler(this.buttonChest_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(87, 205);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 56);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonArms
            // 
            this.buttonArms.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArms.Location = new System.Drawing.Point(270, 101);
            this.buttonArms.Name = "buttonArms";
            this.buttonArms.Size = new System.Drawing.Size(100, 56);
            this.buttonArms.TabIndex = 3;
            this.buttonArms.Text = "Arms";
            this.buttonArms.UseVisualStyleBackColor = true;
            this.buttonArms.Click += new System.EventHandler(this.buttonArms_Click);
            // 
            // buttonLegs
            // 
            this.buttonLegs.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLegs.Location = new System.Drawing.Point(270, 205);
            this.buttonLegs.Name = "buttonLegs";
            this.buttonLegs.Size = new System.Drawing.Size(100, 56);
            this.buttonLegs.TabIndex = 4;
            this.buttonLegs.Text = "Legs";
            this.buttonLegs.UseVisualStyleBackColor = true;
            this.buttonLegs.Click += new System.EventHandler(this.buttonLegs_Click);
            // 
            // buttonAbs
            // 
            this.buttonAbs.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbs.Location = new System.Drawing.Point(449, 101);
            this.buttonAbs.Name = "buttonAbs";
            this.buttonAbs.Size = new System.Drawing.Size(100, 56);
            this.buttonAbs.TabIndex = 5;
            this.buttonAbs.Text = "Abs";
            this.buttonAbs.UseVisualStyleBackColor = true;
            this.buttonAbs.Click += new System.EventHandler(this.buttonAbs_Click);
            // 
            // buttonCardio
            // 
            this.buttonCardio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCardio.Location = new System.Drawing.Point(449, 205);
            this.buttonCardio.Name = "buttonCardio";
            this.buttonCardio.Size = new System.Drawing.Size(100, 56);
            this.buttonCardio.TabIndex = 6;
            this.buttonCardio.Text = "Cardio";
            this.buttonCardio.UseVisualStyleBackColor = true;
            this.buttonCardio.Click += new System.EventHandler(this.buttonCardio_Click);
            // 
            // Workout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::Proiect1_DuncaLuca.Properties.Resources.fundalWorkout;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.buttonCardio);
            this.Controls.Add(this.buttonAbs);
            this.Controls.Add(this.buttonLegs);
            this.Controls.Add(this.buttonArms);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonChest);
            this.Controls.Add(this.textBoxWorkout);
            this.Name = "Workout";
            this.Text = "Workout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWorkout;
        private System.Windows.Forms.Button buttonChest;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonArms;
        private System.Windows.Forms.Button buttonLegs;
        private System.Windows.Forms.Button buttonAbs;
        private System.Windows.Forms.Button buttonCardio;
    }
}

