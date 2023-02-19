namespace Faker.Model;

public class RandomField<T> : Field<T>
{
    private readonly Func<T,T,T> _func;

    public RandomField(Bogus.Faker faker, string description, T min, T max, Func<T, T, T> func, FieldType fieldType) :
        base(faker, description)
    {
        Min = min;
        Max = max;
        _func = func;
        FieldType = fieldType;
    }

    public T Min { get;set; }
    public T Max { get;set; }
    
    public override T? GenerateExact()
    {
        return _func(Min, Max);
    }

    public override FieldType FieldType { get; }
}
