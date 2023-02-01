using PropertyChanged;
using ProyectoProgreso3.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgreso3.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class JNEstadisticasModel
    {
        public ObservableCollection<GETransacion> Summary { get; set; }
        public ObservableCollection<MVTransacciones> SpendingList { get; set; }

        public void GetTransactionsSummary()
        {
            var data =
                 App.TransactionsRepo.GetItems();
            var result =
                 new List<GETransacion>();
            var groupedTransactions =
                 data.GroupBy(t => t.OperationDate.Date);

            foreach (var group in groupedTransactions)
            {
                var transactionSummary = new GETransacion
                {
                    TransactionsDate = group.Key,
                    TransactionsTotal = group.Sum(t => t.IsIncome ? t.Amount : -t.Amount),
                    ShownDate = group.Key.ToString("MM/dd")
                };
                result.Add(transactionSummary);
            }

            result = result.OrderBy(x => x.TransactionsDate).ToList();

            Summary = new ObservableCollection<GETransacion>(result);

            var spendingList = data.Where(x => x.IsIncome == false);
            SpendingList = new ObservableCollection<MVTransacciones>(spendingList);

        }
    }
}
