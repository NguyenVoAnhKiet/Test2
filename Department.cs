class Department
{
    internal string name;
    internal int number;
    LinkedList<string> location;
    internal Manages manager;
    internal LinkedList<Employee> employees;

    public Department(Manages manager, string name, int number)
    {
        this.name = name;
        this.number = number;
        this.manager = manager;
        this.location = new LinkedList<string>();
        employees = new LinkedList<Employee>();
    }
}
