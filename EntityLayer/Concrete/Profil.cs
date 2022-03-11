using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Profil
    {

            [Key]
            public int ProfilID { get; set; }
           
            public int UserID { get; set; }
            public DateTime Tarih { get; set; }
            public DateTime Saat { get; set; }
            public int FoodID { get; set; }
            //public ICollection <List<Foods>> Foods { get; set; }           
            //public virtual User User { get; set; }

            

    }
    }

