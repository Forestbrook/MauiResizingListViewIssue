namespace MauiApp3;

public class ExampleListViewModel
{
    public ExampleListViewModel()
    {
        Items = CreateItems().ToList();
    }

    public IList<ExampleListItemViewModel> Items { get; }

    private static IEnumerable<ExampleListItemViewModel> CreateItems()
    {
        for (var i = 1; i <= 100; i++)
        {
            yield return new ExampleListItemViewModel(i);
        }
    }
}