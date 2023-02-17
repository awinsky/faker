namespace Faker.Model;

public class EmailField : Field<string>
{
    public EmailField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Provider { get; set; }
    public string? UniqueSuffix { get; set; }

    public override string? GenerateExact()
    {
        return Faker.Internet.Email(FirstName, LastName, Provider, UniqueSuffix);
    }

    public override FieldType FieldType => FieldType.Email;
}