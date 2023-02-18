using static Bogus.DataSets.Name;

namespace Faker.Model;

public class FindNameField : Field<string>
{
    public FindNameField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public bool? WithPrefix { get; set; }
    public bool? WithSuffix { get; set; }
    public Gender? Gender { get; set; }

    public override string? GenerateExact()
    {
        return Faker.Name.FindName(FirstName, LastName, WithPrefix, WithSuffix, Gender);
    }

    public override FieldType FieldType => FieldType.FindName;
}