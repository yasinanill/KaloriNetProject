using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriNetProject.BusinessLayer.Abstract
{
   public  interface IRecordService
    {

        void Create(DailyRecord entity);
        List<DailyRecord> GetOrders(string userId);
    }
}
