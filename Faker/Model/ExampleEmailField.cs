namespace Faker.Model;

public class ExampleEmailField : Field<string>
{
    public ExampleEmailField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public override string? GenerateExact()
    {
        return Faker.Internet.ExampleEmail(FirstName,LastName);
    }

    public override FieldType FieldType => FieldType.ExampleEmail;
}