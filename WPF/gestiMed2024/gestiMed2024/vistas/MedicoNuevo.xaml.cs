using gestiMed2024.clases;
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
    /// Lógica de interacción para MedicoNuevo.xaml
    /// </summary>
    public partial class MedicoNuevo : Window
    {
        private MedicoNuevoVM vm;
        public MedicoNuevo()
        {
            vm = new MedicoNuevoVM();
            this.DataContext = vm;
            vm.setVentana(this);
            InitializeComponent();
        }
        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            Medico med = obtenerMedico();
            vm.aceptar(med);
        }
        private void cancelarButton_Click(object sender, RoutedEventArgs e)
        {
            vm.cancelar();
        }
        private Medico obtenerMedico()
        {
            string nombre = nombreTextBox.Text;
            string apellidos = apellidosTextBox.Text;
            string numero = numeroTextBox.Text;
            string dni = dniTextBox.Text;
            string mail = emailTextBox.Text;
            string contra = contraTextBox.Text;
            Medico med = new Medico(dni, nombre, apellidos, mail, contra, numero);
            return med;
        }
    }
}
