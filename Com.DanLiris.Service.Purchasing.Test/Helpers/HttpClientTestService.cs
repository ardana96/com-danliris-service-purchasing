﻿using Com.DanLiris.Service.Purchasing.Lib.Helpers;
using Com.DanLiris.Service.Purchasing.Lib.Interfaces;
using Com.DanLiris.Service.Purchasing.Lib.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Com.DanLiris.Service.Purchasing.Test.Helpers
{
    public class HttpClientTestService : IHttpClientService
    {
        public static string Token;

        public Task<HttpResponseMessage> PutAsync(string url, HttpContent content)
        {
            return Task.Run(() => new HttpResponseMessage());
        }
        public Task<HttpResponseMessage> GetAsync(string url)
        {
            return Task.Run(() => new HttpResponseMessage());
        }

        public Task<HttpResponseMessage> PostAsync(string url, HttpContent content)
        {
            return Task.Run(() => new HttpResponseMessage());
        }
    }
}
