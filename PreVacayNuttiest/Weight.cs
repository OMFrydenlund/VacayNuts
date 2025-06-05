using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreVacayNuttiest
{
    internal class Weight
    {
        private List<Coin> BagOfGold { get; set; }

        public Weight()
        {
            BagOfGold = new List<Coin>()
            {
                new Coin('A', true),
                new Coin('B', true),
                new Coin('C', true),
                new Coin('D', true),
                new Coin('E', true),
                new Coin('F', true),
                new Coin('G', true),
                new Coin('H', true),
                new Coin('I', true),
                new Coin('J', true),
                new Coin('K', true),
                new Coin('L', false)
            };
            var collectionA = BagOfGold.Take(4).ToList();
            var collectionB = BagOfGold.Skip(4).Take(4).ToList();
            var collectionC = BagOfGold.Skip(8).ToList();

            int firstResult = CompareWeight(collectionA, collectionB);
            Console.WriteLine($"Checking groups A: {PrintCoinsInCollection(collectionA)} and B: {PrintCoinsInCollection(collectionB)}");

            if (firstResult == 0)
            {
                Console.WriteLine("Groups A and B have equal values, checking group C.");
                Console.WriteLine($"C collection: {PrintCoinsInCollection(collectionC)}");
                FindFakeCoin(collectionC);
            }
            else if (firstResult < 0)
            {
                //collectionB is lighter
                Console.WriteLine("\nA is heavier than B");
                Console.WriteLine($"Fake coin is in this group: {PrintCoinsInCollection(collectionA)}");
                FindFakeCoin(collectionA);
            }
            else
            {
                //collectionA is lighter
                Console.WriteLine("\nB is heavier than A");
                Console.WriteLine($"Fake coin is in this group: {PrintCoinsInCollection(collectionB)}");
                FindFakeCoin(collectionB);
            }

            Console.ReadLine();
        }

        private int CompareWeight(List<Coin> a, List<Coin> b)
        {
            double weightA = a.Sum(c => c.Weight);
            double weightB = b.Sum(c => c.Weight);

            if (weightA > weightB)
            {
                return -1;
            }
            else if (weightA < weightB)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void FindFakeCoin(List<Coin> coins)
        {
            var g1 = coins.Take(2).ToList();
            var g2 = coins.Skip(2).Take(2).ToList();

            Console.WriteLine($"Group 1: {PrintCoinsInCollection(g1)}");
            Console.WriteLine($"Group 2: {PrintCoinsInCollection(g2)}");

            int secondResult = CompareWeight(g1, g2);
            List<Coin> suspectGroup;

            if (secondResult >  0)
            {
                Console.WriteLine("Group 2 has the fake coin");
                suspectGroup = g2;
            }
            else if (secondResult < 0)
            {
                Console.WriteLine("Group 1 has the fake coin");
                suspectGroup = g1;
            }
            else
            {
                suspectGroup = null;

            }

            if (suspectGroup.Count == 2){
                int testResult = CompareWeight(
                    new List<Coin> { suspectGroup[0] },
                    new List<Coin> { suspectGroup[1] }
                    );
                if (testResult == 0)
                {
                    Console.WriteLine($"\nUnable to determine fake between {suspectGroup[0].Id} and {suspectGroup[1].Id}");
                }
                else if( testResult < 0)
                {
                    Console.WriteLine($"\nFake coin is {suspectGroup[0].Id}");
                }
                else
                {
                    Console.WriteLine($"\nFake coin is {suspectGroup[1].Id}");
                }
            }
        }

        private string PrintCoinsInCollection(List<Coin> coins)
        {
            string textToReturn = "";
            foreach (Coin c in coins)
            {
                textToReturn += c.Id;
            }
            textToReturn += " ";
            return textToReturn;
        }
    }
}
