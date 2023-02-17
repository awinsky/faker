using Faker.Model;
using Microsoft.JSInterop;

namespace Faker.Pages;

public partial class Index
{
    private readonly List<FieldWrapper> _selectedFields = new();
    private readonly List<string?[]> _result = new();
    private int Count { get; set; } = 10;
    private string _locale = "en";
    private void AddFiled(IField field)
    {
        _result.Clear();
        var count = _selectedFields.Count(x => x.Field.Description == field.Description) + 1;
        var name = $"{field.Description}#{count}";
        _selectedFields.Add(new(field, name));
    }

    private Task LocaleChanged(LocaleDto locale)
    {
        _locale = locale.Id;
        var sources = Sources.ToArray();
        foreach (var source in sources)
        {
            source.InitFaker(locale.Id);
        }

        return Task.CompletedTask;
    }

    private void RemoveField(FieldWrapper fieldWrapper)
    {
        _result.Clear();
        _selectedFields.Remove(fieldWrapper);
    }

    private void Generate()
    {
        _result.Clear();
        var current = 0;
        while (current < Count)
        {
            var currentResult = new string?[_selectedFields.Count];
            for (var i = 0; i < _selectedFields.Count; i++)
            {
                currentResult[i] = _selectedFields[i].Field.GenerateString();
            }
            _result.Add(currentResult);
            current++;
        }
    }

    private async Task SaveToCsv()
    {
        if (_result.Count > 0)
        {
            var stream = new MemoryStream();
            await using var writer = new StreamWriter(stream);

            var header = string.Join(";", _selectedFields.Select(s => s.Name));
            await writer.WriteLineAsync(header);
            foreach (var line in _result.Select(item => string.Join(";", item)))
            {
                await writer.WriteLineAsync(line);
            }

            await writer.FlushAsync();
            stream.Seek(0,SeekOrigin.Begin);
            var file = stream.ToArray();

         
            await JsRuntime.InvokeVoidAsync("BlazorDownloadFile",
                "export.csv",
                "text/csv", file);
        }
    }
}