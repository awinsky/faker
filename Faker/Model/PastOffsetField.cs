namespace Faker.Model;

public class PastOffsetField : Field<DateTimeOffset>
{
    public PastOffsetField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }
    public int YearsToGoBack { get; set; } = 1;
    public DateTimeOffset? RefDate { get; set; } = null;
    public override DateTimeOffset GenerateExact()
    {
        return Faker.Date.PastOffset(YearsToGoBack, RefDate);
    }

    public override FieldType FieldType => FieldType.PastOffset;
}