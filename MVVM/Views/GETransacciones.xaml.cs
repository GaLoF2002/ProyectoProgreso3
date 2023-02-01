using ProyectoProgreso3.MVVM.ViewModels;

namespace ProyectoProgreso3.MVVM.Views;

public partial class GETransacciones : ContentPage
{
	public GETransacciones()
	{
		InitializeComponent();
        BindingContext = new GETransaccionesModel();
    }

	private  async  void Save_Clicked(object sender, EventArgs e)
	{
        var currentVM =(GETransaccionesModel)BindingContext;
        var message =currentVM.SaveTransaction();
        await DisplayAlert("Info", message, "Ok");
        await Navigation.PopToRootAsync();
    }

	private async void Cancel_Clicked(object sender, EventArgs e)
	{
        await Navigation.PopToRootAsync();
    }
}