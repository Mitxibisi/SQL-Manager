using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace DinApp
{
    public partial class Form1 : Form
    {
        SqlConnection connection = null;

        public Form1()
        {
            InitializeComponent();
        }

        // Evento del botón para conectar
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Recoger los datos ingresados por el usuario en los TextBox
            string server = txtServer.Text.Trim();
            string database = txtDatabase.Text.Trim();
            string user = txtUser.Text.Trim(); // Agregar TextBox para usuario
            string password = txtPassword.Text.Trim(); // Agregar TextBox para contraseña

            // Crear la cadena de conexión
            if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Servidor y Base de Datos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Determinar el tipo de autenticación
            string connectionString;
            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(password))
            {
                connectionString = $"Server={server}; Database={database}; User Id={user}; Password={password}; TrustServerCertificate=True;";
            }
            else
            {
                connectionString = $"Server={server}; Database={database}; TrustServerCertificate=True;";
            }

            // Intentar conectar con la base de datos
            connection = new SqlConnection(connectionString); // Mueve la creación de la conexión fuera de using

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

        // Evento para ejecutar la consulta
        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            string query = txtQuery.Text.Trim(); // Obtener el texto de la consulta del TextBox

            // Comprobar si la consulta está vacía
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Por favor, ingresa una consulta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ejecutar la consulta y mostrar los resultados
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    // Crear un SqlDataReader para leer los resultados de la consulta
                    SqlDataReader reader = command.ExecuteReader();

                    // Limpiar el ListBox antes de mostrar nuevos resultados
                    lstResults.Items.Clear();

                    // Leer los resultados
                    while (reader.Read())
                    {
                        // Para este ejemplo, asumimos que la consulta devuelve una sola columna (puedes ajustarlo según el tipo de consulta)
                        lstResults.Items.Add(reader[0].ToString());
                    }

                    reader.Close();  // Cerrar el SqlDataReader
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadQuery(object sender, EventArgs e)
        {
            txtQuery.Text = "SELECT table_name\r\nFROM information_schema.tables\r\nWHERE table_type = 'BASE TABLE'";
        }

        private void btnCompareSignals_Click(object sender, EventArgs e)
        {
            // Obtener las señales aportadas (pueden venir de un TextBox o de otro control)
            string[] señalesAportadas = txtSignals.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Llamar a la base de datos para obtener las plantillas
            string query = "SELECT TemplateTag, TemplateId, Mapeado FROM Plantillas";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    SqlDataReader reader = command.ExecuteReader();

                    string mejorPlantilla = "";
                    string mejorId = "";
                    int maxCoincidencias = 0;

                    // Leer las plantillas y comparar las señales
                    while (reader.Read())
                    {
                        string templateTag = reader["TemplateTag"].ToString();
                        string Id = reader["TemplateId"].ToString();
                        string mapeado = reader["Mapeado"].ToString();

                        // Dividir las señales mapeadas de la plantilla
                        string[] señalesPlantilla = mapeado.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                        // Contar las coincidencias
                        int coincidencias = señalesAportadas.Count(s => señalesPlantilla.Contains(s.Trim())); //Este metodo es totalmente temporal ya que no se como se diferencia los mapeados.

                        // Si encontramos más coincidencias, actualizar el mejor resultado
                        if (coincidencias > maxCoincidencias)
                        {
                            maxCoincidencias = coincidencias;
                            mejorPlantilla = templateTag;
                            mejorId = Id;
                        }
                    }

                    reader.Close();

                    // Mostrar la plantilla más parecida
                    if (string.IsNullOrEmpty(mejorPlantilla))
                    {
                        MessageBox.Show("No se encontraron coincidencias.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"La plantilla más parecida es: {mejorPlantilla} con el ID: {mejorId}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}