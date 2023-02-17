namespace Faker.Model;

public abstract class Field<T> : IField<T>
{
    protected readonly Bogus.Faker Faker;

    protected Field(Bogus.Faker faker, string description)
    {
        Faker = faker;
        Description = description;
    }
    
    public virtual string Description { get; }

    public abstract T? GenerateExact();
    
    public virtual object? Generate()
    {
        return GenerateExact();
       
    }

    public virtual FieldType FieldType => FieldType.Simple;

    public virtual string? GenerateString()
    {
        return GenerateExact()?.ToString();
    }
}

