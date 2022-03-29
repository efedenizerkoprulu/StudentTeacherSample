using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Teacher : IEntity
    {
        public Teacher()
        {
            Lessons = new List<Lesson>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime StartedDate { get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}
