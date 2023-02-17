using System.Globalization;
using Faker.Model;

namespace Faker.Services;

public class DateFieldSource : BaseFieldSource
{
    public override string CategoryName => "Date";
    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new SimpleField<string>(Faker, () => Faker.Date.Past().ToString(CultureInfo.InvariantCulture),
            "Past");
        yield return new SimpleField<string>(Faker, () => Faker.Date.PastOffset().ToString(CultureInfo.InvariantCulture),
            "Past Offset");
        yield return new SimpleField<string>(Faker, () => Faker.Date.Soon().ToString(CultureInfo.InvariantCulture),
            "Soon");
        yield return new SimpleField<string>(Faker, () => Faker.Date.SoonOffset().ToString(CultureInfo.InvariantCulture),
            "Soon Offset");
        yield return new SimpleField<string>(Faker, () => Faker.Date.Future().ToString(CultureInfo.InvariantCulture),
            "Future");
        yield return new SimpleField<string>(Faker, () => Faker.Date.FutureOffset().ToString(CultureInfo.InvariantCulture),
            "Future Offset");
        yield return new SimpleField<string>(Faker, () => Faker.Date.Timespan().ToString(),
            "Timespan");
        yield return new SimpleField<string>(Faker, () => Faker.Date.Month(),
            "Month");
        yield return new SimpleField<string>(Faker, () => Faker.Date.Weekday(),
            "Weekday");
    }
}