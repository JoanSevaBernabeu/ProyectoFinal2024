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
            abreVentanaHabitacionNueva();
        }
        private void CommandBindingEliminarHabitacion_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            abreVentanaEliminarHabitacion();
        }
        private void CommandBindingTratamientoNuevo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            abreVentanaTratamientoNuevo();
        }
        private void CommandBindingEliminarTratamiento_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            abreVentanaEliminarTratamiento();
        }
        private void CommandBindingMedicamentoNuevo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            abreVentanaMedicamentoNuevo();
        }
        private void CommandBindingEliminarMedicamento_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            abreVentanaEliminarMedicamento();
        }
        private void CommandBindingMedicoNuevo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            abreVentanaMedicoNuevo();
        }
        private void CommandBindingEliminarMedico_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            abreVentanaEliminarMedico();
        }
        private void CommandBindingPacienteNuevo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            abreVentanaPacienteNuevo();
        }
        private void CommandBindingEliminarPaciente_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            abreVentanaEliminarPaciente();
        }
        private void salirButton_Click(object sender, RoutedEventArgs e)
        {
            vm.cancelar();
        }
        private void addPaciente_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaPacienteNuevo();
        }
        private void delPaciente_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaEliminarPaciente();
        }
        private void addMedico_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaMedicoNuevo();
        }
        private void delMedico_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaEliminarMedico();
        }
        private void addHabitacion_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaHabitacionNueva();
        }
        private void modHabitacion_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaEliminarHabitacion();
        }
        private void addMedicamento_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaMedicamentoNuevo();
        }
        private void delMedicamento_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaEliminarMedicamento();
        }
        private void addTratamiento_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaTratamientoNuevo();
        }
        private void delTratamiento_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaEliminarTratamiento();
        }
        private void addPacienteImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaPacienteNuevo();
        }
        private void delPacienteImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaEliminarPaciente();
        }
        private void addMedicoImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaMedicoNuevo();
        }
        private void delMedicoImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaEliminarMedico();
        }
        private void addHabitacionImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaHabitacionNueva();
        }
        private void delHabitacionImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaEliminarHabitacion();
        }
        private void addMedicamentoImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaMedicamentoNuevo();
        }
        private void delMedicamentoImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaEliminarMedicamento();
        }
        private void addTratamientoImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaTratamientoNuevo();
        }
        private void delTratamientoImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            abreVentanaEliminarTratamiento();
        }
        private void abreVentanaEliminarPaciente()
        {
            vm.eliminarPaciente();
        }
        private void abreVentanaEliminarHabitacion()
        {
            vm.eliminarHabitacion();
        }
        private void abreVentanaEliminarMedicamento()
        {
            vm.eliminarMedicamento();
        }
        private void abreVentanaEliminarMedico()
        {
            vm.eliminarMedico();
        }
        private void abreVentanaEliminarTratamiento()
        {
            vm.eliminarTratamiento();
        }
        private void abreVentanaPacienteNuevo()
        {
            vm.pacienteNuevo();
        }
        private void abreVentanaHabitacionNueva()
        {
            vm.habitacionNueva();
        }
        private void abreVentanaMedicamentoNuevo()
        {
            vm.medicamentoNuevo();
        }
        private void abreVentanaMedicoNuevo()
        {
            vm.medicoNuevo();
        }
        private void abreVentanaTratamientoNuevo()
        {
            vm.tratamientoNuevo();
        }
    }
}
