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
@Path("habitacion")
public class HabitacionResource {
    
    @Context
    private UriInfo context;

    public HabitacionResource() {
    }
    
    @GET
    @Produces({MediaType.APPLICATION_JSON})
    public Response getHabitaciones(){
        Response response;
        ListaHabitaciones lista = DAOHabitacion.obtenerHabitaciones();
        response = Response.status(Response.Status.OK).entity(lista.getLista()).build();
        return response;
    }
    
    @GET
    @Path("num/{numero}")
    @Produces({MediaType.APPLICATION_JSON})
    public Response getHabitacion(@PathParam("numero") String numero){
        Response response;
        Habitacion habitacion = DAOHabitacion.getHabitacion(numero);
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
    
    @PUT
    @Path("put/{numHabitacion}/{numCamasOcu}")
    @Produces({MediaType.APPLICATION_JSON})
    public Response putPacienteUrgencia(@PathParam("numHabitacion") String numHabitacion, @PathParam("numCamasOcu") int numCamasOcu){
        Response response;
        DAOHabitacion.putCamOcupadas(numHabitacion, numCamasOcu);
        response = Response.status(Response.Status.OK).build();
        return response;
    }
}
