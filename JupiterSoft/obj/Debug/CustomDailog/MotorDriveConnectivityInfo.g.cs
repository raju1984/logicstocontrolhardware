﻿#pragma checksum "..\..\..\CustomDailog\MotorDriveConnectivityInfo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8AC264DDE3D0BE43B748F1F971617599D23BE4806FFD2383F6F0E78F3C3B909D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using JupiterSoft.CustomDailog;
using ModernWpf;
using ModernWpf.Controls;
using ModernWpf.Controls.Primitives;
using ModernWpf.DesignTime;
using ModernWpf.MahApps;
using ModernWpf.MahApps.Controls;
using ModernWpf.Markup;
using ModernWpf.Media.Animation;
using Ozeki.Media;
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
using WebcamControl;


namespace JupiterSoft.CustomDailog {
    
    
    /// <summary>
    /// MotorDriveConnectivityInfo
    /// </summary>
    public partial class MotorDriveConnectivityInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\CustomDailog\MotorDriveConnectivityInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label HeaderTitle;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\CustomDailog\MotorDriveConnectivityInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Addressbox;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\CustomDailog\MotorDriveConnectivityInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MotorFrequency;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\CustomDailog\MotorDriveConnectivityInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MotorRegister;
        
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
            System.Uri resourceLocater = new System.Uri("/JupiterSoft;component/customdailog/motordriveconnectivityinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CustomDailog\MotorDriveConnectivityInfo.xaml"
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
            this.Addressbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.MotorFrequency = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.MotorRegister = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 132 "..\..\..\CustomDailog\MotorDriveConnectivityInfo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnOk_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 142 "..\..\..\CustomDailog\MotorDriveConnectivityInfo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

