using ProyectoEmail.Interfaces;
using ProyectoEmail.Modelo;
using ProyectoEmail.UI.Transacciones;
using SQLite;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoEmail.UI.BD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Usuarios : ContentPage
    {
        private SQLiteAsyncConnection _conn;
        private ObservableCollection<TablaUsuarios> T_usuarios; 

        public Usuarios()
        {
            InitializeComponent();
            _conn = DependencyService.Get<ISQLiteDB>().GetConnection();
            _conn.CreateTableAsync<TablaUsuarios>();

        }

         private void ListaUsuarios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var obj_id= (TablaUsuarios)e.SelectedItem;
            var item_id = obj_id.id.ToString();
            int ID = Convert.ToInt32(item_id);

            var obj_name = (TablaUsuarios)e.SelectedItem;
            var item_name = obj_name.nombre.ToString();
            String name = item_name;

            var obj_email = (TablaUsuarios)e.SelectedItem;
            var item_email = obj_email.nombre.ToString();
            String email = item_email;

            var obj_pass= (TablaUsuarios)e.SelectedItem;
            var item_pass = obj_pass.nombre.ToString();
            String pass = item_pass;


            try
            {
                Navigation.PushAsync(new ModificarEliminar(ID,name,email,pass));
            }
            catch (Exception)
            {
                throw;
            }
        
        }

        protected async override void OnAppearing()
        {
            
            var Resultusuarios= await _conn.Table<TablaUsuarios>().ToListAsync();
            T_usuarios = new ObservableCollection<TablaUsuarios>(Resultusuarios);
            ListaUsuarios.ItemsSource = T_usuarios;
            base.OnAppearing();
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Agregarusuario());
        }
    }
}