using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsExpender
{
    class Inventory
    {
        private static uint golds=0;
        private static List<Block> blocks;
        private static List<Character> ownedCharacters;

        static Inventory()
        {
            golds = 0;
            blocks = new List<Block>();
            ownedCharacters = new List<Character>();
        }
        public static void AddCharacter(Character character)
        {
            if(!ownedCharacters.Contains(character))
                ownedCharacters.Add(character);
        }

        public static void AddBlock(Block block)
        {
            if (!blocks.Contains(block))
                blocks.Add(block);
        }
        public static List<Character> OwnedCharacters
        {
            get => ownedCharacters;
            set => ownedCharacters = value;
        }

        public static List<Block> Blocks
        {
            get => blocks;
            set => blocks = value;
        }

        public static uint Golds
        {
            get => golds;
            set => golds = value;
        }

    }
}
