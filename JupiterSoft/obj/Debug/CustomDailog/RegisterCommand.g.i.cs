﻿#pragma checksum "..\..\..\CustomDailog\RegisterCommand.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DE6F85873FB2C5E5A15C911C91572BA15E0EF9F899A0F1AB96E49640C7556FD2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using JupiterSoft.CustomDailog;
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


namespace JupiterSoft.CustomDailog {
    
    
    /// <summary>
    /// RegisterCommand
    /// </summary>
    public partial class RegisterCommand : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\CustomDailog\RegisterCommand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label HeaderTitle;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\CustomDailog\RegisterCommand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RegisterNumber;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\CustomDailog\RegisterCommand.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RegisterOutput;
        
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
            System.Uri resourceLocater = new System.Uri("/JupiterSoft;component/customdailog/registercommand.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CustomDailog\RegisterCommand.xaml"
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
            this.HeaderTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.RegisterNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.RegisterOutput = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            
            #line 100 "..\..\..\CustomDailog\RegisterCommand.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnOk_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 110 "..\..\..\CustomDailog\RegisterCommand.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

