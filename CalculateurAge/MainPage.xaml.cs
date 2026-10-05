namespace CalculateurAge;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // Gestionnaire appelé au clic du bouton Calculer.
    private async void OnCalculerClicked(object sender, EventArgs e)
    {
        // Validation : on refuse un nom vide.
        if (string.IsNullOrWhiteSpace(entryNom.Text))
        {
            await DisplayAlertAsync("Erreur", "Entrez un nom.", "OK");
            return; // On sort sans rien calculer
        }

        DateTime d = pickerDate.Date ?? DateTime.Today;
        int age = DateTime.Today.Year - d.Year;

        // Si l'anniversaire n'est pas encore passé cette année,
        // on retire une année.
        if (d.Date > DateTime.Today.AddYears(-age)) age--;

        // On écrit DIRECTEMENT dans les contrôles (Phase A)
        lblResultat.Text = $"{entryNom.Text}, vous avez {age} ans";
        lblResultat.IsVisible = true;
    }
}