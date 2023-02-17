using Faker;
using Faker.Model;
using Faker.Services;
using MatBlazor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


IFieldSource[] sources =
{
    new AddressFieldSource(),
    new CommerceFieldSource(),
    new CompanyFieldSource(),
    new DatabaseFieldSource(),
    new DateFieldSource(),
    new FinanceFieldSource(),
    new HackerFieldSource(),
    new ImageFieldSource(),
    new InternetFieldSource(),
    new LoremFieldSource(),
    new NameFieldSource(),
    new SystemFieldSource(),
    new VehicleFieldSource(),
    new RandomFieldSource()
};
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<IEnumerable<IFieldSource>>(x => sources);
builder.Services.AddSingleton<ILocaleSource,LocaleSource>();
builder.Services.AddMatBlazor();
await builder.Build().RunAsync();



