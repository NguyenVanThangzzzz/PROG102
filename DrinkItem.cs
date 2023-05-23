using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWMainAssignment
{
    class DrinkItem:FoodBase
    {
        public List<string> DrinkItemCombo { get; set; }
        public bool IsAvailable { get; set; }
        public int NumOfBottle { get; set; }
        public DrinkItem()
        {

        }

        public DrinkItem(string foodBaseID, string foodBaseName, double foodBasePrice, 
            FoodCategory foodBaseCategory, List<string> drinkItemCombo, bool isAvailable)
            :base(foodBaseID, foodBaseName, foodBasePrice, foodBaseCategory)
        {
            DrinkItemCombo = drinkItemCombo;
            IsAvailable = isAvailable;
        }

        public int enterNumberOfBottle()
        {
            
            Console.WriteLine("Enter the number of bottle: ");
            NumOfBottle = int.Parse(Console.ReadLine());
            return NumOfBottle;
        }

        public double calPrice()
        {
            return NumOfBottle * base.FoodBasePrice;

        }
        public override string ToString()
        {
            return base.ToString()+" is available"+ IsAvailable;
        }
    }
}
