package com.proyecto.gestimed

class Tratamiento(descripcion:String,medicamento:Medicamento,nombre:String,solucion:String) {
    var descripcion: String
    var medicamento: Medicamento
    var nombre: String
    var solucion: String
    init {
        this.nombre = nombre
        this.descripcion = descripcion
        this.solucion = solucion
        this.medicamento = medicamento
    }
}