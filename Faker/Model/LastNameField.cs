using Bogus.DataSets;

namespace Faker.Model;

public class LastNameField : Field<string>
{
    public LastNameField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }
    public Name.Gender? Gender { get; set; }
    public override string? GenerateExact()
    {
        return Faker.Name.LastName(Gender);
    }

    public override FieldType FieldType => FieldType.LastName;
}