using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSemana6_RobinsonSoplin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Put : ContentPage
    {

        const string Url = "http://192.168.200.7/moviles/post.php";

        public Put()
        {
            InitializeComponent();
        }

        private void btnActualizar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = "";
                Datos data = new Datos();
                data.codigo = int.Parse(txtCodigo.Text);
                data.nombre = txtNombre.Text;
                data.apellido = txtApellido.Text;
                data.edad = int.Parse(txtEdad.Text);

                var content = JsonConvert.SerializeObject(data);

                parametros += "?codigo=" + txtCodigo.Text;
                parametros += "&nombre=" + txtNombre.Text;
                parametros += "&apellido=" + txtApellido.Text;
                parametros += "&edad=" + txtEdad.Text;
                var urlCompleta = new Uri(Url + parametros);

                cliente.UploadString(urlCompleta, "PUT", content);

                DisplayAlert("Alerta", "Registro modificado correctamente.", "Ok");

            }
            catch (Exception)
            {

                DisplayAlert("Mensaje de alerta", "Algo Salió Mal", "OK");
            }
        }
    }
}