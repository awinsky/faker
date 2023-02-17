namespace Faker.Model;

public class StreetAddressField : Field<string>
{

    public bool UseFullAddress { get; set; }

    public StreetAddressField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public override string? GenerateExact()
    {
        return Faker.Address.StreetAddress(UseFullAddress);
    }
    
    public override FieldType FieldType => FieldType.StreetAddress;

}