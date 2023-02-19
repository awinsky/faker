namespace Faker.Model;

public class RandomEvenField : Field<int>
{
    public RandomEvenField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }
    public int Min { get; set; } = 0;
    public int Max { get; set; } = 1;
    public override int GenerateExact()
    {
        return Faker.Random.Even(Min, Max);
    }

    public override FieldType FieldType => FieldType.RandomEven;
}