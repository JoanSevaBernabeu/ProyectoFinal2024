using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using gestiMed2024.clases;
using gestiMed2024.vistas;
using gestiMed2024.servicios;
using gestiMed2024.listas;

namespace gestiMed2024.viewmodels
{
    class MedicamentoNuevoVM
    {
        private MedicamentoNuevo ventana;
        MedicamentoService servicio;
        List<Medicamento> medicamentos;

        public void setVentana(MedicamentoNuevo ventana)
        {
            this.ventana = ventana;
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
        public void obtenerMedicamentos()
        {
            servicio = new MedicamentoService();
            ListaMedicamento lista = servicio.getAllMedicamentos();
            medicamentos = lista.getMedicamentos();
        }
        public List<Tratamiento> getTratamientos()
        {
            TratamientoService tratamientoService = new TratamientoService();
            ListaTratamiento listaTratamientos = tratamientoService.getAllTratamientos();
            List<Tratamiento> tratamientos = listaTratamientos.getListaTratamientos();
            return tratamientos;
        }
        public Tratamiento getTratamiento(string nombre)
        {
            TratamientoService tratamientoService = new TratamientoService();
            ListaTratamiento listaTratamientos = tratamientoService.getAllTratamientos();
            List<Tratamiento> tratamientos = listaTratamientos.getListaTratamientos();
            if (tratamientos.Count() != 1) return null;
            else return tratamientos[0];
        }
        public void error()
        {
            string mensaje = "Este medicamento ya existe";
            string caption = "Error";

            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensaje, caption, botones);
        }
        public void aceptar(Medicamento medicamento)
        {
            obtenerMedicamentos();
            bool existe = false;
            foreach (Medicamento med in medicamentos)
            {
                if (med.getId() == medicamento.getId()) existe = true;
            }
            if (existe) error();
            else postMedicamento(medicamento);
        }
        public void postMedicamento(Medicamento medicamento)
        {
            string mensaje = "Ejecucion completada!";
            string caption = "Aceptado";

            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensaje, caption, botones);

            servicio.postMedicamento(medicamento);
        }
    }
}
