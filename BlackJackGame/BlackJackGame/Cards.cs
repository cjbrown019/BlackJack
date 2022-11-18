using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    public class Cards
    {
        public string Name { get; set; }
        public int FaceValue { get; set; }
        public string Suit { get; set; }

        public Cards(string name, int faceValue, string suit)
        {
            Name = name;
            FaceValue = faceValue;
            Suit = suit;
        }
    }
}
