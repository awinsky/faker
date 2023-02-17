namespace Faker.Model;

public class FieldWrapper
{
    public FieldWrapper(IField field, string name)
    {
        Field = field;
        Name = name;
    }

    public IField Field{get;}
    public string Name { get;}
}