package com.example.gestimedmedico

import java.util.*
import kotlin.collections.ArrayList

class Paciente(sip: String, nombre: String, apellidos: String, numContacto: String, nacimiento: Date, medicos: List<Medico>, urgencia: String, tratamiento: Tratamiento, habitacion: Habitacion) {
    var sip: String
    var nombre: String
    var apellidos: String
    var numContacto: String
    var nacimiento: Date
    var medicos: List<Medico>
    var tratamiento: Tratamiento
    var urgencia : String
    var habitacion: Habitacion

    init {
        this.sip = sip
        this.nombre = nombre
        this.apellidos = apellidos
        this.numContacto = numContacto
        this.nacimiento = nacimiento
        this.medicos = medicos
        this.tratamiento = tratamiento
        this.urgencia = urgencia
        this.habitacion = habitacion
    }
}