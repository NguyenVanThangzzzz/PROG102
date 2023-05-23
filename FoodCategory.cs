using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWMainAssignment
{
    class FoodCategory
    {
        public int FoodCategoryID { get; set; }
        public string FoodCategoryName { get; set; }

        public FoodCategory()
        {

        }

        public FoodCategory(int foodCategoryID)
        {
            FoodCategoryID = foodCategoryID;
        }

        public FoodCategory(int foodCategoryID, string foodCategoryName)
        {
            FoodCategoryID = foodCategoryID;
            FoodCategoryName = foodCategoryName;
        }

        public override string ToString()
        {
            return "FoodCategory "+ FoodCategoryID+" "+FoodCategoryName;
        }
    }
}
