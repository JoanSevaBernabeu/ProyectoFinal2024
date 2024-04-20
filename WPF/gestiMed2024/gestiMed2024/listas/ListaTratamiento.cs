using gestiMed2024.clases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiMed2024.listas
{
    class ListaTratamiento
    {
        List<Tratamiento> tratamientos;

        public ListaTratamiento() { }
        public ListaTratamiento(List<Tratamiento> tratamientos)
        {
            this.tratamientos = tratamientos;
        }
        public void setListaTratamiento(List<Tratamiento> tratamientos)
        {
            this.tratamientos = tratamientos;
        }
        public List<Tratamiento> getListaTratamientos()
        {
            return tratamientos;
        }
    }
}
