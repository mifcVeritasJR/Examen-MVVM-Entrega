﻿using Examen_MVVM.ViewModels;

namespace Examen_Mvvm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}