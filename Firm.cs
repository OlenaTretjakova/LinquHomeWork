using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinquHomeWork
{
    public class Firm 
    {
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public string DirectorLastName { get; set; }
        public string ProfilFirm { get; set; }
        public int NumberEmployees { get; set; }
        public Address Address { get; set; }
        public List<Employee> Employees { get; set; }
        public Firm(string name, DateTime dateCreated, string directorLastName, string profilFirm, int numberEmployees, Address address)
        {
            Name = name;
            DateCreated = dateCreated;
            DirectorLastName = directorLastName;
            ProfilFirm = profilFirm;
            NumberEmployees = numberEmployees;
            Address = address;
            Employees = new List<Employee>();

        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return Employees.GetEnumerator();
        }

        public override string ToString()
        {
            string employeeInfo = string.Join(", ", Employees.Select(e => e.ToString()));
            return $"{Name}, {DateCreated}, {DirectorLastName}, {ProfilFirm}, {NumberEmployees}, {Address}, Employees: [{employeeInfo}]";
        }
    }
}
