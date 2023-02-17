namespace Faker.Model;

public class ImageLoremFlickrUrlField : Field<string>
{
    public ImageLoremFlickrUrlField(Bogus.Faker faker, string description) : base(faker, description)
    {
    }
    public int Width { get; set; } = 100;
    public int Height { get; set; } = 100;
    public string Keywords { get; set; } = "Keywords";
    public bool Grascale { get; set; }
    public bool MatchAllKeywords{get;set;}

    public override object? Generate()
    {
        return Faker.Image.LoremFlickrUrl(Width, Height, Keywords, Grascale, MatchAllKeywords);

    }

    public override FieldType FieldType => FieldType.ImageLoremFlickrUrl;

    public override string? GenerateString()
    {
        return Generate()?.ToString();
    }
}