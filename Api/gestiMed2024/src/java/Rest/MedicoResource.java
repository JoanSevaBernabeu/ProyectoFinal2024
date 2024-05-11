/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Rest;

import Clases.Medico;
import DAO.DAOMedico;
import Listas.ListaMedico;
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
import javax.ws.rs.core.UriInfo;

/**
 *
 * @author joans
 */
@Path("medico")
public class MedicoResource {
    @Context
    private UriInfo context;

    public MedicoResource() {
    }

    @GET
    @Produces({MediaType.APPLICATION_JSON})
    public Response getAllMedicos() {
        Response response;

        ListaMedico med = DAOMedico.getMedicos();
        
        response = Response.status(Response.Status.OK).entity(med.getLista()).build();
        return response;
    }
    
    @GET
    @Path("dni/{dni}")
    @Produces({MediaType.APPLICATION_JSON})
    public Response getMedico(@PathParam("dni") String dni){
        Response response;
        
        Medico med = DAOMedico.getMedico(dni,true);
        
        response = Response.status(Response.Status.OK).entity(med).build();
        return response;
    }
    @POST
    @Path("nuevo")
    @Consumes(MediaType.APPLICATION_JSON)
    public Response postMedico(Medico medico){
        Response response;
        
        DAOMedico.medicoPost(medico);
        response = Response.status(Response.Status.CREATED).build();
        return response;
    }
    @DELETE
    @Path("delete/{dni}")
    @Produces({MediaType.APPLICATION_JSON})
    public Response deleteMedico(@PathParam("dni") String dni){
        Response response;
        
        DAOMedico.medicoDelete(dni);
        response = Response.status(Response.Status.OK).build();
        return response;
    }
    
    @PUT
    @Path("put/{dni}/{pass}")
    @Produces({MediaType.APPLICATION_JSON})
    public Response putPacienteUrgencia(@PathParam("dni") String dni, @PathParam("pass") String pass){
        Response response;
        
        DAOMedico.putPass(dni, pass);
        response = Response.status(Response.Status.OK).build();
        return response;
    }
}
