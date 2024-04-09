using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using gestiMed2024.clases;
using RestSharp;
using Newtonsoft.Json;
using gestiMed2024.listas;

namespace gestiMed2024.servicios
{
    class HabitacionService
    {
        private string ruta;

        public HabitacionService()
        {
            ruta = "http://localhost:8085/gestiMed2024/gestimed2024/habitacion";
        }

        public ListaHabitaciones getAllHabitaciones()
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("",Method.Get);
            var response = client.Execute(request);
            ListaHabitaciones habitaciones = JsonConvert.DeserializeObject<ListaHabitaciones>(response.Content);
            return habitaciones;
        }
        public ListaHabitaciones getHabitacion(string numero)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/num/" + numero, Method.Get);
            var response = client.Execute(request);
            ListaHabitaciones habitaciones = JsonConvert.DeserializeObject<ListaHabitaciones>(response.Content);
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
