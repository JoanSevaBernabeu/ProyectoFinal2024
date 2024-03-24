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

namespace gestiMed2024.vistas
{
    /// <summary>
    /// Lógica de interacción para EliminarPaciente.xaml
    /// </summary>
    public partial class EliminarPaciente : Window
    {
        private EliminarPacienteVM vm;
        public EliminarPaciente()
        {
            vm = new EliminarPacienteVM();
            this.DataContext = vm;
            vm.setVentana(this);
            InitializeComponent();
        }
        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            string sip = sipTextBox.Text;
            vm.aceptar(sip);
        }
        private void cancelarButton_Click(object sender, RoutedEventArgs e)
        {
            vm.cancelar();
        }
    }
}
