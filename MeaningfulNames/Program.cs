using System;

namespace MeaningfulNames {
    class Program {
        static void Main (string[] args) {
            
            Console.WriteLine ("Display Owner");

            Console.WriteLine ("enter owner");
            var owner = Console.ReadLine ();

            Console.WriteLine ("enter item");
            var item = Console.ReadLine ();

            Console.WriteLine ("enter item count");
            var itemCount = Convert.ToInt32(Console.ReadLine ());

            var naming = new GoodNames(owner, itemCount, item);

            Console.WriteLine(naming.Message());

        }
    }
}