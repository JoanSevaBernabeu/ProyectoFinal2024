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
using gestiMed2024.listas;

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
                ventana.Close();
            }
        }
        public void obtenerPacientes()
        {
            ListaPaciente listaPacientes = servicio.getAllPacientes();
            pacientes = listaPacientes.getListaPacientes();
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
        public ListaMedico getMedicos()
        {
            ListaMedico listaMedicos = new ListaMedico();
            listaMedicos = medServicio.GetAllMedicos();
            return listaMedicos;
        }
        public Medico getMedico(string dni)
        {
            ListaMedico listaMedico = medServicio.getMedico(dni);
            List<Medico> medico = listaMedico.getCollectionMedicos();
            if (medico.Count != 1) return null;
            else return medico[0];
        }
        public Habitacion getHabitacion(string num)
        {
            ListaHabitaciones listaHabitaciones = habServicio.getHabitacion(num);
            List<Habitacion> habitaciones = listaHabitaciones.getHabitaciones();
            if (habitaciones.Count() != 1) return null;
            else return habitaciones[0];
        }
        public Tratamiento getTratamiento(string nombre)
        {
            ListaTratamiento listaTratamientos = tratServicio.getTratamiento(nombre);
            List<Tratamiento> tratamientos = listaTratamientos.getListaTratamientos();
            if (tratamientos.Count() != 1) return null;
            else return tratamientos[0];
        }
        public List<Tratamiento> getTratamientos()
        {
            ListaTratamiento listaTratamiento = tratServicio.getAllTratamientos();
            List<Tratamiento> tratamientos = listaTratamiento.getListaTratamientos();
            return tratamientos;
        }
    }
}
