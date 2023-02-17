namespace Faker.Model;

public class Field<T> : IField<T>
{
    private readonly Func<T>? _generator;
    private readonly Func<string?>? _stringGenerator;
    protected readonly Bogus.Faker Faker;

    public Field(Bogus.Faker faker, string description)
    {
        Faker = faker;
        Description = description;
    }

    public Field(Bogus.Faker faker,
        Func<T> generator, string description, 
        Func<string?>? stringGenerator = null)
    {
        Faker = faker;
        _generator = generator;
        Description = description;

        _stringGenerator = stringGenerator??(()=>_generator()?.ToString());
    }

    public virtual string Description { get; }

    public virtual object? Generate()
    {
        if (_generator != null) return _generator();
        return null;
    }

    public virtual FieldType FieldType => FieldType.Simple;

    public virtual string? GenerateString()
    {
        return _stringGenerator?.Invoke();
    }
}

