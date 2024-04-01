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
    class MedicoService
    {
        private string ruta;

        public MedicoService()
        {
            ruta = "http://localhost:8085/gestiMed2024/gestimed2024/medico";

        }
        public ListaMedico GetAllMedicos()
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("",Method.Get);
            var response = client.Execute(request);
            ListaMedico medicosCollection = JsonConvert.DeserializeObject<ListaMedico>(response.Content);
            return medicosCollection;
        }
        public ObservableCollection<Medico> getMedico(string dni)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/dni/" + dni, Method.Get);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<ObservableCollection<Medico>>(response.Content);
        }
        public RestResponse postMedico(Medico medico)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/nuevo", Method.Post);
            string datos = JsonConvert.SerializeObject(medico);
            request.AddParameter("application/json", datos, ParameterType.RequestBody);
            var response = client.Execute(request);
            return response;
        }
        public RestResponse deleteMedico(string dni)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/delete/" + dni, Method.Delete);
            var response = client.Execute(request);
            return response;
        }
    }
}
