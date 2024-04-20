using gestiMed2024.listas;
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
        private ListaPaciente pacientes;

        //Constructores 
        public Medico() { }
        public Medico(string apellidos,string contrasenya, string dni, string email, string nombre, string numContacto, ListaPaciente pacientes)
        {
            this.apellidos = apellidos;
            this.contrasenya = contrasenya;
            this.dni = dni;
            this.email = email;
            this.nombre = nombre;
            this.numContacto = numContacto;
            this.pacientes = pacientes;
        }
        public Medico(string apellidos, string contrasenya, string dni, string email, string nombre, string numContacto)
        {
            this.apellidos = apellidos;
            this.contrasenya = contrasenya;
            this.dni = dni;
            this.email = email;
            this.nombre = nombre;
            this.numContacto = numContacto;
        }
        //Getters
        public string getDni() { return dni; }
        public string getNombre() { return nombre; }
        public string getApellidos() { return apellidos; }
        public string getEmail() { return email; }
        public string getContrasenya() { return contrasenya; }
        public string getNumContacto() { return numContacto; }
        public ListaPaciente getPacientes() { return pacientes; }
        // Setters
        public void setDni(string dni) { this.dni = dni; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setApellidos(string apellidos) { this.apellidos = apellidos; }
        public void setEmail(string email) { this.email = email; }
        public void setContrasenya(string contrasenya) { this.contrasenya = contrasenya; }
        public void setPacientes(ListaPaciente pacientes) { this.pacientes = pacientes; }
    }
}
