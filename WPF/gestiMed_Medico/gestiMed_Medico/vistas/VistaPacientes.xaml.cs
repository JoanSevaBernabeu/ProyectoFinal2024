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

namespace gestiMed_Medico.vistas
{
    /// <summary>
    /// Lógica de interacción para VistaPacientes.xaml
    /// </summary>
    public partial class VistaPacientes : Window
    {
        List<string> lista = new List<string> {"Joan","Edurne","Joy"};
        public VistaPacientes()
        {
            InitializeComponent();
            vinculacion();
        }
        public void vinculacion()
        {
            listaListBox.ItemsSource = lista;
            
        }
    }
}
