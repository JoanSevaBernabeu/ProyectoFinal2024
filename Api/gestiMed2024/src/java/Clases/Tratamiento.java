/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Clases;

import Listas.ListaPaciente;
import java.io.Serializable;
import java.util.List;

/**
 *
 * @author joans
 */
public class Tratamiento implements Serializable{
    
    private String nombre;
    private String descripcion;
    private String solucion;
    private ListaPaciente pacienteList;
    private Medicamento medicamento;
    
    public Tratamiento() {
    }

    public Tratamiento(String nombre, String descripcion, String solucion) {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.solucion = solucion;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public String getSolucion() {
        return solucion;
    }

    public void setSolucion(String solucion) {
        this.solucion = solucion;
    }

    public ListaPaciente getPacienteList() {
        return pacienteList;
    }

    public void setPacienteList(ListaPaciente pacienteList) {
        this.pacienteList = pacienteList;
    }

    public Medicamento getMedicamento() {
        return medicamento;
    }

    public void setMedicamento(Medicamento medicamento) {
        this.medicamento = medicamento;
    }

    @Override
    public String toString() {
        return "Tratamiento{" + "nombre=" + nombre + ", descripcion=" + descripcion + ", solucion=" + solucion + ", pacienteList=" + pacienteList + ", medicamento=" + medicamento + '}';
    }
    
    
}
