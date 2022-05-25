using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSemana6_RobinsonSoplin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Put ();//Actualizar(); //aqui pones el nombre de la pantalla que quieres probar// Put,Delete,MainPage,Actualizar
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
