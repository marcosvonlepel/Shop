﻿namespace Shop.UIForms.ViewModels
{
    using System.Windows.Input;
    using Xamarin.Forms;
    using GalaSoft.MvvmLight.Command;
    using Views;
    public class LoginViewModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand => new RelayCommand(Login);

        public LoginViewModel()
        {
            this.Email = "marcosvonlepel@hotmail.com";
            this.Password = "123456";
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter an email", "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter a password", "Accept");
                return;
            }

            if (!this.Email.Equals("marcosvonlepel@hotmail.com") || !this.Password.Equals("123456"))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Incorrect user or password", "Accept");
                return;
            }
            MainViewModel.GetInstance().Products = new ProductsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ProductsPage());
        }
    }

}
