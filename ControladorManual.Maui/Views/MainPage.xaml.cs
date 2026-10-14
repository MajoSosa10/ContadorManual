using ControladorManual.Maui.Models;

namespace ControladorManual.Maui.Views;

public partial class MainPage : ContentPage
{
    private Contador _contador;
    public MainPage()
	{
		InitializeComponent();
        _contador = new Contador();
        BindingContext = _contador;
	}


    private void OnContarButton_Clicked(object sender, EventArgs e) //manejadores de eventos
    {
        _contador.Contar();
    }

    private void OnReiniciarButton_Clicked(object sender, EventArgs e)
    {
        _contador.Reiniciar();
    }
}