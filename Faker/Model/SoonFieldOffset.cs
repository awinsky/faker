namespace Faker.Model;

public class SoonFieldOffset : Field<DateTimeOffset>
{
    public SoonFieldOffset(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public int Days { get; set; }
    public DateTime? RefDate { get; set; }

    public override DateTimeOffset GenerateExact()
    {
       return Faker.Date.SoonOffset(Days,RefDate);
    }

    public override FieldType FieldType => FieldType.SoonOffset;
}