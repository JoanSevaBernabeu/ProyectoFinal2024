package com.example.gestimedmedico

import android.content.Context
import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel

class PacienteModel(): ViewModel() {
    private var listaPacientes = MutableLiveData<ArrayList<Paciente>>()
    lateinit var contexto: Context
    var paciente = MutableLiveData<Paciente>()
    private var listaMedicos = MutableLiveData<ArrayList<Medico>>()
    fun getListaPacientes(): ArrayList<Paciente>?{
        return listaPacientes.value
    }
    fun setListaPacientes(pacientes: ArrayList<Paciente>){
        listaPacientes.value = pacientes
    }
    fun setContxto(contexto: Context){
        this.contexto = contexto
    }
    fun getContxto():Context{
        return contexto
    }
    fun setPaciente(paciente: Paciente){
        this.paciente.value = paciente
    }
    fun getPaciente():LiveData<Paciente>{
        return paciente
    }
    fun getListaMedicos():ArrayList<Medico>?{
        return listaMedicos.value
    }
    fun setListaMedicos(medicos: ArrayList<Medico>){
        listaMedicos.value = medicos
    }
}