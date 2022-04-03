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
        public List<Teacher> GetTeacherName()
        {

            using (SampleContext context = new SampleContext())
            {
                var getName = context.Teachers.Select(t => new Teacher
                {
                    Id = t.Id,
                    Name = t.Name
                }).ToList();
                return getName;
            }

        }

        public void SetPassiveData(int id)
        {
            using (SampleContext context = new SampleContext())
            {
                var getLesson = Get(X => X.Id == id);
                getLesson.IsActiveData = false;
                context.Update(getLesson);
                context.SaveChanges();

            }
        }

        public List<TeacherStudentDTO> GetListLesson()
        {
            using (SampleContext context = new SampleContext())
            {
                var result = context.Lessons.Join(context.Teachers,
                   lesson => lesson.TeacherID, teacher => teacher.Id, (lesson, teacher) => new TeacherStudentDTO
                   {
                       LessonId = lesson.Id,
                       TeacherName = teacher.Name,
                       LessonName = lesson.Name,
                       IsActiveData = lesson.IsActiveData
                   }).Where(s => s.IsActiveData == true);

                return result.ToList();


            }
        }
    }
}
