using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using KaloriNetProject.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriNetProject.BusinessLayer.Concrete
{
    public class RecordManager : IRecordService
    {
        private IRecordDal _recordDal;
        public RecordManager(IRecordDal recordDal)
        {
            _recordDal = recordDal;
        }

        public void Create(DailyRecord entity)
        {
            _recordDal.Create(entity);
        }

        public List<DailyRecord> GetOrders(string userId)
        {
            return _recordDal.GetOrders(userId);

        }
    }
}