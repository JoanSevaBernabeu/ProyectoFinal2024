using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using gestiMed2024.clases;

namespace gestiMed2024.listas
{
    class ListaPaciente
    {
        List<Paciente> pacientes;
        public ListaPaciente() { }
        public ListaPaciente(List<Paciente> pacientes)
        {
            this.pacientes = pacientes;
        }
        public void setListaPacientes(List<Paciente> pacientes)
        {
            this.pacientes = pacientes;
        }
        public List<Paciente> getListaPacientes()
        {
            return pacientes;
        }
    }
}
