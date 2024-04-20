using gestiMed2024.listas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiMed2024.clases
{
    class Paciente
    {
        private string sip;
        private string nombre;
        private string apellidos;
        private string numContacto;
        private string urgencia;
        private DateTime nacimiento;
        private ListaMedico medicos;
        private Tratamiento tratamiento;
        private Habitacion habitacion;

        public Paciente() { }
        public Paciente(string apellidos, DateTime nacimiento, string nombre, string numContacto,Habitacion habitacion, string sip,Tratamiento tratamiento,string urgencia) 
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
        public Paciente(string apellidos,ListaMedico medicos, DateTime nacimiento, string nombre, string numContacto, Habitacion habitacion, string sip, Tratamiento tratamiento, string urgencia)
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
        // Getters
        public string getSip() { return sip; }
        public string getNombre() { return nombre; }
        public string getApellidos() { return apellidos; }
        public string getNumContactos() { return numContacto; }
        public string getUrgencia() { return urgencia; }
        public DateTime getNacimiento() { return nacimiento; }
        public ListaMedico getMedicos() { return medicos; }
        public Tratamiento getTratamiento() { return tratamiento; }
        public Habitacion getHabitacion() { return habitacion; }
        //Setters
        public void setSip(string sip) { this.sip = sip; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setApellidos(string apellidos) { this.apellidos = apellidos; }
        public void setNumContacto(string numContacto) { this.numContacto = numContacto; }
        public void setUrgencia(string urgencia) { this.urgencia = urgencia; }
        public void setNacimiento(DateTime nacimiento) { this.nacimiento = nacimiento; }
        public void setMedicos(ListaMedico medicos) { this.medicos = medicos; }
        public void setTratamiento(Tratamiento tratamiento) { this.tratamiento = tratamiento; }
        public void setHabitacion(Habitacion habitacion) { this.habitacion = habitacion; }
    }
}
