using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Student : ManageID, IEntity
    {
       
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string StudentClass { get; set; }
        public string StudentNo { get; set; }
        // de bunu IEntitye atsam çözdürecek o yüzden id class yaptım evet abi eline sağlık 
    }
}
