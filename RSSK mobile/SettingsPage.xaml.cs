namespace RSSK_mobile;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    private async void ButtonAboutTheApp(object sender, EventArgs e)
    {
        var version = "1.0.0"; // �������� �� ����������� ������ ����������
        var message = $"������ ����������: {version}";

        // ����������� ������������ �����������
        await DisplayAlert("���������� � ������", message, "OK");
    }




    // ����� ���������� ������� � ������ �� ���
    private async void ButtonFAQ(object sender, EventArgs e)
    {
        var Hint= "����� ����� ������������ ����� ���������� ������� �� ��������, ������, � ����������, ������� ���������";
        var message = $" {Hint}";
        await DisplayAlert("� ����������", message, "OK");
       
    }
}