﻿#pragma checksum "..\..\..\Pages\RQ_list3.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B0C457B8A86531D1CB3BF8E9DAD5F876"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
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


namespace NewDesignTool.Pages {
    
    
    /// <summary>
    /// RQ_list3
    /// </summary>
    public partial class RQ_list3 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Pages\RQ_list3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas_RQ3;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Pages\RQ_list3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox compareSolutions;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Pages\RQ_list3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox tasks;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Pages\RQ_list3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox measures;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\RQ_list3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Addtext;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\RQ_list3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mainSolution;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\RQ_list3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox context;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\RQ_list3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkbox1;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\RQ_list3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkbox2;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\RQ_list3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkbox3;
        
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
            System.Uri resourceLocater = new System.Uri("/NewDesignTool;component/pages/rq_list3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\RQ_list3.xaml"
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
            this.canvas_RQ3 = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.compareSolutions = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.tasks = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.measures = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            
            #line 18 "..\..\..\Pages\RQ_list3.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Item_Del);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Addtext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 20 "..\..\..\Pages\RQ_list3.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Item_Add);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mainSolution = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.context = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.checkbox1 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 25 "..\..\..\Pages\RQ_list3.xaml"
            this.checkbox1.Checked += new System.Windows.RoutedEventHandler(this.checkbox1_checked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.checkbox2 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 26 "..\..\..\Pages\RQ_list3.xaml"
            this.checkbox2.Checked += new System.Windows.RoutedEventHandler(this.checkbox2_checked);
            
            #line default
            #line hidden
            return;
            case 12:
            this.checkbox3 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 27 "..\..\..\Pages\RQ_list3.xaml"
            this.checkbox3.Checked += new System.Windows.RoutedEventHandler(this.checkbox3_checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

