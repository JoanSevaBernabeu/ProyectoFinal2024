using gestiMed2024.listas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiMed2024.clases
{
    class Medicamento
    {
        private string id;
        private string nombre;
        private int cantidad;
        private int intervalo;
        private ListaTratamiento tratamientos;

        // Constructores
        public Medicamento() { }
        public Medicamento(int cantidad, string id, int intervalo, string nombre)
        {
            this.cantidad = cantidad;
            this.id = id;
            this.intervalo = intervalo;
            this.nombre = nombre;
        }
        // Getters
        public string getId() { return id; }
        public string getNombre() { return nombre; }
        public int getCantidad() { return cantidad; }
        public int getIntervalo() { return intervalo; }
        public ListaTratamiento getTratamiento() { return tratamientos; }
        // Setters
        public void setId(string id) { this.id = id; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setCantidad(int cantidad) { this.cantidad = cantidad; }
        public void setIntervalo(int intervalo) { this.intervalo = intervalo; }
        public void setTratamientos(ListaTratamiento tratamientos) { this.tratamientos = tratamientos; }
    }
}
