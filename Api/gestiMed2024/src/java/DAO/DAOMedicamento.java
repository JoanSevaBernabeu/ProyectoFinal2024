/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import Clases.Medicamento;
import Clases.Tratamiento;
import Listas.ListaMedicamento;
import Listas.ListaTratamiento;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author joans
 */
public class DAOMedicamento {
    static Connection con = null;
    static String mensaje= "";
    
    public static void conectar(){
        try {
            // Conexión a la BD
            String url;

            Class.forName("com.mysql.cj.jdbc.Driver");
            url = "jdbc:mysql://localhost:3306/gestimed";
            url += "?autoReconnect=true&useSSL=false&zeroDateTimeBehavior=convertToNull&serverTimezone=UTC";

            String usuario = "root";
            String password = "1234";
            con = DriverManager.getConnection(url, usuario, password);

        } catch (ClassNotFoundException | SQLException ex) {
            Logger.getLogger(DAOMedicamento.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    public static void desconectar() {
        try {
            // Cerrar conexión
            con.close();
        } catch (SQLException ex) {
            Logger.getLogger(DAOMedicamento.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    public static ListaMedicamento getMedicamentos(){
        ListaMedicamento lista = new ListaMedicamento();
        Statement statement = null;
        conectar();
        try{
            String sentencia = "SELECT * FROM medicamento;";
            statement = con.createStatement();
            ResultSet rs = statement.executeQuery(sentencia);
            while(rs.next()){
                Medicamento medicamento = new Medicamento(rs.getString("id"),rs.getString("nombre"),rs.getInt("cantidad"),rs.getInt("intervalo"));
                lista.add(medicamento);
            }
        }catch(SQLException ex){
            Logger.getLogger(DAOMedicamento.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
        return lista;
    }
    
    public static Medicamento getMedicamento(String id){
        Medicamento medicamento = null;
        Statement statement = null;
        conectar();
        try{
            String sentencia = "SELECT * FROM medicamento WHERE id LIKE '"+id+"'";
            statement = con.createStatement();
            ResultSet rs = statement.executeQuery(sentencia);
            if(rs.next()){
                medicamento = new Medicamento(rs.getString("id"),rs.getString("nombre"),rs.getInt("cantidad"),rs.getInt("intervalo"));
                ListaTratamiento tratamientos = getTratamientos(rs.getString("medicamento"));
                medicamento.setTratamientoList(tratamientos);
            }
        }catch(SQLException ex){
            Logger.getLogger(DAOMedicamento.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
        return medicamento;
    }
    
    public static ListaTratamiento getTratamientos(String medicamento){
        ListaTratamiento tratamientos = new ListaTratamiento();
        Statement statement = null;
        conectar();
        try{
            String sentencia = "SELECT * FROM tratamiento WHERE medicamento LIKE '"+medicamento+"'";
            statement = con.createStatement();
            ResultSet rs = statement.executeQuery(sentencia);
            while(rs.next()){
                Tratamiento tratamiento = DAOTratamiento.getTratamiento(rs.getString("nombre"));
                tratamientos.add(tratamiento);
            }
        }catch(SQLException ex){
            Logger.getLogger(DAOMedicamento.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
        return tratamientos;
    }
    public static void postMedicamento(Medicamento medicamento){
        Statement statement = null;
        conectar();
        try{
            statement = con.createStatement();
            String post = "INSERT INTO medicamento VALUES ('"+medicamento.getId()+"','"+medicamento.getNombre()+"',"+medicamento.getCantidad()+","+medicamento.getIntervalo()+");";
            ResultSet rs = statement.executeQuery(post);
        }catch(SQLException ex){
            Logger.getLogger(DAOMedicamento.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
    }
    public static void deleteMedicamento(String id){
        Statement statement = null;
        conectar();
        try{
            statement = con.createStatement();
            String delete = "DELETE FROM medicamento WHERE id LIKE '"+ id + "'";
            int rs = statement.executeUpdate(delete);
        }catch(SQLException ex){
            Logger.getLogger(DAOMedicamento.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
    }
    
    public static void putMedicamento(String id, int cantidad){
        Statement statement = null;
        conectar();
        try{
            statement = con.createStatement();
            String put = "UPDATE medicamento SET cantidad="+cantidad+" WHERE id LIKE '"+id+"'";
            int rs = statement.executeUpdate(put);
        }catch(SQLException ex){
            Logger.getLogger(DAOMedicamento.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
    }
}
