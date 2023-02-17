using System.Globalization;
using Faker.Model;

namespace Faker.Services;

public class DateFieldSource : BaseFieldSource
{
    public override string CategoryName => "Date";
    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new PastField(Faker, "Past");
        yield return new PastOffsetField(Faker, "Past Offset");
        yield return new SoonField(Faker, "Soon");
        yield return new SoonFieldOffset(Faker, "Soon Offset");
        yield return new FutureField(Faker, "Future");
        yield return new FutureOffsetField(Faker, "Future Offset");


        yield return new SimpleField<string>(Faker, () => Faker.Date.Timespan().ToString(),
            "Timespan");
        yield return new SimpleField<string>(Faker, () => Faker.Date.Month(),
            "Month");
        yield return new SimpleField<string>(Faker, () => Faker.Date.Weekday(),
            "Weekday");
    }
}