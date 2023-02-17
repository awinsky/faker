namespace Faker.Model;

public class SimpleField<T> : Field<T>
{
    private readonly Func<T>? _generator;
    private readonly Func<string?>? _stringGenerator;
    public SimpleField(Bogus.Faker faker,
        Func<T> generator, string description,
        Func<string?>? stringGenerator = null): base(faker, description)
    {
        _generator = generator;
      

        _stringGenerator = stringGenerator ?? (() => _generator()?.ToString());
    }

    public override T? GenerateExact()
    {
        return _generator != null ? _generator() : default;
    }

    public override string? GenerateString()
    {
        return _stringGenerator != null ? _stringGenerator() : base.GenerateString();
    }
}