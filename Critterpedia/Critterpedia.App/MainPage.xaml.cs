using Critterpedia.App.ViewModels;
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
using Windows.UI.Core;
using Critterpedia.App.Commands;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Critterpedia.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        /// <summary>
        /// Override the on navigated to built in navigation controls.
        /// 
        /// Disable the default back button.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Disable the default back button
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Disabled;
        }

        /// <summary>
        /// Click event handler for navigating to the About page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void About_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the About Page
            Frame.Navigate(typeof(AboutPage));
        }

        /// <summary>
        /// Click event handler for exiting the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            // Programmatically Exit
            Application.Current.Exit();
        }

        private void FishButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the Fish Page
            Frame.Navigate(typeof(FishPage));
        }

        private void BugsButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the Bugs Page
            Frame.Navigate(typeof(BugsPage));
        }

        private void SeaCreaturesButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the Sea Creatures Page
            Frame.Navigate(typeof(SeaCreaturesPage));
        }
    }
}
