using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace gestiMed2024.clases
{
    class Tratamiento : ObservableObject
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }
        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { SetProperty(ref descripcion, value); }
        }
        private string solucion;
        public string Solucion
        {
            get { return solucion; }
            set { SetProperty(ref solucion, value); }
        }
        private Medicamento medicamento;
        public Medicamento Medicamento
        {
            get { return medicamento; }
            set { SetProperty(ref medicamento, value); }
        }

        // Constructores
        public Tratamiento() { }
        public Tratamiento(string descripcion, Medicamento medicamento, string nombre, string solucion)
        {
            this.descripcion = descripcion;
            this.medicamento = medicamento;
            this.nombre = nombre;
            this.solucion = solucion;
        }
        public Tratamiento(string descripcion, string nombre, string solucion)
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
            this.solucion = solucion;
        }
        public void addMedicamento(Medicamento medicamento)
        {
            if (medicamento == null) this.medicamento = medicamento;
        }
    }
}
