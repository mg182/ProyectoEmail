using ProyectoEmail.Modelo;

using System.Collections.Generic;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoEmail.UI.Facultades
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Enfermeria : ContentPage
    {
        public Enfermeria()
        {
            InitializeComponent();
            lenf.ItemsSource = new List<Coordinador>()
            {
                new Coordinador() { nombrec="M.C.E. Juan Carlos García García",carrera="Lic en Enfermeria",email="carlosqx@live.com.mx"},
                new Coordinador() { nombrec="MDM Alba Lucely Matú Pech.",carrera="Lic en Gerontologia",email="alblmatu@uacam.mx"},
                new Coordinador() { nombrec="Dra. Jaqueline Guadalupe Guerrero Ceh",carrera="Lic en Fisioterapia",email="jgguerre@uacam.mx"}


            };
        }
    }
}