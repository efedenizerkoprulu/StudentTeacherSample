using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class TeacherStudentDTO:IDTO
    {
       public int LessonId { get; set; }
        public string TeacherName { get; set; }
        public string LessonName { get; set; }
        public bool IsActiveData { get; set; }
    }
}
