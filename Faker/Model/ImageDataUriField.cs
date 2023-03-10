namespace Faker.Model;

public class ImageDataUriField : Field<string>
{
    public ImageDataUriField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public int Width { get; set; } = 100;
    public int Height { get; set; } = 100;
    public string? Color { get; set; } = "gray";

    public override string? GenerateExact()
    {
        return Faker.Image.DataUri(Width, Height, Color);
    }

    public override FieldType FieldType => FieldType.ImageDataUri;

}