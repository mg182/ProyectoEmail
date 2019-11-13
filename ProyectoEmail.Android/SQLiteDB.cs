
using Xamarin.Forms;
using ProyectoEmail.Droid;
using ProyectoEmail.Interfaces;
using SQLite;
using System.IO;

[assembly: Dependency(typeof(SQLiteDB))]
namespace ProyectoEmail.Droid
{
    public class SQLiteDB : ISQLiteDB
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "DB.db3");
            return new SQLiteAsyncConnection(path);

        }
    }
}