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
using gestiMed2024.listas;

namespace gestiMed2024.viewmodels
{
    class EliminarMedicoVM
    {
        private EliminarMedico ventana;
        MedicoService servicio;
        Collection<Medico> medicos;

        public void error()
        {
            string mensaje = "Este medico no existe";
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
        public void setVentana(EliminarMedico ventana)
        {
            this.ventana = ventana;
        }
        public void obtenerMedicos()
        {
            servicio = new MedicoService();
            ListaMedico listaMedicos = servicio.GetAllMedicos();
            medicos = listaMedicos.getCollectionMedicos();
        }
        public void aceptar(string dni)
        {
            obtenerMedicos();
            bool existe = false;
            foreach (Medico medico in medicos)
            {
                if (medico.getDni() == dni) existe = true;
            }
            if (existe) deleteMedico(dni);
            else error();
        }
        private void deleteMedico(string dni)
        {
            string mensaje = "Ejecucion completada!";
            string caption = "Aceptado";

            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensaje, caption, botones);

            servicio.deleteMedico(dni);
        }
    }
}
