using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriNetProject.Models
{


    public class RecordListModel
    {
        public int recordId { get; set; }
        public string recordNumber { get; set; }
        public string recordNote { get; set; }
        public string recordNote2 { get; set; }
        public DateTime recordDate { get; set; }


        public List<RecordItemModel> RecordItems { get; set; }

        public decimal TotalPrice()
        {
            return RecordItems.Sum(i => i.Calorie * i.Quantity);
        }
    }
    public class RecordItemModel
    {
        public int RecordItemId { get; set; }
        public decimal Calorie { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        
    }


}