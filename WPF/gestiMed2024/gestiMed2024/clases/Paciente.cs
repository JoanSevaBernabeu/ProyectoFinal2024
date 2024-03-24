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
        private string dolencias;
        private string urgencia;
        private DateTime nacimiento;
        private Collection<Medico> medicos;
        private Tratamiento tratamiento;
        private Habitacion habitacion;

        public Paciente() { }
        public Paciente(string sip, string nombre, string apellidos, string numContacto, DateTime nacimiento, string dolencias, string urgencia)
        {
            this.sip = sip;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.numContacto = numContacto;
            this.nacimiento = nacimiento;
            this.dolencias = dolencias;
            this.urgencia = urgencia;
        }
        // Getters
        public string getSip() { return sip; }
        public string getNombre() { return nombre; }
        public string getApellidos() { return apellidos; }
        public string getNumContactos() { return numContacto; }
        public DateTime getNacimiento() { return nacimiento; }
        public Collection<Medico> getMedicos() { return medicos; }
        public Tratamiento getTratamiento() { return tratamiento; }
        public Habitacion getHabitacion() { return habitacion; }
        //Setters
        public void setSip(string sip) { this.sip = sip; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setApellidos(string apellidos) { this.apellidos = apellidos; }
        public void setNumContacto(string numContacto) { this.numContacto = numContacto; }
        public void setNacimiento(DateTime nacimiento) { this.nacimiento = nacimiento; }
        public void setMedicos(Collection<Medico> medicos) { this.medicos = medicos; }
        public void setTratamiento(Tratamiento tratamiento) { this.tratamiento = tratamiento; }
        public void setHabitacion(Habitacion habitacion) { this.habitacion = habitacion; }
    }
}
