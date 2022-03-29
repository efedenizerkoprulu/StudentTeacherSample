using Core.DataAccess.EntityFremework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFremework
{
    public class EfTeacherDal:EntityRepositoryBase<Teacher,SampleContext>,ITeacherDal
    {
    }
}
