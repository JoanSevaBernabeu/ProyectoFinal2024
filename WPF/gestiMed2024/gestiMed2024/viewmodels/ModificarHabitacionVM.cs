using gestiMed2024.clases;
using gestiMed2024.servicios;
using gestiMed2024.vistas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestiMed2024.viewmodels
{
    class ModificarHabitacionVM
    {
        private EliminarHabitacion ventana;
        HabitacionService servicio;
        List<Habitacion> habitaciones;

        public ModificarHabitacionVM()
        {
            servicio = new HabitacionService();
            habitaciones = new List<Habitacion>();
        }

        public void error()
        {
            string mensaje = "Esta habitacion no existe";
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
        public void setVentana(EliminarHabitacion ventana)
        {
            this.ventana = ventana;
        }
        public void obtenerHabitaciones()
        {
            habitaciones = servicio.getAllHabitaciones();
        }
        public void deleteHabitacion(string numero)
        {
            string mensaje = "Ejecucion completada!";
            string caption = "Aceptado";

            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensaje, caption, botones);
        }
        public void aceptar(string numero, int numCamas)
        {
            obtenerHabitaciones();
            bool existe = false;
            foreach (Habitacion habitacion in habitaciones)
            {
                if (habitacion.numHabitacion.Equals(numero)) existe = true;
            }
            if (existe){
                servicio.putHabitacion(numero, numCamas);
                deleteHabitacion(numero);
            }
            else error();
        }
        public void cierraVentana()
        {
            ventana.Close();
        }
    }
}
