namespace WindowsFormsApp1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.edtsenha = new System.Windows.Forms.TextBox();
            this.Permissões = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ckGaragem = new System.Windows.Forms.CheckBox();
            this.ckVent = new System.Windows.Forms.CheckBox();
            this.ckCelular = new System.Windows.Forms.CheckBox();
            this.ckCadastrar = new System.Windows.Forms.CheckBox();
            this.ckLuz = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // edtNome
            // 
            this.edtNome.Location = new System.Drawing.Point(335, 31);
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(191, 20);
            this.edtNome.TabIndex = 1;
            // 
            // edtsenha
            // 
            this.edtsenha.Location = new System.Drawing.Point(335, 80);
            this.edtsenha.Name = "edtsenha";
            this.edtsenha.PasswordChar = '*';
            this.edtsenha.Size = new System.Drawing.Size(191, 20);
            this.edtsenha.TabIndex = 2;
            // 
            // Permissões
            // 
            this.Permissões.AutoSize = true;
            this.Permissões.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Permissões.Location = new System.Drawing.Point(281, 149);
            this.Permissões.Name = "Permissões";
            this.Permissões.Size = new System.Drawing.Size(91, 20);
            this.Permissões.TabIndex = 3;
            this.Permissões.Text = "Permissões";
            this.Permissões.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Luz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ventilador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Garagem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(158, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cadastrar";
            // 
            // ckGaragem
            // 
            this.ckGaragem.AutoSize = true;
            this.ckGaragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckGaragem.Location = new System.Drawing.Point(357, 276);
            this.ckGaragem.Name = "ckGaragem";
            this.ckGaragem.Size = new System.Drawing.Size(15, 14);
            this.ckGaragem.TabIndex = 4;
            this.ckGaragem.UseVisualStyleBackColor = true;
            // 
            // ckVent
            // 
            this.ckVent.AutoSize = true;
            this.ckVent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckVent.Location = new System.Drawing.Point(357, 242);
            this.ckVent.Name = "ckVent";
            this.ckVent.Size = new System.Drawing.Size(15, 14);
            this.ckVent.TabIndex = 4;
            this.ckVent.UseVisualStyleBackColor = true;
            // 
            // ckCelular
            // 
            this.ckCelular.AutoSize = true;
            this.ckCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckCelular.Location = new System.Drawing.Point(357, 310);
            this.ckCelular.Name = "ckCelular";
            this.ckCelular.Size = new System.Drawing.Size(15, 14);
            this.ckCelular.TabIndex = 4;
            this.ckCelular.UseVisualStyleBackColor = true;
            // 
            // ckCadastrar
            // 
            this.ckCadastrar.AutoSize = true;
            this.ckCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckCadastrar.Location = new System.Drawing.Point(357, 343);
            this.ckCadastrar.Name = "ckCadastrar";
            this.ckCadastrar.Size = new System.Drawing.Size(15, 14);
            this.ckCadastrar.TabIndex = 4;
            this.ckCadastrar.UseVisualStyleBackColor = true;
            // 
            // ckLuz
            // 
            this.ckLuz.AutoSize = true;
            this.ckLuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckLuz.Location = new System.Drawing.Point(357, 206);
            this.ckLuz.Name = "ckLuz";
            this.ckLuz.Size = new System.Drawing.Size(15, 14);
            this.ckLuz.TabIndex = 4;
            this.ckLuz.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(190, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(357, 403);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 35);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ckCadastrar);
            this.Controls.Add(this.ckCelular);
            this.Controls.Add(this.ckLuz);
            this.Controls.Add(this.ckVent);
            this.Controls.Add(this.ckGaragem);
            this.Controls.Add(this.Permissões);
            this.Controls.Add(this.edtsenha);
            this.Controls.Add(this.edtNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.TextBox edtsenha;
        private System.Windows.Forms.Label Permissões;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckGaragem;
        private System.Windows.Forms.CheckBox ckVent;
        private System.Windows.Forms.CheckBox ckCelular;
        private System.Windows.Forms.CheckBox ckCadastrar;
        private System.Windows.Forms.CheckBox ckLuz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
    }
}