using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfRecordRepository : IGenericRepository<DailyRecord>, IRecordDal
    {
        Context c = (new Context());

        public List<DailyRecord> GetOrders(string userId)
        {
            using (var context = new Context())
            {
                var orders = context.DailyRecords
                                .Include(i => i.DailyRecordItem)
                                .ThenInclude(i => i.Product)
                                .AsQueryable();

                if (!string.IsNullOrEmpty(userId))
                {
                    orders = orders.Where(i => i.UserId == userId);
                }

                return orders.ToList();
            }
        }
    }
    }

