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
    public partial class Cqb : ContentPage
    {
        public Cqb()
        {
            InitializeComponent();
            lcqb.ItemsSource = new List<Coordinador>()
            {
                new Coordinador() { nombrec="QFB. Geovani Araceli Salinas ",carrera="Lic en QFB",email="gasalina@uacam.mx"},
                new Coordinador() { nombrec="Mtro. Juan Gabriel Aldana Perera",carrera="Lic en Biologia",email=" jgaldana@uacam.mx"},
                new Coordinador() { nombrec="M. en C. Primavera García Pérez",carrera="Bioquimico Ambiental",email="prgarcia@uacam.mx"}


            };
        }
    }
}