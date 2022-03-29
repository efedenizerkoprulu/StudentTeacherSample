using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Abstract
{
    public interface ITeacherService
    {
        IDataResult<List<Teacher>> ListTeachers();
        IResult AddTeacher(Teacher entity);
        IResult UpdateTeacher(Teacher entity);
        IResult DeleteTeacher(Teacher entity);
        IResult IsExsistEmailSymbol(Teacher TeacherEmail);
        IDataResult<Teacher> GetTeacher(int id);
        IResult IsStartedWithTurkeyNumber(string PhoneNumber);
    }
}
