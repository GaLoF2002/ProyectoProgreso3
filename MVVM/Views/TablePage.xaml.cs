using ProyectoProgreso3.MVVM.ViewModels;

namespace ProyectoProgreso3.MVVM.Views;

public partial class TablePage : ContentPage
{
    public TablePage()
    {
        InitializeComponent();
        BindingContext = new TableModel();
    }

    private async void AddTransaction_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GETransacciones());
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var vm = (TableModel)BindingContext;
        vm.FillData();
    }
}