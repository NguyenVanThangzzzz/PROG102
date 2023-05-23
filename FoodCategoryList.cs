using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWMainAssignment
{
    class FoodCategoryList
    {
        private List<FoodCategory> foodCategoryInRes = new List<FoodCategory>();
        internal List<FoodCategory> FoodCategoryInRes { get => foodCategoryInRes; set => foodCategoryInRes = value; }
        public FoodCategoryList()
        {
            foodCategoryInRes.Add(new FoodCategory(1, "Food"));
            foodCategoryInRes.Add(new FoodCategory(2, "Drink"));
            foodCategoryInRes.Add(new FoodCategory(3, "Desesert"));

        }
        public void displayCategoryList()
        {
            foreach (var item in foodCategoryInRes)
            {
                Console.WriteLine(item.ToString());
            }
        }


    }
}
