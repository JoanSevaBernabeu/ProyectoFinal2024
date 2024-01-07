/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Clases;

import Listas.ListaTratamiento;
import java.io.Serializable;
import java.util.List;

/**
 *
 * @author joans
 */
public class Medicamento implements Serializable{
    private String id;
    private String nombre;
    private Integer cantidad;
    private Integer intervalo;
    private ListaTratamiento tratamientoList;
    
    public Medicamento() {
    }

    public Medicamento(String id) {
        this.id = id;
    }

    public Medicamento(String id, String nombre, Integer cantidad, Integer intervalo) {
        this.id = id;
        this.nombre = nombre;
        this.cantidad = cantidad;
        this.intervalo = intervalo;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public Integer getCantidad() {
        return cantidad;
    }

    public void setCantidad(Integer cantidad) {
        this.cantidad = cantidad;
    }

    public Integer getIntervalo() {
        return intervalo;
    }

    public void setIntervalo(Integer intervalo) {
        this.intervalo = intervalo;
    }

    public ListaTratamiento getTratamientoList() {
        return tratamientoList;
    }

    public void setTratamientoList(ListaTratamiento tratamientoList) {
        this.tratamientoList = tratamientoList;
    }

    @Override
    public String toString() {
        return "Medicamento{" + "id=" + id + ", nombre=" + nombre + ", cantidad=" + cantidad + ", intervalo=" + intervalo + ", tratamientoList=" + tratamientoList + '}';
    }
    
    
}
