using Faker.Model;

namespace Faker.Services;

public class CommerceFieldSource : BaseFieldSource
{
    public override string CategoryName => "Commerce";
    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new SimpleField<string>(Faker, () => Faker.Commerce.Department(), "Department");
        yield return new PriceField(Faker, "Price");
        yield return new CategoriesField(Faker, "Categories");
        yield return new SimpleField<string>(Faker, () => Faker.Commerce.ProductName(), "Product Name");
        yield return new SimpleField<string>(Faker, () => Faker.Commerce.Color(), "Color");
        yield return new SimpleField<string>(Faker, () => Faker.Commerce.Product(), "Product");
        yield return new SimpleField<string>(Faker, () => Faker.Commerce.ProductAdjective(), "Product Adjective");
        yield return new SimpleField<string>(Faker, () => Faker.Commerce.ProductMaterial(), "Product Material");
        yield return new SimpleField<string>(Faker, () => Faker.Commerce.Ean8(), "Ean8");
        yield return new SimpleField<string>(Faker, () => Faker.Commerce.Ean13(), "Ean13");
    }
}