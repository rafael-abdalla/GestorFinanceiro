﻿#pragma checksum "..\..\..\..\..\Views\Autenticacao\ucLogin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "736650E5231B8F02859D4D236F55C6144FAA4CC1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GestorFinanceiro.WPF.Views.Autenticacao;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace GestorFinanceiro.WPF.Views.Autenticacao {
    
    
    /// <summary>
    /// ucLogin
    /// </summary>
    public partial class ucLogin : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 67 "..\..\..\..\..\Views\Autenticacao\ucLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtSenha;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GestorFinanceiro.WPF;V1.0.0.0;component/views/autenticacao/uclogin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Autenticacao\ucLogin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtSenha = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 70 "..\..\..\..\..\Views\Autenticacao\ucLogin.xaml"
            this.txtSenha.PasswordChanged += new System.Windows.RoutedEventHandler(this.PasswordBox_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 82 "..\..\..\..\..\Views\Autenticacao\ucLogin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

