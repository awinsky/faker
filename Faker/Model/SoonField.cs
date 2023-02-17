namespace Faker.Model;

public class SoonField : Field<DateTime>
{
    public SoonField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public int Days { get; set; }
    public DateTime? RefDate { get; set; }

    public override DateTime GenerateExact()
    {
       return Faker.Date.Soon(Days,RefDate);
    }

    public override FieldType FieldType => FieldType.Soon;
}