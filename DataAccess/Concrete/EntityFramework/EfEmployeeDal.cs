using AutoMapper_Project.Core.DataAccess.EntityFramework;
using AutoMapper_Project.DAL.Abstract;
using AutoMapper_Project.Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepasitoryBase<Employee, ApplicationDBContext>, IEmployeeDal
    {

    }
}
