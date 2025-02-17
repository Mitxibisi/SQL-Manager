namespace DinApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.TabPage tabQuery;
        private System.Windows.Forms.TabPage tabSignalComparison;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnExecuteQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCompareSignals;
        private System.Windows.Forms.TextBox txtSignals;
        private System.Windows.Forms.Button btnLoadQuery;
        private System.Windows.Forms.Button btnCloseConnection;

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
            tabControl = new TabControl();
            tabConnection = new TabPage();
            btnConnect = new Button();
            txtServer = new TextBox();
            lblServer = new Label();
            txtDatabase = new TextBox();
            lblDatabase = new Label();
            txtUser = new TextBox();
            lblUser = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblStatus = new Label();
            tabQuery = new TabPage();
            btnLoadQuery = new Button();
            btnExecuteQuery = new Button();
            txtQuery = new TextBox();
            lstResults = new ListBox();
            tabSignalComparison = new TabPage();
            btnCompareSignals = new Button();
            txtSignals = new TextBox();
            btnCloseConnection = new Button();
            tabControl.SuspendLayout();
            tabConnection.SuspendLayout();
            tabQuery.SuspendLayout();
            tabSignalComparison.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabConnection);
            tabControl.Controls.Add(tabQuery);
            tabControl.Controls.Add(tabSignalComparison);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(350, 420);
            tabControl.TabIndex = 0;
            // 
            // tabConnection
            // 
            tabConnection.Controls.Add(btnCloseConnection);
            tabConnection.Controls.Add(btnConnect);
            tabConnection.Controls.Add(txtServer);
            tabConnection.Controls.Add(lblServer);
            tabConnection.Controls.Add(txtDatabase);
            tabConnection.Controls.Add(lblDatabase);
            tabConnection.Controls.Add(txtUser);
            tabConnection.Controls.Add(lblUser);
            tabConnection.Controls.Add(txtPassword);
            tabConnection.Controls.Add(lblPassword);
            tabConnection.Controls.Add(lblStatus);
            tabConnection.Location = new Point(4, 24);
            tabConnection.Name = "tabConnection";
            tabConnection.Padding = new Padding(3);
            tabConnection.Size = new Size(342, 392);
            tabConnection.TabIndex = 0;
            tabConnection.Text = "Conexión";
            tabConnection.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 12);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(100, 23);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Conectar";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtServer
            // 
            txtServer.Location = new Point(93, 60);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(216, 23);
            txtServer.TabIndex = 1;
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(12, 63);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(74, 15);
            lblServer.TabIndex = 2;
            lblServer.Text = "Servidor (IP):";
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(93, 100);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(216, 23);
            txtDatabase.TabIndex = 3;
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Location = new Point(12, 103);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(83, 15);
            lblDatabase.TabIndex = 4;
            lblDatabase.Text = "Base de Datos:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(93, 140);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(216, 23);
            txtUser.TabIndex = 5;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(12, 143);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 6;
            lblUser.Text = "Usuario";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(93, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(216, 23);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 183);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 15);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Contraseña";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 220);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(123, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Estado: Desconectado";
            // 
            // tabQuery
            // 
            tabQuery.Controls.Add(btnLoadQuery);
            tabQuery.Controls.Add(btnExecuteQuery);
            tabQuery.Controls.Add(txtQuery);
            tabQuery.Controls.Add(lstResults);
            tabQuery.Location = new Point(4, 24);
            tabQuery.Name = "tabQuery";
            tabQuery.Padding = new Padding(3);
            tabQuery.Size = new Size(342, 392);
            tabQuery.TabIndex = 1;
            tabQuery.Text = "Consulta SQL";
            tabQuery.UseVisualStyleBackColor = true;
            // 
            // btnLoadQuery
            // 
            btnLoadQuery.Location = new Point(115, 6);
            btnLoadQuery.Name = "btnLoadQuery";
            btnLoadQuery.Size = new Size(70, 23);
            btnLoadQuery.TabIndex = 13;
            btnLoadQuery.Text = "Ver Tablas";
            btnLoadQuery.UseVisualStyleBackColor = true;
            btnLoadQuery.Click += btnLoadQuery_Click;
            // 
            // btnExecuteQuery
            // 
            btnExecuteQuery.Location = new Point(9, 6);
            btnExecuteQuery.Name = "btnExecuteQuery";
            btnExecuteQuery.Size = new Size(100, 23);
            btnExecuteQuery.TabIndex = 10;
            btnExecuteQuery.Text = "Ejecutar Consulta";
            btnExecuteQuery.UseVisualStyleBackColor = true;
            btnExecuteQuery.Click += btnExecuteQuery_Click;
            // 
            // txtQuery
            // 
            txtQuery.Location = new Point(9, 35);
            txtQuery.Multiline = true;
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(324, 52);
            txtQuery.TabIndex = 11;
            // 
            // lstResults
            // 
            lstResults.FormattingEnabled = true;
            lstResults.ItemHeight = 15;
            lstResults.Location = new Point(9, 103);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(324, 274);
            lstResults.TabIndex = 12;
            // 
            // tabSignalComparison
            // 
            tabSignalComparison.Controls.Add(btnCompareSignals);
            tabSignalComparison.Controls.Add(txtSignals);
            tabSignalComparison.Location = new Point(4, 24);
            tabSignalComparison.Name = "tabSignalComparison";
            tabSignalComparison.Padding = new Padding(3);
            tabSignalComparison.Size = new Size(342, 392);
            tabSignalComparison.TabIndex = 2;
            tabSignalComparison.Text = "Comparar Señales";
            tabSignalComparison.UseVisualStyleBackColor = true;
            // 
            // btnCompareSignals
            // 
            btnCompareSignals.Location = new Point(12, 12);
            btnCompareSignals.Name = "btnCompareSignals";
            btnCompareSignals.Size = new Size(132, 23);
            btnCompareSignals.TabIndex = 13;
            btnCompareSignals.Text = "Comparar Señales";
            btnCompareSignals.UseVisualStyleBackColor = true;
            btnCompareSignals.Click += btnCompareSignals_Click;
            // 
            // txtSignals
            // 
            txtSignals.Location = new Point(12, 41);
            txtSignals.Multiline = true;
            txtSignals.Name = "txtSignals";
            txtSignals.Size = new Size(324, 345);
            txtSignals.TabIndex = 14;
            // 
            // btnCloseConnection
            // 
            btnCloseConnection.Location = new Point(118, 12);
            btnCloseConnection.Name = "btnCloseConnection";
            btnCloseConnection.Size = new Size(100, 23);
            btnCloseConnection.TabIndex = 10;
            btnCloseConnection.Text = "Desconectar";
            btnCloseConnection.UseVisualStyleBackColor = true;
            btnCloseConnection.Click += btnCloseConnection_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(374, 450);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Conexión y Consultas SQL";
            tabControl.ResumeLayout(false);
            tabConnection.ResumeLayout(false);
            tabConnection.PerformLayout();
            tabQuery.ResumeLayout(false);
            tabQuery.PerformLayout();
            tabSignalComparison.ResumeLayout(false);
            tabSignalComparison.PerformLayout();
            ResumeLayout(false);
        }
    }
}