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
        ObservableCollection<Medico> medicos;

        public ListaMedico() { }
        public ListaMedico(ObservableCollection<Medico> medicos) 
        {
            this.medicos = medicos;
        }

        public void setCollectionMedicos(ObservableCollection<Medico> medicos)
        {
            this.medicos = medicos;
        }
        public ObservableCollection<Medico> getCollectionMedicos()
        {
            return medicos;
        }
    }
}
