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
    public class ProfilManager : IProfilService
    {

        IProfilDal _profilDal;

        public ProfilManager(IProfilDal profilDal)
        {
            _profilDal = profilDal;
        }
        public ProfilManager() {

            _profilDal = new EfProfilRepository();
        
        }

        public void ProfilAdd(Profil profil)
        {
            _profilDal.Add(profil);
        }

        public void ProfilDelete(Profil profil)
        {
            _profilDal.Delete(profil);
        }

        public void ProfilUpdate(Profil profil)
        {
            _profilDal.Update(profil);
        }

        public List<Profil> GetList()
        {
            return _profilDal.GetListAll();
        }
        public List<Profil> GetListAll()
        {
            return _profilDal.GetListAll();
        }

        public Profil GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
