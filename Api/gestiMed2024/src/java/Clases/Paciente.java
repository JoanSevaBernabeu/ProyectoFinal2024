/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Clases;

import Listas.ListaMedico;
import java.io.Serializable;
import java.util.ArrayList;
import java.util.Date;

/**
 *
 * @author joans
 */
public class Paciente implements Serializable{
    
    private String sip;
    private String nombre;
    private String apellidos;
    private String numContacto;
    private Date nacimiento;
    private String urgencia;
    private ListaMedico medicoList;
    private Habitacion numHabitacion;
    private Tratamiento tratamiento;
    
    public Paciente() {
    }

    public Paciente(String sip, String nombre, String apellidos, String numContacto, Date nacimiento, String urgencia) {
        this.sip = sip;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.numContacto = numContacto;
        this.nacimiento = nacimiento;
        this.urgencia = urgencia;
    }

    public String getSip() {
        return sip;
    }

    public void setSip(String sip) {
        this.sip = sip;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellidos() {
        return apellidos;
    }

    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public String getNumContacto() {
        return numContacto;
    }

    public void setNumContacto(String numContacto) {
        this.numContacto = numContacto;
    }

    public Date getNacimiento() {
        return nacimiento;
    }

    public void setNacimiento(Date nacimiento) {
        this.nacimiento = nacimiento;
    }

    public String getUrgencia() {
        return urgencia;
    }

    public void setUrgencia(String urgencia) {
        this.urgencia = urgencia;
    }

    public ListaMedico getMedicoList() {
        return medicoList;
    }

    public void setMedicoList(ListaMedico medicoList) {
        this.medicoList = medicoList;
    }

    public Habitacion getNumHabitacion() {
        return numHabitacion;
    }

    public void setNumHabitacion(Habitacion numHabitacion) {
        this.numHabitacion = numHabitacion;
    }

    public Tratamiento getTratamiento() {
        return tratamiento;
    }

    public void setTratamiento(Tratamiento tratamiento) {
        this.tratamiento = tratamiento;
    }

    @Override
    public String toString() {
        return "Paciente{" + "sip=" + sip + ", nombre=" + nombre + ", apellidos=" + apellidos + ", numContacto=" + numContacto + ", nacimiento=" + nacimiento + ", urgencia=" + urgencia + ", medicoList=" + medicoList + ", numHabitacion=" + numHabitacion + ", tratamiento=" + tratamiento + '}';
    }
    
    
}
