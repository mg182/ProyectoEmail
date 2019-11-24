using ProyectoEmail.Interfaces;
using ProyectoEmail.Modelo;
using SQLite;
using System;
using System.Collections.ObjectModel;
using System.Net.Mail;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoEmail.UI.Transacciones
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnviarCorreo : ContentPage
    {

        private SQLiteAsyncConnection _conn;
        private ObservableCollection<TablaUsuarios> T_usuarios;
        public string destinatario;
        public string remitente;
        public string contraseña;
        public string asunto;
        public string cuerpo;
        

        public EnviarCorreo(string correo)
        {
            InitializeComponent();
            _conn = DependencyService.Get<ISQLiteDB>().GetConnection();
            _conn.CreateTableAsync<TablaUsuarios>();
            destinatario = correo;
          
        } 

        protected async override void OnAppearing()
        {

            var Resultusuarios = await _conn.Table<TablaUsuarios>().ToListAsync();
            //T_usuarios = new ObservableCollection<TablaUsuarios>(Resultusuarios);
            pcorreo.ItemsSource = Resultusuarios;
            txtTo.Text = destinatario;
            base.OnAppearing();
        }
        
        private void btnSend_Clicked(object sender, System.EventArgs e)
        {
            asunto = txtSubject.Text;
            cuerpo = txtBody.Text;
            var ed = string.IsNullOrEmpty(destinatario);
            var er = string.IsNullOrEmpty(remitente);
            var ea = string.IsNullOrEmpty(asunto);
            var ecu = string.IsNullOrEmpty(cuerpo);

            if (ed || er || ea || ecu)
            {

                DisplayAlert("Error", "Uno o mas campos estan vacios", "OK");

            }

            else
            {

                try
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress(remitente);
                    mail.To.Add(destinatario);
                    mail.Subject = asunto;
                    mail.Body = cuerpo;
                    SmtpServer.Port = 25;
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.EnableSsl = true;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(remitente, contraseña);
                    SmtpServer.Send(mail);
                    DisplayAlert("Correo exitoso", "El correo se ha enviado con éxito", "OK");
                    clean();
                }
                catch (Exception ex)
                {
                    DisplayAlert("Error", ex.Message, "OK");
                }
            }

        }
        private void pcorreo_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            var selecteditem = pcorreo.SelectedItem as TablaUsuarios;
            remitente = selecteditem.correo;
            contraseña = selecteditem.contraseña;
            txtfrom.Text = remitente; 

        }

        void clean()
        {
            txtfrom.Text= "";
            txtBody.Text = "";
            txtSubject.Text = "";
            txtTo .Text= "";

        }
    }
}