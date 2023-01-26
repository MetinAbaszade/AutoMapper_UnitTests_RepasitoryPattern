using AutoMapper_Project.Core.Entities;

namespace AutoMapper_Project.Entities.Concrete
{
    public class Address : IEntity
    {
        public Address()
        {
            Id = Guid.NewGuid();
        }

        public Address(string? street, int number, string? city, string? country, Guid employeeId)
        {
            Id = Guid.NewGuid();
            Street = street;
            Number = number;
            City = city;
            Country = country;
            EmployeeId = employeeId;
        }

        public Guid Id { get; set; }
        public string? Street { get; set; }
        public int Number { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public Guid? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
