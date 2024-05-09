using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiMed_Medico.clases
{
    class Paciente : ObservableObject
    {
        private string sip;
        public string Sip
        {
            get { return sip; }
            set { SetProperty(ref sip, value); }
        }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }
        private string apellidos;
        public string Apellidos
        {
            get { return apellidos; }
            set { SetProperty(ref apellidos, value); }
        }
        private string numContacto;
        public string NumContacto
        {
            get { return numContacto; }
            set { SetProperty(ref numContacto, value); }
        }
        private string urgencia;
        public string Urgencia
        {
            get { return urgencia; }
            set { SetProperty(ref urgencia, value); }
        }
        private DateTime nacimiento;
        public DateTime Nacimiento
        {
            get { return nacimiento; }
            set { SetProperty(ref nacimiento, value); }
        }
        private List<Medico> medicos;
        public List<Medico> Medicos
        {
            get { return medicos; }
            set { SetProperty(ref medicos, value); }
        }
        private Tratamiento tratamiento;
        public Tratamiento Tratamiento
        {
            get { return tratamiento; }
            set { SetProperty(ref tratamiento, value); }
        }
        private Habitacion habitacion;
        public Habitacion Habitacion
        {
            get { return habitacion; }
            set { SetProperty(ref habitacion, value); }
        }

        public Paciente() { }
        public Paciente(string apellidos, DateTime nacimiento, string nombre, string numContacto, Habitacion habitacion, string sip, Tratamiento tratamiento, string urgencia)
        {
            this.apellidos = apellidos;
            this.nacimiento = nacimiento;
            this.nombre = nombre;
            this.numContacto = numContacto;
            this.habitacion = habitacion;
            this.sip = sip;
            this.tratamiento = tratamiento;
            this.urgencia = urgencia;
        }
        public Paciente(string apellidos, List<Medico> medicos, DateTime nacimiento, string nombre, string numContacto, Habitacion habitacion, string sip, Tratamiento tratamiento, string urgencia)
        {
            this.apellidos = apellidos;
            this.medicos = medicos;
            this.nacimiento = nacimiento;
            this.nombre = nombre;
            this.numContacto = numContacto;
            this.habitacion = habitacion;
            this.sip = sip;
            this.tratamiento = tratamiento;
            this.urgencia = urgencia;
        }
        public Paciente(string apellidos, DateTime nacimiento, string nombre, string numContacto, string sip, string urgencia)
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
