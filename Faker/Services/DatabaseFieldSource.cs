using Faker.Model;

namespace Faker.Services;

public class DatabaseFieldSource : BaseFieldSource
{

    public override string CategoryName => "Database";
    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new SimpleField<string>(Faker, () => Faker.Database.Column(), "Column");
        yield return new SimpleField<string>(Faker, () => Faker.Database.Type(), "Type");
        yield return new SimpleField<string>(Faker, () => Faker.Database.Collation(), "Collation");
        yield return new SimpleField<string>(Faker, () => Faker.Database.Engine(), "Engine");
    }
}