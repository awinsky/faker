using System.Globalization;
using Faker.Model;

namespace Faker.Services;

public class RandomFieldSource : BaseFieldSource
{
    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new Field<string>(Faker, () => Faker.Random.Number().ToString(), "Number");
        //yield return new Field<string>(Faker, () => Faker.Random.Digits(), "Number");
        yield return new Field<string>(Faker, () => Faker.Random.Even().ToString(), "Even");
        yield return new Field<string>(Faker, () => Faker.Random.Odd().ToString(), "Odd");
        yield return new Field<string>(Faker, () => Faker.Random.Double()
            .ToString(CultureInfo.InvariantCulture), "Double");
        yield return new Field<string>(Faker, () => Faker.Random.Decimal()
            .ToString(CultureInfo.InvariantCulture), "Decimal");
        yield return new Field<string>(Faker, () => Faker.Random.Float()
            .ToString(CultureInfo.InvariantCulture), "Float");
        yield return new Field<string>(Faker, () => Faker.Random.Byte()
            .ToString(CultureInfo.InvariantCulture), "Byte");
        yield return new Field<string>(Faker, () => Faker.Random.Int()
            .ToString(CultureInfo.InvariantCulture), "Int");
        yield return new Field<string>(Faker, () => Faker.Random.Long()
            .ToString(CultureInfo.InvariantCulture), "Long");
        yield return new Field<string>(Faker, () => Faker.Random.Short()
            .ToString(CultureInfo.InvariantCulture), "Short");
        yield return new Field<string>(Faker, () => Faker.Random.Char()
            .ToString(CultureInfo.InvariantCulture), "Char");
        yield return new Field<string>(Faker, () => Faker.Random.String()
            .ToString(CultureInfo.InvariantCulture), "String");
        yield return new Field<string>(Faker, () => Faker.Random.Hash()
            .ToString(CultureInfo.InvariantCulture), "Hash");
        yield return new Field<string>(Faker, () => Faker.Random.Bool()
            .ToString(CultureInfo.InvariantCulture), "Bool");
        yield return new Field<string>(Faker, () => Faker.Random.Guid()
            .ToString(), "Guid");
        yield return new Field<string>(Faker, () => Faker.Random.RandomLocale(), "Random Locale");
        yield return new Field<string>(Faker, () => Faker.Random.Hexadecimal(), "Hexadecimal");
      
    }
}