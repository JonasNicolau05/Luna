namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SerialArduino = new System.IO.Ports.SerialPort(this.components);
            this.MenuTop = new System.Windows.Forms.Panel();
            this.MenuDeslizante = new System.Windows.Forms.Panel();
            this.ListaClientes = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Usuarios = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Menus = new System.Windows.Forms.PictureBox();
            this.MenuTop.SuspendLayout();
            this.MenuDeslizante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menus)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progressBar1.Location = new System.Drawing.Point(652, 456);
            this.progressBar1.MinimumSize = new System.Drawing.Size(136, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(136, 32);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // SerialArduino
            // 
            this.SerialArduino.PortName = "COM4";
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.MenuTop.Controls.Add(this.pictureBox1);
            this.MenuTop.Controls.Add(this.button1);
            this.MenuTop.Controls.Add(this.Menus);
            this.MenuTop.Location = new System.Drawing.Point(0, -1);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(800, 84);
            this.MenuTop.TabIndex = 2;
            // 
            // MenuDeslizante
            // 
            this.MenuDeslizante.BackColor = System.Drawing.Color.DodgerBlue;
            this.MenuDeslizante.Controls.Add(this.pictureBox2);
            this.MenuDeslizante.Controls.Add(this.button2);
            this.MenuDeslizante.Controls.Add(this.Usuarios);
            this.MenuDeslizante.Controls.Add(this.btnCadastrar);
            this.MenuDeslizante.Location = new System.Drawing.Point(0, 83);
            this.MenuDeslizante.Name = "MenuDeslizante";
            this.MenuDeslizante.Size = new System.Drawing.Size(270, 419);
            this.MenuDeslizante.TabIndex = 3;
            // 
            // ListaClientes
            // 
            this.ListaClientes.BackgroundColor = System.Drawing.Color.White;
            this.ListaClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaClientes.Location = new System.Drawing.Point(276, 105);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.Size = new System.Drawing.Size(512, 312);
            this.ListaClientes.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(292, 450);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 38);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(412, 450);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 38);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.salir;
            this.pictureBox2.Location = new System.Drawing.Point(-14, 347);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::WindowsFormsApp1.Properties.Resources.relo3;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(10, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "Histórico";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Enter += new System.EventHandler(this.btnCadastrar_Enter);
            this.button2.Leave += new System.EventHandler(this.btnCadastrar_Leave);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCadastrar_MouseUp);
            // 
            // Usuarios
            // 
            this.Usuarios.BackColor = System.Drawing.Color.Transparent;
            this.Usuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Usuarios.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.ForeColor = System.Drawing.Color.White;
            this.Usuarios.Image = global::WindowsFormsApp1.Properties.Resources.clientes;
            this.Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Usuarios.Location = new System.Drawing.Point(10, 98);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(250, 70);
            this.Usuarios.TabIndex = 1;
            this.Usuarios.Text = "Usuários";
            this.Usuarios.UseVisualStyleBackColor = false;
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            this.Usuarios.Enter += new System.EventHandler(this.btnCadastrar_Enter);
            this.Usuarios.Leave += new System.EventHandler(this.btnCadastrar_Leave);
            this.Usuarios.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCadastrar_MouseUp);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Image = global::WindowsFormsApp1.Properties.Resources.Businessman_48px;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(10, 22);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(250, 70);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "\r\nCadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            this.btnCadastrar.Enter += new System.EventHandler(this.btnCadastrar_Enter);
            this.btnCadastrar.Leave += new System.EventHandler(this.btnCadastrar_Leave);
            this.btnCadastrar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCadastrar_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Close_Window__2_48px;
            this.pictureBox1.Location = new System.Drawing.Point(768, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.user__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(779, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menus
            // 
            this.Menus.Image = global::WindowsFormsApp1.Properties.Resources.Menu_48px;
            this.Menus.Location = new System.Drawing.Point(12, 13);
            this.Menus.Name = "Menus";
            this.Menus.Size = new System.Drawing.Size(42, 45);
            this.Menus.TabIndex = 0;
            this.Menus.TabStop = false;
            this.Menus.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.ListaClientes);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.MenuDeslizante);
            this.Controls.Add(this.MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luna";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuTop.ResumeLayout(false);
            this.MenuDeslizante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.Ports.SerialPort SerialArduino;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Menus;
        private System.Windows.Forms.Panel MenuDeslizante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Usuarios;
        private System.Windows.Forms.DataGridView ListaClientes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

