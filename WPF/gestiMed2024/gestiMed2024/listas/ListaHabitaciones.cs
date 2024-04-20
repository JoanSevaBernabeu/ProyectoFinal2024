using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using gestiMed2024.clases;

namespace gestiMed2024.listas
{
    class ListaHabitaciones
    {
        List<Habitacion> habitaciones;
        public ListaHabitaciones() { }
        public ListaHabitaciones(List<Habitacion> habitaciones)
        {
            this.habitaciones = habitaciones;
        }
        public void setHabitaciones(List<Habitacion> habitaciones) { this.habitaciones = habitaciones; }
        public List<Habitacion> getHabitaciones() { return habitaciones; }
    }
}
