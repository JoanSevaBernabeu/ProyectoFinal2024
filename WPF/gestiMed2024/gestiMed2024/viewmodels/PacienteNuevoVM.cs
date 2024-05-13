using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using gestiMed2024.clases;
using gestiMed2024.vistas;
using gestiMed2024.servicios;

namespace gestiMed2024.viewmodels
{
    class PacienteNuevoVM
    {
        private PacienteNuevo ventana;
        PacienteService servicio;
        MedicoService medServicio;
        List<Paciente> pacientes;
        HabitacionService habServicio;
        TratamientoService tratServicio;

        public PacienteNuevoVM()
        {
            servicio = new PacienteService();
            medServicio = new MedicoService();
            pacientes = new List<Paciente>();
            habServicio = new HabitacionService();
            tratServicio = new TratamientoService();
        }

        public void setVentana(PacienteNuevo ventana)
        {
            this.ventana = ventana;
        }
        public void error()
        {
            string mensaje = "Este paciente ya existe";
            string caption = "Error";

            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensaje, caption, botones);
        }
        public void cancelar()
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
        public void obtenerPacientes()
        {
            pacientes = servicio.getAllPacientes();
        }
        public void postPaciente(Paciente paciente)
        {
            string mensaje = "Ejecucion completada!";
            string caption = "Aceptado";

            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensaje, caption, botones);

            servicio.postPaciente(paciente);
        }
        public void aceptar(Paciente paciente)
        {
            obtenerPacientes();
            bool existe = false;
            foreach (Paciente pac in pacientes)
            {
                if (pac.Sip == paciente.Sip) existe = true;
            }
            if (existe) error();
            else postPaciente(paciente);
        }
        public List<Medico> getMedicos()
        {
            List<Medico> listaMedicos = new List<Medico>();
            listaMedicos = medServicio.GetAllMedicos();
            return listaMedicos;
        }
        public Medico getMedico(string dni)
        {
            Medico medico = medServicio.getMedico(dni);
            return medico;
        }
        public Habitacion getHabitacion(string num)
        {
            Habitacion habitacion = habServicio.getHabitacion(num);
            return habitacion;
        }
        public Tratamiento getTratamiento(string nombre)
        {
            Tratamiento tratamiento = tratServicio.getTratamiento(nombre);
            return tratamiento;
        }
        public List<Tratamiento> getTratamientos()
        {
            List<Tratamiento> tratamientos = tratServicio.getAllTratamientos();
            return tratamientos;
        }
        public void cierraVentana()
        {
            ventana.Close();
        }
    }
}
