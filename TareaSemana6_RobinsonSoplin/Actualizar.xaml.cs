using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSemana6_RobinsonSoplin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Actualizar : ContentPage
    {

        private const string Url = "http://192.168.200.7/moviles/post.php"; //aqui tienes que poner la ip de tu compu
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<TareaSemana6_RobinsonSoplin.Datos> _post;

        public Actualizar()
        {
            InitializeComponent();
        }

        private async void btnGet_Clicked(object sender, EventArgs e)
        {
            var content = await client.GetStringAsync(Url);
            List<Datos> posts = JsonConvert.DeserializeObject<List<TareaSemana6_RobinsonSoplin.Datos>>(content);
            _post = new ObservableCollection<TareaSemana6_RobinsonSoplin.Datos>(posts);


            MyListView.ItemsSource = _post;
        }
    }
}