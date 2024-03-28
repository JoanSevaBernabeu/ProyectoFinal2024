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
    class PacienteService
    {
        private string ruta;
        public PacienteService()
        {
            ruta = "http://localhost:8085/gestiMed2024/gestimed2024/paciente";

        }
        public ObservableCollection<Paciente> getAllPacientes()
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("",Method.Get);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<ObservableCollection<Paciente>>(response.Content);
        }
        public ObservableCollection<Paciente> getPaciente(string sip)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/sip/" + sip, Method.Get);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<ObservableCollection<Paciente>>(response.Content);
        }
        public RestResponse postPaciente(Paciente paciente)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/nuevo", Method.Post);
            string datos = JsonConvert.SerializeObject(paciente);
            request.AddParameter("application/json", datos, ParameterType.RequestBody);
            var response = client.Execute(request);
            return response;
        }
        public RestResponse deletePaciente(string sip)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/delete/" + sip, Method.Delete);
            var response = client.Execute(request);
            return response;
        }
    }
}
