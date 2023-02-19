using System.Globalization;
using Faker.Model;

namespace Faker.Services;

public class AddressFieldSource : BaseFieldSource
{

    public override string CategoryName => "Address";

    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new SimpleField<string>(Faker, () => Faker.Address.City(), "City");
        yield return new StreetAddressField(Faker, "Street Address");
        yield return new SimpleField<string>(Faker, () => Faker.Address.ZipCode(), "Zip Code");
        yield return new SimpleField<string>(Faker, () => Faker.Address.CitySuffix(), "City Suffix");
        yield return new SimpleField<string>(Faker, () => Faker.Address.StreetName(), "Street Name");
        yield return new SimpleField<string>(Faker, () => Faker.Address.BuildingNumber(), "Building Number");
        yield return new SimpleField<string>(Faker, () => Faker.Address.StreetSuffix(), "Street Suffix");
        yield return new SimpleField<string>(Faker, () => Faker.Address.SecondaryAddress(), "Secondary Address");
        yield return new SimpleField<string>(Faker, () => Faker.Address.County(), "County");
        yield return new SimpleField<string>(Faker, () => Faker.Address.Country(), "Country");
        yield return new SimpleField<string>(Faker, () => Faker.Address.FullAddress(), "Full Address");
        yield return new SimpleField<string>(Faker, () => Faker.Address.CountryCode(), "Country Code");
        yield return new SimpleField<string>(Faker, () => Faker.Address.State(), "State");
        yield return new SimpleField<string>(Faker, () => Faker.Address.StateAbbr(), "State Abbr");

        yield return new LatitudeField(Faker, "Latitude");
        yield return new LongitudeField(Faker, "Longitude");
        yield return new DirectionField(Faker, "Direction");
        yield return new CardinalDirectionField(Faker, "Cardinal Direction");
        yield return new OrdinalDirectionField(Faker, "Ordinal Direction");
      
    }
}