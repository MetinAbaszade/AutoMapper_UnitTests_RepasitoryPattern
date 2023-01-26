using AutoMapper_Project.Core.Entities;

namespace AutoMapper_Project.Entities.Concrete
{
    public class Employee : IEntity
    {
        public Employee()
        {
            Id = Guid.NewGuid();
        }

        public Employee(string? name, Address? address, int registrationId, string? department, string? jobrole)
        {
            Id = Guid.NewGuid();
            Name = name;
            Address = address;
            RegistrationId = registrationId;
            Department = department;
            Jobrole = jobrole;
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Address Address { get; set; }
        public int RegistrationId { get; set; }
        public string? Department { get; set; }
        public string? Jobrole { get; set; }
    }
}
