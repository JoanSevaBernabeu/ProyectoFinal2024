using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestiMed2024.vistas;

namespace gestiMed2024.viewmodels
{
    class MainWindowVM
    {
        private MainWindow ventana;
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
        public void aceptar()
        {
            string mensaje = "Ejecucion completada!";
            string caption = "Aceptado";

            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensaje, caption, botones);
        }
        public void error()
        {
            string mensaje = "Ha ocurrido un error, revise los campos";
            string caption = "Error";

            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensaje, caption, botones);
        }
        public void habitacionNueva()
        {
            HabitacionNueva habitacion_nueva = new HabitacionNueva();
            habitacion_nueva.Owner = ventana;
            habitacion_nueva.Show();
        }
        public void eliminarHabitacion()
        {
            EliminarHabitacion eliminar_habitacion = new EliminarHabitacion();
            eliminar_habitacion.Owner = ventana;
            eliminar_habitacion.Show();
        }
        public void tratamientoNuevo()
        {
            TratamientoNuevo tratamiento_nuevo = new TratamientoNuevo();
            tratamiento_nuevo.Owner = ventana;
            tratamiento_nuevo.Show();
        }
        public void eliminarTratamiento()
        {
            EliminarTratamiento eliminar_tratamiento = new EliminarTratamiento();
            eliminar_tratamiento.Owner = ventana;
            eliminar_tratamiento.Show();
        }
        public void medicamentoNuevo()
        {
            MedicamentoNuevo medicamento_nuevo = new MedicamentoNuevo();
            medicamento_nuevo.Owner = ventana;
            medicamento_nuevo.Show();
        }
        public void eliminarMedicamento()
        {
            EliminarMedicamento eliminar_medicamento = new EliminarMedicamento();
            eliminar_medicamento.Owner = ventana;
            eliminar_medicamento.Show();
        }
        public void medicoNuevo()
        {
            MedicoNuevoVM medico_nuevo = new MedicoNuevoVM();
            medico_nuevo.Owner = ventana;
            medico_nuevo.Show();
        }
        public void eliminarMedico()
        {
            EliminarMedico eliminar_medico = new EliminarMedico();
            eliminar_medico.Owner = ventana;
            eliminar_medico.Show();
        }
        public void setVentana(MainWindow ventana)
        {
            this.ventana = ventana;
        }
        public void pacienteNuevo()
        {
            PacienteNuevo paciente_nuevo = new PacienteNuevo();
            paciente_nuevo.Owner = ventana;
            paciente_nuevo.Show();
        }
        public void eliminarPaciente()
        {
            EliminarPaciente eliminar_paciente = new EliminarPaciente();
            eliminar_paciente.Owner = ventana;
            eliminar_paciente.Show();
        }
    }
}
