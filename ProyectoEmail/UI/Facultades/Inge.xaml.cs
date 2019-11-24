using ProyectoEmail.Modelo;
using ProyectoEmail.UI.Transacciones;
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
    public partial class Inge : ContentPage
    {
        public Inge()
        {
            InitializeComponent();
            ling.ItemsSource = new List<Coordinador>()
            {
                new Coordinador() { nombrec="M.A.C. Gabriela Patricia Aldana Narváez",carrera="Lic en Ing Civil y Administración",email="gpaldana@uacam.mx"},
                new Coordinador() { nombrec="Ing. Hugo Rodriguez Lara",carrera="Lic en Mecanica Electrica",email="hrodrigu@uacam.mx"},
                new Coordinador() { nombrec="M.T.E. Nancy G. Ortiz Cuevas",carrera="Lic en Sistemas Computacionales",email="nagortiz@uacam.mx"},
                new Coordinador() { nombrec="Mtro. Héctor Manuel Quej Cosgaya",carrera="Lic en Mecatrónica",email="hecmquej@uacam.mx"},
                new Coordinador() { nombrec="Mtro. Héctor Manuel Quej Cosgaya",carrera="Lic en Tecnologia de Software",email="hecmquej@uacam.mx"},
                new Coordinador() { nombrec="correotest",carrera="Lic en Psicología", email="al052298@uacam.mx"}


            };
        }

        private void ling_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var email = (Coordinador)e.SelectedItem;
            var correo = email.email;

            try
            {
                Navigation.PushAsync(new EnviarCorreo(correo));
            }
            catch (Exception)
            {
                throw;
            } 


        }
    }
}