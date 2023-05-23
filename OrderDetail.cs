using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWMainAssignment
{
    class OrderDetail
    {
        public string CustomerName { get; set; }    
        public string DiscountType { get; set; }
        public Table OrderedTable { get; set; }

        public List<FoodBase> OrderedFoodItemList { get; set; }

        public string DateCreated { get; set; }
        public OrderDetail()
        {

        }

        public OrderDetail(string customerName, string discountType, Table orderedTable,
            List<FoodBase> orderedFoodItemList, string dateCreated)
        {
            CustomerName = customerName;
            DiscountType = discountType;
            OrderedTable = orderedTable;
            OrderedFoodItemList = orderedFoodItemList;
            DateCreated = dateCreated;
        }
        public double totalPayment()
        {
            double totalPayment = 0;
            List<FoodBase> foods = OrderedFoodItemList;
            foreach (var item in foods)
            {
                if (item.GetType().Name.Equals("DrinkItem"))
                {
                    DrinkItem tmp = (DrinkItem)item;
                    totalPayment = totalPayment + tmp.calPrice();
                }
                else {
                    FoodItem tmp = (FoodItem)item;
                    totalPayment = totalPayment + tmp.calPrice();
                }
                
            }
            return totalPayment;

        }
    }
}
