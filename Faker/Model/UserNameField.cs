namespace Faker.Model;

public class UserNameField : Field<string>
{
    public UserNameField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }
    public string? FirstName{get;set;}
    public string? LastName{get;set;}
    public override string? GenerateExact()
    {
        return Faker.Internet.UserName(FirstName, LastName);
    }

    public override FieldType FieldType => FieldType.UserName;
}