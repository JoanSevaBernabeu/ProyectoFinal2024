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
        private string Apellidos;
        public string apellidos
        {
            get { return Apellidos; }
            set { SetProperty(ref Apellidos, value); }
        }
        private string Contrasenya;
        public string contrasenya
        {
            get { return Contrasenya; }
            set { SetProperty(ref Contrasenya, value); }
        }
        private string Dni;
        public string dni
        {
            get { return Dni; }
            set { SetProperty(ref Dni, value); }
        }
        private string Email;
        public string email
        {
            get { return Email; }
            set { SetProperty(ref Email, value); }
        }
        private string Nombre;
        public string nombre
        {
            get { return Nombre; }
            set { SetProperty(ref Nombre, value); }
        }
        private string NumContacto;
        public string numContacto
        {
            get { return NumContacto; }
            set { SetProperty(ref NumContacto, value); }
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
            this.Apellidos = apellidos;
            this.Contrasenya = contrasenya;
            this.Dni = dni;
            this.Email = email;
            this.Nombre = nombre;
            this.NumContacto = numContacto;
        }
    }
}
