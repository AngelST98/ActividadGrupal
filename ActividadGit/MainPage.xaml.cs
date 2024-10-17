namespace ActividadGit
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Blazer(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Blazer());
        }
    }

}
