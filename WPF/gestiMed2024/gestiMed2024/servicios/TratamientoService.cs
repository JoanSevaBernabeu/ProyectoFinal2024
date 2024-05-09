using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using gestiMed2024.clases;
using RestSharp;
using Newtonsoft.Json;

namespace gestiMed2024.servicios
{
    class TratamientoService
    {
        private string ruta;
        public TratamientoService()
        {
            ruta = "http://localhost:8085/gestiMed2024/gestimed2024/tratamiento";
        }
        public List<Tratamiento> getAllTratamientos()
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("",Method.Get);
            var response = client.Execute(request);
            List<Tratamiento> lista = JsonConvert.DeserializeObject<List<Tratamiento>>(response.Content);
            return lista;
        }
        public List<Tratamiento> getTratamiento(string nombre)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/tratamiento/" + nombre, Method.Get);
            var response = client.Execute(request);
            List<Tratamiento> lista = JsonConvert.DeserializeObject<List<Tratamiento>>(response.Content);
            return lista;
        }
        public RestResponse postTratamiento(Tratamiento tratamiento)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/nuevo", Method.Post);
            string datos = JsonConvert.SerializeObject(tratamiento);
            request.AddParameter("application/json", datos, ParameterType.RequestBody);
            var response = client.Execute(request);
            return response;
        }
        public RestResponse deleteTratamiento(string nombre)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/delete/" + nombre, Method.Delete);
            var response = client.Execute(request);
            return response;
        }
    }
}
