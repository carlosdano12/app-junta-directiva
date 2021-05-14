﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using AppJuntaDirectiva.clases;
using AppJuntaDirectiva.dtos;
using System.Text;

namespace AppJuntaDirectiva.comunicaciones
{
    class LoginManager
    {
        const string url = "http://10.0.2.2:3000/api/v1/auth/login";

        private async Task<HttpClient> get()
        {

            HttpClient cliente = new HttpClient();
            cliente.DefaultRequestHeaders.Add("Accept", "application/json");
            return cliente;
        }

        public async Task<ApiResponse> login(string username, string password)
        {
            Login login = new Login()
            {
                username = username,
                password = password,
            };
            HttpClient cliente = await get();
            var response = await cliente.PostAsync(url,
                new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8, "application/json"));
            ApiResponse apiResponse = new ApiResponse();
            apiResponse.code = response.StatusCode.ToString();
            apiResponse.message = await response.Content.ReadAsStringAsync();
            return apiResponse;

        }

    }
}

