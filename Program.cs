using System;
using System.Collections.Generic;
using System.Linq;

namespace LinquHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Firm> firms = new List<Firm>()
        {
            new Firm("Alpha Corp", new DateTime(2023,05,10), "Smith", "Software Development", 50, new Address("New York", "Broadway", 123)),
            new Firm("Beta Industries", new DateTime (2021,12,15), "Johnson", "Manufacturing", 150, new Address("Los Angeles", "Main Street", 456)),
            new Firm("Gamma Solutions", new DateTime (2022,08,20), "Williams", "Software Development", 200, new Address("Chicago", "Lake Shore Drive", 789)),
            new Firm("Delta Enterprises", new DateTime(2024,02,28), "Brown", "Finance", 75, new Address("Houston", "Oak Street", 321)),
            new Firm("Epsilon Technologies", new DateTime(2023,11,05), "Jones", "Software Development", 100, new Address("Miami", "Ocean Avenue", 654)),
            new Firm("Zeta Innovations", new DateTime(2022,06,17), "Davis", "Research and Development", 300, new Address("Seattle", "Pine Street", 987)),
            new Firm("Eta Services", new DateTime(2024,09,23), "Miller", "Healthcare", 80, new Address("Boston", "Cambridge Street", 111)),
            new Firm("Theta Systems", new DateTime(2022,03,08), "Wilson", "Telecommunications", 250, new Address("San Francisco", "Market Street", 222)),
            new Firm("Iota Enterprises", new DateTime(2023,07,12), "Taylor", "E-commerce", 120, new Address("Atlanta", "Peachtree Street", 333)),
            new Firm("Kappa Technologies", new DateTime(2024,01,30), "Anderson", "Engineering", 180, new Address("Denver", "Colorado Boulevard", 444))
        };


            Console.WriteLine("All firms:");
            Console.WriteLine();


            foreach (var item in firms)
            {
                Console.WriteLine(item.ToString());
            }



            var firmWhisProfilSoftwareDevelopment = firms.Where(item => item.ProfilFirm == "Software Development");

            Console.WriteLine();

            Console.WriteLine("All firms whose prifile 'Software Development' :");

            Console.WriteLine();

            foreach (var item in firmWhisProfilSoftwareDevelopment)
            {
                Console.WriteLine(item.ToString());
            }



            var firmsEmplyoeesMore10 = firms.Where(item => item.NumberEmployees > 10);

            Console.WriteLine();

            Console.WriteLine("Firms are had employees more than 10 :");

            Console.WriteLine();

            foreach (var item in firmsEmplyoeesMore10)
            {
                Console.WriteLine(item.ToString());
            }


            var firmsEmplyoeesMore10less100 = firms.Where(item => item.NumberEmployees > 10 && item.NumberEmployees < 100)
                .Select(s => new { s.Name, s.NumberEmployees });

            Console.WriteLine();

            Console.WriteLine("Firms are had employees more than 10 and less than 30 :");

            Console.WriteLine();

            foreach (var item in firmsEmplyoeesMore10less100)
            {
                Console.WriteLine(item.ToString());
            }

            var firmDirectorAndersonInDnver = firms.Where(item => item.DirectorLastName == "Anderson" && item.Address.City == "Denver")
                .Select(s => new { s.Name, s.DirectorLastName, s.Address.City });

            Console.WriteLine();

            Console.WriteLine("Firm is had director Anderson and city Denver:");

            Console.WriteLine();

            foreach (var item in firmDirectorAndersonInDnver)
            {
                Console.WriteLine(item.ToString());
            }


            Employee per1 = new Employee("John", "Doe", 1);
            Employee per2 = new Employee("Jane", "Doe", 2);
            Employee per3 = new Employee("Alice", "Smith", 3);
            Employee per4 = new Employee("Bob", "Johnson", 4);
            Employee per5 = new Employee("Emily", "Brown", 5);
            Employee per6 = new Employee("Michael", "Davis", 6);
            Employee per7 = new Employee("Emma", "Wilson", 7);

            foreach (var item in firms.Where(i => i.DirectorLastName == "Anderson"))
            {
                item.AddEmployee(per1);
                item.AddEmployee(per2);
                item.AddEmployee(per3);
                item.AddEmployee(per4);
                item.AddEmployee(per5);
                item.AddEmployee(per6);
                item.AddEmployee(per7);

            }


            Console.WriteLine("All firms:");
            Console.WriteLine();


            foreach (var item in firms)
            {
                Console.WriteLine(item.ToString());
            }


            Console.WriteLine();

            Console.WriteLine("Employees whis ID 1:");
            foreach (var item in firms)
            {
                foreach (var employee in item.Employees.Where(e => e.EmployeeID == 1))
                {
                    Console.WriteLine(employee.ToString());
                }
            }

            Console.ReadLine();
        }
    }

}
