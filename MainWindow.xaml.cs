using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using System.Deployment.Application;
using System.Net;

namespace mstall
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string ver;
        string newestver;

        public MainWindow()
        {
            InitializeComponent();
            frame.Navigate(new System.Uri("winsettings.xaml", UriKind.RelativeOrAbsolute));

            versionnumber();

        }

        private void btn_winsettings_Click(object sender, RoutedEventArgs e)
        {
            rect_btn_windowssettings.Visibility = Visibility.Visible;
            rect_btn_install.Visibility = Visibility.Hidden;
            rect_btn_settings.Visibility = Visibility.Hidden;

            btn_winsettings.FontWeight = FontWeights.Bold;
            btn_install.FontWeight = FontWeights.Normal;
            btn_settings.FontWeight = FontWeights.Normal;

            frame.Navigate(new System.Uri("winsettings.xaml",UriKind.RelativeOrAbsolute));

        }

        private void btn_install_Click(object sender, RoutedEventArgs e)
        {
            rect_btn_windowssettings.Visibility = Visibility.Hidden;
            rect_btn_install.Visibility = Visibility.Visible;
            rect_btn_settings.Visibility = Visibility.Hidden;

            btn_winsettings.FontWeight = FontWeights.Normal;
            btn_install.FontWeight = FontWeights.Bold;
            btn_settings.FontWeight = FontWeights.Normal;

            frame.Navigate(new System.Uri("install.xaml", UriKind.RelativeOrAbsolute));

        }

        private void btn_settings_Click(object sender, RoutedEventArgs e)
        {
            rect_btn_windowssettings.Visibility = Visibility.Hidden;
            rect_btn_install.Visibility = Visibility.Hidden;
            rect_btn_settings.Visibility = Visibility.Visible;

            btn_winsettings.FontWeight = FontWeights.Normal;
            btn_install.FontWeight = FontWeights.Normal;
            btn_settings.FontWeight = FontWeights.Bold;

            frame.Navigate(new System.Uri("settings.xaml", UriKind.RelativeOrAbsolute));

        }


        public void versionnumber()
        {

            try
            {
                var version = ApplicationDeployment.CurrentDeployment.CurrentVersion;
                ver = Convert.ToString(version).Substring(0, Convert.ToString(version).Length - 4);
            }
            catch (Exception)
            {
                var version = Assembly.GetExecutingAssembly().GetName().Version;
                ver = Convert.ToString(version).Substring(0, Convert.ToString(version).Length - 4);
            }

            WebClient webClient = new WebClient();

            try
            {
                newestver = webClient.DownloadString("https://pastebin.com/raw/sQftF95n");
            }
            catch (System.Net.WebException)
            {
                newestver = "0";
            }

             /*   if (ver == newestver)
            {
                lbl_test.Content = "Die neuste Version ist bereits installiert";
            }
            else if (newestver == "0")
            {
                lbl_test.Content = "Version konnnte nicht abgefragt werden";
            }
            else
            {
                lbl_test.Content = "Es ist eine neue Version verfgbar";
            } */

            this.Title = "mstall" + " " + "v." + ver;
        } 


    }
}
