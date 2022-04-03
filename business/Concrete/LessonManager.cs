using business.Abstract;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Concrete
{
    public class LessonManager : ILessonService
    {
        ILessonDal _lessonDal;

        public LessonManager(ILessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }

        public IResult AddLesson(Lesson entity)
        {
            _lessonDal.Add(entity);
            return new SuccessResult();
        }

        public IResult DeleteLesson(Lesson entity)
        {
            _lessonDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<Lesson> GetLesson(int id)
        {
           return new SuccessDataResult<Lesson>(_lessonDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Teacher>> GetTeacherName()
        {
            return new SuccessDataResult<List<Teacher>>(_lessonDal.GetTeacherName());
        }

        public IDataResult<List<TeacherStudentDTO>> ListLessons()
        {
            return new SuccessDataResult<List<TeacherStudentDTO>>(_lessonDal.GetListLesson());
        }

        public IResult PassiveData(int id)
        {
            _lessonDal.SetPassiveData(id);
            return new SuccessResult();
        }

        public IResult UpdateLesson(Lesson entity)
        {
            _lessonDal.Update(entity);
            return new SuccessResult();
        }
    }
}
