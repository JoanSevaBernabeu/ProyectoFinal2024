﻿#pragma checksum "..\..\..\..\vistas\MedicamentoNuevo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EB7B919856CF531DD41BDE6BD8F56AE794621A53525C681372D5B77FFEEDBC72"
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
    /// MedicamentoNuevo
    /// </summary>
    public partial class MedicamentoNuevo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 54 "..\..\..\..\vistas\MedicamentoNuevo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idTextBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\vistas\MedicamentoNuevo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cantidadTextBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\vistas\MedicamentoNuevo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox intervaloTextBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\vistas\MedicamentoNuevo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nombreTextBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\vistas\MedicamentoNuevo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel tratamientosStackPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/GestiMed;component/vistas/medicamentonuevo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\vistas\MedicamentoNuevo.xaml"
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
            this.idTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cantidadTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.intervaloTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.nombreTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tratamientosStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            
            #line 60 "..\..\..\..\vistas\MedicamentoNuevo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 61 "..\..\..\..\vistas\MedicamentoNuevo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.aceptarButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 62 "..\..\..\..\vistas\MedicamentoNuevo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cancelarButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

