

using ProyectoEmail.Modelo;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoEmail.UI.Facultades
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conta : ContentPage
    {
        
        public Conta()
        {
            InitializeComponent();
            lcontaduria.ItemsSource = new List<Coordinador>()
            {
                new Coordinador() { nombrec="C.P. Carlos Enrique Cruz Mora",carrera="Lic en Contaduria",email="carecruz@uacam.mx"},
                new Coordinador() { nombrec="C.P. Carlos Iván Mut Coyoc",carrera="Lic Administracion y Finanzas",email="carecruz@uacam.mx"}
                



            };

        } 

       

    }
}