
using ProyectoProgreso3.MVVM.Models;
using ProyectoProgreso3.MVVM.Views;
using ProyectoProgreso3.Repositories;


namespace ProyectoProgreso3;

public partial class App : Application
{
		public static BaseRepository<MVTransacciones>
			TransactionsRepo{ get; private set; }

    public App(BaseRepository<MVTransacciones> _transactionsRepo)
	{
		InitializeComponent();
		  
		TransactionsRepo = _transactionsRepo;



		MainPage = new AppDistribu ();
	}
}
