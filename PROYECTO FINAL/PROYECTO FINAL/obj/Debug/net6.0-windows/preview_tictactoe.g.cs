﻿#pragma checksum "..\..\..\preview_tictactoe.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58660CB0FB161214BF6DD78B5AC42AC2D501F68D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using PROYECTO_FINAL;
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


namespace PROYECTO_FINAL {
    
    
    /// <summary>
    /// preview_tictactoe
    /// </summary>
    public partial class preview_tictactoe : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 81 "..\..\..\preview_tictactoe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement myMediaElement;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\preview_tictactoe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Nombre;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\preview_tictactoe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Descripcion;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\preview_tictactoe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Dificultad;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\preview_tictactoe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Tipo;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PROYECTO FINAL;component/preview_tictactoe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\preview_tictactoe.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 74 "..\..\..\preview_tictactoe.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Volver_a_menu);
            
            #line default
            #line hidden
            return;
            case 2:
            this.myMediaElement = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 3:
            this.Nombre = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Descripcion = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Dificultad = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Tipo = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            
            #line 134 "..\..\..\preview_tictactoe.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Jugar_tictactoe);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

