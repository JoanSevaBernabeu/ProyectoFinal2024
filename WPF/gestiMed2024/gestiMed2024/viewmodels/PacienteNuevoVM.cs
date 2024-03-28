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
        Collection<Paciente> pacientes;

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
                ventana.Close();
            }
        }
        public void obtenerPacientes()
        {
            servicio = new PacienteService();
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
                if (pac.getSip() == paciente.getSip()) existe = true;
            }
            if (existe) error();
            else postPaciente(paciente);
        }
        public Collection<Medico> getMedicos()
        {
            MedicoService medServicio = new MedicoService();
            ObservableCollection<Medico> medicos = medServicio.GetAllMedicos();
            return medicos;
        }
        public Medico getMedico(string dni)
        {
            MedicoService medServicio = new MedicoService();
            Collection<Medico> medico = medServicio.getMedico(dni);
            if (medico.Count != 1) return null;
            else return medico[0];
        }
        public Habitacion getHabitacion(string num)
        {
            HabitacionService habServicio = new HabitacionService();
            ObservableCollection<Habitacion> habitaciones = habServicio.getHabitacion(num);
            if (habitaciones.Count() != 1) return null;
            else return habitaciones[0];
        }
        public Tratamiento getTratamiento(string nombre)
        {
            TratamientoService tratServicio = new TratamientoService();
            ObservableCollection<Tratamiento> tratamientos = tratServicio.getTratamiento(nombre);
            if (tratamientos.Count() != 1) return null;
            else return tratamientos[0];
        }
        public Collection<Tratamiento> getTratamientos()
        {
            TratamientoService tratServicio = new TratamientoService();
            ObservableCollection<Tratamiento> tratamientos = tratServicio.getAllTratamientos();
            return tratamientos;
        }
    }
}
