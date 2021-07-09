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
    /// Interaktionslogik für winsettings.xaml
    /// </summary>
    public partial class winsettings : Page
    {
        bool explorersettings_status = true;
        bool HideFileExt_status = true;
        bool Hidden_status = true;
        bool SharingWizardOn_status = true;
        bool NavPanelExpandToCurrentFolder_status = true;


        public winsettings()
        {
            InitializeComponent();
        }

        private void ListBoxItem_explorersettings_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (explorersettings_status)
            {
                img_explorersettings.Source = new BitmapImage(new Uri(@"/Assets/icons8-schalter-aus-30.png", UriKind.Relative));
                explorersettings_status = false;

                img_hidefileext.Source = new BitmapImage(new Uri(@"/Assets/icons8-schalter-aus-30.png", UriKind.Relative));
                img_hidden.Source = new BitmapImage(new Uri(@"/Assets/icons8-schalter-aus-30.png", UriKind.Relative));
                img_sharingwizardon.Source = new BitmapImage(new Uri(@"/Assets/icons8-schalter-aus-30.png", UriKind.Relative));
                img_navpanel.Source = new BitmapImage(new Uri(@"/Assets/icons8-schalter-aus-30.png", UriKind.Relative));

                HideFileExt_status = false;
                Hidden_status = false;
                SharingWizardOn_status = false;
                NavPanelExpandToCurrentFolder_status = false;
            }
            else
            {


                img_explorersettings.Source = new BitmapImage(new Uri(@"/Assets/icons8-schalter-an-32.png", UriKind.Relative));
                explorersettings_status = true;

                img_hidefileext.Source = new BitmapImage(new Uri(@"/Assets/icons8-schalter-an-32.png", UriKind.Relative));
                img_hidden.Source = new BitmapImage(new Uri(@"/Assets/icons8-schalter-an-32.png", UriKind.Relative));
                img_sharingwizardon.Source = new BitmapImage(new Uri(@"/Assets/icons8-schalter-an-32.png", UriKind.Relative));
                img_navpanel.Source = new BitmapImage(new Uri(@"/Assets/icons8-schalter-an-32.png", UriKind.Relative));

                HideFileExt_status = true;
                Hidden_status = true;
                SharingWizardOn_status = true;
                NavPanelExpandToCurrentFolder_status = true;


            }

        }

        private void ListBoxItem_HideFileExt_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void ListBoxItem_Hidden_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void ListBoxItem_SharingWizardOn_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void ListBoxItem_NavPanelExpandToCurrentFolder_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }


    }
}
