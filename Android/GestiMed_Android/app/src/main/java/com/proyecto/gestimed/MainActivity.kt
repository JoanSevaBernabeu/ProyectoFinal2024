package com.proyecto.gestimed

import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.activity.viewModels
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch

class MainActivity : AppCompatActivity() {

    val model: PacienteModel by viewModels()
    private var listaPacientes = ArrayList<Paciente>()
    private var listaMedicos = ArrayList<Medico>()
    private var listaTratamientos = ArrayList<Tratamiento>()
    private var listaMedicamentos = ArrayList<Medicamento>()
    private var listaHabitaciones = ArrayList<Habitacion>()
    private var adaptadorApi: AdaptadorApi = AdaptadorApi()

    override fun onCreate(savedInstanceState: Bundle?) {
        model.setContxto(this)
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        listaMedicos = addMedicos()
        listaHabitaciones = addHabitaciones()
        listaMedicamentos = addMedicamentos()
        listaTratamientos = addTratamiento()
        listaPacientes = addPacientes()

        model.setListaPacientes(listaPacientes)
        model.setListaMedicos(listaMedicos)
        /*
        getPacientes()
        getMedicos()
        model.setListaPacientes(listaPacientes)
        model.setListaMedicos(listaMedicos)

         */
    }

    private fun getPacientes(){
        CoroutineScope(Dispatchers.Main).launch {
            listaPacientes = adaptadorApi.cargarPacientes().await()
        }
    }
    private fun getMedicos(){
        CoroutineScope(Dispatchers.Main).launch {
            listaMedicos = adaptadorApi.cargarMedicos().await()
        }
    }

    private fun addMedicos(): ArrayList<Medico>{
        var medicos = ArrayList<Medico>()
        medicos.add(Medico("Florin","1234","5678","florin@gmail","Debora","0987"))
        medicos.add(Medico("Perez","1234","5678","perez@gmail","Claudia","0987"))
        medicos.add(Medico("Cuesta","1234","5678","cuesta@gmail","Alejandro","0987"))
        return medicos
    }

    private fun addHabitaciones(): ArrayList<Habitacion>{
        var habitaciones = ArrayList<Habitacion>()
        habitaciones.add(Habitacion(1,3,"001"))
        habitaciones.add(Habitacion(1,3,"002"))
        habitaciones.add(Habitacion(1,3,"003"))
        return habitaciones
    }

    private fun addMedicamentos():ArrayList<Medicamento>{
        var medicamentos = ArrayList<Medicamento>()
        medicamentos.add(Medicamento(100,"0876",8,"ibuprofeno"))
        medicamentos.add(Medicamento(20,"0877",6,"paracertelamor"))
        return medicamentos
    }
    private fun addTratamiento():ArrayList<Tratamiento>{
        var tratamientos = ArrayList<Tratamiento>()
        tratamientos.add(Tratamiento("Haser kk al reves",listaMedicamentos[0],"tratamiento1","Haser la kk normal"))
        tratamientos.add(Tratamiento("Haser kk al reves",listaMedicamentos[1],"tratamiento2","Haser la kk normal"))
        tratamientos.add(Tratamiento("Haser kk al reves",listaMedicamentos[0],"tratamiento3","Haser la kk normal"))
        return tratamientos
    }

    private fun addPacientes():ArrayList<Paciente>{
        var pacientes = ArrayList<Paciente>()
        pacientes.add(Paciente("Hernandez",listaMedicos,19930620,"Goku","620220902",listaHabitaciones[0],listaTratamientos[0],"alta"))
        pacientes.add(Paciente("Hernandez",listaMedicos,19930620,"Goku2","620220902",listaHabitaciones[0],listaTratamientos[0],"alta"))
        pacientes.add(Paciente("Hernandez",listaMedicos,19930620,"Goku3","620220902",listaHabitaciones[0],listaTratamientos[0],"alta"))
        return pacientes
    }
    /*


     */
}