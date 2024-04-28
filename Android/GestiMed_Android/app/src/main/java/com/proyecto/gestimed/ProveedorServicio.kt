package com.proyecto.gestimed

interface ProveedorServicio {
    @GET("medico")
    @Headers("Accept: application/json","Content-Type: application/json")
    suspend fun getAllMedicos():Response<ArrayList<Medico>>

    @GET("medico/dni/{dni}")
    @Headers("Accept: application/json","Content-Type: application/json")
    suspend fun getMedico(@Path("dni") dni: String):Response<Medico>

    @GET("paciente")
    @Headers("Accept: application/json","Content-Type: application/json")
    suspend fun getAllPacientes():Response<ArrayList<Paciente>>

    @GET("paciente/sip/{sip}")
    @Headers("Accept: Application/json","Content-Type: application/json")
    suspend fun getPaciente(@Path("sip") sip: String):Response<Paciente>
}