namespace Faker.Model;

public interface IField<out T> : IField
{
    
}

public interface IField
{
    string Description { get; }
    string? GenerateString();
    object? Generate();
    FieldType FieldType { get; }
}