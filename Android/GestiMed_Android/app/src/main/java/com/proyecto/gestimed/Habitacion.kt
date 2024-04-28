package com.proyecto.gestimed

class Habitacion (camOcupadas:Int,camTotales:Int,numHabitacion:String){
    var camOcupadas: Int
    var camTotales: Int
    var numHabitacion: String
    lateinit var pacienteList: List<Paciente>

    init {
        this.camOcupadas = camOcupadas
        this.camTotales = camTotales
        this.numHabitacion = numHabitacion
    }
}