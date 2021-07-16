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
using Microsoft.Win32;
using System.Windows.Forms;

namespace mstall
{
    /// <summary>
    /// Interaktionslogik für winsettings.xaml
    /// </summary>
    public partial class winsettings : Page
    {

        #region language

        string language = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;

        string[] lang_expsettings = { "Explorer Settings", "Explorer Einstellungen" };
        string[] lang_hidefileext = { "Show extensions for known file types", "Erweiterungen bei bekannten Dateitypen einblenden" };
        string[] lang_hidden = { "   Show hidden files, folders and drives", "   Ausgeblendete Dateien, Ordner und Laufwerke anzeigen" };                                       
        string[] lang_sharingwizard = { "   Disable Sharing Wizard", "   Freigabeassistent deaktivieren" };                                                      
        string[] lang_navpanelexpandtocurrentfolder = { "   Expand to open folder", "   Erweitern, um Ordner zu öffnen aktivieren" };                           
        string[] lang_ad = { "   Remove advertising in Start menu", "   Werbung im Startmenü entfernen" }; 
        string[] lang_effects = { "   Minimize visual effects (recommended for slow devices)", "   Visuelle Effekte minimieren (empfohlen für langsame Geräte)" };                               
        string[] lang_winminimize = { "   Remove effect when minimizing windows", "   Entfernen von Effekt beim Minimieren von Fenstern" };                                     
        string[] lang_listviewshadow = { "   Remove shadow behind text from desktop icons", "   Entfernen vom Schatten hinter Text von Desktopicons" };                                
        string[] lang_dragfullwindows = { "   Removing the effect when resizing the windows", "   Entfernen des Effektes beim Verändern der Größe der Fenster" };                       
        string[] lang_btn_change = { "Change", "Ändern" };
        string[] lang_message = { "The operation was completed successfully", "Der Vorgang wurde erfolgreich abgeschlossen" };                                                                                     
        string[] lang_errormessage = { "The following settings could not be changed:", "Folgende Einstellungen konnten nicht geändert werden:" };                                   


        string caption = "mstall ® 2021 by Kilian Schuch";

        int lang;
        #endregion

        bool settings_error = false;

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
            explorereinstellungen();
            ad();
            effects();
            check();
        }

        #region Explorereinstellungen

        private void explorereinstellungen()
        {
            //Einstellungen setzen
            if (HideFileExt_status)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", 0, Microsoft.Win32.RegistryValueKind.DWord);
            }

            if (Hidden_status == true)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", 1, Microsoft.Win32.RegistryValueKind.DWord);
            }

            if (SharingWizardOn_status == true)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "SharingWizardOn", 0, Microsoft.Win32.RegistryValueKind.DWord);
            }

            if (NavPanelExpandToCurrentFolder_status == true)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "NavPaneExpandToCurrentFolder", 1, Microsoft.Win32.RegistryValueKind.DWord);
            }
        }

        #endregion

        #region AD

        private void ad()
        {
            if (ad_status)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SilentInstalledAppsEnabled", 0, Microsoft.Win32.RegistryValueKind.DWord);
            }
        }


        #endregion

        #region Effekte

        private void effects()
        {

            if (winminimize_status == true)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop\\WindowMetrics", "MinAnimate", 0, Microsoft.Win32.RegistryValueKind.String);
            }

            if (listviewshadow_status == true)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\PExplorer\\Advanced", "ListviewShadow", 0, Microsoft.Win32.RegistryValueKind.DWord);
            }

            if (dragfullwindows_status == true)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop\\DragFullWindows", "DragFullWindows", 0, Microsoft.Win32.RegistryValueKind.String);
            }
            
        }

        #endregion

        #region check

        private void check()
        {

            //Explorer
            if (HideFileExt_status && Convert.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", 1)) != "0")
            {
                lang_errormessage[lang] = lang_errormessage[lang] + "\n • " + lang_hidefileext[lang];
                settings_error = true;
            }

            if (Hidden_status && Convert.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", 0)) != "1")
            {
                lang_errormessage[lang] = lang_errormessage[lang] + "\n • " + lang_hidden[lang];
                settings_error = true;
            }

            if (SharingWizardOn_status && Convert.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "SharingWizardOn", 1)) != "0")
            {
                lang_errormessage[lang] = lang_errormessage[lang] + "\n • " + lang_sharingwizard[lang];
                settings_error = true;
            }

            if (NavPanelExpandToCurrentFolder_status && Convert.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "NavPaneExpandToCurrentFolder", 0)) != "1")
            {
                lang_errormessage[lang] = lang_errormessage[lang] + "\n • " + lang_navpanelexpandtocurrentfolder[lang];
                settings_error = true;
            }

            //Ad
            if (ad_status && Convert.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SilentInstalledAppsEnabled", 1)) != "0")
            {
                lang_errormessage[lang] = lang_errormessage[lang] + "\n • " + lang_ad[lang];
                settings_error = true;
            }

            //Effects
            if (winminimize_status && Convert.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop\\WindowMetrics", "MinAnimate", 1)) != "0")
            {
                lang_errormessage[lang] = lang_errormessage[lang] + "\n • " + lang_winminimize[lang];
                settings_error = true;
            }

            if (listviewshadow_status && Convert.ToString(Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\PExplorer\\Advanced", "ListviewShadow", 1)) != "0")
            {
                lang_errormessage[lang] = lang_errormessage[lang] + "\n • " + lang_listviewshadow[lang];
                settings_error = true;
            }

            if (dragfullwindows_status && Convert.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop\\DragFullWindows", "DragFullWindows", 1)) != "0")
            {
                lang_errormessage[lang] = lang_errormessage[lang] + "\n • " + lang_dragfullwindows[lang];
                settings_error = true;
            }

            if (settings_error)
            {
                System.Windows.Forms.MessageBox.Show(lang_errormessage[lang], caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(lang_message[lang], caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Language

        private new void Language(string language)
        {
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