using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppClimaAPI.Model;
using AppClimaAPI.Services;
using AppClimaAPI.View;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppClimaAPI.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaInicial : ContentView 
    {
        public PaginaInicial()
        {
            InitializeComponent();
            // this.Title = "Previsão do Tempo";
            this.BindingContext = new Clima();
        }

        private async void btnPrevisao_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(cidadeEntry.Text))
                {
                    Clima previsaoDoClima = await DataService.GetPrevisaoDoClima(cidadeEntry.Text);
                    this.BindingContext = previsaoDoClima;
                    btnPrevisao.Text = "Nova Previsão";
                }
            }
            catch (Exception ex)
            {
                // await DisplayAlert("Erro ", ex.Message, "Ok");
            }

        }
    }
}