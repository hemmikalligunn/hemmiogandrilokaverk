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

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;

            bits.Text = tempButton.Name;
        
        }
    }
}
