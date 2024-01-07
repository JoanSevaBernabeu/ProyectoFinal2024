/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import Clases.Habitacion;
import Listas.ListaHabitaciones;
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
public class DAOHabitacion {
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
        public static Habitacion getHabitacion(String numHabitacion){
        Habitacion habitacion = null;
        ListaHabitaciones lista = obtenerHabitaciones();
        for(Habitacion hab: lista.getLista()){
            if(hab.getNumHabitacion().equals(numHabitacion)){
                habitacion = hab;
            }
        }
        return habitacion;
    }
    
    public static ListaHabitaciones obtenerHabitaciones(){
        ListaHabitaciones lista = new ListaHabitaciones();
        Statement statement = null;
        conectar();
        try{
            String sentencia = "SELECT * FROM habitacion;";
            statement = con.createStatement();
            ResultSet rs = statement.executeQuery(sentencia);
            while(rs.next()){
                Habitacion habitacion = new Habitacion(rs.getString("numHabitacion"),rs.getInt("numCamasTotales"),rs.getInt("numCamasOcu"));
                lista.add(habitacion);
            }
        }catch(SQLException ex){
            Logger.getLogger(DAOHabitacion.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
        return lista;
    }
    public static void postHabitacion(Habitacion habitacion)
    {
        Statement statement = null;
        conectar();
        try{
            String sentencia = "INSERT INTO habitacion VALUES ('"+habitacion.getNumHabitacion()+"',"+habitacion.getCamTotales()+","+habitacion.getCamOcupadas()+";";
            ResultSet rs = statement.executeQuery(sentencia);
        }catch(SQLException ex){
            Logger.getLogger(DAOHabitacion.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
    }
    public static boolean deleteHabitacion(String id){
        Statement statement = null;
        boolean ok = false;
        conectar();
        try{
            String sentencia = "DELETE FROM habitacion WHERE numHabitacion LIKE '"+id+"';";
            ResultSet rs = statement.executeQuery(sentencia);   
        }catch(SQLException ex){
            Logger.getLogger(DAOHabitacion.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
        return ok;
    }
}
