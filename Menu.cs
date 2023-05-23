using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWMainAssignment
{
    class Menu
    {
        public static int enterUserChoice()
        {
            int choice;
            Console.WriteLine("Press 1: Creating the restaurant");
            Console.WriteLine("Press 2: Display the restaurant");
            Console.WriteLine("Press 3: Create the new Order");
            Console.WriteLine("Press 4: List all the order based on ID staff");
            Console.WriteLine("Press 5: End the program");
            Console.WriteLine("===========================");
            Console.WriteLine("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
