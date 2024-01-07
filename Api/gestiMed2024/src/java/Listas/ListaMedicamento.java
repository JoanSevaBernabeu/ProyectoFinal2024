/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Listas;

import Clases.Medicamento;
import java.io.Serializable;
import java.util.ArrayList;

/**
 *
 * @author joans
 */
public class ListaMedicamento implements Serializable{
    private ArrayList<Medicamento> lista = new ArrayList<Medicamento>();
    
    public ListaMedicamento(){
    }
    public ListaMedicamento(ArrayList<Medicamento> lista){
        this.lista = lista;
    }
    
    public ArrayList<Medicamento> getLista(){
        return lista;
    }
    public void setLista(ArrayList<Medicamento> lista){
        this.lista = lista;
    }
    public void add(Medicamento med){
        this.lista.add(med);
    }
    public void delete(Medicamento medicamento){
        this.lista.remove(medicamento);
    }
}
