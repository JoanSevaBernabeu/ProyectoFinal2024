using gestiMed_Medico.clases;
using gestiMed_Medico.servicios;
using gestiMed_Medico.vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestiMed_Medico.viewmodels
{
    class VistaPacientesVM : INotifyPropertyChanged
    {
        private List<Paciente> pacientes;
        private VistaPacientes ventana;
        PacienteService servicio;

        private Paciente pacienteSelect;
        public Paciente PacienteSelect
        {
            get { return pacienteSelect; }
            set
            {
                pacienteSelect = value;
                OnPropertyChanged(nameof(pacienteSelect));
            }
        }
        public List<Paciente> Pacientes
        {
            get { return pacientes; }
            set
            {
                pacientes = value;
                OnPropertyChanged(nameof(pacientes));
            }
        }

        

        public VistaPacientesVM()
        {
            pacientes = new List<Paciente>();
            servicio = new PacienteService();
            obtenerPacientes();
        }

        public void obtenerPacientes()
        {
            pacientes = servicio.getAllPacientes();
        }

        public void setVentana(VistaPacientes ventana)
        {
            this.ventana = ventana;
        }

        public void salir()
        {
            string mensaje = "¿Seguro que desea salir?";
            string caption = "Cancelar";

            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(mensaje, caption, botones);
            if (result == DialogResult.Yes)
            {
                cierraVentana();
            }
        }
        public void cierraVentana()
        {
            ventana.Close();
        }

        public List<Paciente> getPacientes() { return pacientes;}

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
