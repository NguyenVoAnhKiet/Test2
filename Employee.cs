class Employee
{
    Name? name = null;
    string? ssn = null;
    DateTime? bdate = null;
    string? sex = null;
    string? address = null;
    double? salary = null;
    Employee? supervisor = null;
    LinkedList<Employee> supervísee = new LinkedList<Employee>();

    public Employee(Name name, string ssn, string sex, string address, double salary)
    {
        this.name = name;
        this.ssn = ssn;
        this.sex = sex;
        this.address = address;
        this.salary = salary;
    }
}
