using CommunityToolkit.Mvvm.ComponentModel;
using gestiMed_Medico.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiMed_Medico.listas
{
    class ListaMedicos : ObservableObject
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
