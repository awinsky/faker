using Faker.Model;

namespace Faker.Services;

public class LoremFieldSource : BaseFieldSource
{
    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new Field<string>(Faker, () => Faker.Lorem.Word(), "Word");
        yield return new Field<string>(Faker, () => string.Join(" ", Faker.Lorem.Words()), "Words");
        yield return new Field<string>(Faker, () => Faker.Lorem.Letter(), "Letter");
        yield return new Field<string>(Faker, () => Faker.Lorem.Sentence(), "Sentence");
        yield return new Field<string>(Faker, () => Faker.Lorem.Paragraph(), "Paragraph");
        yield return new Field<string>(Faker, () => Faker.Lorem.Text(), "Text");
        yield return new Field<string>(Faker, () => Faker.Lorem.Slug(), "Slug");

    }

    
}