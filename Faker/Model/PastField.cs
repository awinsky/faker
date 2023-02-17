namespace Faker.Model;

public class PastField : Field<DateTime>
{
    public PastField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public int YearsToGoBack { get; set; } = 1;
    public DateTime? RefDate { get;set; } =null;

    public override DateTime GenerateExact()
    {
        return Faker.Date.Past(YearsToGoBack, RefDate);
    }
}