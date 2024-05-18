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

namespace gestiMed2024.viewmodels
{
    class TratamientoNuevoVM
    {
        private TratamientoNuevo ventana;
        TratamientoService servicio;
        List<Tratamiento> tratamientos;

        public TratamientoNuevoVM()
        {
            servicio = new TratamientoService();
            tratamientos = new List<Tratamiento>();
        }

        public void setVentana(TratamientoNuevo ventana)
        {
            this.ventana = ventana;
        }
        public void error()
        {
            string mensaje = "Este tratamiento ya existe";
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
        public List<Medicamento> getMedicamentos()
        {
            MedicamentoService medicamentoService = new MedicamentoService();
            List<Medicamento> medicamentos = medicamentoService.getAllMedicamentos();
            return medicamentos;
        }
        public Medicamento getMedicamento(string nombre)
        {
            MedicamentoService medicamentoService = new MedicamentoService();
            Medicamento medicamento = medicamentoService.getMedicamento(nombre);
            return medicamento;
        }
        public void aceptar(Tratamiento tratamiento)
        {
            obtenerTratamientos();
            bool existe = false;
            foreach (Tratamiento trat in tratamientos)
            {
                if (trat.nombre.Equals(tratamiento.nombre)) existe = true;
            }
            if (existe) error();
            else postTratamiento(tratamiento);
        }
        public void postTratamiento(Tratamiento tratamiento)
        {
            string mensaje = "Ejecucion completada!";
            string caption = "Aceptado";

            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensaje, caption, botones);

            servicio.postTratamiento(tratamiento);
        }
        public void obtenerTratamientos()
        {
            servicio = new TratamientoService();
            tratamientos = servicio.getAllTratamientos();
        }
    }
}
