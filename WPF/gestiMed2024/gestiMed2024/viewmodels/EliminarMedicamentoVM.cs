﻿using gestiMed2024.clases;
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
    class EliminarMedicamentoVM
    {
        private EliminarMedicamento ventana;
        MedicamentoService servicio;
        List<Medicamento> medicamentos;

        public EliminarMedicamentoVM()
        {
            servicio = new MedicamentoService();
            medicamentos = new List<Medicamento>();
        }

        public void error()
        {
            string mensaje = "Este medicamento no existe";
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
        public void setVentana(EliminarMedicamento ventana)
        {
            this.ventana = ventana;
        }
        public void obtenerMedicamentos()
        {
            medicamentos = servicio.getAllMedicamentos();
        }
        public void deleteMedicamento(string id)
        {
            string mensaje = "Ejecucion completada!";
            string caption = "Aceptado";

            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensaje, caption, botones);

            servicio.deleteMedicamento(id);
        }
        public void aceptar(string id)
        {
            obtenerMedicamentos();
            bool existe = false;
            foreach (Medicamento med in medicamentos)
            {
                if (med.id == id) existe = true;
            }
            if (existe) deleteMedicamento(id);
            else error();
        }
        public void cierraVentana()
        {
            ventana.Close();
        }
    }
}
