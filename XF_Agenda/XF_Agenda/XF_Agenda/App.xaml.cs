﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Agenda.Views;

namespace XF_Agenda
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ContatosPage();
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
