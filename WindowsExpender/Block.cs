using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsExpender
{
    public class Block
    {
        private string name;
        private uint price;
        private Color color;
        private uint quantity;

        public Block(string name,uint price, Color color)
        {
            this.name = name;
            this.price = price;
            this.color = color;
            quantity = 0;
        }
        public Color Color
        {
            get => color;
            set => color = value;
        }

        public uint Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public uint Price
        {
            get => price;
            set => price = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
