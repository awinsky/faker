namespace Faker.Model;

public class AccountField : Field<string>
{
    public AccountField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public int Length { get; set; } = 8;

    public override string? GenerateExact()
    {
        return Faker.Finance.Account(Length);
    }

    public override FieldType FieldType => FieldType.Account;
}