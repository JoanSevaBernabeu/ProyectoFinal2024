/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Rest;

import Clases.Habitacion;
import DAO.DAOHabitacion;
import Listas.ListaHabitaciones;
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
@Path("habitacion")
public class HabitacionResource {
    
    @Context
    private UriInfo context;

    public HabitacionResource() {
    }
    
    @GET
    @Produces({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    public Response getHabitaciones(){
        Response response;
        ListaHabitaciones lista = DAOHabitacion.obtenerHabitaciones();
        response = Response.status(Response.Status.OK).entity(lista.getLista()).build();
        return response;
    }
    
    @GET
    @Path("num/{numero}")
    @Produces({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    public Response getHabitacion(@PathParam("numero") Short numero){
        Response response;
        String id = numero.toString();
        Habitacion habitacion = DAOHabitacion.getHabitacion(id);
        response = Response.status(Response.Status.OK).entity(habitacion).build();
        return response;
    }
    
    @POST
    @Path("nueva")
    @Consumes(MediaType.APPLICATION_JSON)
    public Response postHabitacion(Habitacion habitacion){
        Response response = null;
        
        DAOHabitacion.postHabitacion(habitacion);
        response = Response.status(Response.Status.CREATED).build();
        return response;
    }
    
    @DELETE
    @Path("delete/{numHabitacion}")
    @Produces({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    public Response deleteHabitacion(@PathParam("numHabitacion") String numHabitacion){
        Response response;
        DAOHabitacion.deleteHabitacion(numHabitacion);
        response = Response.status(Response.Status.OK).build();
        return response;
    }
}
