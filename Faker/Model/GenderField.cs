using Bogus.DataSets;

namespace Faker.Model;

public class GenderField : Field<Name.Gender>
{
    private readonly Random _random = new();
    
    public GenderField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public override Name.Gender GenerateExact()
    {
        var randomNumber = _random.Next(0, 1);
        return (Name.Gender)randomNumber;
    }

    public override FieldType FieldType => FieldType.Gender;
}