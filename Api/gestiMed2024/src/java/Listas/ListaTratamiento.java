/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Listas;

import Clases.Tratamiento;
import java.io.Serializable;
import java.util.ArrayList;

/**
 *
 * @author joans
 */
public class ListaTratamiento implements Serializable{
    private ArrayList<Tratamiento> lista = new ArrayList<Tratamiento>();
    
    public ListaTratamiento(){  
    }
    public ListaTratamiento(ArrayList<Tratamiento> lista){
        this.lista = lista;
    }
    public ArrayList<Tratamiento> getLista(){
        return lista;
    }
    public void setLista(ArrayList<Tratamiento> lista){
        this.lista = lista;
    }
    public void add(Tratamiento tratamiento){
        this.lista.add(tratamiento);
    }
    public void delete(Tratamiento tratamiento){
        this.lista.remove(tratamiento);
    }
}
