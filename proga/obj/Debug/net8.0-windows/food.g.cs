﻿#pragma checksum "..\..\..\food.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "697B8F1CD240DA01E41CF83B1C2611060DE07E61"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
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
using proga;


namespace proga {
    
    
    /// <summary>
    /// food
    /// </summary>
    public partial class food : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 58 "..\..\..\food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FoodsPlane;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FoodsFact;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FoodsDifference;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RestaurantPlane;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RestaurantFact;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RestaurantDifference;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OtherPlane;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OtherFact;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OtherDifference;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSubTotalPlane;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSubTotalFact;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSubTotalDifference;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/proga;component/food.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\food.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\food.xaml"
            ((proga.food)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Food_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FoodsPlane = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\food.xaml"
            this.FoodsPlane.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FoodsChangeText);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FoodsFact = ((System.Windows.Controls.TextBox)(target));
            
            #line 59 "..\..\..\food.xaml"
            this.FoodsFact.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FoodsChangeText);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FoodsDifference = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.RestaurantPlane = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\..\food.xaml"
            this.RestaurantPlane.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RestaurantChangeText);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RestaurantFact = ((System.Windows.Controls.TextBox)(target));
            
            #line 62 "..\..\..\food.xaml"
            this.RestaurantFact.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RestaurantChangeText);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RestaurantDifference = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.OtherPlane = ((System.Windows.Controls.TextBox)(target));
            
            #line 64 "..\..\..\food.xaml"
            this.OtherPlane.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OtherChangeText);
            
            #line default
            #line hidden
            return;
            case 9:
            this.OtherFact = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\..\food.xaml"
            this.OtherFact.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OtherChangeText);
            
            #line default
            #line hidden
            return;
            case 10:
            this.OtherDifference = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.TextBoxSubTotalPlane = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.TextBoxSubTotalFact = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.TextBoxSubTotalDifference = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

