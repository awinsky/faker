using Faker.Model;

namespace Faker.Services;

public class LoremFieldSource : BaseFieldSource
{
    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new SimpleField<string>(Faker, () => Faker.Lorem.Word(), "Word");
        yield return new SimpleField<string>(Faker, () => string.Join(" ", Faker.Lorem.Words()), "Words");
        yield return new LetterField(Faker, "Letter");
        yield return new SentenceField(Faker, "Sentence");
        yield return new ParagraphField(Faker, "Paragraph");
        yield return new SimpleField<string>(Faker, () => Faker.Lorem.Text(), "Text");
        yield return new SlugField(Faker, "Slug");

    }

    
}