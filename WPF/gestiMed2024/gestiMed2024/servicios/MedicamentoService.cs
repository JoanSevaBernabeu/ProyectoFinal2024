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
    class MedicamentoService
    {
        private string ruta;

        public MedicamentoService()
        {
            ruta = "http://localhost:8085/gestiMed2024/gestimed2024/medicamento";
        }

        public ObservableCollection<Medicamento> getAllMedicamentos()
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("",Method.Get);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<ObservableCollection<Medicamento>>(response.Content);
        }
        public ObservableCollection<Medicamento> getMedicamento(string id)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/id/" + id, Method.Get);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<ObservableCollection<Medicamento>>(response.Content);
        }
        public RestResponse postMedicamento(Medicamento medicamento)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/nuevo", Method.Post);
            string datos = JsonConvert.SerializeObject(medicamento);
            request.AddParameter("application/json", datos, ParameterType.RequestBody);
            var response = client.Execute(request);
            return response;
        }
        public RestResponse deleteMedicamento(string id)
        {
            var client = new RestClient(ruta);
            var request = new RestRequest("/delete/" + id, Method.Delete);
            var response = client.Execute(request);
            return response;
        }
    }
}
