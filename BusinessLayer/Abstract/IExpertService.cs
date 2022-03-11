using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface IExpertService
    {
        void ExpertAdd(Expert expert);
        void ExpertDelete(Expert expert);
        void ExpertUpdate(Expert expert);
        List<Expert> GetList();
        Expert GetById(int id);
    }
}
