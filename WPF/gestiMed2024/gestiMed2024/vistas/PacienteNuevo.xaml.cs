using gestiMed2024.clases;
using gestiMed2024.viewmodels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para PacienteNuevo.xaml
    /// </summary>
    public partial class PacienteNuevo : Window
    {
        private PacienteNuevoVM vm;
        public PacienteNuevo()
        {
            vm = new PacienteNuevoVM();
            this.DataContext = vm;
            vm.setVentana(this);
            InitializeComponent();
            rellenaComboboxMedicos();
            rellenaComboUrgencia();
            rellenaComboTratamiento();
        }
        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            Paciente paciente = obtenerPaciente();
            vm.aceptar(paciente);
            vm.cierraVentana();
        }
        private void rellenaComboUrgencia()
        {
            urgenciaComboBox.Items.Add("Urgente");
            urgenciaComboBox.Items.Add("Medio");
            urgenciaComboBox.Items.Add("Bajo");
        }
        private void rellenaComboTratamiento()
        {
            List<Tratamiento> tratamientos = vm.getTratamientos();
            foreach (Tratamiento trat in tratamientos)
            {
                tratamientoComboBox.Items.Add(trat.Nombre);
            }
        }
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            rellenaComboboxMedicos();
        }
        private void cancelarButton_Click(object sender, RoutedEventArgs e)
        {
            vm.cancelar();
        }
        private void rellenaComboboxMedicos()
        {
            System.Windows.Controls.ComboBox combo = new System.Windows.Controls.ComboBox();
            combo.Width = 110;
            combo.Height = 30;
            combo.Margin = new Thickness(10, 10, 10, 10);
            List<Medico> medicos = vm.getMedicos();
            foreach (Medico med in medicos)
            {
                combo.Items.Add(med.Nombre);
            }
            medicosStackPanel.Children.Add(combo);
        }
        private List<Medico> obtenerMedicos()
        {
            StackPanel stack = medicosStackPanel;
            List<Medico> medicos = new List<Medico>();
            for (int i = 0; i < stack.Children.Count; i++)
            {
                Medico med = vm.getMedico(stack.Children[i].ToString());
                medicos.Add(med);
            }
            return medicos;
        }
        private Paciente obtenerPaciente()
        {
            Paciente paciente;
            string nombre = nombreTextBox.Text;
            string sip = SipTextBox.Text;
            string telefono = telefonoTextBox.Text;
            string apellidos = apellidoTextBox.Text;
            string ano = anoTextBox.Text;
            Habitacion habitacion = vm.getHabitacion(numHabitacionTextBox.Text);
            Tratamiento tratamiento = vm.getTratamiento(tratamientoComboBox.SelectedItem.ToString());
            string urgencia = urgenciaComboBox.SelectedItem.ToString();
            List<Medico> listaMedicos = obtenerMedicos();
            paciente = new Paciente(apellidos,ano,nombre,telefono,sip,urgencia);
            paciente.Habitacion=habitacion;
            paciente.Tratamiento=tratamiento;
            paciente.Medicos=listaMedicos;
            return paciente;
        }
    }
}
