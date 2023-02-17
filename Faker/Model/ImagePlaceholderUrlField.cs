namespace Faker.Model;

public class ImagePlaceholderUrlField : Field<string>
{
    public ImagePlaceholderUrlField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }
    public int Width { get; set; } = 100;
    public int Height { get; set; } = 100;
    public string Text { get; set; } = "Image text";
    public string BackColor { get; set; } = "cccccc";
    public string TextColor { get; set; } = "textColor";
    public string Format { get; set; } = "png";

    public override FieldType FieldType => FieldType.ImagePlaceholderUrl;
    public override string? GenerateExact()
    {
        return Faker.Image.PlaceholderUrl(Width, Height, Text, BackColor, TextColor, Format);
    }

}