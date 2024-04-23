package com.example.gestimedmedico

import android.content.Context
import android.graphics.Color
import android.view.View
import android.widget.LinearLayout
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView

class HolderPaciente(itemView:View, i:Int, contexto: Context): RecyclerView.ViewHolder(itemView), View.OnClickListener{
    lateinit var listenerOnClick:View.OnClickListener
    private var nombre: TextView
    private var apellidos: TextView
    private var sip: TextView
    private var linear: LinearLayout
    init {
        nombre = itemView.findViewById(R.id.nombreTextView)
        apellidos = itemView.findViewById(R.id.apellidosTextView)
        sip = itemView.findViewById(R.id.sipTextView)
        linear = itemView.findViewById(R.id.lineaLayout)
    }
    fun bind(paciente: Paciente){
        nombre.text = paciente.nombre
        apellidos.text = paciente.apellidos
        sip.text = paciente.sip
        if(paciente.urgencia.equals("Urgente")){
            linear.setBackgroundColor(Color.parseColor("#800101"))
        }else if(paciente.urgencia.equals("Medio")) {
            linear.setBackgroundColor(Color.parseColor("#B69902"))
        }else{
            linear.setBackgroundColor(Color.parseColor("#428101"))
        }
    }

    override fun onClick(p0: View?) {
        listenerOnClick.onClick(p0)
    }

}