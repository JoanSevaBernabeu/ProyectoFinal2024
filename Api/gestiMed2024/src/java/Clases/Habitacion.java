/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Clases;

import Listas.ListaPaciente;
import java.io.Serializable;

/**
 *
 * @author joans
 */
public class Habitacion implements Serializable{
    
    private String numHabitacion;
    private Integer camTotales;
    private Integer camOcupadas;
    private ListaPaciente pacienteList;
    
    public Habitacion() {
    }

    public Habitacion(String numHabitacion) {
        this.numHabitacion = numHabitacion;
    }

    public Habitacion(String numHabitacion, Integer camTotales, Integer camOcupadas) {
        this.numHabitacion = numHabitacion;
        this.camTotales = camTotales;
        this.camOcupadas = camOcupadas;
    }

    public String getNumHabitacion() {
        return numHabitacion;
    }

    public void setNumHabitacion(String numHabitacion) {
        this.numHabitacion = numHabitacion;
    }

    public Integer getCamTotales() {
        return camTotales;
    }

    public void setCamTotales(Integer camTotales) {
        this.camTotales = camTotales;
    }

    public Integer getCamOcupadas() {
        return camOcupadas;
    }

    public void setCamOcupadas(Integer camOcupadas) {
        this.camOcupadas = camOcupadas;
    }

    public ListaPaciente getPacienteList() {
        return pacienteList;
    }

    public void setPacienteList(ListaPaciente pacienteList) {
        this.pacienteList = pacienteList;
    }
    
    public void addPaciente(Paciente paciente){
        pacienteList.add(paciente);
    }
    
    public void deletePaciente(Paciente paciente){
        pacienteList.delete(paciente);
    }

    @Override
    public String toString() {
        return "Habitacion{" + "numHabitacion=" + numHabitacion + ", camTotales=" + camTotales + ", camOcupadas=" + camOcupadas + ", pacienteList=" + pacienteList + '}';
    }
    
    
}
