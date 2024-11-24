namespace MauiAppConvertisseur
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnCelsiusToFahrenheit(object sender, EventArgs e)
        {
            if (double.TryParse(celsiusEntry.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                fahrenheitLabel.Text = $"{fahrenheit:F1} °F";
            }
            else
            {
                DisplayAlert("Erreur", "Veuillez entrer une valeur valide pour °C.", "OK");
            }
        }
        private void OnFahrenheitToCelsius(object sender, EventArgs e)
        {
            if (double.TryParse(fahrenheitEntry.Text, out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                celsiusLabel.Text = $"{celsius:F1} °C";
            }
            else
            {
                DisplayAlert("Erreur", "Veuillez entrer une valeur valide pour °F.", "OK");
            }
        }

    }
}
