namespace Faker.Model;

public class OrdinalDirectionField : Field<string>
{
    public OrdinalDirectionField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }
    public bool UseAbbreviation { get; set; }
    public override string? GenerateExact()
    {
        return Faker.Address.CardinalDirection(UseAbbreviation);
    }

    public override FieldType FieldType => FieldType.OrdinalDirection;
}