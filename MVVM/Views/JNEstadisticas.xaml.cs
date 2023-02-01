using ProyectoProgreso3.MVVM.ViewModels;

namespace ProyectoProgreso3.MVVM.Views;

public partial class JNEstadisticas : ContentPage
{
	public JNEstadisticas()
	{
		InitializeComponent();
        BindingContext = new JNEstadisticasModel();
    }
    protected override void OnAppearing()
    {
        var vm = (JNEstadisticasModel)BindingContext;
        vm.GetTransactionsSummary();
    }

}