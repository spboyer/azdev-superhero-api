#r "Newtonsoft.Json"

#load "heroGenerator.csx"

using Newtonsoft.Json;

public class Person
{
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        _heroName = GetHeroName(firstName, lastName);
    }

    [JsonProperty("firstName")]
    public string FirstName { get; set; }

    [JsonProperty("lastName")]
    public string LastName { get; set; }

    private string _heroName;

    [JsonProperty("heroName")]
    public string HeroName { get { return _heroName;} }
}