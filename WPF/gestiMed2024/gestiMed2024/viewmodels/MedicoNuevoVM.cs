using gestiMed2024.vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using gestiMed2024.clases;
using gestiMed2024.servicios;

namespace gestiMed2024.viewmodels
{
    class MedicoNuevoVM
    {
        private MedicoNuevo ventana;
        MedicoService servicio;
        List<Medico> medicos;

        public MedicoNuevoVM()
        {
            servicio = new MedicoService();
            medicos = new List<Medico>();
        }
       
        public void obtenerMedicos()
        {
            medicos = servicio.GetAllMedicos();
        }
        public void aceptar(Medico med)
        {
            obtenerMedicos();
            bool existe = false;
            foreach (Medico medico in medicos)
            {
                if (medico.dni == med.dni) existe = true;
            }
            if (existe) error();
            else postMedico(med);
        }
        public void postMedico(Medico medico)
        {
            string mensaje = "Ejecucion completada!";
            string caption = "Aceptado";

            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensaje, caption, botones);

            servicio.postMedico(medico);
        }
        public void error()
        {
            string mensaje = "Este medico ya existe";
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
                cierraVentana();
            }
        }
        public void setVentana(MedicoNuevo ventana)
        {
            this.ventana = ventana;
        }
        public void cierraVentana()
        {
            ventana.Close();
        }
    }
}
