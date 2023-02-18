using Bogus.DataSets;

namespace Faker.Model;

public class PrefixField : Field<string>
{
    public PrefixField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }
    public Name.Gender? Gender { get; set; }
    public override string? GenerateExact()
    {
        return Faker.Name.Prefix(Gender);
    }
    public override FieldType FieldType => FieldType.Prefix;
}