using Faker.Model;

namespace Faker.Services;

public class InternetFieldSource : BaseFieldSource
{
    protected override IEnumerable<IField> GetFieldsInternal()
    {
        yield return new AvatarField(Faker, "Avatar");
        yield return new EmailField(Faker, "Email");
        yield return new ExampleEmailField(Faker, "Example Email");
        yield return new UserNameField(Faker, "User Name");
        yield return new UserNameUnicodeField(Faker, "Unicode User Name");
        
        yield return new SimpleField<string>(Faker, () => Faker.Internet.DomainName(), "Domain Name");
        yield return new SimpleField<string>(Faker, () => Faker.Internet.DomainWord(), "Domain Word");
        yield return new SimpleField<string>(Faker, () => Faker.Internet.DomainSuffix(), "Domain Suffix");
        yield return new SimpleField<string>(Faker, () => Faker.Internet.Ip(), "IP");
        yield return new SimpleField<string>(Faker, () => Faker.Internet.IpAddress().ToString(), "Ip Address");
        yield return new SimpleField<string>(Faker, () => Faker.Internet.IpEndPoint().ToString(), "Ip End Point");
        yield return new SimpleField<string>(Faker, () => Faker.Internet.Ipv6(), "Ipv6");
        yield return new SimpleField<string>(Faker, () => Faker.Internet.Ipv6Address().ToString(), "Ipv6 Address");
        yield return new SimpleField<string>(Faker, () => Faker.Internet.Ipv6EndPoint().ToString(), "Ipv6 End Point");
        yield return new SimpleField<string>(Faker, () => Faker.Internet.UserAgent(), "User Agent");
        yield return new SimpleField<string>(Faker, () => Faker.Internet.Mac(), "Mac");

        yield return new PasswordField(Faker, "Password");

        yield return new SimpleField<string>(Faker, () => Faker.Internet.Color(), "Color");
        yield return new SimpleField<string>(Faker, () => Faker.Internet.Protocol(), "Protocol");
        yield return new SimpleField<string>(Faker, () => Faker.Internet.Url(), "Url");
        yield return new SimpleField<string>(Faker, () => Faker.Internet.UrlWithPath(), "Url With Path");
        yield return new SimpleField<string>(Faker, () => Faker.Internet.UrlRootedPath(), "Url Rooted Path");
    }
}