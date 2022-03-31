using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsExpender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Tutorial();
            //Bitmap newBitmap = new Bitmap(100,100);
            //newBitmap = ChangeColor(newBitmap);
            //pictureBox2.Image= newBitmap.Clone(new Rectangle(0, 0, newBitmap.Width, newBitmap.Height),System.Drawing.Imaging.PixelFormat.DontCare);
            
            Block block = new Block("Fer",100, Color.Red);
            Mine mine = new Mine("Mine de fer", block);
            mine.CreateMine();
            mine.CreateMine();
            foreach (Form form in mine.Forms)
            {
                form.ShowDialog();
            }
        }
        
        public void Tutorial()
        {
            Minor minor = new Minor("Perso2Base", 1, 1);
            Inventory.AddCharacter(minor);
            Block block = new Block("Fer", 100, Color.Red);
            Mine mine = new Mine("Mine de fer", block);

        }

        public static Bitmap ChangeColor(Bitmap scrBitmap)
        {
            //You can change your new color here. Red,Green,LawnGreen any..
            Color newColor = Color.Blue;
            Color actualColor;
            //make an empty bitmap the same size as scrBitmap
            Bitmap newBitmap = new Bitmap(scrBitmap.Width, scrBitmap.Height);
            for (int i = 0; i < scrBitmap.Width; i++)
            {
                for (int j = 0; j < scrBitmap.Height; j++)
                {
                    //get the pixel from the scrBitmap image
                    actualColor = scrBitmap.GetPixel(i, j);
                    // > 150 because.. Images edges can be of low pixel colr. if we set all pixel color to new then there will be no smoothness left.
                    if (actualColor.A > 150)
                        newBitmap.SetPixel(i, j, newColor);
                    else
                        newBitmap.SetPixel(i, j, actualColor);
                }
            }
            return newBitmap;
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            g.FillRectangle(Brushes.Yellow, 10, 10, 10, 10);
            g.DrawRectangle(Pens.Black, 10, 10, 100, 100);
        }
    }
}
