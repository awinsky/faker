using Faker.Model;

namespace Faker.Services;

public class CompanyFieldSource : BaseFieldSource
{
    public override string CategoryName => "Company";
    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new SimpleField<string>(Faker, () => Faker.Company.CompanySuffix(), "Company Suffix");
        yield return new SimpleField<string>(Faker, () => Faker.Company.CompanyName(), "Company Name");
        yield return new SimpleField<string>(Faker, () => Faker.Company.CatchPhrase(), "Catch Phrase");
        yield return new SimpleField<string>(Faker, () => Faker.Company.Bs(), "Bs");
    }
}