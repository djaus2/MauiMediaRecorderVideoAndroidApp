﻿namespace MauiCameraViewSample
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("nextpage", typeof(MainPage));
        }
    }
}
