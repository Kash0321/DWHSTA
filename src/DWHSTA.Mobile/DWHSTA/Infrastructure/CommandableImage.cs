using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DWHSTA.Infrastructure
{
    public class CommandableImage : Image
    {
        public static BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(Command), typeof(CommandableImage));

        public Command Command
        {
            get { return (Command)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public CommandableImage()
        {
            GestureRecognizers.Add(new TapGestureRecognizer() { Command = new Command(DisTap) });
        }

        private void DisTap(object sender)
        {
            if (Command != null)
            {
                Command.Execute(sender);
            }
        }

    }
}
