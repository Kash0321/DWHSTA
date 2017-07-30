using DWHSTA.Infrastructure;
using DWHSTA.Model;
using DWHSTA.NewTableOrder;
using DWHSTA.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DWHSTA.TableOrders
{
    /// <summary>
    /// ViewModel que gestiona el listado de la entidad <see cref="TableOrder"/>
    /// </summary>
    public class TableOrdersViewModel : BaseViewModel
    {
        /// <summary>
        /// Colección de gastos gestionados
        /// </summary>
        public ObservableCollection<TableOrder> TableOrders { get; set; }

        /// <summary>
        /// Comando: Obtiene los comandas de mesas en activo
        /// </summary>
        public Command GetTableOrdersCommand { get; set; }

        public Command AddTableOrderCommand { get; set; }

        /// <summary>
        /// Inicializa una instancia de <see cref="TableOrdersViewModel"/>
        /// </summary>
        public TableOrdersViewModel()
        {
            TableOrders = new ObservableCollection<TableOrder>();
            GetTableOrdersCommand = new Command(async () => await GetTableOrdersAsync());
            AddTableOrderCommand = new Command(() => NavigateToNewTableOrder());
            GetTableOrdersAsync();

            //MessagingCenter.Subscribe<NewTableOrderViewModel, object[]>(this, "AddTableOrder", async (obj, tableOrderData) =>
            //{
            //    var tableOrder = tableOrderData[0] as TableOrder;
            //    TableOrders.Add(tableOrder);

            //    await DependencyService.Get<ITableOrderService>().AddTableOrderAsync(tableOrder);
            //});
        }

        TableOrder selectedTableOrder;
        /// <summary>
        /// Comnanda seleccionada en la UI
        /// </summary>
        public TableOrder SelectedTableOrder
        {
            get { return selectedTableOrder; }
            set
            {
                selectedTableOrder = value;
                OnPropertyChanged();

                if (selectedTableOrder != null)
                {
                    MessagingCenter.Send(this, "NavigateToDetail", selectedTableOrder);
                    selectedTableOrder = null;
                }
            }
        }

        async Task GetTableOrdersAsync()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                TableOrders.Clear();
                var tableOrdersService = DependencyService.Get<ITableOrderService>();
                var tableOrders = await tableOrdersService.GetTableOrdersAsync();
                foreach (var tableOrder in tableOrders)
                {
                    TableOrders.Add(tableOrder);
                }
            }
            catch (Exception ex)
            {
                MessagingCenter.Send(this, "Error", ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }
        void NavigateToNewTableOrder()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                MessagingCenter.Send(this, "NavigateToNewTableOrder", "NewTableOrderView");
            }
            catch (Exception ex)
            {
                MessagingCenter.Send(this, "Error", ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
