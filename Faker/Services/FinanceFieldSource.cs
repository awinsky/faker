﻿using System.Globalization;
using Faker.Model;

namespace Faker.Services;

public class FinanceFieldSource : BaseFieldSource
{
    public override string CategoryName => "Finance";
    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new Field<string>(Faker, () => Faker.Finance.Account(), "Account");
        yield return new Field<string>(Faker, () => Faker.Finance.AccountName(), "Account Name");
        yield return new Field<string>(Faker, () => Faker.Finance.Amount().ToString(CultureInfo.InvariantCulture),
            "Amount");
        yield return new Field<string>(Faker, () => Faker.Finance.TransactionType(),
            "Amount");
        yield return new Field<string>(Faker, () => Faker.Finance.Currency().Symbol,
            "Currency Symbol");
        yield return new Field<string>(Faker, () => Faker.Finance.Currency().Code,
            "Currency Code");
        yield return new Field<string>(Faker, () => Faker.Finance.Currency().Description,
            "Currency Description");
        yield return new Field<string>(Faker, () => Faker.Finance.CreditCardNumber(),
            "Credit Card Number");
        yield return new Field<string>(Faker, () => Faker.Finance.CreditCardCvv(),
            "Credit Card Cvv");
        yield return new Field<string>(Faker, () => Faker.Finance.BitcoinAddress(),
            "Bitcoin Address");
        yield return new Field<string>(Faker, () => Faker.Finance.EthereumAddress(),
            "Ethereum Address");
        yield return new Field<string>(Faker, () => Faker.Finance.RoutingNumber(),
            "Routing Number");
        yield return new Field<string>(Faker, () => Faker.Finance.Bic(),
            "Bic");
        yield return new Field<string>(Faker, () => Faker.Finance.Iban(),
            "Iban");
    }
}