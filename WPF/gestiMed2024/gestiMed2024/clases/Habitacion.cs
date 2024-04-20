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
        private int camTotales;
        private int camOcupadas;
        private Collection<Paciente> pacientes;

        // Constructores
        public Habitacion() { }
        public Habitacion(int camOcupadas, int camTotales, string numHabitacion)
        {
            this.numHabitacion = numHabitacion;
            this.camTotales = camTotales;
            this.camOcupadas = camOcupadas;
        }
        // Getters
        public string getNumHabitacion() { return numHabitacion; }
        public int getNumCamasTotales() { return camTotales; }
        public int getNumCamasOcupadas() { return camOcupadas; }
        public Collection<Paciente> getListaPacientes() { return pacientes; }
        // Setters
        public void setNumHabitacion(string numHabitacion) { this.numHabitacion = numHabitacion; }
        public void setNumCamasTotales(int camTotales) { this.camTotales = camTotales; }
        public void setNumCamasOcupadas(int camOcupadas) { this.camOcupadas = camOcupadas; }
        public void setListaPacientes(Collection<Paciente> pacientes) { this.pacientes = pacientes; }
        public void addPaciente(Paciente paciente)
        {
            if (camTotales >= camOcupadas) pacientes.Add(paciente);
        }
    }
}
