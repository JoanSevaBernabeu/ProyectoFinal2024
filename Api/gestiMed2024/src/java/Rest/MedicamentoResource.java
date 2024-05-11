/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Rest;

import Clases.Medicamento;
import DAO.DAOMedicamento;
import Listas.ListaMedicamento;
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
@Path("medicamento")
public class MedicamentoResource {
    @Context
    private UriInfo context;

    public MedicamentoResource() {
    }
    
    @GET
    @Produces({MediaType.APPLICATION_JSON})
    public Response getAllMedicamentos() {
        Response response;
  
        ListaMedicamento lista = DAOMedicamento.getMedicamentos();
        
        response = Response.status(Response.Status.OK).entity(lista.getLista()).build();
        return response;
    }
    
    @GET
    @Path("id/{id}")
    @Produces({MediaType.APPLICATION_JSON})
    public Response getOneMedicamento(@PathParam("id") String id) {
        Response response;
        
        Medicamento med = DAOMedicamento.getMedicamento(id);
        
        response = Response.status(Response.Status.OK).entity(med).build();
        return response;
    }
    
    @POST
    @Path("nuevo")
    @Consumes(MediaType.APPLICATION_JSON)
    public Response postMedicamento(Medicamento medicamento){
        Response response;
        
        DAOMedicamento.postMedicamento(medicamento);
        response = Response.status(Response.Status.CREATED).build();
        return response;
    }
    @DELETE
    @Path("delete/{id}")
    @Produces({MediaType.APPLICATION_JSON})
    public Response deleteMedicamento(@PathParam("id") String id){
        Response response;
        DAOMedicamento.deleteMedicamento(id);
        response = Response.status(Response.Status.OK).build();
        return response;
    }
    
    @PUT
    @Path("put/{id}/{cantidad}")
    @Produces({MediaType.APPLICATION_JSON})
    public Response putCantidad(@PathParam("id") String id, @PathParam("cantidad")int cantidad){
        Response response;
        DAOMedicamento.putMedicamento(id, cantidad);
        response = Response.status(Response.Status.OK).build();
        return response;
    }
}
