class Work_ON
{
    internal Project number;
    internal System.DateTime start_date;
    internal TimeSpan hour;
    public Work_ON(Project number, string start_date)
    {
        this.number = number;
        this.start_date = DateTime.Parse(start_date);
        this.hour = DateTime.Now.Subtract(this.start_date);
    }
}