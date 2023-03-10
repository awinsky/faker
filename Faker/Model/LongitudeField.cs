namespace Faker.Model;

public class LongitudeField : Field<double>
{
    public LongitudeField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public double Min { get; set; } = -180;
    public double Max { get; set; } = 180;

    public override object? Generate()
    {
        return GenerateExact();
    }

    public override string? GenerateString()
    {
        return Generate()?.ToString();
    }

    public override double GenerateExact()
    {
        return Faker.Address.Longitude(Min, Max);
    }

    public override FieldType FieldType => FieldType.Longitude;

}