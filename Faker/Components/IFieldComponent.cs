using Faker.Model;
using Microsoft.AspNetCore.Components;

namespace Faker.Components;

public interface IFieldComponent
{
    EventCallback<FieldWrapper> RemoveRequested { get; set; }

    FieldWrapper? Field { get; set; }
}


public abstract class BaseFieldComponent : OwningComponentBase, IFieldComponent
{
    [Parameter]
    public EventCallback<FieldWrapper> RemoveRequested { get; set; }
    [Parameter]
    public FieldWrapper? Field { get; set; }

    protected async Task RemoveField()
    {
        if (RemoveRequested.HasDelegate)
        {
            await RemoveRequested.InvokeAsync(Field);
        }
    }
}