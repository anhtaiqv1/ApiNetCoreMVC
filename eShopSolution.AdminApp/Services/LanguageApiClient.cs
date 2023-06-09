﻿using eShopSolution.ViewModel.Common;
using eShopSolution.ViewModel.System.Languages;
using eShopSolution.ViewModel.System.Roles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace eShopSolution.AdminApp.Services
{
    public class LanguageApiClient : BaseApiClient, ILanguageApiClient
    {
     

        public LanguageApiClient(IHttpClientFactory httpClientFactory
            , IConfiguration configuration, 
            IHttpContextAccessor httpContextAccessor) :base(httpClientFactory,configuration , httpContextAccessor) 

        {
            
        }


        public async Task<ApiResult<List<LanguageVm>>> GetAll()
        {
            return await GetAsync<ApiResult<List<LanguageVm>>>("/api/languages");
        }
    }
}
