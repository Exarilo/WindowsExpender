using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsExpender
{
    public class Character
    {
        private string name;
        private int currentLVL;
        private int currentXP;
        private int maxXP;
        private double multiplierXP;
        private int rarity;
        private int currentPositionX;
        private int currentPositionY;


        public Character(string name, int rarity)
        {
            this.name = name;
            this.rarity = rarity;
            currentLVL = 1;
            currentXP = 0;
            multiplierXP = 1.2;
            currentPositionX = 0;
            currentPositionY = 0;
        }

        public string Name
        {
            get => name;
        }

        public int Rarity
        {
            get => rarity;
            set => rarity = value;
        }

        public int CurrentPositionX
        {
            get => currentPositionX;
            set => currentPositionX = value;
        }

        public int CurrentPositionY
        {
            get => currentPositionY;
            set => currentPositionY = value;
        }

        public double MultiplierXP
        {
            get => multiplierXP;
        }

        public int CurrentLVL
        {
            get => currentLVL;
            set => currentLVL = value;
        }

        public int CurrentXP
        {
            get => currentXP;
            set
            {
                if (value >= maxXP)
                {
                    currentXP = value - maxXP;
                    currentLVL++;
                    maxXP = Convert.ToInt32(maxXP * multiplierXP);
                }
            }
        }
    }
}
