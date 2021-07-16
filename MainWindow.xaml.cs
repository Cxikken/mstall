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
using System.IO;

namespace mstall
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string ver;
        string newestver;

        string language = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
        int lang;
        #region language
        string[] winsettings = { "Windows Settings", "Windows Einstellungen" };
        string[] install = { "Install", "Installieren" };
        string[] settings = { "Settings", "Einstellungen" };
        string[] lang_messagever = { "There is a new version available \n Should the new version be downloaded?", "Es ist eine neue Version verfügbar \n Soll die neue Version heruntergeladen werden?" };

        string caption = "Windows Einstellungen ® 2021 by Kilian Schuch";
        #endregion


        public MainWindow()
        {
            InitializeComponent();
            frame.Navigate(new System.Uri("winsettings.xaml", UriKind.RelativeOrAbsolute));

            Language(language);
            versionnumber();

        }

        #region Buttons

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

        #endregion

        #region Version

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


            if (newestver == "0")
            {
                //
            }
            else if (newestver != ver)
            {
                MessageBoxResult result = MessageBox.Show(lang_messagever[lang], caption, MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    string target = "https://github.com/Cxikken/mstall/releases/download/latest/mstall_setup.exe";
                    System.Diagnostics.Process.Start(target);
                }

            }


            this.Title = "mstall" + " " + "v." + ver;
        }

        #endregion

        #region Language

        private new void Language(string language)
        {
            if (language == "de")
            {
                lang = 1;
            } else
            {
                lang = 0;
            }

            btn_winsettings.Content = winsettings[lang];
            btn_install.Content = install[lang];
            btn_settings.Content = settings[lang];
        }

        #endregion

    }
}
