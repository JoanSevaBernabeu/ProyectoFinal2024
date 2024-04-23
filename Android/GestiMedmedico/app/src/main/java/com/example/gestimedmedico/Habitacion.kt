package com.example.gestimedmedico

class Habitacion (numHabitacion: String, numCamasTotales: Short, numCamasOcu: Short){
    var numHabitacion: String
    var numCamasTotales: Short
    var numCamasOcu: Short
    lateinit var pacientes: List<Paciente>

    init {
        this.numHabitacion = numHabitacion
        this.numCamasTotales = numCamasTotales
        this.numCamasOcu = numCamasOcu
    }
}