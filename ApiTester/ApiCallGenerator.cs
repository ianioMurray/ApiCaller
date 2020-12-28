using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ApiTester
{
    public enum CallType
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    static class ApiCallGenerator
    {
        static HttpClient client;
        public static string Output
        {
            get; private set;
        }

        public static async Task ApiCall(string baseUrl, string additionalUrl, string authToken, CallType typeOfCall, string requestBody)
        {
            client = new HttpClient();
            await MakeApiCall(baseUrl, additionalUrl, authToken, typeOfCall, requestBody);
            string val = Output;
        }

        static async Task MakeApiCall(string baseUrl, string additionalUrl, string authToken, CallType typeOfCall, string requestBody)
        {
            Output = "";
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if(!String.IsNullOrEmpty(authToken))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
            }

            try
            {
                switch (typeOfCall)
                {
                    case CallType.GET:
                        {
                            Output = await MakeGetCallAsync(additionalUrl);
                            break;
                        }
                    case CallType.POST:
                        {
                            Output = await MakePostCallAsync(additionalUrl, requestBody);
                            break;
                        }
                    case CallType.PUT:
                        {
                            Output = await MakePutCallAsync(additionalUrl, requestBody);
                            break;
                        }
                    case CallType.DELETE:
                        {
                            Output = await MakeDeleteCallAsync(baseUrl + additionalUrl, requestBody);
                            break;
                        }
                }
            }
            catch (Exception e)
            {
                Output = e.Message;
            }
        }

        //GET Method
        static async Task<string> MakeGetCallAsync(string path)
        {
            string output = "";
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                var returnedProduct = await response.Content.ReadAsStringAsync();
                output = returnedProduct.ToString();
            }
            else
            {
                output = ApiCallSuccessOrFailureMessage(false, (int)response.StatusCode, response.StatusCode.ToString());
            }

            return output;
        }

        //POST Method
        static async Task<string> MakePostCallAsync(string path, string requestBody)
        {
            string output = "";
            HttpContent content = GetContent(requestBody);

            var response = await client.PostAsync(path, content).ConfigureAwait(false);

            if(response.IsSuccessStatusCode)
            {
                output = ApiCallSuccessOrFailureMessage(true, (int)response.StatusCode, response.StatusCode.ToString());
            }
            else
            {
                output = ApiCallSuccessOrFailureMessage(false, (int)response.StatusCode, response.StatusCode.ToString());
            }

            return output;
        }

        //PUT method 
        static async Task<string> MakePutCallAsync(string path, string requestBody)
        {
            string output = "";
            HttpContent content = GetContent(requestBody);

            var response = await client.PutAsync(path, content);

            if (response.IsSuccessStatusCode)
            {
                output = ApiCallSuccessOrFailureMessage(true, (int)response.StatusCode, response.StatusCode.ToString());
            }
            else
            {
                output = ApiCallSuccessOrFailureMessage(false, (int)response.StatusCode, response.StatusCode.ToString());
            }

            return output;
        }

        //DELETE Method
        static async Task<string> MakeDeleteCallAsync(string path, string requestBody)
        {
            string output = "";
            HttpContent content = GetContent(requestBody);

            HttpResponseMessage response = await client.DeleteAsJsonAsync(path, content);
            if (response.IsSuccessStatusCode)
            {
                output = ApiCallSuccessOrFailureMessage(true, (int)response.StatusCode, response.StatusCode.ToString());
            }
            else
            {
                output = ApiCallSuccessOrFailureMessage(false, (int)response.StatusCode, response.StatusCode.ToString());
            }

            return output;
        }

        //Helper methods
        static string ApiCallSuccessOrFailureMessage(bool wasSuccessful, int responseCode, string responseMessage)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("The API call ");
            
            if(wasSuccessful)
            {
                sb.Append("was successful");
            }
            else
            {
                sb.Append("FAILED");
            }

            sb.Append(" - the returned HTML status was " + responseCode + " - " + responseMessage);

            return sb.ToString();
        }

        static HttpContent GetContent(string requestBody)
        {
            HttpContent content;
            if (String.IsNullOrEmpty(requestBody))
            {
                content = null;
            }
            else
            {
                var myContent = JsonConvert.SerializeObject(requestBody);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                List<byte> characterList = buffer.ToList();
                characterList.RemoveAll(b => b == 92);
                characterList.RemoveAll(b => b == 32);
                characterList.RemoveAt(characterList.Count - 1);
                characterList.RemoveAt(0);
                buffer = characterList.ToArray();

                content = new ByteArrayContent(buffer);
            }
            return content;
        }






        //If you wanted to fill the contents of an object with the return from an API call below are some examples.
        //I have not used them as the API caller is generic so knowing what the object the API will be returned will look like would be very difficult 
        //This code could be used if the object returned was of a know type - it is set to use a Product so this would need to be changed for the 
        //object being returned


        //static async Task<Uri> MakePostCallAsync(Product product)
        //{
        //    var myContent = JsonConvert.SerializeObject(product);
        //    var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
        //    var byteContent = new ByteArrayContent(buffer);
        //    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        //    var url = "api/products/" + product.Id;
        //    var response = await client.PostAsync(url, byteContent).ConfigureAwait(false);

        //    //throws an exception if IsSuccessStatusCode would be false (not HTML response between 200 and 299)
        //    response.EnsureSuccessStatusCode();

        //    // return URI of the created resource.
        //    return response.RequestMessage.RequestUri;
        //}

        //static async Task<T> MakeGetCallAsync<T>(T input , string path)
        //{
        //    HttpResponseMessage response = await client.GetAsync(path);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var returnedProduct = await response.Content.ReadAsStringAsync();
        //        //deserializer is required to turn the item into an object - not required if it will be output as a string
        //        input = JsonConvert.DeserializeObject<T>(returnedProduct);
        //    }
        //    return input;
        //}
    }
}
