namespace Faker.Model;

public class ParagraphField : Field<string>
{
    public ParagraphField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public int Min { get; set; } = 3;

    public override string? GenerateExact()
    {
        return Faker.Lorem.Paragraph(Min);
    }

    public override FieldType FieldType => FieldType.Paragraph;
}