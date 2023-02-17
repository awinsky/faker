using Faker.Model;

namespace Faker.Services;

public class NameFieldSource : BaseFieldSource
{
    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new Field<string>(Faker, () => Faker.Name.FirstName(), "First Name");
        yield return new Field<string>(Faker, () => Faker.Name.LastName(), "Last Name");
        yield return new Field<string>(Faker, () => Faker.Name.FullName(), "Full Name");
        yield return new Field<string>(Faker, () => Faker.Name.Prefix(), "Prefix");
        yield return new Field<string>(Faker, () => Faker.Name.Suffix(), "Suffix");
        yield return new Field<string>(Faker, () => Faker.Name.FindName(), "Find Name");
        yield return new Field<string>(Faker, () => Faker.Name.JobTitle(), "Job Title");
        yield return new Field<string>(Faker, () => Faker.Name.JobDescriptor(), "Job Descriptor");
        yield return new Field<string>(Faker, () => Faker.Name.JobArea(), "Job Area");
        yield return new Field<string>(Faker, () => Faker.Name.JobType(), "Job Type");
        yield return new Field<string>(Faker, () => Faker.Phone.PhoneNumber(), "Phone Number");
        yield return new Field<string>(Faker, () => Faker.Phone.PhoneNumberFormat(), "Phone Number Format");
    }
}