using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Arvestus_Ottomar_Raidlepp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int counter = 1;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string username = "user";
            string password = "SecretPassword";
            if (counter < 3)
            {
                if (userbox.Text == username && passwordbox.Password == password)
                {
                    this.Frame.Navigate(typeof(Content));
                }
                else
                {
                    resultblock.Text = "Sisselogimine ebaõnnestus";
                    counter++;
                }
            }
            else
            {
                resultblock.Text = "Sisselogimine ebaõnnestus, sisselogimine blokeeritud!";
                button1.IsEnabled = false;
            }

        }
    }
}
