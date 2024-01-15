namespace CinebookAppAA;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnTapped(object? sender, TappedEventArgs e)
    {
        Navigation.PushModalAsync(new CartPage());
    }

    private void OnTappedQA(object? sender, TappedEventArgs e)
    {
        Navigation.PushModalAsync(new QAPage());
    }
}