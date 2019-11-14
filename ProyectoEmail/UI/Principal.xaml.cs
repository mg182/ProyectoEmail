using ProyectoEmail.UI.BD;
using ProyectoEmail.UI.Facultades;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoEmail.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : MasterDetailPage
    {
        public Principal()
        {
            InitializeComponent();
        }
         
        public void MyMenu()
        {
            Detail = new NavigationPage(new Feed());
            List<Menu> menu = new List<Menu>
            {
                new Menu {Page= new Usuarios(), Title="Usuarios", Menudetail="Agregar correos", Icon="icons/users.png"},
                new Menu {Page= new Favoritos(), Title="Favoritos", Menudetail="Agregar a favoritos", Icon="icons/coord_fav.png"},
                new Menu {Page= new Conta(),Title="Contaduria", Menudetail="Campus I", Icon="icons/contaduria.png"},
                new Menu {Page= new Cqb(),Title="Ciencias Quimico Biologicas", Menudetail="Campus V", Icon="icons/cqb.png"},
                new Menu {Page= new Derecho(),Title="Derecho", Menudetail="Campus I", Icon="icons/derecho.png"},
                new Menu {Page= new Enfermeria(),Title="Enfermeria", Menudetail="Campus III", Icon="icons/enfermeria.png"},
                new Menu {Page= new Humanidades(),Title="Humanidades", Menudetail="Campus I", Icon="icons/humanidades.png"},
                new Menu {Page= new Inge(),Title="Ingenieria", Menudetail="Campus v", Icon="icons/ingenieria.png"},
                new Menu {Page= new Medicina(),Title="Medicina", Menudetail="Campus III", Icon="icons/medicina.png"},
                new Menu {Page= new Odontologia(),Title="Odontologia", Menudetail="Campus I", Icon="icons/odontologia.png"},
                new Menu {Page= new Sociales(),Title="Sociales", Menudetail="Campus I", Icon="icons/sociales.png"}
            };
        }

        public class Menu
        {
            public string Title
            {
                get;
                set;
            }

            public string Menudetail
            {
                get;
                set;
            } 

            public ImageSource Icon
            {
                get;
                set;
            }

            public Page Page
            {
                get;
                set;
            }
        }

        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if (menu!=null)
            {
                IsPresented = false;
                Detail = new NavigationPage(menu.Page);

            }

        }
    }
}