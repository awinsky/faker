namespace Faker.Model;

public class ImagePicsumUrlField : Field<string>
{
    public ImagePicsumUrlField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }
    public int Width { get; set; } = 100;
    public int Height { get; set; } = 100;

    public bool GrayScale{get;set;}
    public bool Blur{get;set;}

    public override object? Generate()
    {
        return Faker.Image.PicsumUrl(Width, Height, GrayScale, Blur);
    }

    public override FieldType FieldType => FieldType.ImagePicsumUrl;
    public override string? GenerateString()
    {
        return Generate()?.ToString();
    }
}