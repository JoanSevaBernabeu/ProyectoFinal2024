using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace gestiMed_Medico.clases
{
    class Medicamento : ObservableObject
    {
        private int Cantidad;
        public int cantidad
        {
            get { return Cantidad; }
            set { SetProperty(ref Cantidad, value); }
        }
        private string Id;
        public string id
        {
            get { return Id; }
            set { SetProperty(ref Id, value); }
        }
        private int Intervalo;
        public int intervalo
        {
            get { return Intervalo; }
            set { SetProperty(ref Intervalo, value); }
        }
        private string Nombre;
        public string nombre
        {
            get { return Nombre; }
            set { SetProperty(ref Nombre, value); }
        }
        private List<Tratamiento> Tratamientos;
        public List<Tratamiento> tratamientos
        {
            get { return Tratamientos; }
            set { SetProperty(ref Tratamientos, value); }
        }
        // Constructores
        public Medicamento() { }
        public Medicamento(int cantidad, string id, int intervalo, string nombre)
        {
            this.Cantidad = cantidad;
            this.Id = id;
            this.Intervalo = intervalo;
            this.Nombre = nombre;
        }
    }
}
