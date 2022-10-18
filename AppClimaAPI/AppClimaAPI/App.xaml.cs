﻿using AppClimaAPI.View;
using System;
using Xamarin.Forms;
using System.IO;
using Xamarin.Forms.Xaml;

namespace AppClimaAPI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaInicial();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
