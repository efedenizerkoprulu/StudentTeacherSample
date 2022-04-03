using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ILessonDal:IEntityRepository<Lesson>
    {
        public List<Teacher> GetTeacherName();
        public List<TeacherStudentDTO> GetListLesson();
        public void SetPassiveData(int id); 
    }
}