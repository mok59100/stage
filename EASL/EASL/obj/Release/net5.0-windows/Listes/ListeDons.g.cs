﻿#pragma checksum "..\..\..\..\Listes\ListeDons.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D786FB29B7243FCC8A3EAB4CA5911B2B22619E16"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using EASL.Listes;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace EASL.Listes {
    
    
    /// <summary>
    /// ListeDons
    /// </summary>
    public partial class ListeDons : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\Listes\ListeDons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgListeDons;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Listes\ListeDons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAjouterDons;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Listes\ListeDons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSupprimerDons;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Listes\ListeDons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModifierDons;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Listes\ListeDons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRetourDons;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EASL;component/listes/listedons.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Listes\ListeDons.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DgListeDons = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.btnAjouterDons = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\Listes\ListeDons.xaml"
            this.btnAjouterDons.Click += new System.Windows.RoutedEventHandler(this.btnActions_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSupprimerDons = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\Listes\ListeDons.xaml"
            this.btnSupprimerDons.Click += new System.Windows.RoutedEventHandler(this.btnActions_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnModifierDons = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\Listes\ListeDons.xaml"
            this.btnModifierDons.Click += new System.Windows.RoutedEventHandler(this.btnActions_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnRetourDons = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\Listes\ListeDons.xaml"
            this.btnRetourDons.Click += new System.Windows.RoutedEventHandler(this.Retour);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

