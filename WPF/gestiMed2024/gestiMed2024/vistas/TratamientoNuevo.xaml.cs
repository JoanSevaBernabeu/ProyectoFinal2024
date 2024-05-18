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
    /// Lógica de interacción para TratamientoNuevo.xaml
    /// </summary>
    public partial class TratamientoNuevo : Window
    {
        private TratamientoNuevoVM vm;
        public TratamientoNuevo()
        {
            vm = new TratamientoNuevoVM();
            this.DataContext = vm;
            vm.setVentana(this);
            
            InitializeComponent();
            rellenaComboBox();
        }
        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            Tratamiento tratamiento = obtenerTratamiento();
            if (tratamiento == null) vm.error();
            else vm.aceptar(tratamiento);
        }
        private void cancelarButton_Click(object sender, RoutedEventArgs e)
        {
            vm.cancelar();
        }
        private Tratamiento obtenerTratamiento()
        {
            string nombre = nombreTextBox.Text;
            string solucion = solucionTextBox.Text;
            string descripcion = descripcionTextBox.Text;
            string med = medicamentoComboBox.SelectedItem.ToString();
            Medicamento medicamento = vm.getMedicamento(med);
            Tratamiento tratamiento = new Tratamiento(descripcion,nombre,solucion);
            tratamiento.medicamento = medicamento;
            return tratamiento;
        }
        private void rellenaComboBox()
        {
            List<Medicamento> medicamentos = vm.getMedicamentos();
            foreach (Medicamento med in medicamentos)
            {
                medicamentoComboBox.Items.Add(med.nombre);
            }
        }
    }
}
