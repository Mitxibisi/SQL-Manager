namespace DinApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            Opc = new TabControl();
            Opciones = new TabPage();
            lblServer = new Label();
            txtServer = new TextBox();
            lblDatabase = new Label();
            txtDatabase = new TextBox();
            lblStatus = new Label();
            Datos = new TabPage();
            loadTablesButton = new Button();
            queryButton = new Button();
            txtQuery = new TextBox();
            Opc.SuspendLayout();
            Opciones.SuspendLayout();
            Datos.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(6, 193);
            button1.Name = "button1";
            button1.Size = new Size(255, 73);
            button1.TabIndex = 0;
            button1.Text = "Abrir BD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnConnect_Click;
            // 
            // Opc
            // 
            Opc.Controls.Add(Opciones);
            Opc.Controls.Add(Datos);
            Opc.Cursor = Cursors.Hand;
            Opc.Location = new Point(12, 12);
            Opc.Name = "Opc";
            Opc.SelectedIndex = 0;
            Opc.Size = new Size(507, 301);
            Opc.TabIndex = 2;
            Opc.Tag = "Hola";
            // 
            // Opciones
            // 
            Opciones.Controls.Add(button1);
            Opciones.Controls.Add(lblServer);
            Opciones.Controls.Add(txtServer);
            Opciones.Controls.Add(lblDatabase);
            Opciones.Controls.Add(txtDatabase);
            Opciones.Controls.Add(lblStatus);
            Opciones.Location = new Point(4, 24);
            Opciones.Name = "Opciones";
            Opciones.Padding = new Padding(3);
            Opciones.Size = new Size(499, 273);
            Opciones.TabIndex = 0;
            Opciones.Text = "Opciones";
            Opciones.UseVisualStyleBackColor = true;
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(7, 103);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(53, 15);
            lblServer.TabIndex = 3;
            lblServer.Text = "Servidor:";
            // 
            // txtServer
            // 
            txtServer.Location = new Point(93, 100);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(216, 23);
            txtServer.TabIndex = 4;
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Location = new Point(7, 143);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(82, 15);
            lblDatabase.TabIndex = 5;
            lblDatabase.Text = "Base de datos:";
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(93, 140);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(216, 23);
            txtDatabase.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(6, 166);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(123, 15);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Estado: Desconectado";
            // 
            // Datos
            // 
            Datos.Controls.Add(loadTablesButton);
            Datos.Controls.Add(queryButton);
            Datos.Controls.Add(txtQuery);
            Datos.Location = new Point(4, 24);
            Datos.Name = "Datos";
            Datos.Padding = new Padding(3);
            Datos.Size = new Size(499, 273);
            Datos.TabIndex = 1;
            Datos.Text = "Datos";
            Datos.UseVisualStyleBackColor = true;
            // 
            // loadTablesButton
            // 
            loadTablesButton.Location = new Point(81, 3);
            loadTablesButton.Name = "loadTablesButton";
            loadTablesButton.Size = new Size(75, 23);
            loadTablesButton.TabIndex = 2;
            loadTablesButton.Text = "See All Tables";
            loadTablesButton.UseVisualStyleBackColor = true;
            loadTablesButton.Click += LoadQuery;
            // 
            // queryButton
            // 
            queryButton.Location = new Point(2, 3);
            queryButton.Name = "queryButton";
            queryButton.Size = new Size(75, 23);
            queryButton.TabIndex = 1;
            queryButton.Text = "New Query";
            queryButton.UseVisualStyleBackColor = true;
            queryButton.Click += NewQuery;
            // 
            // txtQuery
            // 
            txtQuery.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtQuery.Location = new Point(0, 27);
            txtQuery.Multiline = true;
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(500, 1140);
            txtQuery.TabIndex = 0;
            // 
            // Form1
            // 
            ClientSize = new Size(531, 325);
            Controls.Add(Opc);
            Name = "Form1";
            Text = "Formulario";
            Opc.ResumeLayout(false);
            Opciones.ResumeLayout(false);
            Opciones.PerformLayout();
            Datos.ResumeLayout(false);
            Datos.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Variable;
        private System.Windows.Forms.TabControl Opc;
        private System.Windows.Forms.TabPage Opciones;
        private System.Windows.Forms.TabPage Datos;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.Button loadTablesButton;
    }
}