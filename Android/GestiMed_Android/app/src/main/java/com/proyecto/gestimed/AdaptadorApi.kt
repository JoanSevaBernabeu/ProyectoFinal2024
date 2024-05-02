package com.proyecto.gestimed

import kotlinx.coroutines.*
// import retrofit2.Response
// import retrofit2.Retrofit
// import retrofit2.converter.gson.GsonConverterFactory

class AdaptadorApi {
    /*
    fun cargarMedicos(): Deferred<ArrayList<Medico>> {
        val proveedorServicio : ProveedorServicio = creaRetrofit()
        var respuesta = ArrayList<Medico>()
        return CoroutineScope(Dispatchers.Main).async {
            val response: Response<ArrayList<Medico>> = proveedorServicio.getAllMedicos()
            if(response.isSuccessful){
                val medicoResponse = response.body()
                if(medicoResponse != null){
                    respuesta = medicoResponse
                }
            }
            respuesta
        }
    }

    fun cargarPacientes(): Deferred<ArrayList<Paciente>> {
        val proveedorServicio: ProveedorServicio = creaRetrofit()
        var respuesta = ArrayList<Paciente>()

        return CoroutineScope(Dispatchers.Main).async {
            val response: Response<ArrayList<Paciente>> = proveedorServicio.getAllPacientes()
            if(response.isSuccessful){
                val pacienteResponse = response.body()
                if(pacienteResponse != null){
                    respuesta = pacienteResponse
                }
            }
            respuesta
        }
    }


    private fun creaRetrofit(): ProveedorServicio{
        val url = "http://192.168.1.128:8081/gestimed/gestimed/"
        val retrofit: Retrofit = Retrofit.Builder().baseUrl(url).addConverterFactory(
            GsonConverterFactory.create()).build()
        return retrofit.create(ProveedorServicio::class.java)
    }

     */
}