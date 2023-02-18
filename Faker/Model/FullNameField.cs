using Bogus.DataSets;

namespace Faker.Model;

public class FullNameField : Field<string>
{
    public FullNameField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public Name.Gender? Gender { get; set; }
    public override string? GenerateExact()
    {
        return Faker.Name.FullName(Gender);
    }
    public override FieldType FieldType => FieldType.FullName;
}