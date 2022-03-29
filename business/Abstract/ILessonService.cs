using Core.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Abstract
{
    public interface ILessonService
    {
        IDataResult<List<TeacherStudentDTO>> ListLessons();
        IResult AddLesson(Lesson entity);
        IResult UpdateLesson(Lesson entity);
        IDataResult<Lesson> GetLesson(int id);
        IDataResult<List<Teacher>> GetTeacherName();
        IResult PassiveData(int id);
    }
}
