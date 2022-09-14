using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayınTarlası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saniye = 0,dakika=0;
       
        int i = 18,j=1;
        int mayınX, mayınY;
        private void button4_Click(object sender, EventArgs e)
        {
            
            if(i >= 0)
            {
                tableLayoutPanel1.SetRow(pictureBox3,i);
                i--;
            }
            else
            {
                MessageBox.Show("KAZANDIN");
            }

            

            timer1.Start();
            YakınMayın();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (j < 20 && j > 0)
            {
                j--;
                tableLayoutPanel1.SetColumn(pictureBox3, j);
                
            }
            else 
            {
                MessageBox.Show("SOL TARAFA ÇOK GİTTİN...");
            }
            
            timer1.Start();
            YakınMayın();
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            i++;
            if (i <= 20)
            {
                tableLayoutPanel1.SetRow(pictureBox3, i);
                
            }
            else
            {
                MessageBox.Show("ÇOK AŞAĞIYA İNDİN...");
            }
            

            timer1.Start();
            YakınMayın();
        }

        private void button7_Click(object sender, EventArgs e)
        {
               
            if ( j < 19 )
            {
                j++;
                tableLayoutPanel1.SetColumn(pictureBox3, j);
               // tableLayoutPanel1.BackColor = Color.White;
                
            }
            else
            {
                MessageBox.Show("SAĞ TARAFA ÇOK GİTTİN...");
            }

            timer1.Start();

            YakınMayın();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
           // label1.Text = "i: " + i.ToString() + "j: " + j.ToString();
        }

        int[] diziX = new int[40];
        int[] diziY = new int[40];

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            /* Image image = Image.FromFile("C:\\Users\\hp\\Pictures\\Saved Pictures\\mayın.PNG");

             int SA, AS;
             Random Sa = new Random();
             Random As = new Random();
             PictureBox[] picarray = new PictureBox[50];

             for (int k = 1; k <= 40; k++)
             {
                 picarray[k] = new PictureBox();
                 picarray[k].Image = image;
                 SA = Sa.Next(20);
                 AS = As.Next(20);
                 tableLayoutPanel1.Controls.Add(picarray[k], SA, AS);
             }*/

            
            Random X = new Random();
            
            for (int k = 0; k < 40; k++)
            {
                mayınX = X.Next(20);
                mayınY = X.Next(20);
                if (mayınY != 19)
                {
                    diziX[k] = mayınX;
                    diziY[k] = mayınY;
                    tableLayoutPanel1.Controls.Add(new Label() { Text = "+" }, mayınX, mayınY);
                }
                else
                {
                    mayınX = X.Next(20);
                    mayınY = X.Next(20);
                }
                
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            /* Image image = Image.FromFile("C:\\Users\\hp\\Pictures\\Saved Pictures\\mayın.PNG");

             int SA, AS;
             Random Sa = new Random();
             Random As = new Random();
             PictureBox[] picarray = new PictureBox[50];

             for (int k = 1; k <= 50; k++)
             {
                 picarray[k] = new PictureBox();
                 picarray[k].Image = image;
                 SA = Sa.Next(20);
                 AS = As.Next(20);
                 tableLayoutPanel1.Controls.Add(picarray[k], SA, AS);
             }*/

            
            Random X = new Random();

            for (int k = 0; k < 50; k++)
            {
                mayınX = X.Next(20);
                mayınY = X.Next(20);
                if (mayınY != 19)
                {
                    tableLayoutPanel1.Controls.Add(new Label() { Text = "+" }, mayınX, mayınY);
                }
                else
                {
                    mayınX = X.Next(20);
                    mayınY = X.Next(20);
                }

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            /*Image image = Image.FromFile("C:\\Users\\hp\\Pictures\\Saved Pictures\\mayın.PNG");

            int SA, AS;
            Random Sa = new Random();
            Random As = new Random();
            PictureBox[] picarray = new PictureBox[50];

            for (int k = 1; k <= 80; k++)
            {
                picarray[k] = new PictureBox();
                picarray[k].Image = image;
                SA = Sa.Next(20);
                AS = As.Next(20);
                tableLayoutPanel1.Controls.Add(picarray[k], SA, AS);
            }*/

           
            Random X = new Random();

            for (int k = 0; k < 80; k++)
            {
                mayınX = X.Next(20);
                mayınY = X.Next(20);
                if (mayınY != 19)
                {
                    tableLayoutPanel1.Controls.Add(new Label() { Text = "+" }, mayınX, mayınY);
                }
                else
                {
                    mayınX = X.Next(20);
                    mayınY = X.Next(20);
                }

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            
            if (saniye >= 60)
            {
                dakika++;
                saniye = 0;
            }
            label4.Text = "Zaman " + dakika + ":" + saniye;



        }

        private void YakınMayın()
        {
            int yakınMayın=0;

           /* for(int k = 0; k < 20; k++)
            {
                for(int l = 0; l < 20; l++)
                {
                    if (i == diziX[k] && (j++) == diziY[l])
                    {
                        yakınMayın++;
                        j--;
                    }
                }
                
            }
            
             */  
            


            label3.Text = "Mayınlara Yakın " + yakınMayın.ToString();
            yakınMayın = 0;

        }

    }
}
