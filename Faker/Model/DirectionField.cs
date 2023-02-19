namespace Faker.Model;

public class DirectionField : Field<string>
{
    public DirectionField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public bool UseAbbreviation { get; set; }

    public override string? GenerateExact()
    {
        return Faker.Address.Direction(UseAbbreviation);
    }
    public override FieldType FieldType => FieldType.Direction;
}