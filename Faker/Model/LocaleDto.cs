namespace Faker.Model;

public class LocaleDto
{
    public LocaleDto(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public string Id{get;set;}
    public string Name { get;set;}  
}