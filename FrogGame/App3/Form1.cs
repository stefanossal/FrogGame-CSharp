using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace App3
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int k = 0;
        int s = 0;
        int l;
        int m;
        public Form1()
        {  
            InitializeComponent();
            pictureBox1.Visible = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            if (comboBox1.Text == "Εύκολο" && (comboBox2.Text == "20" || comboBox2.Text == "40" || comboBox2.Text == "60"))
            {
                timer1.Interval = 1000;
                timer1.Start();
                timer1.Enabled = true;
                timer2.Start();
                timer2.Enabled = true;
            }
            else if (comboBox1.Text == "Δύσκολο" && (comboBox2.Text == "20" || comboBox2.Text == "40" || comboBox2.Text == "60"))
            {
                timer1.Interval = 500;
                timer1.Start();
                timer1.Enabled = true;
                timer2.Start();
                timer2.Enabled = true;
            }
            else if (comboBox1.Text == "Επίπεδο Δυσκολίας" || comboBox2.Text == "Χρόνος")
            {
                pictureBox1.Visible = false;
                MessageBox.Show("Παρακαλώ επιλέξτε επίπεδο δυσκολίας και χρόνο");
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r = new Random();
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            //Τυχαία τοποθεσία γραφικού
            int t;
            int x;
            t = r.Next(0, panel1.Width - pictureBox1.Width);
            x = r.Next(0, panel1.Height - pictureBox1.Height);
            pictureBox1.Location = new Point(t, x);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
                k = k + 1;
                label1.Text = "Χρόνος : "; textBox1.Text = k.ToString();
                if (k.ToString() == comboBox2.Text)
                {
                    timer2.Stop();
                    timer1.Stop();
                    MessageBox.Show("Τέλος παιχνιδιού το σκόρ σου είναι : " + s);
                    pictureBox1.Visible = false;
                    k = 0;
                    //Κορυφαία σκόρ 
                    if (comboBox1.Text == "Εύκολο")
                    {
                        if (s > l)
                        {
                            label3.Text = "Κορ. Σκόρ (Εύκολο) : "; textBox3.Text = s.ToString();
                            l = s;
                        }

                    }
                    if (comboBox1.Text == "Δύσκολο")
                    {
                        if (s > m)
                        {
                            label4.Text = "Κορ. Σκόρ (Δύσκολο) : "; textBox4.Text = s.ToString();
                            m = s;
                        }

                    }
                    s = 0;
                }
           
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            s = s + 1;
            label2.Text = "Σκόρ : "; textBox2.Text = s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
