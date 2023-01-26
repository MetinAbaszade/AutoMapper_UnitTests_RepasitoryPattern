using AutoMapper_Project.DAL;
using AutoMapper_Project.DAL.Abstract;
using AutoMapper_Project.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Xunit;

namespace DataAccess.UnitTests
{
    public class EfDataAccessTests
    {
        [Fact]
        public void Delete_Insert_and_Get_an_Employee()
        {
            IEmployeeDal employeeDal = new EfEmployeeDal();
            employeeDal.DeleteAll();

            var NewEmployee = new Employee("Matin", null, 0, "Programming Department", "Software Engineer");
            employeeDal.Add(NewEmployee);

            var Employees = employeeDal.GetList();
            Assert.True(Employees.Count > 0, "The Employees count was not greater than 0");
        }
    }
}