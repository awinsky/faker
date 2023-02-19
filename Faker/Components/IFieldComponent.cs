using Faker.Model;
using Microsoft.AspNetCore.Components;

namespace Faker.Components;

public interface IFieldComponent
{
    EventCallback<FieldWrapper> RemoveRequested { get; set; }

    FieldWrapper? Field { get; set; }
    string? OutputName { get; set; }
}