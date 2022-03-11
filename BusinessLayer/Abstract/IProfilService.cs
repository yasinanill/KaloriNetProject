using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProfilService
    {
        void ProfilAdd(Profil profil);
        void ProfilDelete(Profil profil);
        void ProfilUpdate(Profil profil);
        public List<Profil> GetList();
        public Profil GetById(int id);

    }
}

