class Name
{
    string? fname = null;
    string? minit = null;
    string? lname = null;

    public Name(string fname, string minit, string lname)
    {
        this.fname = fname;
        this.minit = minit;
        this.lname = lname;
    }

    public void Output()
    {
        Console.WriteLine($"{fname}\t{minit}\t{lname}");
    }
}
