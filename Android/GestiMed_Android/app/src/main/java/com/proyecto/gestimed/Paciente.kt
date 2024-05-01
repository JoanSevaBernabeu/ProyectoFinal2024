package com.proyecto.gestimed

import java.util.Date

class Paciente(apellidos:String,medicoList:List<Medico>,nacimiento:Long,nombre:String,numContacto:String,numHabitacion:Habitacion,sip:String,tratamiento:Tratamiento,urgencia:String) {
    var apellidos: String
    var medicoList: List<Medico>
    var nacimiento: Long
    var nombre: String
    var numContacto: String
    var numHabitacion: Habitacion
    var sip : String
    var tratamiento: Tratamiento
    var urgencia: String

    init{
        this.apellidos = apellidos
        this.medicoList = medicoList
        this.nacimiento = nacimiento
        this.nombre = nombre
        this.numContacto = numContacto
        this.numHabitacion = numHabitacion
        this.sip = sip
        this.tratamiento = tratamiento
        this.urgencia = urgencia
    }
}