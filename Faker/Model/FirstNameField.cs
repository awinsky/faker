using Bogus.DataSets;

namespace Faker.Model;

public class FirstNameField : Field<string>
{
    public FirstNameField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public Name.Gender? Gender { get; set; }

    public override string? GenerateExact()
    {
        return Faker.Name.FirstName(Gender);
    }

    public override FieldType FieldType => FieldType.FirstName;
}