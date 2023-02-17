using Faker.Model;

namespace Faker.Services;

public class ImageFieldSource : BaseFieldSource
{
    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new ImageDataUriField(Faker, "Image data uri");
        yield return new ImagePicsumUrlField(Faker, "Picsum Url");
        yield return new ImagePlaceholderUrlField(Faker, "Placeholder Url");
        yield return new ImageLoremFlickrUrlField(Faker, "Image Lorem Flickr Url");
        yield return new ImageLoremPixelUrlField(Faker, "Image LoremPixel Url");
        //yield return new ImageLoremPixelUrl(Faker, "Lorem Pixel Url");


    }
}