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
using gestiMed2024.listas;

namespace gestiMed2024.viewmodels
{
    class TratamientoNuevoVM
    {
        private TratamientoNuevo ventana;
        TratamientoService servicio;
        List<Tratamiento> tratamientos;

        public TratamientoNuevoVM()
        {
            ventana = new TratamientoNuevo();
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
            ListaMedicamento lista = medicamentoService.getAllMedicamentos();
            List<Medicamento> medicamentos = lista.getMedicamentos();
            return medicamentos;
        }
        public Medicamento getMedicamento(string nombre)
        {
            MedicamentoService medicamentoService = new MedicamentoService();
            ListaMedicamento lista = medicamentoService.getMedicamento(nombre);
            List<Medicamento> medicamento = lista.getMedicamentos();
            if (medicamento.Count() != 1) return null;
            else return medicamento[0];
        }
        public void aceptar(Tratamiento tratamiento)
        {
            obtenerTratamientos();
            bool existe = false;
            foreach (Tratamiento trat in tratamientos)
            {
                if (trat.Nombre == tratamiento.Nombre) existe = true;
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
            ListaTratamiento lista = servicio.getAllTratamientos();
            tratamientos = lista.getListaTratamientos();
        }
    }
}
