using business.Abstract;
using business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFremework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.DependencyReolvers.Ninject
{
    public class BusinessModule:NinjectModule 
    {
        public override void Load()
        {
            Bind<ITeacherService>().To<TeacherMenager>().InSingletonScope();
            Bind<ILessonService>().To<LessonManager>().InSingletonScope();
            Bind<StudentManager>().To<StudentManager>().InSingletonScope();

            Bind<ITeacherDal>().To<EfTeacherDal>().InSingletonScope();
            Bind<ILessonDal>().To<EfLessonDal>().InSingletonScope();
            Bind<IStudentDal>().To<EfStudentDal>().InSingletonScope();
        }
    }
}
