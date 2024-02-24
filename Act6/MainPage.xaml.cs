namespace Act6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            fechaNacimiento.MaximumDate = DateTime.Now.AddMonths(-1);
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var años = 0;
            var meses = 0;
            var fecha = fechaNacimiento.Date;
            while (fecha < fechaActual.Date)
            {
                fecha = fecha.AddMonths(1);
                meses++;
                if (meses == 12)
                {
                    años++;
                    meses = 0;
                }
            }
            if((años > 0) || (meses > 0) )
            {
                label.Text = $"Edad: {años} años y {meses} meses";
            }
            else
            {
                await DisplayAlert("Aviso", "La fecha de nacimiento no puede ser mayor a la fecha actual", "Aceptar");
            }
        }
    }

}
