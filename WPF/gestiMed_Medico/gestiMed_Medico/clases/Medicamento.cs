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
        private string id;
        public string Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }
        private int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
            set { SetProperty(ref cantidad, value); }
        }
        private int intervalo;
        public int Intervalo
        {
            get { return intervalo; }
            set { SetProperty(ref intervalo, value); }
        }
        private List<Tratamiento> tratamientos;
        public List<Tratamiento> Tratamientos
        {
            get { return tratamientos; }
            set { SetProperty(ref tratamientos, value); }
        }
        // Constructores
        public Medicamento() { }
        public Medicamento(int cantidad, string id, int intervalo, string nombre)
        {
            this.cantidad = cantidad;
            this.id = id;
            this.intervalo = intervalo;
            this.nombre = nombre;
        }
    }
}
