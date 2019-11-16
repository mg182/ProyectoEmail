using ProyectoEmail.Interfaces;
using ProyectoEmail.Modelo;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoEmail.UI.Transacciones
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModificarEliminar : ContentPage
    {
        public int id_s;
        public string name_s;
        private string email_s;
        private string pass_s;
        private SQLiteAsyncConnection _conn;

        public IEnumerable<TablaUsuarios> ResultadoUpdate { get; private set; }
        public IEnumerable<TablaUsuarios> ResultadoDelete { get; private set; }

        public ModificarEliminar(int id, string name, string email, string pass)
        {
            InitializeComponent();
            _conn = DependencyService.Get<ISQLiteDB>().GetConnection();
            _conn.CreateTableAsync<TablaUsuarios>();
            id_s = id;
            name_s = name;
            email_s = email;
            pass_s = pass;


        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            notification.Text = "Se afectará al ID " + id_s + " con nombre "+ name_s;
            user.Text = name_s;
            email.Text = email_s;
            pass.Text = pass_s;

        }

        public static IEnumerable<TablaUsuarios> Delete (SQLiteConnection db, int id)
        {
            return db.Query<TablaUsuarios>("DELETE FROM TablaUsuarios where id=? ", id);
        }
        public static IEnumerable<TablaUsuarios> Update(SQLiteConnection db, string nombre, string correo, string contraseña,int id)
        {
            return db.Query<TablaUsuarios>("UPDATE  TablaUsuarios SET nombre=?,correo=?,contraseña=? where id=?",nombre,correo,contraseña,id);
        }

        private void btnModify_Clicked(object sender, System.EventArgs e)
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DB.db3");
            var db = new SQLiteConnection(databasePath);
            ResultadoUpdate = Update(db, user.Text, email.Text, pass.Text, id_s);
            DisplayAlert("Exitoso", "Se ha modificado el usuario", "Regresar");
            clean();

        }

        private void btnDelete_Clicked(object sender, System.EventArgs e)
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DB.db3");
            var db = new SQLiteConnection(databasePath);
            ResultadoDelete = Delete(db, id_s);
            DisplayAlert("Exitoso", "Se ha eliminado el usuario", "Regresar");

        } 

        void clean()
        {
            user.Text = "";
            email.Text = "";
            pass.Text = "";
        }
    }
}