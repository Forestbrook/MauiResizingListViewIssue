namespace MauiApp3;

public partial class ExampleListItemViewCell : ViewCell
{
    public const int ClosedCellHeight = 40;
    public const int OpenCellHeight = ClosedCellHeight + 40;
    private ExampleListItemViewModel _viewModel;

    public ExampleListItemViewCell()
    {
        InitializeComponent();
        Height = ClosedCellHeight;
    }

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
        _viewModel = BindingContext as ExampleListItemViewModel;
        UpdateHeight();
    }

    private void OnOpenClose(object sender, EventArgs args)
    {
        if (_viewModel == null)
            return;

        _viewModel.OpenClose();
        UpdateHeight();
        ForceUpdateSize();
    }

    private void UpdateHeight()
        => Height = _viewModel?.IsOpen ?? false ? OpenCellHeight : ClosedCellHeight;
}