using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiMed2024.clases
{
    class Tratamiento
    {
        private string nombre;
        private string descripcion;
        private string solucion;
        private Medicamento medicamento;

        // Constructores
        public Tratamiento() { }
        public Tratamiento(string nombre, string descripcion, string solucion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.solucion = solucion;
        }
        public void addMedicamento(Medicamento medicamento)
        {
            if (medicamento == null) this.medicamento = medicamento;
        }
        // Getters
        public string getNombre() { return nombre; }
        public string getDescripcion() { return descripcion; }
        public string getSolucion() { return solucion; }
        public Medicamento getMedicamento() { return medicamento; }
        // Setters
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setDescripcion(string descripcion) { this.descripcion = descripcion; }
        public void setSolucion(string solucion) { this.solucion = solucion; }
        public void setMedicamento(Medicamento medicamento) { this.medicamento = medicamento; }
    }
}
