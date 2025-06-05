using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreVacayNuttiest
{
    internal class Coin
    {
        public char Id { get; private set; }
        public bool Authentic { get; private set; }
        public double Weight { get; private set; }

        public Coin(char letter, bool authenticity)
        {
            Id = letter;
            Weight = AssignCoinWeight(authenticity);
        }

        private double AssignCoinWeight(bool authenticity)
        {
            double weight;
            switch (authenticity)
            {
                case true:
                    weight = 1;
                    break;
                case false:
                    weight = 2;
                    break;
            }
            return weight;
        }
        
        // method to add coin, after assigning authenticity state
    }
}
