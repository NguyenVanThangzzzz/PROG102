using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWMainAssignment
{
    class Table
    {
        public int TableID { get; set; }
        public string TableName { get; set; }

        public string TableDescription { get; set; }
        public bool TableStatus { get; set; }
        public Table()
        {

        }

        public Table(int tableID, string tableName, string tableDescription, bool tableStatus)
        {
            TableID = tableID;
            TableName = tableName;
            TableDescription = tableDescription;
            TableStatus = tableStatus;
        }

        public override string ToString()
        {
            return TableID + " "+ TableName+ " "+ TableDescription+ " "+TableStatus;
        }
    }
}
