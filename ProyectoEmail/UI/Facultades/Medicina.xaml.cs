using ProyectoEmail.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoEmail.UI.Facultades
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Medicina : ContentPage
    {
        public Medicina()
        {
            InitializeComponent();
            lmed.ItemsSource = new List<Coordinador>()
            {
                new Coordinador() { nombrec="Dr. Domingo S. Medina Góngora",carrera="Lic en Medico Cirujano",email="dsmedina@uacam.mx"},
                new Coordinador() { nombrec="Mtra. Cecilia Lara Gamboa",carrera="Lic en Nutricion",email="hrodrigu@uacam.mx"},
                new Coordinador() { nombrec="Dr. Eduardo R. de la Gala Guerrero",carrera="Posgrado",email="edgrgala@uacam.mx"}
          


            };
        }
    }
}