using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWMainAssignment
{
    class FoodItem:FoodBase
    {

        public List<string> FoodItemIngredient{ get; set; }
        public int NumOfDisk { get; set; }
        public FoodItem()
        {

        }

        public FoodItem(string foodBaseID, string foodBaseName, double foodBasePrice,
            FoodCategory foodBaseCategory, List<string> foodItemIngredient)
            : base(foodBaseID, foodBaseName, foodBasePrice, foodBaseCategory)
        {
            FoodItemIngredient = foodItemIngredient;
           
        }

        public int enterNumberOfDisk()
        {

            Console.WriteLine("Enter the number of disk: ");
            NumOfDisk = int.Parse(Console.ReadLine());
            return NumOfDisk;
        }

        public double calPrice()
        {
            return NumOfDisk * base.FoodBasePrice;

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
