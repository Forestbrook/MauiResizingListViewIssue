using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp3;

public partial class ExampleListItemViewModel : ObservableObject
{
    public ExampleListItemViewModel(int index)
    {
        Label1 = $"Top label {index}";
        Label2 = $"Bottom label {index}";
    }

    [ObservableProperty]
    private bool _isOpen;

    public string Label1 { get; }

    public string Label2 { get; }

    public void OpenClose()
        => IsOpen = !IsOpen;
}