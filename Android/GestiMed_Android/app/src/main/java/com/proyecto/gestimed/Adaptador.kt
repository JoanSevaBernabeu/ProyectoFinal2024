package com.proyecto.gestimed

import android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView

class Adaptador(var pacientes: List<Paciente>,var contexto: Context): RecyclerView.Adapter<HolderPaciente>(),
    View.OnClickListener {
    lateinit var listener: View.OnClickListener
    var posicion: Int = 0
    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): HolderPaciente {
        var view = LayoutInflater.from(parent.context).inflate(R.layout.linea_recycle,parent,false)
        var holder = HolderPaciente(view,0,contexto)
        view.setOnClickListener(this)
        return holder
    }

    override fun onBindViewHolder(holder: HolderPaciente, position: Int) {
        holder.bind(pacientes[position])
        posicion = position
    }

    override fun getItemCount(): Int {
        return pacientes.size
    }

    override fun onClick(p0: View?) {
        listener.onClick(p0)
    }
    fun clickAdaptador(listener: View.OnClickListener){
        this.listener = listener
    }
}