using gestiMed_Medico.vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiMed_Medico.viewmodels
{
    class VistaPacientesVM
    {
        public List<string> nombres;
        private VistaPacientes ventana;

        public VistaPacientesVM(List<string> nombres)
        {
            this.nombres = nombres;
        }

        public void setVentana(VistaPacientes ventana)
        {
            this.ventana = ventana;
        }
    }
}
