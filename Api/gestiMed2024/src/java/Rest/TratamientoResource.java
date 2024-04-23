/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Rest;

import Clases.Tratamiento;
import DAO.DAOTratamiento;
import Listas.ListaTratamiento;
import javax.ws.rs.Consumes;
import javax.ws.rs.DELETE;
import javax.ws.rs.GET;
import javax.ws.rs.POST;
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
@Path("tratamiento")
public class TratamientoResource {
    @Context
    private UriInfo context;

    public TratamientoResource() {
    }
    
    @GET
    @Produces({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    public Response getAllTratamientos(){
        Response response;
        
        ListaTratamiento lista = DAOTratamiento.getTratamientos();
        response = Response.status(Response.Status.OK).entity(lista.getLista()).build();
        
        return response;
    }
    
    @GET
    @Path("tratamiento/{nombre}")
    @Produces({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    public Response getTratamiento(@PathParam("nombre") String nombre){
        Response response;
        
        Tratamiento tratamiento = DAOTratamiento.getTratamiento(nombre);
        response = Response.status(Response.Status.OK).entity(tratamiento).build();
        
        return response;
    }
    @POST
    @Path("nuevo")
    @Consumes(MediaType.APPLICATION_JSON)
    public Response postTratamiento(Tratamiento tratamiento){
        Response response;
        
        DAOTratamiento.tratamientoPost(tratamiento);
        response = Response.status(Response.Status.CREATED).build();
        
        return response;
    }
    
    @DELETE
    @Path("delete/{nombre}")
    @Produces({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    public Response deleteTratamiento(@PathParam("nombre") String nombre){
        Response response;
        
        DAOTratamiento.tratamientoDelete(nombre);
        response = Response.status(Response.Status.OK).build();
        return response;
    }
}
