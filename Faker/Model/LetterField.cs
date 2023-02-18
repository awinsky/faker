namespace Faker.Model;

public class LetterField : Field<string>
{
    public LetterField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public int Number { get; set; } = 1;

    public override string? GenerateExact()
    {
        return Faker.Lorem.Letter(Number);
    }

    public override FieldType FieldType => FieldType.Letter;
}