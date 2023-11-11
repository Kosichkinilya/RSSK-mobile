namespace RSSK_mobile;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    private async void ButtonAboutTheApp(object sender, EventArgs e)
    {
        var version = "1.0.0"; // Заменить на фактическую версию приложения
        var message = $"Версия приложения: {version}";

        // Отображение всплывающего уведомления
        await DisplayAlert("Информация о версии", message, "OK");
    }




    // Часто задаваемые вопросы и ответы на них
    private async void ButtonFAQ(object sender, EventArgs e)
    {
        var Hint= "Здесь будут отображаться часто задаваемые вопросы по колледжу, фишкам, и документам, образцы заявлений";
        var message = $" {Hint}";
        await DisplayAlert("В разработке", message, "OK");
       
    }
}