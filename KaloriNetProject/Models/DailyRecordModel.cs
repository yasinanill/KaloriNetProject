using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriNetProject.Models
{


    public class DailyRecordModel
    {
        public string RecordNote { get; set; }
        public string RecordNote2 { get; set; }
        public string ExpirationYear { get; set; }

        public CartModel CartModel { get; set; }
    }
}