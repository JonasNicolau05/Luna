namespace WindowsFormsApp1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cdNome = new System.Windows.Forms.TextBox();
            this.cdSenha = new System.Windows.Forms.TextBox();
            this.cdConfirma = new System.Windows.Forms.TextBox();
            this.btnCadastrou = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckLuz = new System.Windows.Forms.CheckBox();
            this.ckVentilador = new System.Windows.Forms.CheckBox();
            this.ckGaragem = new System.Windows.Forms.CheckBox();
            this.ckCelular = new System.Windows.Forms.CheckBox();
            this.ckCadastar = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
           
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirme a Senha:";
            // 
            // cdNome
            // 
            this.cdNome.Location = new System.Drawing.Point(276, 31);
            this.cdNome.Name = "cdNome";
            this.cdNome.Size = new System.Drawing.Size(206, 20);
            this.cdNome.TabIndex = 3;
            // 
            // cdSenha
            // 
            this.cdSenha.Location = new System.Drawing.Point(276, 75);
            this.cdSenha.Name = "cdSenha";
            this.cdSenha.PasswordChar = '*';
            this.cdSenha.Size = new System.Drawing.Size(206, 20);
            this.cdSenha.TabIndex = 4;
            // 
            // cdConfirma
            // 
            this.cdConfirma.Location = new System.Drawing.Point(276, 126);
            this.cdConfirma.Name = "cdConfirma";
            this.cdConfirma.PasswordChar = '*';
            this.cdConfirma.Size = new System.Drawing.Size(206, 20);
            this.cdConfirma.TabIndex = 5;
            // 
            // btnCadastrou
            // 
            this.btnCadastrou.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCadastrou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrou.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrou.ForeColor = System.Drawing.Color.White;
            this.btnCadastrou.Location = new System.Drawing.Point(226, 370);
            this.btnCadastrou.Name = "btnCadastrou";
            this.btnCadastrou.Size = new System.Drawing.Size(169, 28);
            this.btnCadastrou.TabIndex = 6;
            this.btnCadastrou.Text = "Cadastrar";
            this.btnCadastrou.UseVisualStyleBackColor = false;
            this.btnCadastrou.Click += new System.EventHandler(this.button1_Click);
            this.btnCadastrou.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCadastrou_MouseUp);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(226, 404);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(169, 31);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Luz";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ventilador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Garagem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cadastrar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 454);
            this.panel1.TabIndex = 10;
            // 
            // ckLuz
            // 
            this.ckLuz.AutoSize = true;
            this.ckLuz.Location = new System.Drawing.Point(387, 212);
            this.ckLuz.Name = "ckLuz";
            this.ckLuz.Size = new System.Drawing.Size(15, 14);
            this.ckLuz.TabIndex = 6;
            this.ckLuz.UseVisualStyleBackColor = true;
            // 
            // ckVentilador
            // 
            this.ckVentilador.AutoSize = true;
            this.ckVentilador.Location = new System.Drawing.Point(387, 239);
            this.ckVentilador.Name = "ckVentilador";
            this.ckVentilador.Size = new System.Drawing.Size(15, 14);
            this.ckVentilador.TabIndex = 7;
            this.ckVentilador.UseVisualStyleBackColor = true;
            // 
            // ckGaragem
            // 
            this.ckGaragem.AutoSize = true;
            this.ckGaragem.Location = new System.Drawing.Point(387, 265);
            this.ckGaragem.Name = "ckGaragem";
            this.ckGaragem.Size = new System.Drawing.Size(15, 14);
            this.ckGaragem.TabIndex = 8;
            this.ckGaragem.UseVisualStyleBackColor = true;
            // 
            // ckCelular
            // 
            this.ckCelular.AutoSize = true;
            this.ckCelular.Location = new System.Drawing.Point(387, 292);
            this.ckCelular.Name = "ckCelular";
            this.ckCelular.Size = new System.Drawing.Size(15, 14);
            this.ckCelular.TabIndex = 9;
            this.ckCelular.UseVisualStyleBackColor = true;
            // 
            // ckCadastar
            // 
            this.ckCadastar.AutoSize = true;
            this.ckCadastar.Location = new System.Drawing.Point(387, 319);
            this.ckCadastar.Name = "ckCadastar";
            this.ckCadastar.Size = new System.Drawing.Size(15, 14);
            this.ckCadastar.TabIndex = 10;
            this.ckCadastar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(133, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Permissões:";
            // 
            // bunifuSeparator1
            // 
            
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 450);
            
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ckCadastar);
            this.Controls.Add(this.ckCelular);
            this.Controls.Add(this.ckGaragem);
            this.Controls.Add(this.ckVentilador);
            this.Controls.Add(this.ckLuz);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCadastrou);
            this.Controls.Add(this.cdConfirma);
            this.Controls.Add(this.cdSenha);
            this.Controls.Add(this.cdNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cdNome;
        private System.Windows.Forms.TextBox cdSenha;
        private System.Windows.Forms.TextBox cdConfirma;
        private System.Windows.Forms.Button btnCadastrou;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckLuz;
        private System.Windows.Forms.CheckBox ckVentilador;
        private System.Windows.Forms.CheckBox ckGaragem;
        private System.Windows.Forms.CheckBox ckCelular;
        private System.Windows.Forms.CheckBox ckCadastar;
        private System.Windows.Forms.Label label9;
        
    }
}