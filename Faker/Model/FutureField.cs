namespace Faker.Model;

public class FutureField : Field<DateTime>
{
    public FutureField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public int YearsToGoForward { get; set; }
    public DateTime? RefDate { get; set; }

    public override DateTime GenerateExact()
    {
        return Faker.Date.Future(YearsToGoForward, RefDate);
    }

    public override FieldType FieldType => FieldType.Future;
}