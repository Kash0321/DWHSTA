using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DWHSTA.Infrastructure
{
    /// <summary>
    /// Enhances <see cref="Image"/> control to be <see cref="Command"/>-available, mixing functionality of <see cref="Button"/> and <see cref="Image"/>
    /// </summary>
    public class ImageButton : Image
    {
        /// <summary>
        /// <see cref="Command"/> to be executed when user taps on the <see cref="ImageButton"/>
        /// </summary>
        public static BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(Command), typeof(ImageButton));

        /// <summary>
        /// <see cref="Command"/> to be executed when user taps on the <see cref="ImageButton"/>
        /// </summary>
        public Command Command
        {
            get { return (Command)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        /// <summary>
        /// Initializes an instance of <see cref="ImageButton"/>
        /// </summary>
        public ImageButton()
        {
            GestureRecognizers.Add(new TapGestureRecognizer() { Command = new Command(async (s) => { await DisTap(s); }) });
        }

        private async Task DisTap(object sender)
        {
            Opacity = .5;
            await Task.Delay(200);

            if (Command != null)
            {
                Command.Execute(sender);
            }

            Opacity = 1;
        }
    }
}
