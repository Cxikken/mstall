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
using System.Net.NetworkInformation;
using System.IO;
using System.Net;
using System.Reflection;
using System.Deployment.Application;

namespace mstall
{
    /// <summary>
    /// Interaktionslogik für winsettings.xaml
    /// </summary>
    public partial class winsettings : Page
    {

        string language = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;

        #region words
        string[] lang_expsettings = { "Explorer Settings", "Explorer Einstellungen" };
        string[] lang_hidefileext = { "Show extensions for known file types", "Erweiterungen bei bekannten Dateitypen einblenden" };
        //string[] lang_hidden = { "", "   Ausgeblendete Dateien, Ordner und Laufwerke anzeigen" };
        //string[] lang_sharingwizard = { "", "   Freigabeassistent deaktivieren" };
        //string[] lang_navpanelexpandtocurrentfolder = { "", "   Erweitern, um Ordner zu öffnen aktivieren" };
        string[] lang_ad = { "Remove advertising in Start menu", "   Werbung im Startmenü entfernen" }; 
        //string[] lang_effects = { "", "   Visuelle Effekte minimieren (empfohlen für langsame Geräte)" };
        //string[] lang_winminimize = { "", "   Entfernen von Effekt beim Minimieren von Fenstern" };
        //string[] lang_listviewshadow = { "", "   Entfernen vom Schatten hinter Text von Desktopicons" };
        //string[] lang_dragfullwindows = { "", "   Entfernen des Effektes beim Verändern der Größe der Fenster" };
        string[] lang_btn_change = { "Change", "Ändern" };
        #endregion

        //Liste
        bool explorersettings_status = true;
        bool HideFileExt_status = true;
        bool Hidden_status = true;
        bool SharingWizardOn_status = true;
        bool NavPanelExpandToCurrentFolder_status = true;

        bool ad_status = true;

        bool effects_status = false;
        bool winminimize_status = false;
        bool listviewshadow_status = false;
        bool dragfullwindows_status = false;

        //Fehler
        bool error_explorrersettings = false;
        bool error_ad = false;
        bool error_effects = false;


        public winsettings()
        {
            InitializeComponent();
            Language(language);
        }


        //Liste mit Einstellungen
        #region Explorereinstellungen Liste


        private void ListBoxItem_explorersettings_MouseUp(object sender, MouseButtonEventArgs e)
        {
            
            if (explorersettings_status)
            {
                img_explorersettings.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                explorersettings_status = false;

                img_hidefileext.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                img_hidden.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                img_sharingwizardon.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                img_navpanel.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));

                HideFileExt_status = false;
                Hidden_status = false;
                SharingWizardOn_status = false;
                NavPanelExpandToCurrentFolder_status = false;
            }
            else
            {
                img_explorersettings.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                explorersettings_status = true;

                img_hidefileext.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                img_hidden.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                img_sharingwizardon.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                img_navpanel.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));

                HideFileExt_status = true;
                HideFileExt_status = true;
                Hidden_status = true;
                SharingWizardOn_status = true;
                NavPanelExpandToCurrentFolder_status = true;
            }

        }

        private void ListBoxItem_HideFileExt_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (HideFileExt_status)
            {
                img_explorersettings.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                explorersettings_status = false;

                img_hidefileext.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                HideFileExt_status = false;

            } 
            else
            {
                img_hidefileext.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                HideFileExt_status = true;
                abteil_explorer();
            }
        }

        private void ListBoxItem_Hidden_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (Hidden_status)
            {
                img_explorersettings.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                explorersettings_status = false;

                img_hidden.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                Hidden_status = false;

            }
            else
            {
                img_hidden.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                Hidden_status = true;
                abteil_explorer();
            }
        }

        private void ListBoxItem_SharingWizardOn_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (SharingWizardOn_status)
            {
                img_explorersettings.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                explorersettings_status = false;

                img_sharingwizardon.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                SharingWizardOn_status = false;
            }
            else
            {
                img_sharingwizardon.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                SharingWizardOn_status = true;
                abteil_explorer();
            }
        }

        private void ListBoxItem_NavPanelExpandToCurrentFolder_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (NavPanelExpandToCurrentFolder_status)
            {
                img_explorersettings.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                explorersettings_status = false;

                img_navpanel.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                NavPanelExpandToCurrentFolder_status = false;

            }
            else
            {
                img_navpanel.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                NavPanelExpandToCurrentFolder_status = true;
                abteil_explorer();
            }
        }

        private void abteil_explorer()
        {
            if(HideFileExt_status && Hidden_status && SharingWizardOn_status && NavPanelExpandToCurrentFolder_status)
            {
                img_explorersettings.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                explorersettings_status = true;
            }
        }

        #endregion

        #region AD Liste

        private void ListBoxItem_ad_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (ad_status)
            {
                img_ad.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                ad_status = false;
            }
            else
            {
                img_ad.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                ad_status = true;
            }
        }

        #endregion

        #region Effekte Liste

        private void ListBoxItem_effects_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (effects_status)
            {
                img_effects.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                effects_status = false;


                img_winminimize.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                winminimize_status = false;
                img_listviewshadow.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                listviewshadow_status = false;
                img_dragfullwindows.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                dragfullwindows_status = false;

            }
            else
            {
                img_effects.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                effects_status = true;

                img_winminimize.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                winminimize_status = true;
                img_listviewshadow.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                listviewshadow_status = true;
                img_dragfullwindows.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                dragfullwindows_status = true;
            }
        }

        private void ListBoxItem_winminimize_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (winminimize_status)
            {
                img_effects.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                effects_status = false;

                img_winminimize.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                winminimize_status = false;
            }
            else
            {
                img_winminimize.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                winminimize_status = true;
                abteil_effects();
            }
        }

        private void ListBoxItem_listviewshadow_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (listviewshadow_status)
            {
                img_effects.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                effects_status = false;

                img_listviewshadow.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                listviewshadow_status = false;
            }
            else
            {
                img_listviewshadow.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                listviewshadow_status = true;
                abteil_effects();
            }
        }

        private void ListBoxItem_dragfullwindows_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (dragfullwindows_status)
            {
                img_effects.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                effects_status = false;

                img_dragfullwindows.Source = new BitmapImage(new Uri(@"/Assets/switch_off.png", UriKind.Relative));
                dragfullwindows_status = false;
            }
            else
            {
                img_dragfullwindows.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                dragfullwindows_status = true;
                abteil_effects();
            }
        }

        private void abteil_effects()
        {
            if (winminimize_status && listviewshadow_status && dragfullwindows_status)
            {
                img_effects.Source = new BitmapImage(new Uri(@"/Assets/switch_on.png", UriKind.Relative));
                effects_status = true;
            }
        }

        #endregion


        //Button wird geklickt
        
        private void btn_change_Click(object sender, RoutedEventArgs e)
        {
            explorereinstellungen(error_explorrersettings);
            ad(error_ad);
            effects(error_effects);
        }

        #region Explorereinstellungen

        private void explorereinstellungen(bool error_explorrersettings)
        {
            if (explorersettings_status == true)
            {
                //
            }
            else
            {
                if (HideFileExt_status == true)
                {
                    //
                }

                if (Hidden_status == true)
                {
                    //
                }

                if (SharingWizardOn_status == true)
                {
                    //
                }

                if (NavPanelExpandToCurrentFolder_status == true)
                {
                    //
                }
            }
        }

        #endregion

        #region AD

        private void ad(bool error_ad)
        {
            //
        }

        #endregion

        #region Effekte

        private void effects(bool error_effects)
        {
            if (effects_status == true)
            {
                //
            }
            else
            {
                if (winminimize_status == true)
                {
                    //
                }

                if (listviewshadow_status == true)
                {
                    //
                }

                if (dragfullwindows_status == true)
                {
                    //
                }
            }
        }

        #endregion

        #region Error

        private void error()
        {
            if(error_explorrersettings)
            {
                //
            }

            if (error_ad)
            {
                //
            }

            if (error_effects)
            {
                //
            }
        }
        #endregion

        #region Language

        private new void Language(string language)
        {
            int lang;

            if (language == "de")
            {
                lang = 1;
            }
            else
            {
                lang = 0;
            }


        }

        #endregion
    }
}