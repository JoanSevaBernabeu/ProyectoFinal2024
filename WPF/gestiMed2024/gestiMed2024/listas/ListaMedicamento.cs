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
        List<Medicamento> medicamentos;
        public ListaMedicamento() { }

        public ListaMedicamento(List<Medicamento> medicamentos)
        {
            this.medicamentos = medicamentos;
        }
        public void setListaMedicamentos(List<Medicamento> medicamentos)
        {
            this.medicamentos = medicamentos;
        }
        public List<Medicamento> getMedicamentos()
        {
            return medicamentos;
        }
    }
}
