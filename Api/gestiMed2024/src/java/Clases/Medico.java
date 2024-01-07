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
public class Medico implements Serializable{
    
    private String dni;
    private String nombre;
    private String apellidos;
    private String email;
    private String contrasenya;
    private String numContacto;
    private ListaPaciente pacienteList;
    
    public Medico() {
    }

    public Medico(String dni, String nombre, String apellidos, String email, String contrasenya, String numContacto) {
        this.dni = dni;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.email = email;
        this.contrasenya = contrasenya;
        this.numContacto = numContacto;
    }

    public String getDni() {
        return dni;
    }

    public void setDni(String dni) {
        this.dni = dni;
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

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getContrasenya() {
        return contrasenya;
    }

    public void setContrasenya(String contrasenya) {
        this.contrasenya = contrasenya;
    }

    public String getNumContacto() {
        return numContacto;
    }

    public void setNumContacto(String numContacto) {
        this.numContacto = numContacto;
    }

    public ListaPaciente getPacienteList() {
        return pacienteList;
    }

    public void setPacienteList(ListaPaciente pacienteList) {
        this.pacienteList = pacienteList;
    }

    @Override
    public String toString() {
        return "Medico{" + "dni=" + dni + ", nombre=" + nombre + ", apellidos=" + apellidos + ", email=" + email + ", contrasenya=" + contrasenya + ", numContacto=" + numContacto + ", pacienteList=" + pacienteList + '}';
    }
    
    
}
