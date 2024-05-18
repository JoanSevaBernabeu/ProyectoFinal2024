using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace gestiMed2024.clases
{
    class Habitacion : ObservableObject
    {
        private string NumHabitacion;
        public string numHabitacion
        {
            get { return NumHabitacion; }
            set { SetProperty(ref NumHabitacion, value); }
        }
        private int CamTotales;
        public int camTotales
        {
            get { return CamTotales; }
            set { SetProperty(ref CamTotales, value); }
        }
        private int CamOcupadas;
        public int camOcupadas
        {
            get { return CamOcupadas; }
            set { SetProperty(ref CamOcupadas, value); }
        }
        private List<Paciente> pacientes;
        public List<Paciente> Pacientes
        {
            get { return pacientes; }
            set { SetProperty(ref pacientes, value); }
        }

        // Constructores
        public Habitacion() { }
        public Habitacion(int camOcupadas, int camTotales, string numHabitacion)
        {
            this.NumHabitacion = numHabitacion;
            this.CamTotales = camTotales;
            this.CamOcupadas = camOcupadas;
        }
        public void addPaciente(Paciente paciente)
        {
            if (camTotales >= camOcupadas) pacientes.Add(paciente);
        }
    }
}
