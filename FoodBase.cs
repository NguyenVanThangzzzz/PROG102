using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWMainAssignment
{
    class FoodBase
    {
        public string FoodBaseID { get; set; }
        public string FoodBaseName { get; set; }
        public double FoodBasePrice { get; set; }
        public FoodCategory FoodBaseCategory { get; set; }

        public FoodBase()
        {

        }

        public FoodBase(string foodBaseID)
        {
            FoodBaseID = foodBaseID;
        }

        public FoodBase(string foodBaseID, string foodBaseName, double foodBasePrice, FoodCategory foodBaseCategory)
        {
            FoodBaseID = foodBaseID;
            FoodBaseName = foodBaseName;
            FoodBasePrice = foodBasePrice;
            FoodBaseCategory = foodBaseCategory;
        }

        public override string ToString()
        {
            return "FoodBase: "+ FoodBaseID+" "+ FoodBaseName + " " + FoodBasePrice + " " + FoodBaseCategory.FoodCategoryName;
        }
    }
}
