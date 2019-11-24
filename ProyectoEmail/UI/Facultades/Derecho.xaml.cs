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
    public partial class Derecho : ContentPage
    {
        public Derecho()
        {
            InitializeComponent();
            lder.ItemsSource = new List<Coordinador>()
            {
               new Coordinador() { nombrec="Licda. Maricela del S. Aguayo González",carrera="Lic en Derecho", email="msaguayo@uacam.mx"}

            };
        }
    }
}