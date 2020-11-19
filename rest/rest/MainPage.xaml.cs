using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace rest
{
    public partial class MainPage : ContentPage
    {

        private const string Url = "http://192.168.1.12/Rest/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<rest.Datos> _post;

        public MainPage()
        {
            InitializeComponent();
            get();
        }

        public async void get()
        {
            try
            {
                var content = await client.GetStringAsync(Url);
                List<rest.Datos> posts = JsonConvert.DeserializeObject<List<rest.Datos>>(content);
                _post = new ObservableCollection<rest.Datos>(posts);

                MyListView.ItemsSource = _post;
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "ERROR " + ex.Message, "OK");
            }
        }


        private async void btnGet_Clicked(object sender, EventArgs e)
        {
            
                await Navigation.PushAsync(new InsertarDato());
                //  await Navigation.PopAsync();


        }

        private async void btnDelete_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Delete());


        }

        private async void btnPut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Put());
        }
    }
}
