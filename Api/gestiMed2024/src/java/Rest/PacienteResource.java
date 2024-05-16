/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Rest;

import Clases.Paciente;
import DAO.DAOPaciente;
import Listas.ListaPaciente;
import java.util.HashMap;
import javax.ws.rs.Consumes;
import javax.ws.rs.DELETE;
import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.PUT;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.Produces;
import javax.ws.rs.core.Context;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;
import javax.ws.rs.core.Response.Status;
import javax.ws.rs.core.UriInfo;

/**
 *
 * @author joans
 */
@Path("paciente")
public class PacienteResource {
    @Context
    private UriInfo context;

    public PacienteResource() {
    }
    
    @GET
    @Produces({MediaType.APPLICATION_JSON})
    public Response getAllPacientes(){
        Response response;
        
        ListaPaciente lista = DAOPaciente.getPacientes();
        response = Response.status(Response.Status.OK).entity(lista.getLista()).build();
        
        return response;
    }
    
    @GET
    @Path("sip/{sip}")
    @Produces({MediaType.APPLICATION_JSON})
    public Response getOnePaciente(@PathParam("sip") String sip){
        Response response;
        Paciente paciente = DAOPaciente.getPaciente(sip,true);
        response = Response.status(Response.Status.OK).entity(paciente).build();
        return response;
    }
    
    @POST
    @Path("nuevo")
    @Consumes(MediaType.APPLICATION_JSON)
    public Response postPaciente(Paciente paciente){
        Status status;
        HashMap<String, String> mensaje = new HashMap<>();
        
        try{
            DAOPaciente.pacientePost(paciente);
            status = Response.Status.CREATED;
            mensaje.put("mensaje", String.format("Paciente %s añadido correctamente", paciente.getSip()));
        }catch(Exception e){
            status = Response.Status.INTERNAL_SERVER_ERROR;
            mensaje.put("mensaje", String.format("Error añadiendo paciente %s: %s", paciente.getSip(), e.getLocalizedMessage()));
        }
        
        return Response.status(status).entity(mensaje).build();
    }
    
    @DELETE
    @Path("delete/{sip}")
    @Produces({MediaType.APPLICATION_JSON})
    public Response deletePaciente(@PathParam("sip") String sip){
        Response response;
        
        DAOPaciente.pacienteDelete(sip);
        response = Response.status(Response.Status.OK).build();
        return response;
    }
    
    @PUT
    @Path("putHab/{sip}/{habitacion}")
    @Produces({MediaType.APPLICATION_JSON})
    public Response putPacienteHabitacion(@PathParam("sip") String sip, @PathParam("habiacion") String habiacion){
        Response response;
        
        DAOPaciente.putHabitacion(sip, habiacion);
        response = Response.status(Response.Status.OK).build();
        return response;
    }
    
    @PUT
    @Path("putTrat/{sip}/{tratamiento}")
    @Produces({MediaType.APPLICATION_JSON})
    public Response putPacienteTratamiento(@PathParam("sip") String sip, @PathParam("tratamiento") String tratamiento){
        Response response;
        
        DAOPaciente.putTratamiento(sip, tratamiento);
        response = Response.status(Response.Status.OK).build();
        return response;
    }
    
    @PUT
    @Path("putUrg/{sip}/{urgencia}")
    @Produces({MediaType.APPLICATION_JSON})
    public Response putPacienteUrgencia(@PathParam("sip") String sip, @PathParam("urgencia") String urgencia){
        Response response;
        
        DAOPaciente.putUrgencia(sip, urgencia);
        response = Response.status(Response.Status.OK).build();
        return response;
    }
}
