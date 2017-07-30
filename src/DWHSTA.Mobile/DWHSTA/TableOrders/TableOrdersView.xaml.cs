using DWHSTA.Model;
using DWHSTA.NewTableOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DWHSTA.TableOrders
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TableOrdersView : ContentPage
    {
        public TableOrdersView()
        {
            InitializeComponent();
            BindingContext = new TableOrdersViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SubscribeToMessages();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            UnsubscribeFromMessages();
        }

        void SubscribeToMessages()
        {
            //MessagingCenter.Subscribe<TableOrdersViewModel, TableOrder>(this, "NavigateToDetail", async (obj, tableOrder) =>
            //{
            //    if (tableOrder != null)
            //    {
            //        await Navigation.PushAsync(new TableOrderDetailView(tableOrder));
            //    }
            //});

            MessagingCenter.Subscribe<TableOrdersViewModel, string>(this, "Error", (obj, s) =>
            {
                DisplayAlert("Error", s, "OK");
            });

            MessagingCenter.Subscribe<TableOrdersViewModel, string>(this, "NavigateToNewTableOrder", async (obj, s) =>
            {
                if (s == "NewTableOrderView")
                {
                    await Navigation.PushAsync(new NewTableOrderView());
                }
            });
        }

        void UnsubscribeFromMessages()
        {
            MessagingCenter.Unsubscribe<TableOrdersViewModel, TableOrder>(this, "NavigateToDetail");
            MessagingCenter.Unsubscribe<TableOrdersViewModel, string>(this, "Error");
            MessagingCenter.Unsubscribe<TableOrdersViewModel, string>(this, "NavigateToNewTableOrder");
        }
    }
}