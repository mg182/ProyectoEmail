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
    public partial class Odontologia : ContentPage
    {
        public Odontologia()
        {
            InitializeComponent();
            lodo.ItemsSource = new List<Coordinador>()
            {
                new Coordinador() { nombrec="M. en C. Verónica López Torres",carrera="Lic en Odontologia",email="verlopez@uacam.mx"}
               


            }; 

        }
    }
}