using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using RestSharp;
using Newtonsoft.Json;
using gestiMed_Medico.clases;

namespace gestiMed2024.servicios
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
        public Habitacion getHabitacion(string numero)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/num/" + numero, Method.Get);
            var response = client.Execute(request);
            Habitacion habitacion = JsonConvert.DeserializeObject<Habitacion>(response.Content);
            return habitacion;
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
        public RestResponse putHabitacion(string numero, int numCamas)
        {
            string ruta2 = numero + "/" + numCamas;
            var client = new RestClient(ruta);
            var request = new RestRequest("/putHab/" + ruta2, Method.Delete);
            var response = client.Put(request);
            return response;
        }
    }
}
