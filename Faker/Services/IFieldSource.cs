using Faker.Model;

namespace Faker.Services;

public interface IFieldSource
{
    string CategoryName { get; }
    IEnumerable<IField> GetFields();
    void InitFaker(string locale);
}