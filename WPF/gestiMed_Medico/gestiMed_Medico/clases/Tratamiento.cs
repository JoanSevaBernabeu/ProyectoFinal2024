using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiMed_Medico.clases
{
    class Tratamiento : ObservableObject
    {
        private string Descripcion;
        public string descripcion
        {
            get { return Descripcion; }
            set { SetProperty(ref Descripcion, value); }
        }
        private Medicamento Medicamento;
        public Medicamento medicamento
        {
            get { return Medicamento; }
            set { SetProperty(ref Medicamento, value); }
        }
        private string Nombre;
        public string nombre
        {
            get { return Nombre; }
            set { SetProperty(ref Nombre, value); }
        }
        private List<Paciente> PacienteList;
        public List<Paciente> pacienteList
        {
            get { return PacienteList; }
            set { SetProperty(ref PacienteList, value); }
        }
        private string Solucion;
        public string solucion
        {
            get { return Solucion; }
            set { SetProperty(ref Solucion, value); }
        }


        // Constructores
        public Tratamiento() { }
        public Tratamiento(string descripcion, Medicamento medicamento, string nombre, string solucion)
        {
            this.Descripcion = descripcion;
            this.Medicamento = medicamento;
            this.Nombre = nombre;
            this.Solucion = solucion;
            this.PacienteList = null;
        }
        public Tratamiento(string descripcion, string nombre, string solucion)
        {
            this.Descripcion = descripcion;
            this.Nombre = nombre;
            this.Solucion = solucion;
            this.PacienteList = null;
        }
        public void addMedicamento(Medicamento medicamento)
        {
            if (medicamento == null) this.medicamento = medicamento;
        }
    }
}
