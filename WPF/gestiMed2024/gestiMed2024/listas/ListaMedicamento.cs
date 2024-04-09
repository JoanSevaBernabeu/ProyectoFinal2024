using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using gestiMed2024.clases;

namespace gestiMed2024.listas
{
    class ListaMedicamento
    {
        ObservableCollection<Medicamento> medicamentos;
        public ListaMedicamento() { }

        public ListaMedicamento(ObservableCollection<Medicamento> medicamentos)
        {
            this.medicamentos = medicamentos;
        }
        public void setListaMedicamentos(ObservableCollection<Medicamento> medicamentos)
        {
            this.medicamentos = medicamentos;
        }
        public ObservableCollection<Medicamento> getMedicamentos()
        {
            return medicamentos;
        }
    }
}
