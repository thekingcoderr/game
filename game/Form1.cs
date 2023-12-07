using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace game
{
    public partial class Form1 : Form
    {
        int count = 0;
        int stop = 0;
        static Image apple = game.Resource1.apple;
        static Image banana = game.Resource1.banana;
        static Image cherry = game.Resource1.cherry;
        static Image halfapple = game.Resource1.halfapple;
        static Image halfbanana = game.Resource1.halfbanana;
        static Image halfcherry = game.Resource1.halfcherry;

        static Image fruit = apple;
        
       

        public Form1()
        {
            InitializeComponent();
        }
        CancellationTokenSource cancellationTokenSource;
        CancellationToken cancellationToken;

        private void Form1_Load(object sender, EventArgs e)
        {
           
            

        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {


        }
        bool run = true;
        int points = 0;


        private void display()
        {
            //pictureBox1.Image = apple;
            //pictureBox1.Image = banana;
            //pictureBox1.Image = apple;
            ImageList photoList1 = new ImageList();
            photoList1.ImageSize = new Size(200, 200);
            //photoList.Draw(g, new Point(20, 20), count);
            photoList1.Images.Add(apple);
            photoList1.Images.Add(banana);
            photoList1.Images.Add(cherry);
            Random rnd = new Random();
            //int times = rnd.Next()
            int spin = rnd.Next(100,200);
            while (spin != 0)
            {
                int slot1 = rnd.Next(0, 3);
                int slot2 = rnd.Next(0, 3);
                int slot3 = rnd.Next(0, 3);

                pictureBox1.Image = photoList1.Images[slot1];
                
                pictureBox2.Image = photoList1.Images[slot2];
                pictureBox3.Image = photoList1.Images[slot3];
                if (slot1 == 0)
                {
                    pictureBox4.Image = halfcherry;
                    pictureBox4.Image = halfbanana;
                }
                else if (slot1 == 1)
                {
                    pictureBox4.Image = halfapple;
                    pictureBox9.Image = halfcherry;
                }
                else if (slot1 == 2)
                {
                    pictureBox4.Image = halfcherry;
                    pictureBox9.Image = halfapple;
                }
                if (slot2 == 0)
                {
                    pictureBox5.Image = halfcherry;
                    pictureBox8.Image = halfbanana;
                }
                else if (slot2 == 1)
                {
                    pictureBox5.Image = halfapple;
                    pictureBox8.Image = halfcherry;
                }
                else if (slot2 == 2)
                {
                    pictureBox5.Image = halfbanana;
                    pictureBox8.Image = halfapple;
                }
                if (slot3 == 0)
                {
                    pictureBox6.Image = halfapple;
                    pictureBox7.Image = halfbanana;
                }
                else if (slot3 == 1)
                {
                    pictureBox6.Image = halfapple;
                    pictureBox7.Image = halfcherry;
                }
                else if (slot3 == 2)
                {
                    pictureBox6.Image = halfbanana;
                    pictureBox7.Image = halfapple;
                }
                spin = spin - 1;


                Thread.Sleep(50);
            }


        }





        private void button2_Click(object sender, EventArgs e)
        {
            if (cancellationTokenSource == null)
            {
                cancellationTokenSource = new CancellationTokenSource();
                cancellationToken = cancellationTokenSource.Token;
                Task.Run((Action)display, cancellationToken);
            }
            //display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            run = false;
            if (pictureBox1 == pictureBox2 && pictureBox1 ==  pictureBox3)
            {
                points = points + 1;
            }

           


        }

        private void label1_Click(object sender, EventArgs e)
        {
            string p = Convert.ToString(points);
            label1.Text = p;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

      
    }
}
