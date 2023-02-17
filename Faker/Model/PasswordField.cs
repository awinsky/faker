namespace Faker.Model;

public class PasswordField : Field<string>
{
    public PasswordField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public int Length { get; set; } = 10;
    public bool Memorable { get; set; }
    public string? RegexPattern { get; set; } = "\\w";
    public string? Prefix { get; set; }


    public override string? GenerateExact()
    {
        return Faker.Internet.Password(Length, Memorable, RegexPattern, Prefix);
    }

    public override FieldType FieldType => FieldType.Password;
}