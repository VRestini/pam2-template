namespace PAM_Astronomy.Views;
using PAM_Astronomy.Services;

[QueryProperty(nameof(AstroName), "astroName")]
public partial class AstronomicalBodiesView : ContentPage
{
    string astroName;
    public string AstroName
    {
        get => astroName;
        set
        {
            astroName = value;
        }
    }
    public AstronomicalBodiesView()
    {
        InitializeComponent();
        btnComet.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=comet");
        btnEarth.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=earth");
        btnMoon.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=moon");
        btnSun.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=sun");
    }
}

