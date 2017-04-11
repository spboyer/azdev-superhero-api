#load "heroGenerator.csx"

public class Person
{
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        _heroName = GetHeroName(firstName, lastName);
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    private string _heroName;

    public string HeroName { get { return _heroName;} }
}