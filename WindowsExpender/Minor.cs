using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsExpender
{
    public class Minor : Character
    {
        private double minigSpeed;

        public Minor(string name, int rarity, double minigSpeed) : base(name, rarity)
        {
            this.minigSpeed = minigSpeed;
        }

        public int test()
        {
            return CurrentLVL;
        }

        public double MiningSpeed
        {
            get => minigSpeed;
            set => minigSpeed = value;
        }
    }
}
