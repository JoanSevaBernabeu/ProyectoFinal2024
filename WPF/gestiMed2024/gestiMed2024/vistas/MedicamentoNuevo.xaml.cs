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
    /// Lógica de interacción para MedicamentoNuevo.xaml
    /// </summary>
    public partial class MedicamentoNuevo : Window
    {
        private MedicamentoNuevoVM vm;
        public MedicamentoNuevo()
        {
            vm = new MedicamentoNuevoVM();
            this.DataContext = vm;
            vm.setVentana(this);
            //rellenaComboBox();
            InitializeComponent();
        }
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            rellenaComboBox();
        }
        private void rellenaComboBox()
        {
            ComboBox combo = new ComboBox();
            combo.Width = 110;
            combo.Height = 30;
            Collection<Tratamiento> tratamientos = vm.getTratamientos();
            foreach (Tratamiento trat in tratamientos)
            {
                combo.Items.Add(trat.getNombre());
            }
            StackPanel stack = tratamientosStackPanel;
            stack.Children.Add(combo);
        }
        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            Medicamento medicamento = obtenerMedicamento();
            if (medicamento == null) vm.error();
            else vm.aceptar(medicamento);
        }
        private void cancelarButton_Click(object sender, RoutedEventArgs e)
        {
            vm.cancelar();
        }
        private Medicamento obtenerMedicamento()
        {
            // id, nombre, intervalo cantidad, tratamientos
            Medicamento medicamento;
            string id = idTextBox.Text;
            int intervalo = int.Parse(intervaloTextBox.Text);
            int cantidad = int.Parse(cantidadTextBox.Text);
            string nombre = nombreTextBox.Text;
            Collection<Tratamiento> tratamientos = obtenerTratamientos();
            medicamento = new Medicamento(id, nombre, cantidad, intervalo);
            medicamento.setTratamientos(tratamientos);

            return medicamento;
        }

        private Collection<Tratamiento> obtenerTratamientos()
        {
            StackPanel stack = tratamientosStackPanel;
            Collection<Tratamiento> tratamientos = null;
            for (int i = 0; i < stack.Children.Count; i++)
            {
                Tratamiento trat = vm.getTratamiento(stack.Children[i].ToString());
                tratamientos.Add(trat);
            }

            return tratamientos;
        }
    }
}
