package com.example.gestimedmedico

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
    private var adaptadorApi: AdaptadorApi = AdaptadorApi()
    override fun onCreateView(
        inflater: LayoutInflater,
        container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        getPacientes()
        getMedicos()
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
}