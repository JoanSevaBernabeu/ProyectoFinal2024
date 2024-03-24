using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiMed2024.clases
{
    class Habitacion
    {
        private string numHabitacion;
        private int numCamasTotales;
        private int numCamasOcu;
        private Collection<Paciente> pacientes;

        // Constructores
        public Habitacion() { }
        public Habitacion(string numHabitacion, int numCamasTotales, int numCamasOcu)
        {
            this.numHabitacion = numHabitacion;
            this.numCamasTotales = numCamasTotales;
            this.numCamasOcu = numCamasOcu;
        }
        // Getters
        public string getNumHabitacion() { return numHabitacion; }
        public int getNumCamasTotales() { return numCamasTotales; }
        public int getNumCamasOcupadas() { return numCamasOcu; }
        public Collection<Paciente> getListaPacientes() { return pacientes; }
        // Setters
        public void setNumHabitacion(string numHabitacion) { this.numHabitacion = numHabitacion; }
        public void setNumCamasTotales(int numCamasTotales) { this.numCamasTotales = numCamasTotales; }
        public void setNumCamasOcupadas(int numCamasOcupadas) { numCamasOcupadas = numCamasOcu; }
        public void setListaPacientes(Collection<Paciente> pacientes) { this.pacientes = pacientes; }

        public void addPaciente(Paciente paciente)
        {
            if (numCamasTotales >= numCamasOcu) pacientes.Add(paciente);
        }
    }
}
