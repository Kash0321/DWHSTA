using DWHSTA.Model;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(DWHSTA.Services.TableOrderAPIService))]

namespace DWHSTA.Services
{
    public class TableOrderAPIService : ITableOrderService
    {
        bool isInitialized;
        IMobileServiceSyncTable<TableOrder> tableOrderTable;

        MobileServiceClient MobileService { get; set; }

        public TableOrderAPIService()
        {
            MobileService = new MobileServiceClient("http://dwhsta.azurewebsites.net", null);
        }

        async Task Initialize()
        {
            if (isInitialized)
                return;

            var store = new MobileServiceSQLiteStore("dwhsta.db");
            store.DefineTable<TableOrder>();
            await MobileService.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());
            tableOrderTable = MobileService.GetSyncTable<TableOrder>();

            isInitialized = true;
        }

        public async Task AddTableOrderAsync(TableOrder order)
        {
            await Initialize();

            await tableOrderTable.InsertAsync(order);
            await SyncTableOrders();
        }

        public async Task<IEnumerable<TableOrder>> GetTableOrdersAsync()
        {
            await Initialize();

            await SyncTableOrders();

            return await tableOrderTable.ToEnumerableAsync();
        }

        async Task SyncTableOrders()
        {
            try
            {
                await MobileService.SyncContext.PushAsync();
                await tableOrderTable.PullAsync($"all{typeof(TableOrder).Name}", tableOrderTable.CreateQuery());
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An error syncing occurred. That is OK, as we have offline sync: " + ex.Message);
            }
        }
    }
}
