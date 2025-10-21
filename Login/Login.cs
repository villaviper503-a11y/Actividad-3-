using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (Validar(user, password))
            {
                MessageBox.Show("Bienvenido, " + user + "!", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Menu menu = new Menu();

                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Usuario o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        


       private bool Validar(string user, string password)
        {
            // Credenciales de prueba
            string usuarioCorrecto = "Prueba";
            string passwordCorrecta = "123456";

            return (user == usuarioCorrecto && password == passwordCorrecta);
        }


    }
}
