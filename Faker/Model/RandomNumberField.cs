namespace Faker.Model;

public class RandomNumberField : Field<int>
{
    public RandomNumberField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public int Min { get; set; } = 0;
    public int Max { get; set; } = 1;
    public override int GenerateExact()
    {
        return Faker.Random.Number(Min,Max);
    }

    public override FieldType FieldType => FieldType.RandomNumber;
}