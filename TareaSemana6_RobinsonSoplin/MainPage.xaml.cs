using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaSemana6_RobinsonSoplin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnInsertar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection(); // Contenedor tipo vector JSON
                // Datos a enviar al POST - Insertar 
                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);

                client.UploadValues("http://192.168.200.7/moviles/post.php", "POST", parametros);
                DisplayAlert("Mensaje de Alerta", "Ingreso correcto", "ok");


            }
            catch (Exception ex )       {

                DisplayAlert("Mensaje de Alerta",ex.Message,"ok");
            }
        }

        private void btnIsertar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Clicked(object sender, EventArgs e)
        {

        }
    }
}
