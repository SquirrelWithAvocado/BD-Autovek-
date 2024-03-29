﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Excel.App
{
    public static class HttpRequester
    {
        public static string AuthHeader = null;
        private static HttpMessageHandler _handler = new HttpClientHandler();
        private static string _url = "http://127.0.0.1:8080";
        
        public static (HttpResponseMessage, string) Get(string getString)
        {
            var (response, text) = MakeGetRequest(getString);
            
            Console.WriteLine($"Get response: {response.StatusCode} {text}");

            return (response, text);
        }

        private static (HttpResponseMessage, string) MakeGetRequest(string prefix)
        {
            var client = new HttpClient(_handler, false);
            client.DefaultRequestHeaders.Add("Auth", AuthHeader);
            var response = client.GetAsync($"{_url}{prefix}").Result;

            var text = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            client.Dispose();

            return (response, text);
        }

        public static HttpResponseMessage SendPost(string content, string prefix)
        {
            var client = new HttpClient(_handler, false);
            client.DefaultRequestHeaders.Add("Auth", AuthHeader);
            var httpContent = new StringContent(content);
            var postResp = client.PostAsync($"{_url}/{prefix}", httpContent).GetAwaiter().GetResult();
            client.Dispose();   
            
            Console.WriteLine($"Get post response with code: {postResp.StatusCode}");

            return postResp;
        }
    }
}