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
            creaComboBox();
        }
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            creaComboBox();
        }
        private void rellenaComboBox(ComboBox comboBox)
        {
            List<Tratamiento> tratamientos = vm.getTratamientos();
            foreach (Tratamiento trat in tratamientos)
            {
                comboBox.Items.Add(trat.nombre);
            }
            
        }
        private void creaComboBox()
        {
            ComboBox combo = new ComboBox();
            combo.Width = 120;
            combo.Height = 30;
            combo.FontSize = 15;
            combo.VerticalAlignment =VerticalAlignment.Center;
            combo.Margin = new Thickness(10, 10, 10, 10);
            combo.HorizontalAlignment = HorizontalAlignment.Center;
            rellenaComboBox(combo);
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
            Medicamento medicamento;
            string id = idTextBox.Text;
            int intervalo = int.Parse(intervaloTextBox.Text);
            int cantidad = int.Parse(cantidadTextBox.Text);
            string nombre = nombreTextBox.Text;
            List<Tratamiento> listaTratamientos = obtenerTratamientos();
            medicamento = new Medicamento(cantidad,id,intervalo,nombre);
            medicamento.tratamientos = listaTratamientos;

            return medicamento;
        }

        private List<Tratamiento> obtenerTratamientos()
        {
            StackPanel stack = tratamientosStackPanel;
            List<Tratamiento> tratamientos = null;

            foreach(var child in tratamientosStackPanel.Children)
            {
                if(child is ComboBox comboBox)
                {
                    if(comboBox.SelectedItem is ComboBoxItem selectedItem)
                    {
                        string nombreTratamiento = selectedItem.ToString();
                        Tratamiento trat = vm.getTratamiento(nombreTratamiento);
                        tratamientos.Add(trat);
                    }
                }
            }

            return tratamientos;
        }
    }
}
