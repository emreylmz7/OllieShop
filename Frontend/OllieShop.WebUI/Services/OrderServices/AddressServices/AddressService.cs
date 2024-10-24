﻿using OllieShop.DtoLayer.OrderDtos.Address;
using OllieShop.WebUI.Services.OrderServices.AddressServices;
using System.Net;

namespace OllieShop.WebUI.Services.CatalogServices.AddressServices
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient _httpClient;

        public AddressService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> CreateAddressAsync(CreateAddressDto createAddressDto)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync("addresses", createAddressDto);
            responseMessage.EnsureSuccessStatusCode();
            return responseMessage;
        }

        public async Task<HttpResponseMessage> DeleteAddressAsync(string id)
        {
            var responseMessage = await _httpClient.DeleteAsync($"addresses?id={id}");
            responseMessage.EnsureSuccessStatusCode();
            return responseMessage;
        }

        public async Task<List<ResultAddressDto>> GetAllAddressAsync()
        {
            var responseMessage = await _httpClient.GetAsync("addresses");
            if (responseMessage.IsSuccessStatusCode)
            {
                var addresses = await responseMessage.Content.ReadFromJsonAsync<List<ResultAddressDto>>();
                return addresses ?? new List<ResultAddressDto>();
            }
            return new List<ResultAddressDto>();
        }

        public async Task<GetByIdAddressDto?> GetByIdAddressAsync(string id)
        {
            var responseMessage = await _httpClient.GetAsync($"addresses/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var address = await responseMessage.Content.ReadFromJsonAsync<GetByIdAddressDto>();
                return address;
            }
            return null;
        }

        public async Task<HttpResponseMessage> UpdateAddressAsync(UpdateAddressDto updateAddressDto)
        {
            var responseMessage = await _httpClient.PutAsJsonAsync("addresses", updateAddressDto);
            responseMessage.EnsureSuccessStatusCode();
            return responseMessage;
        }
    }
}
