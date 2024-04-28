package com.proyecto.gestimed

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.navigation.fragment.NavHostFragment
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView

class RecyclerFragment: Fragment() {
    val model : PacienteModel by activityViewModels()
    override fun onCreateView(
        inflater: LayoutInflater,
        container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        val listaPacientes = model.getListaPacientes()
        val navController = NavHostFragment.findNavController(this)
        val view = inflater.inflate(R.layout.recycler,container,false)
        var recycler = view.findViewById<RecyclerView>(R.id.recycler)
        var adaptador = Adaptador(listaPacientes!!, model.contexto)
        recycler.adapter = adaptador
        adaptador.clickAdaptador{
            var posicion = recycler.getChildAdapterPosition(it)
            model.setPaciente(listaPacientes.get(posicion))
            navController.navigate(R.id.action_recyclerFragment_to_pacienteFragment)
        }

        recycler.layoutManager = LinearLayoutManager(requireActivity(),
            LinearLayoutManager.HORIZONTAL,false)
        return view
    }
}