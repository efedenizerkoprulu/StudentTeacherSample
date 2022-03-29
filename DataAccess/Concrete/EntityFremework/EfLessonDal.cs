using Core.DataAccess.EntityFremework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFremework
{
    public class EfLessonDal : EntityRepositoryBase<Lesson, SampleContext>, ILessonDal
    {
        public List<Teacher> GetTeacherNane()
        {

            using (SampleContext context = new SampleContext())
            {
                var getName = from t in context.Teachers
                              select new Teacher
                              {
                                  ID = t.ID,
                                  Name = t.Name,
                              };
                return getName.ToList();
            }

        }

        public void PassiveData(int id)
        {
            using (SampleContext context = new SampleContext())
            {
                var getLesson = Get(X => X.ID == id);
                getLesson.IsActiveData=false;
                context.Entry(getLesson).Property("IsActiveData").IsModified = true;
                context.SaveChanges();

            }
        }

        public List<TeacherStudentDTO> teacherStudents()
        {
            using (SampleContext context = new SampleContext())
            {
                var getData = (from l in context.Lessons
                              join t in context.Teachers
                              on l.TeacherID equals t.ID
                              select new TeacherStudentDTO
                              {
                                  LessonId = l.ID,
                                  LessonName = l.Name,
                                  TeacherName = t.Name,
                                  IsActiveData=l.IsActiveData
                              }).Where(d=> d.IsActiveData==true).ToList();
                return getData;
                
                
            }
        }
    }
}
