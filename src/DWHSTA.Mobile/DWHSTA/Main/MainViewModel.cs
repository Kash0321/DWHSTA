using DWHSTA.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DWHSTA.Main
{
    public class MainViewModel : BaseViewModel
    {

        public MainViewModel()
        {
            NavigateToRoomCommand = new Command(() => NavigateToRoom());
        }
        /// <summary>
        /// Comando: Navega a la gestión de Sala
        /// </summary>
        public Command NavigateToRoomCommand { get; set; }

        void NavigateToRoom()
        {
            try
            {
                MessagingCenter.Send(this, "NavigateToTableOrders");
            }
            catch (Exception ex)
            {
                MessagingCenter.Send(this, "Error", ex.Message);
            }
        }
    }
}
