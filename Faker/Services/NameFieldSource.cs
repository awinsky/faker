using Faker.Model;

namespace Faker.Services;

public class NameFieldSource : BaseFieldSource
{
    protected override IEnumerable<IField> GetFieldsInternal()
    {

        yield return new FirstNameField(Faker, "First Name");
        yield return new LastNameField(Faker, "Last Name");
        yield return new FullNameField(Faker, "Full Name");
        yield return new PrefixField(Faker, "Prefix");
        yield return new FindNameField(Faker, "Find Name");

      
        yield return new SimpleField<string>(Faker, () => Faker.Name.Suffix(), "Suffix");
        yield return new SimpleField<string>(Faker, () => Faker.Name.JobTitle(), "Job Title");
        yield return new SimpleField<string>(Faker, () => Faker.Name.JobDescriptor(), "Job Descriptor");
        yield return new SimpleField<string>(Faker, () => Faker.Name.JobArea(), "Job Area");
        yield return new SimpleField<string>(Faker, () => Faker.Name.JobType(), "Job Type");
        yield return new SimpleField<string>(Faker, () => Faker.Phone.PhoneNumber(), "Phone Number");
        yield return new SimpleField<string>(Faker, () => Faker.Phone.PhoneNumberFormat(), "Phone Number Format");
        yield return new GenderField(Faker, "Gender");
    }
}