class Employee
{
    internal string fname;
    internal string minit;
    internal string lname;
    internal string name;
    internal string ssn; //social society number
    internal DateTime bdate;
    internal string sex;
    internal string address;
    internal double salary;
    internal Employee supervisor;
    internal LinkedList<Employee> supervisee;
    internal LinkedList<Dependent> dependent;
    internal LinkedList<Work_ON> projects;

    public Employee(string fname, string minit, string lname, string ssn, string sex, string address, double salary)
    {
        this.fname = fname;
        this.minit = minit;
        this.lname = lname;
        this.name = $"{fname} {minit} {lname}";
        this.ssn = ssn;
        this.sex = sex;
        this.address = address;
        this.salary = salary;
        this.supervisee = new LinkedList<Employee>();
        this.dependent = new LinkedList<Dependent>();
        this.projects = new LinkedList<Work_ON>();
    }
}
