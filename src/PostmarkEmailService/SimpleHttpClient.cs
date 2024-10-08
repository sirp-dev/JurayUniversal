﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PostmarkEmailService
{
    internal class SimpleHttpClient : ISimpleHttpClient
    {
        private HttpClient _client = new HttpClient();

        public SimpleHttpClient(TimeSpan? timeoutLength = null){
            _client.Timeout = timeoutLength ?? TimeSpan.FromSeconds(60);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            return _client.SendAsync(request);
        }

        ~SimpleHttpClient(){
            _client.Dispose();
        }
    }
}
