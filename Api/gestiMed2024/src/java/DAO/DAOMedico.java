/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import Clases.Medico;
import Clases.Paciente;
import Listas.ListaMedico;
import Listas.ListaPaciente;
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
public class DAOMedico {
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
            Logger.getLogger(DAOMedico.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    public static void desconectar() {
        try {
            // Cerrar conexión
            con.close();
        } catch (SQLException ex) {
            Logger.getLogger(DAOMedico.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    public static ListaMedico getMedicos(){
        ListaMedico lista = new ListaMedico();
        Statement statement = null;
        conectar();
        try{
            String sentencia = "SELECT * FROM medico;";
            statement = con.createStatement();
            ResultSet rs = statement.executeQuery(sentencia);
            while(rs.next()){
                Medico med = new Medico(rs.getString("dni"),rs.getString("nombre"),rs.getString("apellidos"),rs.getString("email"),rs.getString("contrasenya"),rs.getString("numContacto"));
                ListaPaciente pacientes = obtenerPacientes(med.getDni());
                med.setPacienteList(pacientes);
                lista.add(med);
            }
            rs.close();
        }catch(SQLException ex){
            Logger.getLogger(DAOMedico.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
        return lista    ;
    }
    
    public static Medico getMedico(String dni,boolean obtenerPac){
        Medico med = null;
        Statement statement = null;
        conectar();
        try{
            String sentencia = "SELECT * FROM medico WHERE dni LIKE '" + dni + "'";
            statement = con.createStatement();
            ResultSet rs = statement.executeQuery(sentencia);
            if(rs.next()){
                med = new Medico(rs.getString("dni"),rs.getString("nombre"),rs.getString("apellidos"),rs.getString("email"),rs.getString("contrasenya"),rs.getString("numContacto"));
                if(obtenerPac == true){
                    ListaPaciente pacientes = obtenerPacientes(med.getDni());
                    med.setPacienteList(pacientes);
                }   
            }
        }catch(SQLException ex){
            Logger.getLogger(DAOMedico.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
        return med;
    }
    
    public static ListaPaciente obtenerPacientes(String dni){
        ListaPaciente lista = new ListaPaciente();
        Statement statement = null;
//        conectar();
        try{
            String sentencia = "SELECT * FROM trata WHERE dni_medico LIKE '"+dni+"';";
            statement = con.createStatement();
            ResultSet rs = statement.executeQuery(sentencia);
            if(rs.next()){
                while(rs.next()){
                    Paciente paciente = DAOPaciente.getPaciente(rs.getString("sip_paciente"),false);
                    lista.add(paciente);
                }
            }
        }catch(SQLException ex){
            Logger.getLogger(DAOMedico.class.getName()).log(Level.SEVERE, null, ex);
        }
//        desconectar();
        return lista;
    }
    public static void medicoPost(Medico medico){
        Statement statement = null;
        conectar();
        try{
            statement = con.createStatement();
            String insertaMedico = "INSERT INTO medico VALUES ('"+medico.getDni()+"','"+medico.getNombre()+"','"+medico.getApellidos()+"','"+medico.getEmail()+"','"+medico.getContrasenya()+"','"+medico.getNumContacto()+"')";
            int rs = statement.executeUpdate(insertaMedico);
        }catch(SQLException ex){
            Logger.getLogger(DAOMedico.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
    }
    
    public static void deleteTrata(String dni) throws SQLException{
        Statement statement = con.createStatement();
        
        String delete = "DELETE FROM trata WHERE dni_medico LIKE '"+dni+"'";
        int rs = statement.executeUpdate(delete);
    }
    
    public static void medicoDelete(String dni){
        Statement statement = null;
        conectar();
        try{
            deleteTrata(dni);
            statement = con.createStatement();
            String deleteMedico = "DELETE FROM medico WHERE dni LIKE '"+dni+"';";
            int rs = statement.executeUpdate(deleteMedico);
        }catch(SQLException ex){
            Logger.getLogger(DAOMedico.class.getName()).log(Level.SEVERE, null, ex);
        }
        desconectar();
    }
    
    public static void putPass(String dni, String pass){
        Statement statement = null;
        conectar();
        try{
            String sentencia = "UPDATE medico SET contrasenya = '"+pass+"' WHERE dni LIKE '"+dni+"'";
            statement = con.createStatement();
            int rs = statement.executeUpdate(sentencia);
            
        }catch(SQLException ex){
            Logger.getLogger(DAOPaciente.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}
