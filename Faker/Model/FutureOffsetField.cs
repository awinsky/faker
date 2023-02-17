namespace Faker.Model;

public class FutureOffsetField : Field<DateTimeOffset>
{
    public FutureOffsetField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public int YearsToGoForward { get; set; }
    public DateTimeOffset? RefDate { get; set; }

    public override DateTimeOffset GenerateExact()
    {
        return Faker.Date.FutureOffset(YearsToGoForward, RefDate);
    }

    public override FieldType FieldType => FieldType.FutureOffset;
}