﻿#pragma checksum "..\..\winsettings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "77055E27C7A3364CE50962FEFF95C56100A9E6088DE10140C8CC0944B002BFAA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using mstall;


namespace mstall {
    
    
    /// <summary>
    /// winsettings
    /// </summary>
    public partial class winsettings : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\winsettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox winsettings_listbox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\winsettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_explorersettings;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\winsettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_hidefileext;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\winsettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_hidden;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\winsettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_sharingwizardon;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\winsettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_navpanel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/mstall;component/winsettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\winsettings.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.winsettings_listbox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            
            #line 30 "..\..\winsettings.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ListBoxItem_explorersettings_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.img_explorersettings = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            
            #line 38 "..\..\winsettings.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ListBoxItem_HideFileExt_MouseUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.img_hidefileext = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            
            #line 48 "..\..\winsettings.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ListBoxItem_Hidden_MouseUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.img_hidden = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            
            #line 58 "..\..\winsettings.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ListBoxItem_SharingWizardOn_MouseUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.img_sharingwizardon = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            
            #line 68 "..\..\winsettings.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ListBoxItem_NavPanelExpandToCurrentFolder_MouseUp);
            
            #line default
            #line hidden
            return;
            case 11:
            this.img_navpanel = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

