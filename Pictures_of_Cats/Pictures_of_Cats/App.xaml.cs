﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace Pictures_of_Cats
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            NavigationService.Configure("LoginPage", typeof(LoginPage));
            NavigationService.Configure("GalleryPage", typeof(GalleryPage));
            NavigationService.Configure("DetailPage", typeof(DetailPage));
            var mainPage = ((ViewNavigationService) NavigationService).SetRootPage("LoginPage");

            MainPage = mainPage;
        }
        public static INavigationService NavigationService { get; } = new ViewNavigationService();

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}