using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using gestiMed_Medico.clases;

namespace gestiMed_Medico.servicios
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
            var request = new RestRequest("", Method.Get);
            var response = client.Execute(request);
            List<Tratamiento> lista = JsonConvert.DeserializeObject<List<Tratamiento>>(response.Content);
            return lista;
        }
        public Tratamiento getTratamiento(string nombre)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/tratamiento/" + nombre, Method.Get);
            var response = client.Execute(request);
            Tratamiento tratamiento = JsonConvert.DeserializeObject<Tratamiento>(response.Content);
            return tratamiento;
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
