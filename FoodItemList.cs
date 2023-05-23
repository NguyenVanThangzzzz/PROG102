using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWMainAssignment
{
    class FoodItemList
    {
        private List<FoodBase> listFoodInRes = new List<FoodBase>();
        public FoodItemList()
        {
            listFoodInRes.Add(new FoodItem("Rice123", "Fried Rice", 2.50,new FoodCategory(1), new List<string> {"Rice","Pork" }));
            listFoodInRes.Add(new FoodItem("Pho123", "Pho Noodle", 3.50, new FoodCategory(1), new List<string> { "Pho", "Pork" }));
            listFoodInRes.Add(new FoodItem("Bun123", "Bun Noodle", 3.50, new FoodCategory(1), new List<string> { "Bun", "Pork" }));
            listFoodInRes.Add(new DrinkItem("Coca124", "Coca", 0.50, new FoodCategory(2), new List<string> { "Coca", "Gas" },true));
            listFoodInRes.Add(new DrinkItem("Pepsi124", "Pepsi", 0.50, new FoodCategory(2), new List<string> { "Pepsi", "Gas" }, true));
        }

        internal List<FoodBase> ListFoodInRes { get => listFoodInRes; set => listFoodInRes = value; }

        public void displayListOfFood()
        {
            foreach (var item in listFoodInRes)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public FoodBase foundFood(string idFood)
        {
            
            foreach (var item in listFoodInRes)
            {
                if (item.FoodBaseID==idFood)
                {
                    return item;
                }
            }
            return null;
        }
        public List<FoodBase> enterFoodToMenu()
        {
            string chooseFood="";
            List<FoodBase> foodToMenuTmp = new List<FoodBase>();
            displayListOfFood();
            do
            {
                Console.WriteLine("Enter the id: ");
                // moi ban nhap idFood tu ban phim
                //string idFood = "Rice123";
                string idFood = Console.ReadLine();
                FoodBase chosenFood = foundFood(idFood);
                //Console.WriteLine(chosenFood.GetType().Name);
                if (chosenFood.GetType().Name.Equals("DrinkItem"))
                {
                    DrinkItem tmp = (DrinkItem)chosenFood;
                    Console.Write("Enter the quantity of bottle: ");
                    //tmp.NumOfBottle = 2;
                    tmp.NumOfBottle = int.Parse(Console.ReadLine());
                    foodToMenuTmp.Add(tmp);
                }
                else
                {
                    FoodItem tmp = (FoodItem)chosenFood;
                    Console.Write("Enter the quantity of diskes: ");
                    //tmp.NumOfDisk = 3;
                    tmp.NumOfDisk = int.Parse(Console.ReadLine());
                    foodToMenuTmp.Add(tmp);
                }
                Console.WriteLine("Do you want to continue: yes/no");
                chooseFood = Console.ReadLine();
            } while (chooseFood != "no");
            return foodToMenuTmp;
        }
    }
}
