using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
 public   class DailyRecord
    {
        public DailyRecord()
        {
            DailyRecordItem = new List<DailyRecordItem>();
        }
        public int Id { get; set; }

        public string RecordNumber { get; set; }

        public DateTime recordDate { get; set; }
        public string UserId { get; set; }



        public string RecordNote2 { get; set; }

        public string RecordNote { get; set; }


        public List<DailyRecordItem> DailyRecordItem { get; set; }

    }
}
