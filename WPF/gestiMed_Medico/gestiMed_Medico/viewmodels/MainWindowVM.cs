using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiMed_Medico.vistas
{
    class MainWindowVM
    {
        private MainWindow ventana;

        public void setVentana(MainWindow ventana)
        {
            this.ventana = ventana;
        }

        public void aceptar()
        {
            VistaPacientes vista_pacientes = new VistaPacientes();
            vista_pacientes.Show();
        }
    }
}
