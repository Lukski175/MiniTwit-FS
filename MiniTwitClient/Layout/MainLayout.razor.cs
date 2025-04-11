﻿using Microsoft.AspNetCore.Components;
using MiniTwitClient.Authentication;
using MiniTwitClient.Controllers;

namespace MiniTwitClient.Layout
{
    public partial class MainLayout : LayoutComponentBase
    {
        [Inject] public UserState UserState { get; set; }
        [Inject] public NavigationManager Navigation { get; set; }
        [Inject] public MinitwitController Controller { get; set; }

        public async Task Logout()
        {
            await Controller.Logout();
            UserState.LogOut();
        }

        public void MyPage()
        {
            Navigation.NavigateTo("/");
        }
    }
}
