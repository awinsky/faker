namespace Faker.Model;

public class IbanField : Field<string>
{
    public IbanField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public bool Formatted { get; set; }
    public string? CountryCode { get; set; }

    public override string? GenerateExact()
    {
        return Faker.Finance.Iban(Formatted, CountryCode);
    }

    public override FieldType FieldType => FieldType.Iban;
}