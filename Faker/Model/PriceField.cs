namespace Faker.Model;

public class PriceField : Field<string>
{
    public PriceField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public decimal Min { get; set; } = 1;
    public decimal Max { get; set; } = 1000;
    public int Decimals { get; set; } = 2;
    public string Symbol{get;set;} = string.Empty;

    public override string? GenerateExact()
    {
        return Faker.Commerce.Price(Min, Max, Decimals, Symbol);
    }

    public override FieldType FieldType => FieldType.Price;
}