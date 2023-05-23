using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWMainAssignment
{
    class TableList
    {
        
        private List<Table> tableListInRes = new List<Table>();
        internal List<Table> TableListInRes { get => tableListInRes; set => tableListInRes = value; }
        public TableList()
        {

        }

        public TableList(List<Table> tableListInRes)
        {
            this.tableListInRes = tableListInRes;
        }
        public Table setTableBusyEating(int id)
        {
            Table currentTable=new Table();
            foreach (var item in tableListInRes)
            {
                if((item.TableID==id)&& (item.TableStatus==false))
                {
                    Console.WriteLine($"Table choose: {item.ToString()}");
                    item.TableStatus = true;
                    currentTable = item;
                }
                //else
                //{
                //    Console.WriteLine("Cant use this table");
                //}
            }
            return currentTable;
        }
        public void enterTable()
        {
            tableListInRes.Add(new Table(11, "Table 11", "In the cornner", false));
            tableListInRes.Add(new Table(12, "Table 12", "In the left", false));
            tableListInRes.Add(new Table(13, "Table 13", "In the right", false));
            tableListInRes.Add(new Table(14, "Table 14", "In the cornner", false));

        }

        public void displayTable()
        {
            foreach (var item in tableListInRes)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
