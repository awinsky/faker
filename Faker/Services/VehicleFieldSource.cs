using Faker.Model;

namespace Faker.Services;

public class VehicleFieldSource : BaseFieldSource
{
    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new SimpleField<string>(Faker, () => Faker.Vehicle.Vin(), "Vin");
        yield return new SimpleField<string>(Faker, () => Faker.Vehicle.Manufacturer(), "Manufacturer");
        yield return new SimpleField<string>(Faker, () => Faker.Vehicle.Model(), "Model");
        yield return new SimpleField<string>(Faker, () => Faker.Vehicle.Type(), "Type");
        yield return new SimpleField<string>(Faker, () => Faker.Vehicle.Fuel(), "Fuel");
    }
}
