    using System;
using System.Collections.Generic;

namespace FGWMainAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //TableList myTables = new TableList();
            //myTables.enterTable();
            //myTables.displayTable();
            //Console.WriteLine("=============");
            //// Don 1 mam do an
            //FoodItemList myFoods = new FoodItemList();
            //// Food Drink Desert 
            //myFoods.displayListOfFood();

            int userChoice;
            Restaurant restaurant = new Restaurant();
            while (true)
            {
                userChoice = Menu.enterUserChoice();
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("we are creating the new restaurant");

                        restaurant.RestName = "ABC Restaurant";
                        TableList tableList = new TableList();
                        tableList.enterTable();
                        restaurant.RestTableList = tableList;
                        //  restaurant.RestTableList.displayTable();
                        FoodItemList myFoods = new FoodItemList();

                        restaurant.RestFoodItemList = myFoods;
                        //restaurant.RestFoodItemList.displayListOfFood();
                        List<string> currentStaffs = new List<string>();
                        currentStaffs.Add("Nguyen Van A");
                        currentStaffs.Add("Nguyen Van B");
                        currentStaffs.Add("Nguyen Van C");

                        restaurant.StaffList = currentStaffs;
                        Console.WriteLine("Created");
                        break;
                    case 2:
                        Console.WriteLine("The current information of the restaurant..");
                        restaurant.displayRestaurantInformation();
                        break;
                    case 3:
                        Console.WriteLine("we are creating the new order");
                        Console.WriteLine("Please choose the table with the status False");
                        restaurant.RestTableList.displayTable();
                        Console.WriteLine("Enter the id of current ordered table you want to eat: ");
                        int idTableTmp = int.Parse(Console.ReadLine());
                        // viet lenh nhap id va truyen vao
                        if (restaurant.RestTableList.setTableBusyEating(idTableTmp) != null)
                        {
                            Console.WriteLine($"Yay, we choose this table {idTableTmp}");
                            //restaurant.RestTableList.displayTable();
                            Console.WriteLine(" Display the menu of food: ");
                            restaurant.RestFoodItemList.displayListOfFood();
                            Console.WriteLine("Enter the food do you want to eat: ");
                            List<FoodBase> foods = new List<FoodBase>();
                            foods = restaurant.RestFoodItemList.enterFoodToMenu();
                            Console.WriteLine("Again, we confirmed the food you ordered");
                            foreach (var item in foods)
                            {
                                Console.WriteLine(item);
                            }
                            OrderDetail orderDetail = new OrderDetail();
                            Console.WriteLine("Enter the customer name: ");
                            orderDetail.CustomerName = Console.ReadLine();
                            orderDetail.DiscountType = "Gold";
                            orderDetail.OrderedFoodItemList = foods;
                            orderDetail.OrderedTable = restaurant.RestTableList.setTableBusyEating(idTableTmp);
                            Console.WriteLine("The Order is created");
                            Console.WriteLine($"The Bill is: ${orderDetail.totalPayment()} ");

                        }

                        break;
                    case 4:
                        Console.WriteLine("4");

                        break;
                    case 5:
                        Console.WriteLine("End");
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
