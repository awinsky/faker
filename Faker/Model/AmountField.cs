namespace Faker.Model;

public class AmountField : Field<decimal>
{
    public AmountField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public decimal Min { get; set; } = 0;
    public decimal Max { get; set; } = 1000;
    public int Decimals { get; set; } = 2;

    public override decimal GenerateExact()
    {
        return Faker.Finance.Amount(Min,Max, Decimals);
    }

    public override FieldType FieldType => FieldType.Amount;
}