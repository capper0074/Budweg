﻿#pragma checksum "..\..\..\..\View\DeleteOrder.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E49A3B0063BA79565A3D4638AE6FA0BD23E8120D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Budweg2._1.View;
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


namespace Budweg2._1.View {
    
    
    /// <summary>
    /// DeleteOrder
    /// </summary>
    public partial class DeleteOrder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\View\DeleteOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LB_ShowOrders;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\View\DeleteOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_DeleteOrder;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\View\DeleteOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_OrderID;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\View\DeleteOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Close_Button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Budweg2._1;V1.0.0.0;component/view/deleteorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\DeleteOrder.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LB_ShowOrders = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.BT_DeleteOrder = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\View\DeleteOrder.xaml"
            this.BT_DeleteOrder.Click += new System.Windows.RoutedEventHandler(this.BT_DeleteOrder_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TB_OrderID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Close_Button = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\View\DeleteOrder.xaml"
            this.Close_Button.Click += new System.Windows.RoutedEventHandler(this.Close_Window_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

