namespace ActividadGit
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Caballos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Caballos());
        }
    }

}
