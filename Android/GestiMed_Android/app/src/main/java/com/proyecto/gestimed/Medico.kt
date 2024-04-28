package com.proyecto.gestimed

class Medico (apellidos:String,contrasenya:String,dni:String,email:String,nombre:String,numContacto:String){
    var apellidos: String
    var contrasenya: String
    var dni: String
    var email: String
    var nombre: String
    var numContacto: String
    lateinit var pacientes: List<Paciente>

    init {
        this.dni=dni
        this.nombre=nombre
        this.apellidos=apellidos
        this.email=email
        this.contrasenya=contrasenya
        this.numContacto=numContacto
    }
    fun addPacientesToMedico(pacientes:ArrayList<Paciente>){
        this.pacientes = pacientes
    }
}