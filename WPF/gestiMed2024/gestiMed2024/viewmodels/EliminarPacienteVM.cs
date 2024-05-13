using gestiMed2024.clases;
using gestiMed2024.vistas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestiMed2024.servicios;

namespace gestiMed2024.viewmodels
{
    class EliminarPacienteVM
    {
        private EliminarPaciente ventana;
        PacienteService servicio;
        List<Paciente> pacientes;

        public EliminarPacienteVM()
        {
            servicio = new PacienteService();
            pacientes = new List<Paciente>();
        }

        public void error()
        {
            string mensaje = "Este paciente no existe";
            string caption = "Error";

            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensaje, caption, botones);
        }
        public void cancelar()
        {
            string mensaje = "¿Seguro que desea cancelar?";
            string caption = "Cancelar";

            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(mensaje, caption, botones);
            if (result == DialogResult.Yes)
            {
                ventana.Close();
            }
        }
        public void setVentana(EliminarPaciente ventana)
        {
            this.ventana = ventana;
        }
        public void obtenerPacientes()
        {
            pacientes = servicio.getAllPacientes();
        }
        private void deletePaciente(string sip)
        {
            string mensaje = "Ejecucion completada!";
            string caption = "Aceptado";

            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensaje, caption, botones);

            servicio.deletePaciente(sip);
            ventana.Close();
        }
        public void aceptar(string sip)
        {
            obtenerPacientes();
            bool existe = false;
            foreach (Paciente paciente in pacientes)
            {
                if (paciente.Sip == sip) existe = true;
            }
            if (existe) deletePaciente(sip);
            else error();
        }
    }
}
