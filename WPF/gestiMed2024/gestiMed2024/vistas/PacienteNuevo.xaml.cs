using gestiMed2024.clases;
using gestiMed2024.listas;
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
            urgenciaComboBox.Items.Add("alta");
            urgenciaComboBox.Items.Add("media");
            urgenciaComboBox.Items.Add("baja");
        }
        private void rellenaComboTratamiento()
        {
            List<Tratamiento> tratamientos = vm.getTratamientos();
            foreach (Tratamiento trat in tratamientos)
            {
                tratamientoComboBox.Items.Add(trat.nombre);
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
                combo.Items.Add(med.nombre);
            }
            medicosStackPanel.Children.Add(combo);
        }
        private List<Medico> obtenerMedicos()
        {
            StackPanel stack = medicosStackPanel;
            List<Medico> medicos = new List<Medico>();

            foreach(var child in medicosStackPanel.Children)
            {
                if(child is ComboBox comboBox)
                {
                    string nombreMedico = comboBox.SelectedItem.ToString();
                    Medico medico = obtenerMedico(nombreMedico);
                    medicos.Add(medico);
                }
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
            ListaMedicos lista = new ListaMedicos(listaMedicos);
            paciente = new Paciente(apellidos,ano,nombre,telefono,sip,urgencia);
            paciente.numHabitacion=habitacion;
            paciente.tratamiento=tratamiento;
            paciente.medicoList=lista;
            return paciente;
        }
        private Medico obtenerMedico(string nombre)
        {
            List<Medico> medicos = vm.getMedicos();
            Medico medico = new Medico();
            foreach(Medico med in medicos)
            {
                if (med.nombre.Equals(nombre))
                    medico = med;
            }
            return medico;
        }
    }
}
