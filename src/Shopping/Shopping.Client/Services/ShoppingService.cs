using Microsoft.AspNetCore.Http;
using Shopping.Client.Extensions;
using Shopping.Client.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shopping.Client.Services
{
    public class ShoppingService : IShoppingService
    {
        private readonly HttpClient _client;
        //private readonly IHttpClientFactory _httpClientFactory;
        //private readonly IHttpContextAccessor _httpContextAccessor;

        public ShoppingService(HttpClient client) //, IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
           // _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
          //  _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var response = await _client.GetAsync("/api/Product");
            return await response.ReadContentAs<List<Product>>();
        }
    }
}
