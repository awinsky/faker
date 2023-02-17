using Faker.Model;

namespace Faker.Services;

public class SystemFieldSource : BaseFieldSource
{
    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new Field<string>(Faker, () => Faker.System.FileName(), "File Name");
        yield return new Field<string>(Faker, () => Faker.System.DirectoryPath(), "Directory Path");
        yield return new Field<string>(Faker, () => Faker.System.FilePath(), "File Path");
        yield return new Field<string>(Faker, () => Faker.System.CommonFileName(), "Common File Name");
        yield return new Field<string>(Faker, () => Faker.System.MimeType(), "Mime Type");
        yield return new Field<string>(Faker, () => Faker.System.CommonFileType(), "Common File Type");
        yield return new Field<string>(Faker, () => Faker.System.CommonFileExt(), "Common File Ext");
        yield return new Field<string>(Faker, () => Faker.System.FileType(), "File Type");
        yield return new Field<string>(Faker, () => Faker.System.FileExt(), "File Ext"); 
        yield return new Field<string>(Faker, () => Faker.System.Semver(), "Semver");
        yield return new Field<string>(Faker, () => Faker.System.Version().ToString(), "Version");
        yield return new Field<string>(Faker, () => Faker.System.Exception().ToString(), "Exception");
        yield return new Field<string>(Faker, () => Faker.System.AndroidId(), "Android Id");
        yield return new Field<string>(Faker, () => Faker.System.ApplePushToken(), "Apple Push Token");
        yield return new Field<string>(Faker, () => Faker.System.ApplePushToken(), "Apple Push Token");
    }
}