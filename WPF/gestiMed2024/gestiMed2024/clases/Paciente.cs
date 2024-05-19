using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

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
        private List<Medico> Medicos;
        public List<Medico> medicos
        {
            get { return Medicos; }
            set { SetProperty(ref Medicos, value); }
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
        private Habitacion Habitacion;
        public Habitacion habitacion
        {
            get { return Habitacion; }
            set { SetProperty(ref Habitacion, value); }
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
            this.Habitacion = habitacion;
            this.Sip = sip;
            this.Tratamiento = tratamiento;
            this.Urgencia = urgencia;
        }
        public Paciente(string apellidos,List<Medico> medicos, string nacimiento, string nombre, string numContacto, Habitacion habitacion, string sip, Tratamiento tratamiento, string urgencia)
        {
            this.Apellidos = apellidos;
            this.Medicos = medicos;
            this.Nacimiento = nacimiento;
            this.Nombre = nombre;
            this.NumContacto = numContacto;
            this.Habitacion = habitacion;
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
