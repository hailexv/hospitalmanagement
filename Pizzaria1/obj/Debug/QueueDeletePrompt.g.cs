﻿#pragma checksum "..\..\QueueDeletePrompt.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4AB82AF5F99B317A957FB14D4377E616A6ADBA3F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace Pizzaria1 {
    
    
    /// <summary>
    /// QueueDeletePrompt
    /// </summary>
    public partial class QueueDeletePrompt : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\QueueDeletePrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gBody;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\QueueDeletePrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txbText;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\QueueDeletePrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnYes;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\QueueDeletePrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNo;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\QueueDeletePrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gBar;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\QueueDeletePrompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
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
            System.Uri resourceLocater = new System.Uri("/Pizzaria1;component/queuedeleteprompt.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\QueueDeletePrompt.xaml"
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
            
            #line 8 "..\..\QueueDeletePrompt.xaml"
            ((Pizzaria1.QueueDeletePrompt)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 8 "..\..\QueueDeletePrompt.xaml"
            ((Pizzaria1.QueueDeletePrompt)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gBody = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.txbText = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btnYes = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\QueueDeletePrompt.xaml"
            this.btnYes.Click += new System.Windows.RoutedEventHandler(this.BtnYes_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnNo = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\QueueDeletePrompt.xaml"
            this.btnNo.Click += new System.Windows.RoutedEventHandler(this.btnReturnValue_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.gBar = ((System.Windows.Controls.Grid)(target));
            
            #line 31 "..\..\QueueDeletePrompt.xaml"
            this.gBar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.gBar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\QueueDeletePrompt.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

