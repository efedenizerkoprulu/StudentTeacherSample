using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Abstract
{
    public interface IStudentService
    {
        IDataResult<List<Student>> ListStudents();
        IResult AddStudent(Student entity);
        IResult UpdateStudent(Student entity);
        IResult DeleteStudent(Student entity);
        IResult IsExsistEmailSymbol(Student StudentEmail);
        IDataResult <Student> GetStudent(int id);

    }
}
