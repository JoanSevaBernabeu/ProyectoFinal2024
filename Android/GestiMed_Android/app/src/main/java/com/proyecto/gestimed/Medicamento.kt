package com.proyecto.gestimed

class Medicamento (cantidad:Int,id:String,intervalo:Int,nombre:String){
    var cantidad: Int
    var id: String
    var intervalo: Int
    var nombre: String
    lateinit var tratamientos : List<Tratamiento>


    init {
        this.id = id
        this.nombre = nombre
        this.cantidad = cantidad
        this.intervalo = intervalo
    }
}