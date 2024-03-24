using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiMed2024.clases
{
    class Medico
    {
        private string dni;
        private string nombre;
        private string apellidos;
        private string email;
        private string contrasenya;
        private string numContacto;
        private Collection<Paciente> pacientes;

        //Constructores 
        public Medico() { }
        public Medico(string dni, string nombre, string apellidos, string email, string contrasenya, string numContacto)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.contrasenya = contrasenya;
            this.numContacto = numContacto;
        }
        //Getters
        public string getDni() { return dni; }
        public string getNombre() { return nombre; }
        public string getApellidos() { return apellidos; }
        public string getEmail() { return email; }
        public string getContrasenya() { return contrasenya; }
        public string getNumContacto() { return numContacto; }
        public Collection<Paciente> getPacientes() { return pacientes; }
        // Setters
        public void setDni(string dni) { this.dni = dni; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setApellidos(string apellidos) { this.apellidos = apellidos; }
        public void setEmail(string email) { this.email = email; }
        public void setContrasenya(string contrasenya) { this.contrasenya = contrasenya; }
        public void setPacientes(Collection<Paciente> pacientes) { this.pacientes = pacientes; }
    }
}
