﻿using gestiMed_Medico.clases;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiMed_Medico.servicios
{
    class HabitacionService
    {
        private string ruta;

        public HabitacionService()
        {
            ruta = "http://localhost:8085/gestiMed2024/gestimed2024/habitacion";
        }

        public List<Habitacion> getAllHabitaciones()
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("", Method.Get);
            var response = client.Execute(request);
            List<Habitacion> habitaciones = JsonConvert.DeserializeObject<List<Habitacion>>(response.Content);
            return habitaciones;
        }
        public List<Habitacion> getHabitacion(string numero)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/num/" + numero, Method.Get);
            var response = client.Execute(request);
            List<Habitacion> habitaciones = JsonConvert.DeserializeObject<List<Habitacion>>(response.Content);
            return habitaciones;
        }
        public RestResponse postHabitacion(Habitacion habitacion)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/nueva", Method.Post);
            string datos = JsonConvert.SerializeObject(habitacion);
            request.AddParameter("application/json", datos, ParameterType.RequestBody);
            var response = client.Execute(request);
            return response;
        }
        public RestResponse deleteHabitacion(string numero)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/delete/" + numero, Method.Delete);
            var response = client.Execute(request);
            return response;
        }
    }
}