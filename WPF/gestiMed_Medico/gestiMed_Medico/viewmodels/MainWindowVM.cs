using gestiMed_Medico.clases;
using gestiMed_Medico.servicios;
using gestiMed_Medico.vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestiMed_Medico.viewmodels
{
    class MainWindowVM
    {
        List<Medico> medicos;
        private MainWindow ventana;
        MedicoService servicio;

        public MainWindowVM()
        {
            servicio = new MedicoService();
            medicos = new List<Medico>();
            obtenerMedicos();
        }


        public void setVentana(MainWindow ventana)
        {
            this.ventana = ventana;
        }

        public void aceptar(string dni, string pass)
        {
            bool existe = false;
            foreach(Medico medico in medicos)
            {
                if (medico.dni.Equals(dni) && medico.contrasenya.Equals(pass)) existe = true;
            }
            if (existe) vistaPacientes();
            else error();
        }
        public void obtenerMedicos()
        {
            medicos = servicio.GetAllMedicos();
        }
        public void vistaPacientes()
        {
            VistaPacientes vista_pacientes = new VistaPacientes();
            vista_pacientes.Owner = ventana;
            vista_pacientes.Show();
        }
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
    }
}
