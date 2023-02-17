namespace Faker.Model;

public class ImageLoremPixelUrlField : Field<string>
{
    public ImageLoremPixelUrlField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }

    public string Category { get; set; } = "Random";
    public string[] CategoryOptions => new[]
    {
        "Random",
        "Abstract",
        "Animals",
        "Business",
        "Cats",
        "City",
        "Food",
        "Nightlife",
        "Fashion",
        "People",
        "Nature",
        "Sports",
        "Technics",
        "Transport"
    };
    public bool Randomize{get;set;}
    public int Width { get; set; } = 100;
    public int Height { get; set; } = 100;
    public bool Https{get;set;}
    public override object? Generate()
    {
        return Faker.Image.LoremPixelUrl(Category, Width, Height, Randomize, Https);
    }
    public override string? GenerateString()
    {
        return Generate()?.ToString();
    }

    public override FieldType FieldType => FieldType.ImageLoremPixelUrl;
}