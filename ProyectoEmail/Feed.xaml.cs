using ProyectoEmail.Interfaces;
using ProyectoEmail.Modelo;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoEmail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Feed : ContentPage
    {
        private SQLiteAsyncConnection _conn;
        public IEnumerable<TablaUsuarios> DeleteAll { get; private set; }

        public Feed()
        {
            InitializeComponent();
            _conn = DependencyService.Get<ISQLiteDB>().GetConnection();
            _conn.CreateTableAsync<TablaUsuarios>();
        }
        public static IEnumerable<TablaUsuarios> Delete(SQLiteConnection db)
        {
            return db.Query<TablaUsuarios>("DELETE FROM TablaUsuarios");
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DB.db3");
            var db = new SQLiteConnection(databasePath);
            DeleteAll = Delete(db);


        }
    }
}