﻿#pragma checksum "..\..\..\..\Listes\ListeCotisations.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DE26B9493C36D5C2AF964E171BC14BA599CAA033"
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
    /// ListeCotisations
    /// </summary>
    public partial class ListeCotisations : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\Listes\ListeCotisations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgListeCotisations;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Listes\ListeCotisations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAjouterCotisations;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Listes\ListeCotisations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSupprimerCotisations;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Listes\ListeCotisations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModifierCotisations;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Listes\ListeCotisations.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRetour;
        
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
            System.Uri resourceLocater = new System.Uri("/EASL;V1.0.0.0;component/listes/listecotisations.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Listes\ListeCotisations.xaml"
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
            this.DgListeCotisations = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.btnAjouterCotisations = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\Listes\ListeCotisations.xaml"
            this.btnAjouterCotisations.Click += new System.Windows.RoutedEventHandler(this.btnActions_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSupprimerCotisations = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\Listes\ListeCotisations.xaml"
            this.btnSupprimerCotisations.Click += new System.Windows.RoutedEventHandler(this.btnActions_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnModifierCotisations = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\Listes\ListeCotisations.xaml"
            this.btnModifierCotisations.Click += new System.Windows.RoutedEventHandler(this.btnActions_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnRetour = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\Listes\ListeCotisations.xaml"
            this.btnRetour.Click += new System.Windows.RoutedEventHandler(this.Retour);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

