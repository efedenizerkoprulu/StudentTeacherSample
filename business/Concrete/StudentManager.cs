using business.Abstract;
using Core.Exceptions;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using business.Constants;
using Core.Business;

namespace business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public IResult AddStudent(Student entity)
        {
            IResult result = BusinessRules.Run(IsExsistEmailSymbol(entity));
            if (result != null)
            {
                return result;
            }
            else
            {
                _studentDal.Add(entity);
                return new SuccessResult();
            }
        }

        public IResult DeleteStudent(Student entity)
        {
            _studentDal.Delete(entity);
           return new SuccessResult();
        }

        public IDataResult<List<Student>> ListStudents()
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll());
        }

        public IResult IsExsistEmailSymbol(Student StudentEmail)
        {
            if (StudentEmail.Email.Contains("@"))
            {
                return new SuccessResult();
            }
            else
                throw new VaildEmailAdressException(Messages.ValidEmailAdress);
        }

        public IResult UpdateStudent(Student entity)
        {
            _studentDal.Update(entity);
            return new SuccessResult();
        }

        public IDataResult<Student> GetStudent(int id)
        {

            return new SuccessDataResult<Student>(_studentDal.Get(x => x.ID == id));
        }
    }
}
