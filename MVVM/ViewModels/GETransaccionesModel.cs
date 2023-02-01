using ProyectoProgreso3.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgreso3.MVVM.ViewModels
{
    public class GETransaccionesModel
    {
        public MVTransacciones Transaction { get; set; } = new MVTransacciones
        {
            OperationDate = DateTime.Now,
        };




        public string SaveTransaction()
        {
            App.TransactionsRepo.SaveItem(Transaction);
            return App.TransactionsRepo.StatusMessage;
        }
    }
}
