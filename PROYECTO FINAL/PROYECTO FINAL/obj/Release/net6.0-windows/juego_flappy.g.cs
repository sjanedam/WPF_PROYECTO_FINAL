﻿#pragma checksum "..\..\..\juego_flappy.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72B31FB516F80F8D43929DFB1F35862068A8D764"
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
    /// juego_flappy
    /// </summary>
    public partial class juego_flappy : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\juego_flappy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Pantalla;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\juego_flappy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Mew;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\juego_flappy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Suelo;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\juego_flappy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Puntuacion;
        
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
            System.Uri resourceLocater = new System.Uri("/PROYECTO FINAL;component/juego_flappy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\juego_flappy.xaml"
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
            this.Pantalla = ((System.Windows.Controls.Canvas)(target));
            
            #line 33 "..\..\..\juego_flappy.xaml"
            this.Pantalla.KeyDown += new System.Windows.Input.KeyEventHandler(this.KeyIsDown);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\juego_flappy.xaml"
            this.Pantalla.KeyUp += new System.Windows.Input.KeyEventHandler(this.KeyIsuP);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Mew = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.Suelo = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            
            #line 59 "..\..\..\juego_flappy.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Volver_a_menu);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Puntuacion = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
