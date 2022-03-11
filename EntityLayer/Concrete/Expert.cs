using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Expert
    {
        [Key]
        public int ExpertID { get; set; }
        public string ExpertName { get; set; }
        public string ExpertAbout { get; set; }
        public bool FoodStatus { get; set; }
        public string ExpertPassword { get; set; }
        public string ExpertBranch { get; set; }
        public string ExpertSocial { get; set; }
        public string ExpertSocial2 { get; set; }
        public string ExpertSocial3 { get; set; }
        public string ExpertMenu { get; set; }
        public string ExpertBlog { get; set; }
 
    }
}
