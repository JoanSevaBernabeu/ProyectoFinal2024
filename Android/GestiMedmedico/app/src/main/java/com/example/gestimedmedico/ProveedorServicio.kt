package com.example.gestimedmedico

import retrofit2.Response
import retrofit2.http.GET
import retrofit2.http.Header
import retrofit2.http.Headers
import retrofit2.http.Path

interface ProveedorServicio {
    @GET("medico")
    @Headers("Accept: application/json","Content-Type: application/json")
    suspend fun getAllMedicos():Response<ArrayList<Medico>>

    @GET("medico/dni/{dni}")
    @Headers("Accept: application/json","Content-Type: application/json")
    suspend fun getMedicos(@Path("dni") dni: String):Response<Medico>

    @GET("paciente")
    @Headers("Accept: application/json","Content-Type: application/json")
    suspend fun getAllPacientes():Response<ArrayList<Paciente>>

    @GET("paciente/sip/{sip}")
    @Headers("Accept: Application/json","Content-Type: application/json")
    suspend fun getPaciente(@Path("sip") sip: String):Response<Paciente>
}