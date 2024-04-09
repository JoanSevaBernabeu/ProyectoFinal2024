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
        ObservableCollection<Paciente> pacientes;
        public ListaPaciente() { }
        public ListaPaciente(ObservableCollection<Paciente> pacientes)
        {
            this.pacientes = pacientes;
        }
        public void setListaPacientes(ObservableCollection<Paciente> pacientes)
        {
            this.pacientes = pacientes;
        }
        public ObservableCollection<Paciente> getListaPacientes()
        {
            return pacientes;
        }
    }
}
