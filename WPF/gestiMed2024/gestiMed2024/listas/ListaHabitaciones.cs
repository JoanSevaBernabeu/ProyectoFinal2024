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
        ObservableCollection<Habitacion> habitaciones;
        public ListaHabitaciones() { }
        public ListaHabitaciones(ObservableCollection<Habitacion> habitaciones)
        {
            this.habitaciones = habitaciones;
        }
        public void setHabitaciones(ObservableCollection<Habitacion> habitaciones) { this.habitaciones = habitaciones; }
        public ObservableCollection<Habitacion> getHabitaciones() { return habitaciones; }
    }
}
