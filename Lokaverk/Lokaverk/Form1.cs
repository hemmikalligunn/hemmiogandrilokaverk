﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lokaverk
{
    public partial class Form1 : Form
    {
        int teljari1 = 0, teljari2 = 0;
        int tal1 = 0;
        int currentX = 31;
        int currentY = 20;
        int X = 0;
        int Y = 0;
        int basemovementspeed = 1;
        int ja = 0;
        int nei = 0;
        int tikk = 0;
        int tikk2 = 0;
        int ingosilungar = 0;

        System.DateTime moment = new System.DateTime(1, 1, 1, 1, 1, 1, 1);
      
        Random rand = new Random();
        
      

        Button[] World = new Button[1984];

        public Form1()
        {
            InitializeComponent();
            
        }

        public void CreateWorld1()
        {
            int y = 28;
            int x = 3;

            for (int i = 0; i < World.Length; i++)
            {
                X++;

                teljari1++;

                
                World[i] = new Button();
                World[i].Size = new Size(15, 15);
                World[i].Location = new Point(x, y);
                World[i].Name = (X + ":" + Y);
                World[i].BackColor = Color.LightGreen;
                if (World[i].BackColor == Color.LightGreen)
                {
                    World[i].Text = "green";
                    World[i].ForeColor = World[i].BackColor;
                }
                if (World[i].Name == 17 + ":" + 16)
                {
                    World[i].BackColor = Color.Black;
                    World[i].Text = "gamall";
                    World[i].ForeColor = World[i].BackColor;
                }
                if (World[i].Name == currentX + ":" + currentY)
                {
                    World[i].BackColor = Color.Black;
                    World[i].ForeColor = World[i].BackColor;
                }
                
                
                x = x + 15;
                if (teljari1 == 62)
                {
                    teljari2++;
                    X = 0;
                    x = 3;
                    y = y + 15;
                    teljari1 = 0;
                    Y++;
                }
                this.World[i].Click += Form1_Click;
                this.Controls.Add(World[i]);

              
            }


            //MapDesign

            

            Tré1(32, 10);
            Tré1(20, 25);
            Tré1(23, 5);
            Tré1(4, 3);
            Tré1(11, 6);
            Tré1(16, 1);
            Tré1(16, 8);
            Tré1(14, 21);
            Tré1(9, 26);
            Tré1(3, 25);
            Tré1(8, 0);
            Tré1(1, 9);
            Tré1(1, 15);
            Tré2(11, 2);
            Tré1(5, 30);
            Tré3(15, 28);
            Tré2(46, 2);
            Tré2(48, 10);
            Tré2(44, 21);
            Tré2(1, 0);
            Tré2(3, 20);
            Tré2(6, 23);
            Tré2(19, 19);
            Tré2(25, 12);
            Tré2(34, 25);
            Tré2(6, 7);
            Tré3(50, 28);
            Tré2(22, 24);
            Hús1v2(5, 10);
            Hús1v1(5, 16);
            Hús1v2(12, 11);
            Vatn(58, 4);
            Brú(57,9);
            Kú(33, 5);

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;

            bits.Text = tempButton.Name;
            if (tempButton.BackColor == Color.DarkGreen)
            {
                RTB2.Clear();
                RTB2.Text += "Tré \n";                   
            }
            if (tempButton.BackColor == Color.LightGreen)
            {
                RTB2.Clear();
                RTB2.Text += "grass \n";
            }
            
            if (tempButton.BackColor == Color.FromArgb(69, 36, 14) || tempButton.BackColor == Color.FromArgb(78, 47, 18) || tempButton.BackColor == Color.FromArgb(86, 51, 20))
            {
                RTB2.Clear();
                RTB2.Text += "Lítill kofi \n";
            }
            if (tempButton.BackColor == Color.Black)
            {
                RTB2.Clear();
                RTB2.Text += "Þú \n";
            }
            if (tempButton.BackColor == Color.Black && tempButton.Text == "gamall")
            {
                RTB2.Clear();
                RTB2.Text += "Gamall kall sem virðist vera í vanda \n";
            }
            if (tempButton.BackColor == Color.Blue)
            {
                RTB2.Clear();
                RTB2.Text += "vatn \n";
            }
            if (tempButton.BackColor == Color.Brown)
            {
                RTB2.Clear();
                RTB2.Text += "Brú \n";
            }





        }
        //MapDesignTools

       


        //tré
        public void Tré1(int x, int y)
        {
            for (int i = 0; i < World.Length; i++)
            {
                if (World[i].Name == x + ":" + y || World[i].Name == (x + 1) + ":" + y || World[i].Name == (x + 1) + ":" + (y + 1) || World[i].Name == (x + 1) + ":" + (y - 1) || World[i].Name == (x + 2) + ":" + y || World[i].Name == x + ":" + (y + 1) ||
                    World[i].Name == x + ":" + (y + 2) || World[i].Name == (x - 1) + ":" + y || World[i].Name == (x - 2) + ":" + y || World[i].Name == x + ":" + (y - 1) || World[i].Name == x + ":" + (y - 2) || World[i].Name == (x - 1) + ":" + (y - 1) ||
                    World[i].Name == (x - 1) + ":" + (y + 1))
                {
                    World[i].BackColor = Color.DarkGreen;
                    World[i].ForeColor = World[i].BackColor;
                }

            }


        }
        public void Tré2(int x, int y)
        {
            for (int i = 0; i < World.Length; i++)
            {
                if (World[i].Name == x + ":" + y || World[i].Name == (x + 1) + ":" + y || World[i].Name == x + ":" + (y + 1) || World[i].Name == (x - 1) + ":" + y || World[i].Name == x + ":" + (y - 1))
                {
                    World[i].BackColor = Color.DarkGreen;
                    World[i].ForeColor = World[i].BackColor;
                }

            }
        }
        public void Tré3(int x, int y)
        {
            for (int i = 0; i < World.Length; i++)
            {
                if (World[i].Name == x + ":" + y || World[i].Name == (x + 1) + ":" + y || World[i].Name == (x + 1) + ":" + (y + 1) || World[i].Name == (x + 1) + ":" + (y - 1) || World[i].Name == (x + 2) + ":" + y || World[i].Name == x + ":" + (y + 1) ||
                    World[i].Name == x + ":" + (y + 2) || World[i].Name == (x - 1) + ":" + y || World[i].Name == (x - 2) + ":" + y || World[i].Name == x + ":" + (y - 1) || World[i].Name == x + ":" + (y - 2) || World[i].Name == (x - 1) + ":" + (y - 1) ||
                    World[i].Name == (x - 1) + ":" + (y + 1) || World[i].Name == (x + 3) + ":" + y || World[i].Name == (x - 3) + ":" + y || World[i].Name == x + ":" + (y + 3) || World[i].Name == x + ":" + (y - 3) || World[i].Name == (x + 2) + ":" + (y - 1)
                    || World[i].Name == (x + 2) + ":" + (y + 1) || World[i].Name == (x - 1) + ":" + (y + 2) || World[i].Name == (x + 1) + ":" + (y + 2) || World[i].Name == (x + 1) + ":" + (y - 2) || World[i].Name == (x - 2) + ":" + (y - 1) || World[i].Name == (x - 2) + ":" + (y + 1)
                    || World[i].Name == (x - 1) + ":" + (y -2))
                {
                    World[i].BackColor = Color.DarkGreen;
                    World[i].ForeColor = World[i].BackColor;
                }

            }
        }

        //Vatn
        public void Vatn(int x, int y)
        {
            for (int i = 0; i < World.Length; i++)
            {
                if (World[i].Name == x + ":" + y || World[i].Name == (x + 1) + ":" + y || World[i].Name == (x + 2) + ":" + y || World[i].Name == (x + 3) + ":" + y || World[i].Name == (x + 4) + ":" + y || World[i].Name == (x - 1) + ":" + y || World[i].Name == (x - 2) + ":" + y ||
                    World[i].Name == (x - 3) + ":" + y || World[i].Name == (x - 4) + ":" + y || World[i].Name == x + ":" + (y + 1) || World[i].Name == x + ":" + (y + 2) || World[i].Name == x + ":" + (y + 3) || World[i].Name == x + ":" + (y + 4) || World[i].Name == (x + 1) + ":" + (y + 1)
                    || World[i].Name == (x + 2) + ":" + (y + 2) || World[i].Name == (x + 3) + ":" + (y + 3) || World[i].Name == (x + 4) + ":" + (y + 4) || World[i].Name == (x - 1) + ":" + (y + 1) || World[i].Name == (x - 2) + ":" + (y + 2) || World[i].Name == (x - 3) + ":" + (y + 3)
                    || World[i].Name == (x - 4) + ":" + (y + 4) || World[i].Name == (x + 2) + ":" + (y + 1) || World[i].Name == (x + 3) + ":" + (y + 1) || World[i].Name == (x + 4) + ":" + (y + 1) || World[i].Name == (x - 2) + ":" + (y + 1) || World[i].Name == (x - 3) + ":" + (y + 1)
                    || World[i].Name == (x - 4) + ":" + (y + 1) || World[i].Name == (x - 1) + ":" + (y + 2) || World[i].Name == (x - 3) + ":" + (y + 2) || World[i].Name == (x - 4) + ":" + (y + 2) || World[i].Name == (x + 1) + ":" + (y + 2) || World[i].Name == (x + 3) + ":" + (y + 2)
                    || World[i].Name == (x + 4) + ":" + (y + 2) || World[i].Name == (x - 1) + ":" + (y + 3) || World[i].Name == (x - 2) + ":" + (y + 3) || World[i].Name == (x - 4) + ":" + (y + 3) || World[i].Name == (x + 1) + ":" + (y + 3) || World[i].Name == (x + 2) + ":" + (y + 3)
                    || World[i].Name == (x + 4) + ":" + (y + 3) || World[i].Name == (x + 1) + ":" + (y + 4) || World[i].Name == (x + 2) + ":" + (y + 4) || World[i].Name == (x + 3) + ":" + (y + 4) || World[i].Name == (x - 1) + ":" + (y + 4) || World[i].Name == (x - 2) + ":" + (y + 4)
                    || World[i].Name == (x - 3) + ":" + (y + 4) || World[i].Name == (x - 1) + ":" + (y - 1) || World[i].Name == (x - 2) + ":" + (y - 1) || World[i].Name == (x - 3) + ":" + (y - 1) || World[i].Name == (x - 4) + ":" + (y - 1) || World[i].Name == x + ":" + (y - 1)
                    || World[i].Name == (x + 1) + ":" + (y - 1) || World[i].Name == (x + 2) + ":" + (y - 1) || World[i].Name == (x + 3) + ":" + (y - 1) || World[i].Name == (x + 4) + ":" + (y - 1) || World[i].Name == (x - 1) + ":" + (y - 2) || World[i].Name == (x - 2) + ":" + (y - 2)
                    || World[i].Name == (x - 3) + ":" + (y - 2) || World[i].Name == (x - 4) + ":" + (y - 2) || World[i].Name == x + ":" + (y - 2) || World[i].Name == (x + 1) + ":" + (y - 2) || World[i].Name == (x + 2) + ":" + (y - 2) || World[i].Name == (x + 3) + ":" + (y - 2)
                    || World[i].Name == (x + 4) + ":" + (y - 2) || World[i].Name == (x - 1) + ":" + (y - 3) || World[i].Name == (x - 2) + ":" + (y - 3) || World[i].Name == (x - 3) + ":" + (y - 3) || World[i].Name == (x - 4) + ":" + (y - 3) || World[i].Name == x + ":" + (y - 3)
                    || World[i].Name == (x + 1) + ":" + (y - 3) || World[i].Name == (x + 2) + ":" + (y - 3) || World[i].Name == (x + 3) + ":" + (y - 3) || World[i].Name == (x + 4) + ":" + (y - 3) || World[i].Name == (x - 1) + ":" + (y - 4) || World[i].Name == (x - 2) + ":" + (y - 4)
                    || World[i].Name == (x - 3) + ":" + (y - 4) || World[i].Name == (x - 4) + ":" + (y - 4) || World[i].Name == x + ":" + (y - 4) || World[i].Name == (x + 1) + ":" + (y - 4) || World[i].Name == (x + 2) + ":" + (y - 4) || World[i].Name == (x + 3) + ":" + (y - 4)
                    || World[i].Name == (x + 4) + ":" + (y - 4) || World[i].Name == (x - 5) + ":" + (y + 5) || World[i].Name == (x - 5) + ":" + (y + 4) || World[i].Name == (x - 4) + ":" + (y + 5) || World[i].Name == (x - 6) + ":" + (y + 6) || World[i].Name == (x - 6) + ":" + (y + 5)
                    || World[i].Name == (x - 5) + ":" + (y + 6) || World[i].Name == (x - 5) + ":" + (y - 3) || World[i].Name == (x - 5) + ":" + (y - 2) || World[i].Name == (x - 6) + ":" + (y - 3) || World[i].Name == x + ":" + (y + 5) || World[i].Name == (x + 1) + ":" + (y + 5)
                    || World[i].Name == (x + 2) + ":" + (y + 5) || World[i].Name == (x + 3) + ":" + (y + 5) || World[i].Name == (x + 4) + ":" + (y + 5) || World[i].Name == (x + 2) + ":" + (y + 6) || World[i].Name == (x + 3) + ":" + (y + 6) || World[i].Name == (x + 4) + ":" + (y + 6)
                    || World[i].Name == (x + 3) + ":" + (y + 7) || World[i].Name == (x + 4) + ":" + (y + 7) || World[i].Name == (x + 4) + ":" + (y + 8))
                {
                    World[i].BackColor = Color.Blue;
                    World[i].ForeColor = Color.Green;
                    World[i].Text = "/";
                }
            }
        }

        //Hús
        public void Hús1v1(int x, int y)
        {
            for (int i = 0; i < World.Length; i++)
            {
                if (World[i].Name == x + ":" + y || World[i].Name == (x + 4) + ":" + y ||
                    World[i].Name == x + ":" + (y + 1) || World[i].Name == x + ":" + (y + 2) || World[i].Name == x + ":" + (y + 3) || World[i].Name == x + ":" + (y + 4) || World[i].Name == x + ":" + (y + 5) ||
                    World[i].Name == (x + 4) + ":" + (y + 1) || World[i].Name == (x + 4) + ":" + (y + 2) || World[i].Name == (x + 4) + ":" + (y + 3) || World[i].Name == (x + 4) + ":" + (y + 4) || World[i].Name == (x + 4) + ":" + (y + 5))
                {

                    World[i].BackColor = Color.FromArgb(69, 36, 14);
                    World[i].ForeColor = World[i].BackColor;
                }
                if (World[i].Name == (x + 1) + ":" + y || World[i].Name == (x + 3) + ":" + y ||
                    World[i].Name == (x + 1) + ":" + (y + 1) || World[i].Name == (x + 1) + ":" + (y + 2) || World[i].Name == (x + 1) + ":" + (y + 3) || World[i].Name == (x + 1) + ":" + (y + 4) || World[i].Name == (x + 1) + ":" + (y + 5) ||
                    World[i].Name == (x + 3) + ":" + (y + 1) || World[i].Name == (x + 3) + ":" + (y + 2) || World[i].Name == (x + 3) + ":" + (y + 3) || World[i].Name == (x + 3) + ":" + (y + 4) || World[i].Name == (x + 3) + ":" + (y + 5))
                {
                    World[i].BackColor = Color.FromArgb(78, 47, 18);
                    World[i].ForeColor = World[i].BackColor;
                }
                if (World[i].Name == (x + 2) + ":" + y ||
                    World[i].Name == (x + 2) + ":" + (y + 1) || World[i].Name == (x + 2) + ":" + (y + 2) || World[i].Name == (x + 2) + ":" + (y + 3) || World[i].Name == (x + 2) + ":" + (y + 4) || World[i].Name == (x + 2) + ":" + (y + 5))
                {
                    World[i].BackColor = Color.FromArgb(86, 51, 20);
                    World[i].ForeColor = World[i].BackColor;
                }
            }

        }

        public void Hús1v2(int x, int y)
        {
            for (int i = 0; i < World.Length; i++)
            {
                if (World[i].Name == x + ":" + y || World[i].Name == (x + 1) + ":" + y || World[i].Name == (x + 2) + ":" + y || World[i].Name == (x + 3) + ":" + y || World[i].Name == (x + 4) + ":" + y || World[i].Name == (x + 5) + ":" + y ||
                    World[i].Name == x + ":" + (y + 4) || World[i].Name == (x + 1) + ":" + (y + 4) || World[i].Name == (x + 2) + ":" + (y + 4) || World[i].Name == (x + 3) + ":" + (y + 4) || World[i].Name == (x + 4) + ":" + (y + 4) || World[i].Name == (x + 5) + ":" + (y + 4))
                {
                    World[i].BackColor = Color.FromArgb(69, 36, 14);
                    World[i].ForeColor = World[i].BackColor;
                }
                if (World[i].Name == x + ":" + (y + 1) || World[i].Name == (x + 1) + ":" + (y + 1) || World[i].Name == (x + 2) + ":" + (y + 1) || World[i].Name == (x + 3) + ":" + (y + 1) || World[i].Name == (x + 4) + ":" + (y + 1) || World[i].Name == (x + 5) + ":" + (y + 1) ||
                    World[i].Name == x + ":" + (y + 3) || World[i].Name == (x + 1) + ":" + (y + 3) || World[i].Name == (x + 2) + ":" + (y + 3) || World[i].Name == (x + 3) + ":" + (y + 3) || World[i].Name == (x + 4) + ":" + (y + 3) || World[i].Name == (x + 5) + ":" + (y + 3))
                {
                    World[i].BackColor = Color.FromArgb(78, 47, 18);
                    World[i].ForeColor = World[i].BackColor;
                }
                if (World[i].Name == x + ":" + (y + 2) || World[i].Name == (x + 1) + ":" + (y + 2) || World[i].Name == (x + 2) + ":" + (y + 2) || World[i].Name == (x + 3) + ":" + (y + 2) || World[i].Name == (x + 4) + ":" + (y + 2) || World[i].Name == (x + 5) + ":" + (y + 2))
                {
                    World[i].BackColor = Color.FromArgb(86, 51, 20);
                    World[i].ForeColor = World[i].BackColor;
                }

            }
        }
        //brú 

        public void Brú(int x, int y)
        {
            for (int i = 0; i < World.Length; i++)
            {
                if (World[i].Name == x + ":" + (y-1) || World[i].Name == x + ":" + (y-2) || World[i].Name == x + ":" + (y-3))
                {
                    World[i].BackColor = Color.Brown;
                    World[i].Text = "brown";
                    World[i].ForeColor = World[i].BackColor;
                    
                   
                }
            }
        }

        //ai
 
        //kú

        public void Kú(int x, int y)
        {
            int second = moment.Second;

            for (int i = 0; i < World.Length; i++)
            {
                if (World[i].Name == x+":"+y)
                {
                    World[i].BackColor = Color.White;
                    World[i].Text = "kú";                    
                    World[i].ForeColor = World[i].BackColor;

                }
                if (World[i].Name == (x-1) + ":" + y)
                {
                    World[i].BackColor = Color.Black;
                    World[i].Text = "kú1";
                    World[i].ForeColor = World[i].BackColor;
                }
            
            }

           
            
            
        }

        //start
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            button3.Visible = false;
            bits.Visible = true;
            RTB.Visible = true;
            RTB2.Visible = true;
            timer1.Start();
            CreateWorld1();
            AI();
            
        }

        //hjalp
        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            button5.Visible = true;


        }
        //back fra hjalp

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            button5.Visible = false;

        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
                //upp
                if (keyData == Keys.Up)
                {

                    for (int i = 0; i < World.Length; i++)
                    {
                        if (World[i].Name == currentX + ":" + currentY)
                        {
                            if (World[i].Text == "green")
                            {
                                World[i].BackColor = Color.LightGreen;
                                World[i].ForeColor = World[i].BackColor;
                            }
                            if (World[i].Text == "brown")
                            {
                                World[i].BackColor = Color.Brown;
                                World[i].ForeColor = World[i].BackColor;
                            }

                        }
                    }
                  

                    currentY = currentY - basemovementspeed;


                    for (int i = 0; i < World.Length; i++)
                    {
                        if (World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.DarkGreen || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.FromArgb(86, 51, 20)
                            || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.FromArgb(78, 47, 18) || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.FromArgb(69, 36, 14)
                            || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.Black || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.Blue)
                        {
                            currentY = currentY + basemovementspeed;
                        }
                    }

                    for (int i = 0; i < World.Length; i++)
                    {
                        if (World[i].Name == currentX + ":" + currentY)
                        {
                            World[i].BackColor = Color.Black;
                            World[i].ForeColor = World[i].BackColor;
                        }
                    }
                    return true;
                }

            //niður
                if (keyData == Keys.Down)
                {
                    for (int i = 0; i < World.Length; i++)
                    {
                        if (World[i].Name == currentX + ":" + currentY)
                        {
                            if (World[i].Text == "green")
                            {
                                World[i].BackColor = Color.LightGreen;
                                World[i].ForeColor = World[i].BackColor;
                            }
                            if (World[i].Text == "brown")
                            {
                                World[i].BackColor = Color.Brown;
                                World[i].ForeColor = World[i].BackColor;
                            }

                        }
                    }

                    currentY = currentY + basemovementspeed;

                    for (int i = 0; i < World.Length; i++)
                    {
                        if (World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.DarkGreen || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.FromArgb(86, 51, 20)
                            || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.FromArgb(78, 47, 18) || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.FromArgb(69, 36, 14)
                            || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.Black || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.Blue)
                        {
                            currentY = currentY - basemovementspeed;
                        }
                    }

                    for (int i = 0; i < World.Length; i++)
                    {
                        if (World[i].Name == currentX + ":" + currentY)
                        {
                           
                            World[i].BackColor = Color.Black;
                            World[i].ForeColor = World[i].BackColor;
                        }
                    }
                    return true;
                }

            //vinstri
                if (keyData == Keys.Left)
                {
                    for (int i = 0; i < World.Length; i++)
                    {
                        if (World[i].Name == currentX + ":" + currentY)
                        {
                            if (World[i].Text == "green")
                            {
                                World[i].BackColor = Color.LightGreen;
                                World[i].ForeColor = World[i].BackColor;
                            }
                            if (World[i].Text == "brown")
                            {
                                World[i].BackColor = Color.Brown;
                                World[i].ForeColor = World[i].BackColor;
                            }

                        }
                    }

                    currentX = currentX - basemovementspeed;

                    for (int i = 0; i < World.Length; i++)
                    {
                        if (World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.DarkGreen || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.FromArgb(86, 51, 20)
                            || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.FromArgb(78, 47, 18) || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.FromArgb(69, 36, 14)
                            || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.Black || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.Blue)
                        {
                            currentX = currentX + basemovementspeed;
                        }
                    }

                    for (int i = 0; i < World.Length; i++)
                    {
                        if (World[i].Name == currentX + ":" + currentY)
                        {
                            
                            World[i].BackColor = Color.Black;
                            World[i].ForeColor = World[i].BackColor;
                        }
                    }
                    return true;
                }

            //hægri
                if (keyData == Keys.Right)
                {
                    for (int i = 0; i < World.Length; i++)
                    {
                        if (World[i].Name == currentX + ":" + currentY)
                        {
                            if (World[i].Text == "green")
                            {
                                World[i].BackColor = Color.LightGreen;
                                World[i].ForeColor = World[i].BackColor;
                            }
                            if (World[i].Text == "brown")
                            {
                                World[i].BackColor = Color.Brown;
                                World[i].ForeColor = World[i].BackColor;
                            }

                        }
                    }
                    

                    currentX = currentX + basemovementspeed;
                  
                    for (int i = 0; i < World.Length; i++)
                    {
                        if (World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.DarkGreen || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.FromArgb(86, 51, 20)
                            || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.FromArgb(78, 47, 18) || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.FromArgb(69, 36, 14)
                             || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.Black || World[i].Name == currentX + ":" + currentY && World[i].BackColor == Color.Blue)
                        {
                            currentX = currentX - basemovementspeed;
                        }

                    }
                    for (int i = 0; i < World.Length; i++)
                    {
                        if (World[i].Name == currentX + ":" + currentY)
                        {
                            
                            World[i].BackColor = Color.Black;
                            World[i].ForeColor = World[i].BackColor;
                        }
                    }
                    return true;
                }
               

            //SPACEBAR
                if (keyData == Keys.Space  && tal1 == 3 && ja == 1)
                {
                    RTB.Clear();
                    for (int i = 0; i < World.Length; i++)
                    {
                        if (World[i].Name == 57 + ":" + 6 && World[i].BackColor == Color.Black)
                        {
                            tikk2 = rand.Next(1,6);
                            if (tikk2 == 1)
                            {
                                RTB.Text += "Þú náðir einum Ingosilung";
                                ingosilungar++;
                                label2.Text = ingosilungar.ToString();
                            }
                           else
                            {
                                RTB.Text += "Þú náðir eingu";
                            }
                        }
                    }
                }
                if (keyData == Keys.Space && tal1 == 0)
                {
                    for (int i = 0; i < World.Length; i++)
                    {
                        if (tal1 == 0)
                        {
                            if (World[i].Name == 18 + ":" + 16 && World[i].BackColor == Color.Black || World[i].Name == 16 + ":" + 17 && World[i].BackColor == Color.Black || World[i].Name == 17 + ":" + 17 && World[i].BackColor == Color.Black || World[i].Name == 18 + ":" + 17 && World[i].BackColor == Color.Black
                                || World[i].Name == 16 + ":" + 16 && World[i].BackColor == Color.Black)
                            {
                                RTB.Text = "HJÁÁÁÁÁÁÁÁLP";
                                tal1 = 1;
                            }
                        }
                    }
                    return true;
                }
                if (keyData == Keys.Space && tal1 == 1)
                {

                    RTB.Text = "Ég er svangur \n" + "villtu hjálpa mér? \n";
                    tal1 = 2;
                }

                if (keyData == Keys.J && tal1 == 2)
                {
                    ja++;
                    tal1++;
                    RTB.Text = "æðislegt, ég hélt ég þyrfti að gera þetta sjálfur \n " + 
                        "farðu austur og veiddu handa mér 3 Ingosilunga á brúnni á bryggjunni \n " 
                        +"ég skal gefa þér verðlaun (gamli maðurinn blikkar einu auga) ";

                }
                if (keyData == Keys.N && tal1 == 2)
                {
                    tal1++;
                    RTB.Text = "argasti dónaskapur";
                }
                if (keyData == Keys.Space && tal1 == 3 && ingosilungar >= 3)
                {
                    RTB.Text = "ummmm nom nom nom þetta eru fínir fiskar hér er súkkulaði ;) ";
                    
                }
                       
            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Forritarar: \n Hermann Karl Gunnarsson \n Andri Snær Brynjarsson");
        }
       
        private void AI()
        {
            Kú(33, 5);



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tikk = rand.Next(0, 2);
           
        }

       
    }
}