using Faker.Model;

namespace Faker.Services;




public class HackerFieldSource : BaseFieldSource
{

    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new SimpleField<string>(Faker, () => Faker.Hacker.Abbreviation(), "Abbreviation");
        yield return new SimpleField<string>(Faker, () => Faker.Hacker.Adjective(), "Adjective");
        yield return new SimpleField<string>(Faker, () => Faker.Hacker.Noun(), "Noun");
        yield return new SimpleField<string>(Faker, () => Faker.Hacker.Verb(), "Verb");
        yield return new SimpleField<string>(Faker, () => Faker.Hacker.IngVerb(), "IngVerb");
        yield return new SimpleField<string>(Faker, () => Faker.Hacker.Phrase(), "Phrase");
    }
}