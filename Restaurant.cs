using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWMainAssignment
{
    class Restaurant
    {
        public string RestName { get; set; }
        public TableList RestTableList { get; set; }
        public FoodItemList RestFoodItemList { get; set; }

        public List<string> StaffList { get; set; }
        public Restaurant()
        {

        }

        public Restaurant(string restName, TableList restTableList, FoodItemList restFoodItemList, List<string> staffList)
        {
            RestName = restName;
            RestTableList = restTableList;
            RestFoodItemList = restFoodItemList;
            StaffList = staffList;
        }

        public void displayRestaurantInformation()
        {
            Console.WriteLine($"The restaurant Name {RestName}");
            Console.WriteLine("====================");
            RestTableList.displayTable();
            Console.WriteLine("====================");
            RestFoodItemList.displayListOfFood();
            Console.WriteLine("====================");
            foreach (var item in StaffList)
            {
                Console.WriteLine($"Staff {item}");
            }
            Console.WriteLine("====================");
        }
    }
}
