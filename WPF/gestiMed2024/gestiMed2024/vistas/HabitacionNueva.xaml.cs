using gestiMed2024.clases;
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
using System.Windows.Shapes;

namespace gestiMed2024.vistas
{
    /// <summary>
    /// Lógica de interacción para HabitacionNueva.xaml
    /// </summary>
    public partial class HabitacionNueva : Window
    {
        HabitacionNuevaVM vm;
        public HabitacionNueva()
        {
            vm = new HabitacionNuevaVM();
            this.DataContext = vm;
            vm.setVentana(this);
            InitializeComponent();
        }
        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            Habitacion habitacion = obtenerHabitacion();
            vm.aceptar(habitacion);
        }
        private void cancelarButton_Click(object sender, RoutedEventArgs e)
        {
            vm.cancelar();
        }
        private Habitacion obtenerHabitacion()
        {
            string numeroHabitacion = nHabitacionTextBox.Text;
            int camasTotales = int.Parse(nCamasTextBox.Text);
            int camasOcupadas = int.Parse(ocuCamasTextBox.Text);
            Habitacion habitacion = new Habitacion(numeroHabitacion, camasTotales, camasOcupadas);
            return habitacion;
        }
    }
}
