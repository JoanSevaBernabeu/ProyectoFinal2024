package com.proyecto.gestimed

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import android.widget.TextView
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels

class PacienteFragment(): Fragment() {
    val model: PacienteModel by activityViewModels()
    lateinit var paciente: Paciente
    override fun onCreateView(
        inflater: LayoutInflater,
        container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        var view = inflater.inflate(R.layout.paciente_pulsado,container,false)
        var boton = view.findViewById<Button>(R.id.altaBoton)
        val observer = Observer<Paciente>{
            paciente = it
            var tratamiento = paciente.tratamiento
            var medicamento = tratamiento.medicamento
            bindPaciente(view,paciente)
            bindDatos(view,paciente)
        }
        model.getPaciente().observe(requireActivity(),observer)
        boton.setOnClickListener {
            // eliminar paciente de la base de datos
        }
        return view
    }
    private fun bindPaciente(view: View, paciente:Paciente){
        var dia =paciente.nacimiento.year
        view.findViewById<TextView>(R.id.nombreText).setText(paciente.nombre)
        view.findViewById<TextView>(R.id.apellidosText).setText(paciente.apellidos)
        view.findViewById<TextView>(R.id.sipText).setText(paciente.sip)
        view.findViewById<TextView>(R.id.nacimientoText).setText(dia.toString())
        view.findViewById<TextView>(R.id.contactoText).setText(paciente.numContacto)
    }
    private fun bindDatos(view: View, paciente: Paciente){
        var medicos : List<Medico> = paciente.medicos
        var tratamiento : Tratamiento = paciente.tratamiento
        var medicamento : Medicamento = tratamiento.medicamento
        view.findViewById<TextView>(R.id.medico1Text).setText(medicos[0].nombre + " " + medicos[0].apellidos)
        view.findViewById<TextView>(R.id.medico2Text).setText(medicos[1].nombre + " " + medicos[1].apellidos)
        view.findViewById<TextView>(R.id.medico3Text).setText(medicos[2].nombre + " " + medicos[2].apellidos)
        view.findViewById<TextView>(R.id.nombreTratamiento).setText(tratamiento.nombre)
        view.findViewById<TextView>(R.id.descTratamiento).setText(tratamiento.descripcion)
        view.findViewById<TextView>(R.id.nombreMedicamento).setText(medicamento.nombre)
        view.findViewById<TextView>(R.id.idMedicamento).setText(medicamento.id)
        view.findViewById<TextView>(R.id.intervaloMedicamento).setText(medicamento.intervalo.toString())
    }
}