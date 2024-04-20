using gestiMed2024.clases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiMed2024.listas
{
    class ListaMedico
    {
        List<Medico> medicos;

        public ListaMedico() { }
        public ListaMedico(List<Medico> medicos) 
        {
            this.medicos = medicos;
        }

        public void setCollectionMedicos(List<Medico> medicos)
        {
            this.medicos = medicos;
        }
        public List<Medico> getCollectionMedicos()
        {
            return medicos;
        }
    }
}
