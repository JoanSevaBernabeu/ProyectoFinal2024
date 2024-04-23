package com.example.gestimedmedico

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.activity.viewModels
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import retrofit2.Response
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory
import java.util.*
import kotlin.collections.ArrayList

class MainActivity : AppCompatActivity() {

    val model: PacienteModel by viewModels()
    private var listaPacientes = ArrayList<Paciente>()
    private var listaMedicos = ArrayList<Medico>()
    private var adaptadorApi: AdaptadorApi = AdaptadorApi()

    override fun onCreate(savedInstanceState: Bundle?) {
        model.setContxto(this)
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        /*



        getPacientes()
        getMedicos()
        model.setListaPacientes(listaPacientes)
        model.setListaMedicos(listaMedicos)

         */
    }

    private fun getPacientes(){
        CoroutineScope(Dispatchers.Main).launch {
            listaPacientes = adaptadorApi.cargarPacientes().await()
        }
    }
    private fun getMedicos(){
        CoroutineScope(Dispatchers.Main).launch {
            listaMedicos = adaptadorApi.cargarMedicos().await()
        }
    }

    private fun addMedicos(): ArrayList<Medico>{
        var medicos = ArrayList<Medico>()
        medicos.add(Medico("2","2","2","2","2","2","2","2"))
        medicos.add(Medico("2","2","2","2","2","2","2","2"))
        medicos.add(Medico("2","2","2","2","2","2","2","2"))
        return medicos
    }

    private fun addMedicamentos():Medicamento{
        var medicamento = Medicamento("4875917","Mentiritis",100,false,5)
        return medicamento
    }
    private fun addTratamiento(medicamento:Medicamento):Tratamiento{
        var tratamiento = Tratamiento("cagarPadentro","Haser kk al reves","Haser la kk normal",medicamento)
        return tratamiento
    }
/*


 */
}