namespace Rent_a_Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblLista = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDisponivel = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.txtDisponivel = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.BackColor = System.Drawing.Color.SteelBlue;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblLista.Location = new System.Drawing.Point(277, 38);
            this.lblLista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(353, 42);
            this.lblLista.TabIndex = 0;
            this.lblLista.Text = "LISTA DE CARROS";
            this.lblLista.Click += new System.EventHandler(this.lblLista_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblMatricula.Location = new System.Drawing.Point(118, 115);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(136, 36);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "Matricula";
            this.lblMatricula.Click += new System.EventHandler(this.lblMatricula_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblMarca.Location = new System.Drawing.Point(118, 160);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(97, 36);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblModelo.Location = new System.Drawing.Point(118, 210);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(114, 36);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "Modelo";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblAno.Location = new System.Drawing.Point(118, 258);
            this.lblAno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(70, 36);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "Ano";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblCategoria.Location = new System.Drawing.Point(118, 313);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(143, 36);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblDisponivel
            // 
            this.lblDisponivel.AutoSize = true;
            this.lblDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponivel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblDisponivel.Location = new System.Drawing.Point(118, 367);
            this.lblDisponivel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisponivel.Name = "lblDisponivel";
            this.lblDisponivel.Size = new System.Drawing.Size(154, 36);
            this.lblDisponivel.TabIndex = 6;
            this.lblDisponivel.Text = "Disponivel";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(322, 118);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(176, 27);
            this.txtMatricula.TabIndex = 7;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(322, 165);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(176, 27);
            this.txtMarca.TabIndex = 7;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(322, 210);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(176, 27);
            this.txtModelo.TabIndex = 7;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(322, 258);
            this.txtAno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(176, 27);
            this.txtAno.TabIndex = 7;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(322, 318);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(176, 27);
            this.txtCategoria.TabIndex = 7;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(707, 105);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(123, 47);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Gold;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(707, 175);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(123, 45);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(707, 235);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(123, 47);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.LightPink;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(707, 287);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(123, 54);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(707, 355);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(123, 50);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(122, 442);
            this.dgvAgenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.RowHeadersWidth = 51;
            this.dgvAgenda.RowTemplate.Height = 24;
            this.dgvAgenda.Size = new System.Drawing.Size(708, 238);
            this.dgvAgenda.TabIndex = 13;
            this.dgvAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellContentClick);
            // 
            // txtDisponivel
            // 
            this.txtDisponivel.Location = new System.Drawing.Point(322, 370);
            this.txtDisponivel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDisponivel.Name = "txtDisponivel";
            this.txtDisponivel.Size = new System.Drawing.Size(176, 27);
            this.txtDisponivel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(890, 105);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1256, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDisponivel);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDisponivel);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblLista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Carros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDisponivel;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.TextBox txtDisponivel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

