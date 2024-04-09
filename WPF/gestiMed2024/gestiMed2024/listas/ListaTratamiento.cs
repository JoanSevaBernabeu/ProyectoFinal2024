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
        ObservableCollection<Tratamiento> tratamientos;

        public ListaTratamiento() { }
        public ListaTratamiento(ObservableCollection<Tratamiento> tratamientos)
        {
            this.tratamientos = tratamientos;
        }
        public void setListaTratamiento(ObservableCollection<Tratamiento> tratamientos)
        {
            this.tratamientos = tratamientos;
        }
        public ObservableCollection<Tratamiento> getListaTratamientos()
        {
            return tratamientos;
        }
    }
}
