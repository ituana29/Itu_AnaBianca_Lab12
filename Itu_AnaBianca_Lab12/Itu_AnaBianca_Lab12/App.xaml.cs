﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Itu_AnaBianca_Lab12
{
    public partial class App : Application
    {
        public static object Database { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
