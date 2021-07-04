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

namespace mstall
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btn_winsettings_Click(object sender, RoutedEventArgs e)
        {
            btn_winsettings.Background = new System.Windows.Media.SolidColorBrush(Color.FromRgb(39, 70, 89));
            btn_install.Background = new System.Windows.Media.SolidColorBrush(Color.FromRgb(19, 31, 38));
            btn_settings.Background = new System.Windows.Media.SolidColorBrush(Color.FromRgb(19, 31, 38));

            rect_btn_windowssettings.Visibility = Visibility.Visible;
            rect_btn_install.Visibility = Visibility.Hidden;
            rect_btn_settings.Visibility = Visibility.Hidden;

            btn_winsettings.FontWeight = FontWeights.Bold;
            btn_install.FontWeight = FontWeights.Normal;
            btn_settings.FontWeight = FontWeights.Normal;

        }

        private void btn_install_Click(object sender, RoutedEventArgs e)
        {
            btn_winsettings.Background = new System.Windows.Media.SolidColorBrush(Color.FromRgb(19, 31, 38));
            btn_install.Background = new System.Windows.Media.SolidColorBrush(Color.FromRgb(39, 70, 89));
            btn_settings.Background = new System.Windows.Media.SolidColorBrush(Color.FromRgb(19, 31, 38));

            rect_btn_windowssettings.Visibility = Visibility.Hidden;
            rect_btn_install.Visibility = Visibility.Visible;
            rect_btn_settings.Visibility = Visibility.Hidden;

            btn_winsettings.FontWeight = FontWeights.Normal;
            btn_install.FontWeight = FontWeights.Bold;
            btn_settings.FontWeight = FontWeights.Normal;
        }

        private void btn_settings_Click(object sender, RoutedEventArgs e)
        {
            btn_winsettings.Background = new System.Windows.Media.SolidColorBrush(Color.FromRgb(19, 31, 38));
            btn_install.Background = new System.Windows.Media.SolidColorBrush(Color.FromRgb(19, 31, 38));
            btn_settings.Background = new System.Windows.Media.SolidColorBrush(Color.FromRgb(39, 70, 89));

            rect_btn_windowssettings.Visibility = Visibility.Hidden;
            rect_btn_install.Visibility = Visibility.Hidden;
            rect_btn_settings.Visibility = Visibility.Visible;

            btn_winsettings.FontWeight = FontWeights.Normal;
            btn_install.FontWeight = FontWeights.Normal;
            btn_settings.FontWeight = FontWeights.Bold;
        }


    }
}
