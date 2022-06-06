using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
 public   class DailyRecordItem
    {
        public int Id { get; set; }

        public int recordId { get; set; }
        public DailyRecord DailyRecord { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public decimal Calorie { get; set; }
        public int Quantity { get; set; }




    }
}
