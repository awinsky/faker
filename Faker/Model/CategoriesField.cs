using System;

namespace Faker.Model;

public class CategoriesField : Field<string[]>
{
    public CategoriesField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public int Number { get; set; } = 1;
    public override object? Generate()
    {
        return Faker.Commerce.Categories(Number);
    }

    public override string[]? GenerateExact()
    {
        return Faker.Commerce.Categories(Number);
    }

    public override string? GenerateString()
    {
        var result = GenerateExact()!;
        return string.Join(",", result);

    }

    public override FieldType FieldType => FieldType.Categories;
}