using Faker.Model;
using Microsoft.AspNetCore.Components;

namespace Faker.Components;

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

    public virtual string? OutputName
    {
        get => Field?.Name;
        set
        {
            if (Field != null)
            {
                Field.Name = value;
            }
        }
    }
}