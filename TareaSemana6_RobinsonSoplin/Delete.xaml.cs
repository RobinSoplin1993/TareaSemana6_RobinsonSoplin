using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSemana6_RobinsonSoplin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Delete : ContentPage
    {
        const string Url = "http://192.168.200.7/moviles/post.php";

        public Delete()
        {
            InitializeComponent();
        }
        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            WebClient cliente = new WebClient();

            string parametros = "";

            parametros += "?codigo=" + txtCodigo.Text;

            var urlCompleta = new Uri(Url + parametros);

            cliente.UploadString(urlCompleta, "DELETE", "");

            DisplayAlert("Alerta", "Registro eliminado satisfactoriamente.", "Ok");

        }


    }
}