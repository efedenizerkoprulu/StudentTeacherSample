using business.Abstract;
using business.Constants;
using Core.Business;
using Core.Exceptions;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Concrete
{
    public class TeacherMenager : ITeacherService
    {
        ITeacherDal _teacherDal;

        public TeacherMenager(ITeacherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }
        public IResult AddTeacher(Teacher entity)
        {
            entity.Id = default;
            IResult result = BusinessRules.Run(IsExsistEmailSymbol(entity));
            if (result!= null)
            {
                return result;
            }
            else
            {
                _teacherDal.Add(entity);
                return new SuccessResult();
            }

        }

        public IResult DeleteTeacher(Teacher entity)
        {
            _teacherDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<Teacher> GetTeacher(int id)
        {
            return new SuccessDataResult<Teacher>(_teacherDal.Get(x=>x.Id==id));
        }

        public IResult IsExsistEmailSymbol(Teacher TeacherEmail)
        {
            if (TeacherEmail.Email.Contains("@"))
            {
                return new SuccessResult();
            }
            else
               throw new VaildEmailAdressException(Messages.ValidEmailAdress);
        }

        public IResult IsStartedWithTurkeyNumber(string PhoneNumber)
        {
            return  PhoneNumber.StartsWith("(90")?
             new SuccessResult(Messages.ThisIsTurkeyNumber)
             : new ErrorRuslt(Messages.ThisIsNotTurkeyNumber);
        }

        public IDataResult<List<Teacher>> ListTeachers()
        {
           return new SuccessDataResult<List<Teacher>>(_teacherDal.GetAll());
        }

        public IResult UpdateTeacher(Teacher entity)
        {
            _teacherDal.Update(entity);
            return new SuccessResult();
        }
    }
}
