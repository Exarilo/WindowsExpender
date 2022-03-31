using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsExpender
{
    public class Mine
    {
        private string formName;
        private Block block;
        private uint currentPixelsMine;
        private int numberOfMinor;
        List<Character> characters;
        List<Form> forms;
        int[] currentMinigArea;

        public Mine(string formName, Block block)
        {
            this.block = block;
            this.formName = formName;
            currentMinigArea = new int[] { 100, 100 };
            currentPixelsMine = (uint)(currentMinigArea[0]* currentMinigArea[1]);
            numberOfMinor = 0;
            characters = new List<Character>();
            forms = new List<Form>();
        }

        public void CreateMine()
        {
            //CREATE FORM
            Form form = new Form();
            form.Text = formName;
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            forms.Add(form);

            //CREATE DEFAULT MINING AREA WITH A PICTURE BOX
            PictureBox backgroundPixels = new PictureBox();
            backgroundPixels.Dock = DockStyle.Fill;
            backgroundPixels.BackColor = block.Color;
            backgroundPixels.Image = new Bitmap(Constants.defaultWidth, Constants.defaultWidth);
            backgroundPixels.Paint += new PaintEventHandler(PictureBox_Paint);

            //ADD PICTUBOX TO FORM
            form.Controls.Add(backgroundPixels);
        }
        private void PictureBox_Paint(object sender, PaintEventArgs args)
        {
            //RESET AREA
            PictureBox pbArea = sender as PictureBox;
            Graphics g = args.Graphics;
            Brush repaintBrush = new SolidBrush(block.Color);
            g.FillRectangle(repaintBrush, pbArea.Location.X, pbArea.Location.Y, pbArea.Width, pbArea.Height);
            pbArea.Invalidate();

            //SET NEW DEFAULT AREA
            int width = currentMinigArea[0];
            int height = currentMinigArea[1];
            int x = pbArea.Width / 2 - width / 2;
            int y = pbArea.Bottom - 100;

            g.FillRectangle(Brushes.White, x, y, width, height);
            g.DrawRectangle(Pens.Black, x, y, width, height);
            
            forms[0].Size = new Size(forms[0].Width + 1, forms[0].Height + 1);
        }

        public int[] CurrentMinigArea
        {
            get => currentMinigArea;
            set => currentMinigArea = value;
        }

        public List<Form> Forms
        {
            get => forms;
            set => forms = value;
        }

        public uint CurrentPixelsMine
        {
            get => currentPixelsMine;
            set => currentPixelsMine = value;
        }

        public int NumberOfMinor
        {
            get => numberOfMinor;
            set => numberOfMinor = value;
        }
        public Block Block
        {
            get => block;
            set => block = value;
        }
        public string FormName
        {
            get => formName;
        }
    }
}
