using gestiMed_Medico.viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace gestiMed_Medico.vistas
{
    /// <summary>
    /// Lógica de interacción para VistaPacientes.xaml
    /// </summary>
    public partial class VistaPacientes : Window
    {
        private VistaPacientesVM vm;
        public VistaPacientes()
        {
            vm = new VistaPacientesVM();
            this.DataContext = vm;
            vm.setVentana(this);
            InitializeComponent();
            // itemsControl.ItemsSource = vm.Pacientes;
        }
    }
}
