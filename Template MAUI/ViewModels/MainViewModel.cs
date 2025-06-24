using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace Template_MAUI.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double a;

        [ObservableProperty]
        private double b;

        [ObservableProperty]
        private double suma;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {
            try
            {
                if (A == 0)
                {
                    Alerta("ADVERTENCIA", "Valor de a, no puede ser igual a cero");
                }
                else
                {
                    Suma = A + B;
                    
                    Alerta("Resultado de la Suma", $"La suma es: {Suma}");
                }
            }
            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            A = 0;
            B = 0;
            Suma = 0;
        }
    }
}