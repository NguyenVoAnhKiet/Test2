class Dependent
{
    Name? name = null;
    string? sex = null;
    DateTime? birth_date = null;
    string? relationship = null;

    public Dependent(Name name, string sex, DateTime birth_date, string relationship)
    {
        this.name = name;
        this.sex = sex;
        this.birth_date = birth_date;
        this.relationship = relationship;
    }
}
