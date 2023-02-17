using Bogus.DataSets;

namespace Faker.Model;

public class CreditCardNumberField : Field<string>
{

    private readonly Dictionary<string, CardType> _cardTypes = new()
    {
        ["All"] = null,
        ["Visa"] = CardType.Visa,
        ["Mastercard"] = CardType.Mastercard,
        ["Discover"] = CardType.Discover,
        ["American Express"] = CardType.AmericanExpress,
        ["Diners Club"] = CardType.DinersClub,
        ["Jcb"] = CardType.Jcb,
        ["Switch"] = CardType.Switch,
        ["Solo"] = CardType.Solo,
        ["Maestro"] = CardType.Maestro,
        ["Laser"] = CardType.Laser,
        ["Instapayment"] = CardType.Instapayment,

    };
    public CreditCardNumberField(Bogus.Faker faker, string description) : base(faker, description)
    {
      
    }

    public string Type { get; set; } = "All";

    public IEnumerable<string> Options
    {
        get
        {
            return _cardTypes.Select(s => s.Key);
        }
    }
   

    public override string? GenerateExact()
    {
        return Faker.Finance.CreditCardNumber(_cardTypes[Type]);
    }

    public override FieldType FieldType => FieldType.CreditCardNumber;
}