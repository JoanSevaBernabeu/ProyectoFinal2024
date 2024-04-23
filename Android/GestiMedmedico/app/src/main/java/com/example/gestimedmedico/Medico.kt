package com.example.gestimedmedico

import java.util.*

class Medico (dni:String,nombre:String,apellidos:String,email:String,contrasenya:String,numContacto:String){
    var dni: String
    var nombre: String
    var apellidos: String
    var email: String
    var contrasenya: String
    var numContacto: String
    lateinit var pacientes : List<Paciente>

    init {
        this.dni=dni
        this.nombre=nombre
        this.apellidos=apellidos
        this.email=email
        this.contrasenya=contrasenya
        this.numContacto=numContacto
    }
}