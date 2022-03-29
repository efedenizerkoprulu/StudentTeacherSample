using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Lesson : IEntity
    {
        public int ID { get; set; }
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public bool IsActiveData { get; set; }
        public Teacher Teacher { get; set; }

    }
}
