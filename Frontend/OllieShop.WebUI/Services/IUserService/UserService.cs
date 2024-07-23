﻿using OllieShop.WebUI.Models;

namespace OllieShop.WebUI.Services.IUserService
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserDetailViewModel> GetUserInfoAsync()
        {
            return await _httpClient.GetFromJsonAsync<UserDetailViewModel>("/api/user/getUserInfo");
        }
    }
}
