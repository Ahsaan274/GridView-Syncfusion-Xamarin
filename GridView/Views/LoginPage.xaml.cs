using Grid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Grid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }
        void Init() {
            BackgroundColor = Constant.BackgroundColor;
            Lbl_username.TextColor = Constant.MainTextColor;
            Lbl_password.TextColor = Constant.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constant.LoginIconHeight;
            Entry_username.Completed += (s, e) => Entry_password.Focus();
            Entry_password.Completed += (s, e) => SignInProcedure(s, e);
        }
        void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_username.Text, Entry_password.Text);
            if (user.Check())
            {
                DisplayAlert("Login", "Login Success", "Oka");
                Navigation.PushAsync(new MainPage());
                
            }
            else
            {
                DisplayAlert("Login", "Not Correct Data", "Oka");
            }

        }
    }
}