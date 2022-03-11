using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExpertManager : IExpertService
    {

        IExpertDal _expertDal;

        public ExpertManager(IExpertDal expertDal)
        {
            _expertDal = expertDal;
        }
        public ExpertManager()
        {
            _expertDal = new EfExpertRepository();
        }
        public void ExpertAdd(Expert expert)
        {
            _expertDal.Add(expert);
        }

        public void ExpertDelete(Expert expert)
        {
            throw new NotImplementedException();
        }

        public void ExpertUpdate(Expert expert)
        {
            _expertDal.Update(expert);
        }
        public List<Expert> GetFoodByID(int id)
        {
            return _expertDal.GetListAll(x => x.ExpertID == id);

        }
        public Expert GetById(int id)
        {
           return _expertDal.GetById(id);
        }

        public List<Expert> GetList()
        {
            return _expertDal.GetListAll();
        }
        public List<Expert> GetListAll()
        {
            return _expertDal.GetListAll();
        }
    }
}
