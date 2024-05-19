/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import Clases.Medicamento;
import Clases.Tratamiento;
import static DAO.DAOMedicamento.getMedicamento;
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
public class DAOTratamiento {
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
            Logger.getLogger(DAOHabitacion.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    public static void desconectar() {
        try {
            // Cerrar conexión
            con.close();
        } catch (SQLException ex) {
            Logger.getLogger(DAOHabitacion.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    public static ListaTratamiento getTratamientos(){
        ListaTratamiento lista = new ListaTratamiento();
        Statement statement = null;
        conectar();
        try{
            String sentencia = "SELECT * FROM tratamiento";
            statement = con.createStatement();
            ResultSet rs = statement.executeQuery(sentencia);
            while(rs.next()){
                Tratamiento tratamiento = new Tratamiento(rs.getString("nombre"),rs.getString("descripcion"),rs.getString("solucion"));
                Medicamento medicamento = DAOMedicamento.getMedicamento(rs.getString("medicamento"));
                tratamiento.setMedicamento(medicamento);
                lista.add(tratamiento);
            }
        }catch(SQLException ex){
            Logger.getLogger(DAOTratamiento.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
        return lista;
    }
    
    public static Tratamiento getTratamiento(String nombre){
        Tratamiento tratamiento = null;
        Statement statement = null;
        conectar();
        try{
            String sentencia = "SELECT * FROM tratamiento WHERE nombre LIKE '"+nombre+"'";
            statement = con.createStatement();
            ResultSet rs = statement.executeQuery(sentencia);
            if(rs.next()){
                tratamiento = new Tratamiento(rs.getString("nombre"),rs.getString("descripcion"),rs.getString("solucion"));
                Medicamento medicamento = getMedicamento(rs.getString("medicamento"));
                tratamiento.setMedicamento(medicamento);
            }
        }catch(SQLException ex){
            Logger.getLogger(DAOTratamiento.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
        return tratamiento;
    }
    
    public static void tratamientoPost(Tratamiento tratamiento){
        Statement statement = null;
        Medicamento medicamento = tratamiento.getMedicamento();
        conectar();
        try{
            statement = con.createStatement();
            String creaTratamiento = "INSERT INTO Tratamiento VALUES('"+tratamiento.getNombre()+"','"+tratamiento.getDescripcion()+"','"+tratamiento.getSolucion()+"','"+medicamento.getId()+"');";
            int rs = statement.executeUpdate(creaTratamiento);
            
        }catch(SQLException ex){
            Logger.getLogger(DAOTratamiento.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
    }
    
    public static void tratamientoDelete(String nombre){
        Statement statement = null;
        conectar();
        try{
            putMedicamentoNull(nombre);
            statement = con.createStatement();
            String delete = "DELETE FROM Tratamiento WHERE nombre LIKE '"+nombre+"'";
            int rs = statement.executeUpdate(delete);
        }catch(SQLException ex){
            Logger.getLogger(DAOTratamiento.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
    }
    
    public static void putMedicamentoNull(String nombre){
        Statement statement = null;
        conectar();
        try{
            String put = "UPDATE tratamiento SET medicamento = null WHERE nombre LIKE '"+nombre+"'";
            statement = con.createStatement();
            int rs = statement.executeUpdate(put);
            
        }catch(SQLException ex){
            Logger.getLogger(DAOPaciente.class.getName()).log(Level.SEVERE, null, ex);
        }
        
    }
}
