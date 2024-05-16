namespace LinquHomeWork
{
    public class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int EmployeeID { get; set; }

        public Employee(string name, string lastName, int employeeID)
        {
            Name = name;
            LastName = lastName;
            EmployeeID = employeeID;
        }
        public override string ToString()
        {
            return $"{Name} {LastName} {EmployeeID}";
        }

    }
}
