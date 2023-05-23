using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWMainAssignment
{
    class OrderListBill
    {
        public string StaffName { get; set; }
        public List<OrderDetail> CurrentOrderLists { get; set; }
        public OrderListBill()
        {
            // thieu tao order
        }

        public OrderListBill(string staffName, List<OrderDetail> currentOrderLists)
        {
            StaffName = staffName;
            CurrentOrderLists = currentOrderLists;
        }
    }
}
