using System;
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
        int currentX = 0;
        int currentY = 0;


        Button[] World = new Button[1984];

        public Form1()
        {
            InitializeComponent();
            CreateWorld1();
        }

        public void CreateWorld1()
        {
            int y = 28;
            int x = 3;

            for (int i = 0; i < World.Length; i++)
            {
                currentX++;

                teljari1++;

                
                World[i] = new Button();
                World[i].Size = new Size(15, 15);
                World[i].Location = new Point(x, y);
                World[i].Name = (currentX + ":" + currentY);
                World[i].BackColor = Color.LightGreen;
               
                x = x + 15;
                if (teljari1 == 62)
                {
                    teljari2++;
                    currentX = 0;
                    x = 3;
                    y = y + 15;
                    teljari1 = 0;
                    currentY++;
                }
                this.World[i].Click += Form1_Click;
                this.Controls.Add(World[i]);
            }

            //MapDesign

            StartingPos(31, 20);

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
            Tré1(15, 28);
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

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;

            bits.Text = tempButton.Name;
        
        }
        //MapDesignTools

        public void StartingPos(int x, int y)
        {
            for (int i = 0; i < World.Length; i++)
            {
                if (World[i].Name == x + ":" + y)
                {
                    World[i].BackColor = Color.Black;
                }
            }
        }

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
                }

            }
        }
        public void Tré3(int x, int y)
        {
            for (int i = 0; i < World.Length; i++)
            {
                if (World[i].Name == x + ":" + y)
                {
                    World[i].BackColor = Color.DarkGreen;
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
                }
                if (World[i].Name == (x + 1) + ":" + y || World[i].Name == (x + 3) + ":" + y ||
                    World[i].Name == (x + 1) + ":" + (y + 1) || World[i].Name == (x + 1) + ":" + (y + 2) || World[i].Name == (x + 1) + ":" + (y + 3) || World[i].Name == (x + 1) + ":" + (y + 4) || World[i].Name == (x + 1) + ":" + (y + 5) ||
                    World[i].Name == (x + 3) + ":" + (y + 1) || World[i].Name == (x + 3) + ":" + (y + 2) || World[i].Name == (x + 3) + ":" + (y + 3) || World[i].Name == (x + 3) + ":" + (y + 4) || World[i].Name == (x + 3) + ":" + (y + 5))
                {
                    World[i].BackColor = Color.FromArgb(78, 47, 18);
                }
                if (World[i].Name == (x + 2) + ":" + y ||
                    World[i].Name == (x + 2) + ":" + (y + 1) || World[i].Name == (x + 2) + ":" + (y + 2) || World[i].Name == (x + 2) + ":" + (y + 3) || World[i].Name == (x + 2) + ":" + (y + 4) || World[i].Name == (x + 2) + ":" + (y + 5))
                {
                    World[i].BackColor = Color.FromArgb(86, 51, 20);
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
                }
                if (World[i].Name == x + ":" + (y + 1) || World[i].Name == (x + 1) + ":" + (y + 1) || World[i].Name == (x + 2) + ":" + (y + 1) || World[i].Name == (x + 3) + ":" + (y + 1) || World[i].Name == (x + 4) + ":" + (y + 1) || World[i].Name == (x + 5) + ":" + (y + 1) ||
                    World[i].Name == x + ":" + (y + 3) || World[i].Name == (x + 1) + ":" + (y + 3) || World[i].Name == (x + 2) + ":" + (y + 3) || World[i].Name == (x + 3) + ":" + (y + 3) || World[i].Name == (x + 4) + ":" + (y + 3) || World[i].Name == (x + 5) + ":" + (y + 3))
                {
                    World[i].BackColor = Color.FromArgb(78, 47, 18);
                }
                if (World[i].Name == x + ":" + (y + 2) || World[i].Name == (x + 1) + ":" + (y + 2) || World[i].Name == (x + 2) + ":" + (y + 2) || World[i].Name == (x + 3) + ":" + (y + 2) || World[i].Name == (x + 4) + ":" + (y + 2) || World[i].Name == (x + 5) + ":" + (y + 2))
                {
                    World[i].BackColor = Color.FromArgb(86, 51, 20);
                }

            }
        }
    }
}