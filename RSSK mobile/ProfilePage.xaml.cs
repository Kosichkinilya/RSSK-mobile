using Android.App;
using System.Security.Cryptography.X509Certificates;

namespace RSSK_mobile;

public partial class ProfilePage : ContentPage
{
    public ProfilePage()
    {
        InitializeComponent();
    }

   


    private void Button_Settings(object sender, EventArgs e)
    {
        // Открывает новую страницу при нажатии кнопки
        Navigation.PushAsync(new SettingsPage());

    }
}