using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
using System.Net.Http;


namespace rest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Put : ContentPage
    {
        public Put()
        {
            InitializeComponent();
        }

        private async void btnRegresar_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MainPage());

            /*  try
              {
                  var url = "http://192.168.1.12/Rest/post.php";
                  HttpClient cliente = new HttpClient();
                  var id = txtActualizar_id.Text;
                  var nombre = txtActualizar_nombre.Text;
                  var apellido = txtActualizar_apellido.Text;
                  var edad = txtActualizar_edad.Text;

                  var uri = new Uri(string.Format(url + "?codigo=" + id+"&"+"?nombre="+nombre+"?apellido="+apellido));

                  var response = await cliente.DeleteAsync(uri);
                  if (response.IsSuccessStatusCode)
                  {
                      await DisplayAlert("alerta", "Actualizado correctamente: ", "ok");

                  }
                  else
                  {
                      await DisplayAlert("alerta", "ERROR:: ", "ok");
                  }

              }
              catch (Exception ex)
              {
                  await DisplayAlert("alerta", "Error: " + ex.Message, "ok");
              }
            */
        }

        
        private async void btnActualizar_Clicked(object sender, EventArgs e)
        {
            
            /*
            string Url = "http://192.168.1.12/Rest/post.php";
            HttpClient httpClient = new HttpClient();
            var builder = new UriBuilder(Url);
            builder.Port = -1;
            var query = HttpUtility.ParseQueryString(builder.Query);

            query["codigo"] = this.modelo.codigo.ToString();
            query["nombre"] = this.modelo.nombre;
            query["apellido"] = this.modelo.apellido;
            query["edad"] = this.modelo.edad;

            builder.Query = query.ToString();
            string url = builder.ToString();


            var consultaSerializada = await httpClient.PutAsync(url, null);
            await App.Current.MainPage.DisplayAlert("Alerta", "Dato Ingresado correctamente", "ok");
            await Application.Current.MainPage.Navigation.PopAsync();


            */
        }

    }
}