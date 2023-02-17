using Faker.Model;

namespace Faker.Services;

public abstract class BaseFieldSource : IFieldSource
{
    private string _locale = "en";
    protected Bogus.Faker Faker;
    protected BaseFieldSource()
    {
        Faker = new(_locale);
    }
    
    public virtual string CategoryName => GetType().Name.Replace("FieldSource", "");
    private List<IField>? _fields = null;
    public virtual IEnumerable<IField> GetFields()
    {
        return _fields ??= GetFieldsInternal().ToList();
    }
    protected abstract IEnumerable<IField> GetFieldsInternal();
    public void InitFaker(string locale)
    {
        Faker = new(locale);
        _fields = null;
        _locale = locale;
    }
}