﻿#pragma checksum "..\..\..\..\Formulaires\FormulaireDons.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "443C6B1BDC1F5431F323EC6A896E766E6C8E9C9C"
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
    /// FormulaireDons
    /// </summary>
    public partial class FormulaireDons : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\Formulaires\FormulaireDons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labTitreFormulaire;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Formulaires\FormulaireDons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbNom;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Formulaires\FormulaireDons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbPrenom;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Formulaires\FormulaireDons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbLibelleDon;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Formulaires\FormulaireDons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbMontantDon;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Formulaires\FormulaireDons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Annuler;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Formulaires\FormulaireDons.xaml"
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
            System.Uri resourceLocater = new System.Uri("/EASL;V1.0.0.0;component/formulaires/formulairedons.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Formulaires\FormulaireDons.xaml"
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
            this.txbLibelleDon = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txbMontantDon = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btn_Annuler = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\Formulaires\FormulaireDons.xaml"
            this.btn_Annuler.Click += new System.Windows.RoutedEventHandler(this.Retour);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_Valider = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

