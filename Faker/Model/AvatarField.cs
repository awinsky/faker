namespace Faker.Model;

public class AvatarField : Field<string>
{
    public AvatarField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public override string? GenerateExact()
    {
        return Faker.Internet.Avatar();
    }

    public override FieldType FieldType => FieldType.Avatar;
}