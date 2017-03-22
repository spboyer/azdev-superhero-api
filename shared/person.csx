#load "heroGenerator.csx"

public class Person
{
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        _heroName = GetHeroName(firstName, lastName);
    }

    private string _firstName;
    public string FirstName
    {
        get { return _firstName;}
        set { _firstName = value;}
    }
    
    
    public string LastName { get; set; }

    private string _heroName;
    
    public string HeroName { get { return _heroName;} }
}