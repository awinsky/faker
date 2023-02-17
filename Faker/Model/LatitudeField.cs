namespace Faker.Model;

public class LatitudeField : Field<double>
{
    public LatitudeField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public double Min { get; set; } = -90;
    public double Max { get; set; } = 90;

    public override double GenerateExact()
    {
        return Faker.Address.Latitude(Min, Max);
    }
    
    public override FieldType FieldType => FieldType.Latitude;

}