using RestSharp;

namespace TaskManagementAPITestAutomation.SetUp
{
    public class Context
    {
        string baseUrl = EnvironmentData.baseUrl;        
        public string content = string.Empty;
        public string statusCode = string.Empty;

        public void GetMethod(string resource)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.GET);
            var result = client.Execute(request);
            content = result.Content;
            statusCode = result.StatusCode.ToString();
        }

        public void PostMethod(string resource, object body)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(body);
            request.AddHeader("Content-Type", "application/json");
            var result = client.Execute(request);
            statusCode = result.StatusCode.ToString();
        }

        public void PutMethod(string resource, object body)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(body);
            request.AddHeader("Content-Type", "application/json");
            var result = client.Execute(request);
            statusCode = result.StatusCode.ToString();
        }

        public void DeleteMethod(string resource)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.DELETE);
            var result = client.Execute(request);
            statusCode = result.StatusCode.ToString();
        }
    }
}
