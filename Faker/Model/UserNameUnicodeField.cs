namespace Faker.Model;

public class UserNameUnicodeField : Field<string>
{
    public UserNameUnicodeField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public override string? GenerateExact()
    {
        return Faker.Internet.UserNameUnicode(FirstName, LastName);
    }

    public override FieldType FieldType => FieldType.UserNameUnicode;
}