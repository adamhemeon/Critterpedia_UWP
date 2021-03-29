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
using Windows.ApplicationModel;
using Windows.UI.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Critterpedia.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AboutPage : Page
    {
        public AboutPage()
        {
            this.InitializeComponent();

            Package package = Package.Current;
            PackageId id = package.Id;
            PackageVersion version = id.Version;
            String appName = package.DisplayName;
            String pub = package.PublisherDisplayName;

            appInfo.Text = string.Format("Name: " + appName +
                "\nPublisher: " + pub +
                "\nVersion: {0}.{1}.{2}.{3}"
                , version.Major, version.Minor, version.Build, version.Revision);

        }

        /// <summary>
        /// Override the on navigated to, built in navigation controls
        /// 
        /// OnNavigatedFrom, OnNavigatedTo, OnNavigatingFrom available.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Determining whether to show the default back button
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;

            // Add our back requested event handler to go back
            SystemNavigationManager.GetForCurrentView().BackRequested += About_BackRequested;
        }

        /// <summary>
        /// Event handler to go back from About Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void About_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
            e.Handled = true;
        }
    }
}
