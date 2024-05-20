using CommunityToolkit.Mvvm.ComponentModel;
using gestiMed2024.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiMed2024.listas
{
    class ListaMedicos: ObservableObject
    {
        public List<Medico> lista;

        public ListaMedicos()
        {
        }

        public ListaMedicos(List<Medico> listaMedicos)
        {
            this.lista = listaMedicos;
        }

        public List<Medico> getListaMedicos()
        {
            return lista;
        }
        public void setListaMedicos(List<Medico> listaMedicos)
        {
            this.lista = listaMedicos;
        }
    }
}
