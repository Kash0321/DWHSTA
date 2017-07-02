using DWHSTA.Model;
using DWHSTA.TableOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DWHSTA.Main
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
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
            MessagingCenter.Subscribe<MainViewModel, string>(this, "NavigateToTableOrders", async (obj, s) =>
            {
                if (s == "TableOrdersView")
                {
                    await Navigation.PushAsync(new TableOrdersView());
                }
            });

            MessagingCenter.Subscribe<TableOrdersViewModel, string>(this, "Error", (obj, s) =>
            {
                DisplayAlert("Error", s, "OK");
            });
        }

        void UnsubscribeFromMessages()
        {
            MessagingCenter.Unsubscribe<TableOrdersViewModel, TableOrder>(this, "NavigateToTableOrders");
            MessagingCenter.Unsubscribe<TableOrdersViewModel, string>(this, "Error");
        }
    }
}
