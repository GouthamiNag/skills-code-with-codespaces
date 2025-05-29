public class Member
{
    public string Name { get; set; }
    public string Role { get; set; }
    public int Experience { get; set; } // in years

    public Member(string name, string role, int experience)
    {
        Name = name;
        Role = role;
        Experience = experience;
    }

    public override string ToString()
    {
        return $"{Name} - {Role} ({Experience} years of experience)";
    }
}