using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace DinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento del botón para conectar
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Recoger los datos ingresados por el usuario en los TextBox
            string server = txtServer.Text;  // txtServer es el TextBox para el servidor
            string database = txtDatabase.Text;  // txtDatabase es el TextBox para la base de datos
            string userId = txtUserId.Text;  // txtUserId es el TextBox para el usuario
            string password = txtPassword.Text;  // txtPassword es el TextBox para la contraseña

            // Crear la cadena de conexión
            string connectionString = $"Server={server}; Database={database}; User Id={userId}; Password = {password}; Integrated Security=True";

            // Intentar conectar con la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Establecer la conexión
                    lblStatus.Text = "Conexión exitosa!";
                    lblStatus.ForeColor = System.Drawing.Color.Green;  // Cambiar color de texto a verde
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener las bases de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.ForeColor = System.Drawing.Color.Red;  // Cambiar color de texto a rojo
                }
            }
        }
    
        private void NewQuery(object sender, EventArgs e)
        {
            String newquery = txtQuery.Text;
        }

        private void LoadQuery(object sender, EventArgs e)
        {
            txtQuery.Text = "SELECT table_name\r\nFROM information_schema.tables\r\nWHERE table_type = 'BASE TABLE'";
        }
    }
}