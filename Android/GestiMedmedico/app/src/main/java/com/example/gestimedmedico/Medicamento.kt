package com.example.gestimedmedico

class Medicamento (id: String, nombre: String, cantidad: Int, intervalo: Int){
    var id: String
    var nombre: String
    var cantidad: Int
    var intervalo: Int
    init {
        this.id = id
        this.nombre = nombre
        this.cantidad = cantidad
        this.intervalo = intervalo
    }
}