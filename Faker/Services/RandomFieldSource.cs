using System.Globalization;
using Faker.Model;

namespace Faker.Services;

public class RandomFieldSource : BaseFieldSource
{
    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new RandomNumberField(Faker, "Number");
        yield return new RandomEvenField(Faker, "Even");
        yield return new RandomOddField(Faker, "Odd");


        yield return new RandomField<double>(Faker, "Double", 0.0d, 1.0d, Faker.Random.Double,
            FieldType.RandomDouble);
        yield return new RandomField<decimal>(Faker, "Decimal", 0.0m, 11.0m, Faker.Random.Decimal,
            FieldType.RandomDecimal);
        yield return new RandomField<float>(Faker, "Float", 0.0f, 11.0f, Faker.Random.Float,
            FieldType.RandomFloat);
        yield return new RandomField<byte>(Faker, "Byte", byte.MinValue, byte.MaxValue, Faker.Random.Byte,
            FieldType.RandomByte);
        yield return new RandomField<int>(Faker, "Int", int.MinValue, int.MaxValue, Faker.Random.Int,
            FieldType.RandomInt);
        yield return new RandomField<long>(Faker, "Long", long.MinValue, long.MaxValue, Faker.Random.Long,
            FieldType.RandomLong);
        yield return new RandomField<short>(Faker, "Short", short.MinValue, short.MaxValue, Faker.Random.Short,
            FieldType.RandomShort);
        yield return new RandomField<char>(Faker, "Char", char.MinValue, char.MaxValue, Faker.Random.Char,
            FieldType.RandomChar);
        yield return new RandomField<char>(Faker, "Char", char.MinValue, char.MaxValue, Faker.Random.Char,
            FieldType.RandomChar);


        yield return new SimpleField<string>(Faker, () => Faker.Random.String()
            .ToString(CultureInfo.InvariantCulture), "String");
        yield return new SimpleField<string>(Faker, () => Faker.Random.Hash()
            .ToString(CultureInfo.InvariantCulture), "Hash");
        yield return new SimpleField<string>(Faker, () => Faker.Random.Bool()
            .ToString(CultureInfo.InvariantCulture), "Bool");
        yield return new SimpleField<string>(Faker, () => Faker.Random.Guid()
            .ToString(), "Guid");
        yield return new SimpleField<string>(Faker, () => Faker.Random.RandomLocale(), "Random Locale");
        yield return new SimpleField<string>(Faker, () => Faker.Random.Hexadecimal(), "Hexadecimal");
      
    }
}