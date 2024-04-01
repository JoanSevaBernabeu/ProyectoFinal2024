using gestiMed2024.viewmodels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gestiMed2024
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM vm;
        public MainWindow()
        {
            vm = new MainWindowVM();
            this.DataContext = vm;
            vm.setVentana(this);
            InitializeComponent();
        }
        private void CommandBindingCancelar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            vm.cancelar();
        }
        private void CommandBindingSalir_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void CommandBindingHabitacionNueva_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            vm.habitacionNueva();
        }
        private void CommandBindingEliminarHabitacion_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            vm.eliminarHabitacion();
        }
        private void CommandBindingTratamientoNuevo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            vm.tratamientoNuevo();
        }
        private void CommandBindingEliminarTratamiento_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            vm.eliminarTratamiento();
        }
        private void CommandBindingMedicamentoNuevo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            vm.medicamentoNuevo();
        }
        private void CommandBindingEliminarMedicamento_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            vm.eliminarMedicamento();
        }
        private void CommandBindingMedicoNuevo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            vm.medicoNuevo();
        }
        private void CommandBindingEliminarMedico_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            vm.eliminarMedico();
        }
        private void CommandBindingPacienteNuevo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            vm.pacienteNuevo();
        }
        private void CommandBindingEliminarPaciente_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            vm.eliminarPaciente();
        }
        private void salirButton_Click(object sender, RoutedEventArgs e)
        {
            vm.cancelar();
        }
    }
}
