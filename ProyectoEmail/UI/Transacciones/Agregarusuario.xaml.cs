﻿using ProyectoEmail.Interfaces;
using ProyectoEmail.Modelo;
using SQLite;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoEmail.UI.Transacciones
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Agregarusuario : ContentPage
    {
        private SQLiteAsyncConnection _conn;
        public Agregarusuario()
        {
            InitializeComponent();
            _conn = DependencyService.Get<ISQLiteDB>().GetConnection();
            _conn.CreateTableAsync<TablaUsuarios>();
            
        }

        private void btnAdd_Clicked(object sender, EventArgs e)


            
        {
            var eu = string.IsNullOrEmpty(user.Text);
            var ec = string.IsNullOrEmpty(email.Text);
            var ep = string.IsNullOrEmpty(pass.Text);

            if (eu || ec || ep)
            {
                DisplayAlert("Error", "Uno o mas campos estan vacios", "OK");
            }

            else
            {



                var DatosUsuario = new TablaUsuarios { nombre = user.Text, correo = email.Text, contraseña = pass.Text };
                _conn.InsertAsync(DatosUsuario);
                DisplayAlert("Exitoso", "Se ha agregado el usuario", "Regresar");
                clean();
            }
        } 

         void clean()
        {
            user.Text = "";
            email.Text = "";
            pass.Text = "";

        }
    }
}