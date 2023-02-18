namespace Faker.Model;

public class SlugField : Field<string>
{
    public SlugField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public int WordCount { get; set; } = 3;

    public override string? GenerateExact()
    {
        return Faker.Lorem.Slug(WordCount);
    }
    public override FieldType FieldType => FieldType.Slug;
}