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
                tratamientoComboBox.Items.Add(trat.getNombre());
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
            ListaMedico listaMedicos = vm.getMedicos();
            List<Medico> medicos = listaMedicos.getCollectionMedicos();
            foreach (Medico med in medicos)
            {
                combo.Items.Add(med.getNombre());
            }
            medicosStackPanel.Children.Add(combo);
        }
        private List<Medico> obtenerMedicos()
        {
            StackPanel stack = medicosStackPanel;
            List<Medico> medicos = null;
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
            int dia = int.Parse(diaTextBox.Text);
            int mes = int.Parse(mesTextBox.Text);
            int ano = int.Parse(anoTextBox.Text);
            DateTime nacimiento = new DateTime(ano, mes, dia);
            Habitacion habitacion = vm.getHabitacion(numHabitacionTextBox.Text);
            Tratamiento tratamiento = vm.getTratamiento(tratamientoComboBox.SelectedItem.ToString());
            string urgencia = urgenciaComboBox.SelectedItem.ToString();
            List<Medico> listaMedicos = obtenerMedicos();
            ListaMedico medicos = new ListaMedico(listaMedicos);
            paciente = new Paciente(apellidos,nacimiento,nombre,telefono,sip,urgencia);
            paciente.setHabitacion(habitacion);
            paciente.setTratamiento(tratamiento);
            paciente.setMedicos(medicos);
            return paciente;
        }
    }
}
