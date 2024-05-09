using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiMed_Medico.clases
{
    class Medico : ObservableObject
    {
        private string dni;
        public string Dni
        {
            get { return dni; }
            set { SetProperty(ref dni, value); }
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
        private string email;
        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); }
        }
        private string contrasenya;
        public string Contrasenya
        {
            get { return contrasenya; }
            set { SetProperty(ref contrasenya, value); }
        }
        private string numContacto;
        public string NumContacto
        {
            get { return numContacto; }
            set { SetProperty(ref numContacto, value); }
        }
        private List<Paciente> pacientes;
        public List<Paciente> Pacientes
        {
            get { return pacientes; }
            set { SetProperty(ref pacientes, value); }
        }

        //Constructores 
        public Medico() { }
        public Medico(string apellidos, string contrasenya, string dni, string email, string nombre, string numContacto, List<Paciente> pacientes)
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
    }
}
