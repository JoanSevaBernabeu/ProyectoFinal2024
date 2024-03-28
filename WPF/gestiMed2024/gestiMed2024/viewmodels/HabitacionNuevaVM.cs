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
    class HabitacionNuevaVM
    {
        private HabitacionNueva ventana;
        HabitacionService servicio;
        Collection<Habitacion> habitaciones;

        public void obtenerHabitaciones()
        {
            servicio = new HabitacionService();
            habitaciones = servicio.getAllHabitaciones();
        }
        public void error()
        {
            string mensaje = "Esta habitacion ya existe";
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
        public void setVentana(HabitacionNueva ventana)
        {
            this.ventana = ventana;
        }
        public void aceptar(Habitacion habitacion)
        {
            obtenerHabitaciones();
            bool existe = false;
            foreach (Habitacion hab in habitaciones)
            {
                if (hab.getNumHabitacion() == habitacion.getNumHabitacion()) existe = true;
            }
            if (existe) error();
            else postHabitacion(habitacion);
        }
        public void postHabitacion(Habitacion habitacion)
        {
            string mensaje = "Ejecucion completada!";
            string caption = "Aceptado";

            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensaje, caption, botones);

            servicio.postHabitacion(habitacion);
        }
    }
}
