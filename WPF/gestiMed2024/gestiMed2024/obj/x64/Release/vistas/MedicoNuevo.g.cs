﻿#pragma checksum "..\..\..\..\vistas\MedicoNuevo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6FDDF0DB96C013A5454A484D0328C23A840B3B5252155FBCD83F43D42A490AAE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using gestiMed2024.vistas;


namespace gestiMed2024.vistas {
    
    
    /// <summary>
    /// MedicoNuevo
    /// </summary>
    public partial class MedicoNuevo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\..\..\vistas\MedicoNuevo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nombreTextBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\vistas\MedicoNuevo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox apellidosTextBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\vistas\MedicoNuevo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numeroTextBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\vistas\MedicoNuevo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dniTextBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\vistas\MedicoNuevo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailTextBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\vistas\MedicoNuevo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox contraTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Gesti Med;component/vistas/mediconuevo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\vistas\MedicoNuevo.xaml"
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
            this.nombreTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.apellidosTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.numeroTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.dniTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.emailTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.contraTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 54 "..\..\..\..\vistas\MedicoNuevo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.aceptarButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 55 "..\..\..\..\vistas\MedicoNuevo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cancelarButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
