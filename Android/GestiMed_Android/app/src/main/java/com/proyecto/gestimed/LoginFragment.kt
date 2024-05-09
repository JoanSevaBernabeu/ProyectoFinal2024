package com.proyecto.gestimed

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import android.widget.Toast
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.navigation.fragment.NavHostFragment
import com.google.android.material.textfield.TextInputEditText
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch

class LoginFragment(): Fragment() {
    val model:PacienteModel by activityViewModels()
    private var listaPacientes = ArrayList<Paciente>()
    private var listaMedicos = ArrayList<Medico>()
    private var listaTratamientos = ArrayList<Tratamiento>()
    private var listaMedicamentos = ArrayList<Medicamento>()
    private var listaHabitaciones = ArrayList<Habitacion>()
    private var adaptadorApi: AdaptadorApi = AdaptadorApi()
    override fun onCreateView(
        inflater: LayoutInflater,
        container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {

        listaMedicos = addMedicos()
        listaHabitaciones = addHabitaciones()
        listaMedicamentos = addMedicamentos()
        listaTratamientos = addTratamiento()
        listaPacientes = addPacientes()
        // getPacientes()
        // getMedicos()
        model.setListaPacientes(listaPacientes)
        model.setListaMedicos(listaMedicos)
        val lista = listaMedicos
        val navController = NavHostFragment.findNavController(this)
        val view = inflater.inflate(R.layout.login_fragment,container,false)
        val aceptarBoton = view.findViewById<Button>(R.id.aceptarButton)
        val cancelarBoton = view.findViewById<Button>(R.id.cancelarButton)
        val usuario = view.findViewById<TextInputEditText>(R.id.usuarioInput)
        val passw = view.findViewById<TextInputEditText>(R.id.passwInput)
        aceptarBoton.setOnClickListener {
            var continuar: Boolean = false
            for(item in lista!!){
                if(usuario.text.toString().equals(item.nombre) && passw.text.toString().equals(item.contrasenya)){
                    continuar = true
                }
            }
            if(continuar){
                navController.navigate(R.id.action_loginFragment_to_recyclerFragment)
            }else{
                Toast.makeText(model.getContxto(),"Error en el usuario o contraseña", Toast.LENGTH_LONG).show()
            }
        }
        cancelarBoton.setOnClickListener {
            usuario.setText("")
            passw.setText("")
        }
        return view
    }
    /*
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

     */
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
        pacientes.add(Paciente("Hernandez",listaMedicos,19930620,"Goku","620220902",listaHabitaciones[0],"1234",listaTratamientos[0],"alta"))
        pacientes.add(Paciente("Hernandez",listaMedicos,19930620,"Goku2","620220902",listaHabitaciones[1],"1234",listaTratamientos[0],"media"))
        pacientes.add(Paciente("Hernandez",listaMedicos,19930620,"Goku3","620220902",listaHabitaciones[2],"1234",listaTratamientos[0],"baja"))
        return pacientes
    }

}