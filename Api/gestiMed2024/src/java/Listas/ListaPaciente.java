/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Listas;

import Clases.Paciente;
import java.io.Serializable;
import java.util.ArrayList;

/**
 *
 * @author joans
 */
public class ListaPaciente implements Serializable{
    private ArrayList<Paciente> lista = new ArrayList<Paciente>();
    
    public ListaPaciente(){
    }
    public ListaPaciente(ArrayList<Paciente> lista){
        this.lista = lista;
    }
    public ArrayList<Paciente> getLista(){
        return lista;
    }
    public void setLista(ArrayList<Paciente> lista){
        this.lista = lista;
    }
    public void add(Paciente paciente){
        this.lista.add(paciente);
    }
    public void delete(Paciente paciente){
        this.lista.remove(paciente);
    }
}
