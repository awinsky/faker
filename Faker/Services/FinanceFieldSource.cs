using System.Globalization;
using Faker.Model;

namespace Faker.Services;

public class FinanceFieldSource : BaseFieldSource
{
    public override string CategoryName => "Finance";
    protected override IEnumerable<IField> GetFieldsInternal()
    {
       
        yield return new AccountField(Faker, "Account");
        yield return new SimpleField<string>(Faker, () => Faker.Finance.AccountName(), "Account Name");
        yield return new AmountField(Faker, "Amount");
  
        yield return new SimpleField<string>(Faker, () => Faker.Finance.TransactionType(),
            "Transaction Type");
        yield return new SimpleField<string>(Faker, () => Faker.Finance.Currency().Symbol,
            "Currency Symbol");
        yield return new SimpleField<string>(Faker, () => Faker.Finance.Currency().Code,
            "Currency Code");
        yield return new SimpleField<string>(Faker, () => Faker.Finance.Currency().Description,
            "Currency Description");
        yield return new CreditCardNumberField(Faker, "Credit Card Number");

        yield return new SimpleField<string>(Faker, () => Faker.Finance.CreditCardCvv(),
            "Credit Card Cvv");
        yield return new SimpleField<string>(Faker, () => Faker.Finance.BitcoinAddress(),
            "Bitcoin Address");
        yield return new SimpleField<string>(Faker, () => Faker.Finance.EthereumAddress(),
            "Ethereum Address");
        yield return new SimpleField<string>(Faker, () => Faker.Finance.RoutingNumber(),
            "Routing Number");
        yield return new SimpleField<string>(Faker, () => Faker.Finance.Bic(),
            "Bic");

        yield return new IbanField(Faker, "IBAN");
    }
}