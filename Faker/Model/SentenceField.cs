namespace Faker.Model;

public class SentenceField : Field<string>
{
    public SentenceField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public int? WordCount { get; set; }
    public int? Range { get;set; }

    public override string? GenerateExact()
    {
       return Faker.Lorem.Sentence(WordCount,Range);
    }

    public override FieldType FieldType => FieldType.Sentence;
}