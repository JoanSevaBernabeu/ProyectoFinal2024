using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using gestiMed2024.listas;
using System.Text.Json.Serialization;

namespace gestiMed2024.clases
{
    class Paciente : ObservableObject
    {
        private string Apellidos;
        public string apellidos
        {
            get { return Apellidos; }
            set { SetProperty(ref Apellidos, value); }
        }

        private ListaMedicos MedicoList;
        public ListaMedicos medicoList
        {
            get { return MedicoList; }
            set { SetProperty(ref MedicoList, value); }
        }
        private string Nacimiento;
        public string nacimiento
        {
            get { return Nacimiento; }
            set { SetProperty(ref Nacimiento, value); }
        }
        private string NumContacto;
        public string numContacto
        {
            get { return NumContacto; }
            set { SetProperty(ref NumContacto, value); }
        }
        private Habitacion NumHabitacion;
        public Habitacion numHabitacion
        {
            get { return NumHabitacion; }
            set { SetProperty(ref NumHabitacion, value); }
        }
        private string Sip;
        public string sip
        {
            get { return Sip; }
            set { SetProperty(ref Sip, value); }
        }
        private string Nombre;
        public string nombre
        {
            get { return Nombre; }
            set { SetProperty(ref Nombre, value); }
        }
        private Tratamiento Tratamiento;
        public Tratamiento tratamiento
        {
            get { return Tratamiento; }
            set { SetProperty(ref Tratamiento, value); }
        }
        private string Urgencia;
        public string urgencia
        {
            get { return Urgencia; }
            set { SetProperty(ref Urgencia, value); }
        }
        
        public Paciente() { }
        public Paciente(string apellidos, string nacimiento, string nombre, string numContacto,Habitacion habitacion, string sip,Tratamiento tratamiento,string urgencia) 
        {
            this.Apellidos = apellidos;
            this.Nacimiento = nacimiento;
            this.Nombre = nombre;
            this.NumContacto = numContacto;
            this.NumHabitacion = habitacion;
            this.Sip = sip;
            this.Tratamiento = tratamiento;
            this.Urgencia = urgencia;
        }
        public Paciente(string apellidos,ListaMedicos medicos, string nacimiento, string nombre, string numContacto, Habitacion habitacion, string sip, Tratamiento tratamiento, string urgencia)
        {
            this.Apellidos = apellidos;
            this.MedicoList = medicos;
            this.Nacimiento = nacimiento;
            this.Nombre = nombre;
            this.NumContacto = numContacto;
            this.NumHabitacion = habitacion;
            this.Sip = sip;
            this.Tratamiento = tratamiento;
            this.Urgencia = urgencia;
        }
        public Paciente(string apellidos, string nacimiento, string nombre, string numContacto, string sip, string urgencia)
        {
            this.apellidos = apellidos;
            this.nacimiento = nacimiento;
            this.nombre = nombre;
            this.numContacto = numContacto;
            this.sip = sip;
            this.urgencia = urgencia;
        }
    }
}
