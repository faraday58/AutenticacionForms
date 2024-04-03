using System;
using System.Collections;
using System.Drawing;
using UsuarioLibrary;
using System.Windows.Forms;
using ReproductorMusica_G2_2024_II;

namespace AutenticacionForms
{
    public partial class Form1 : Form
    {
        ArrayList usuarios;
        public Form1()
        {
            InitializeComponent();
            usuarios = new ArrayList();
            AgregarUsuarios();
        }


        private void AgregarUsuarios()
        {
            usuarios.Add(new Usuario("armando" ,"12345"));
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtbUsuario.Text;
            string password = txtbPassword.Text;

            var usuarioPass =(Usuario)usuarios[0];
            if( usuario ==  usuarioPass.Nombre && 
                password == usuarioPass.Password )
            {
               
                FormReproductor formReproductor = new FormReproductor();

                formReproductor.Show();

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecto");
            }



        }
    }
}
