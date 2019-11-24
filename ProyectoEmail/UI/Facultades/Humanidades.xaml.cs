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
    public partial class Humanidades : ContentPage
    {
        public Humanidades()
        {
            InitializeComponent();
            lhum.ItemsSource = new List<Coordinador>()
            {
                new Coordinador() { nombrec="Lic. Adelaida Noemí Alonso Rebolledo",carrera="Lic en Historia",email="analonso@uacam.mx"},
                new Coordinador() { nombrec="Lic. Víctor Felipe Mejía Garrido",carrera="Lic en Literatura",email="vifmejia@uacam.mx"},
                new Coordinador() { nombrec="Mtra. Gladys del Carmen Rodríguez Novelo",carrera="Lic en Psicologia",email="gcrodrig@uacam.mx"}


            };
        }
    }
}