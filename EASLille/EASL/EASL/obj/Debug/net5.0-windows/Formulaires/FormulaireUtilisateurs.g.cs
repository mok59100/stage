﻿#pragma checksum "..\..\..\..\Formulaires\FormulaireUtilisateurs.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C4516A05E048D78F0FBC3E30F521355483914854"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using EASL.Formulaires;
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


namespace EASL.Formulaires {
    
    
    /// <summary>
    /// FormulaireUtilisateurs
    /// </summary>
    public partial class FormulaireUtilisateurs : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\Formulaires\FormulaireUtilisateurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labTitreFormulaire;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Formulaires\FormulaireUtilisateurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbNom;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Formulaires\FormulaireUtilisateurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbPrenom;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Formulaires\FormulaireUtilisateurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbAdresseMail;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Formulaires\FormulaireUtilisateurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbMotDePasse;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Formulaires\FormulaireUtilisateurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbIdRole;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Formulaires\FormulaireUtilisateurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Annuler;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Formulaires\FormulaireUtilisateurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Valider;
        
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
            System.Uri resourceLocater = new System.Uri("/EASL;component/formulaires/formulaireutilisateurs.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Formulaires\FormulaireUtilisateurs.xaml"
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
            this.labTitreFormulaire = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.txbNom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txbPrenom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txbAdresseMail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txbMotDePasse = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.cbIdRole = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.btn_Annuler = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\Formulaires\FormulaireUtilisateurs.xaml"
            this.btn_Annuler.Click += new System.Windows.RoutedEventHandler(this.Retour);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_Valider = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

