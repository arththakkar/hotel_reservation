﻿#pragma checksum "..\..\ReservationPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FD48C48E7C6361C654B261100B9B1042B479B4A9BD4502918E2FC6C26A6BC409"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HotelReservation;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace HotelReservation {
    
    
    /// <summary>
    /// ReservationPage
    /// </summary>
    public partial class ReservationPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\ReservationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackPanel1;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ReservationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_room;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ReservationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackPanel2;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\ReservationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_customers;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\ReservationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackPanel3;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\ReservationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_reservation;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\ReservationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackPanel4;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\ReservationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_employees;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\ReservationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_reservations;
        
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
            System.Uri resourceLocater = new System.Uri("/HotelReservation;component/reservationpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ReservationPage.xaml"
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
            this.StackPanel1 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.btn_room = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\ReservationPage.xaml"
            this.btn_room.Click += new System.Windows.RoutedEventHandler(this.btn_room_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.StackPanel2 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.btn_customers = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\ReservationPage.xaml"
            this.btn_customers.Click += new System.Windows.RoutedEventHandler(this.btn_customers_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.StackPanel3 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.btn_reservation = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\ReservationPage.xaml"
            this.btn_reservation.Click += new System.Windows.RoutedEventHandler(this.btn_reservation_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.StackPanel4 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.btn_employees = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\ReservationPage.xaml"
            this.btn_employees.Click += new System.Windows.RoutedEventHandler(this.btn_employees_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dg_reservations = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

