using System;
#pragma warning disable 8618

namespace DesignPatters.CreationalDesignPatterns.FluentInterface
{
    public class Employee
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
    }
    public class FluentEmployee
    {
        private readonly Employee _employee = new Employee();
        public FluentEmployee NameOfTheEmployee(string fullName)
        {
            _employee.FullName = fullName;
            return this;
        }
        public FluentEmployee Born(string dateOfBirth)
        {
            _employee.DateOfBirth = Convert.ToDateTime(dateOfBirth);
            return this;
        }
        public FluentEmployee WorkingOn(string department)
        {
            _employee.Department = department;
            return this;
        }
        public FluentEmployee StaysAt(string address)
        {
            _employee.Address = address;
            return this;
        }
    }
}