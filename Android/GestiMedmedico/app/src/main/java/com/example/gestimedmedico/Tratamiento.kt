package com.example.gestimedmedico

class Tratamiento(nombre: String, descripcion:String, solucion: String, medicamento:Medicamento) {
    var nombre: String
    var descripcion: String
    var solucion: String
    var medicamento: Medicamento

    init {
        this.nombre = nombre
        this.descripcion = descripcion
        this.solucion = solucion
        this.medicamento = medicamento
    }
}