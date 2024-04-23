using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using gestiMed2024.listas;

namespace gestiMed2024.clases
{
    class Habitacion : ObservableObject
    {
        private string numHabitacion;
        public string NumHabitacion
        {
            get { return numHabitacion; }
            set { SetProperty(ref numHabitacion, value); }
        }
        private int camTotales;
        public int CamTotales
        {
            get { return camTotales; }
            set { SetProperty(ref camTotales, value); }
        }
        private int camOcupadas;
        public int CamOcupadas
        {
            get { return camOcupadas; }
            set { SetProperty(ref camOcupadas, value); }
        }
        private ListaPaciente pacientes;
        public ListaPaciente Pacientes
        {
            get { return pacientes; }
            set { SetProperty(ref pacientes, value); }
        }

        // Constructores
        public Habitacion() { }
        public Habitacion(int camOcupadas, int camTotales, string numHabitacion)
        {
            this.numHabitacion = numHabitacion;
            this.camTotales = camTotales;
            this.camOcupadas = camOcupadas;
        }
        public void addPaciente(Paciente paciente)
        {
            if (camTotales >= camOcupadas) pacientes.addPaciente(paciente);
        }
    }
}
