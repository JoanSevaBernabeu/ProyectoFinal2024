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
    /// Lógica de interacción para EliminarHabitacion.xaml
    /// </summary>
    public partial class EliminarHabitacion : Window
    {
        private EliminarHabitacionVM vm;
        public EliminarHabitacion()
        {
            vm = new EliminarHabitacionVM();
            this.DataContext = vm;
            vm.setVentana(this);
            InitializeComponent();
        }
        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            string numero = numHabitacionTextBox.Text;
            vm.aceptar(numero);
        }
        private void cancelarButton_Click(object sender, RoutedEventArgs e)
        {
            vm.cancelar();
        }
    }
}
