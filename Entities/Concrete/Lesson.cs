using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Lesson : ManageID,IEntity
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public bool IsActiveData { get; set; }
        public Teacher Teacher { get; set; }
        // bunu da böyle düzelttim id sınıfı var ordan tek atıyor 
    }
}
