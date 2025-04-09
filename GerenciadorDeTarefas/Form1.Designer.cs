namespace GerenciadorDeTarefas
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
            this.Criar = new System.Windows.Forms.Button();
            this.Filtro = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.Finalizado = new System.Windows.Forms.FlowLayoutPanel();
            this.Fazendo = new System.Windows.Forms.FlowLayoutPanel();
            this.Fazer = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Criar
            // 
            this.Criar.BackColor = System.Drawing.Color.White;
            this.Criar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Criar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criar.Location = new System.Drawing.Point(37, 26);
            this.Criar.Name = "Criar";
            this.Criar.Size = new System.Drawing.Size(131, 43);
            this.Criar.TabIndex = 0;
            this.Criar.Text = "+Criar";
            this.Criar.UseVisualStyleBackColor = false;
            this.Criar.Click += new System.EventHandler(this.Criar_Click);
            // 
            // Filtro
            // 
            this.Filtro.BackColor = System.Drawing.Color.White;
            this.Filtro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtro.Image = ((System.Drawing.Image)(resources.GetObject("Filtro.Image")));
            this.Filtro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Filtro.Location = new System.Drawing.Point(227, 26);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(135, 43);
            this.Filtro.TabIndex = 1;
            this.Filtro.Text = "Filtrar";
            this.Filtro.UseVisualStyleBackColor = false;
            this.Filtro.Click += new System.EventHandler(this.Filtro_Click);
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.White;
            this.Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(1437, 26);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(131, 43);
            this.Sair.TabIndex = 5;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.Color.White;
            this.buttonConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.Image")));
            this.buttonConsultar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonConsultar.Location = new System.Drawing.Point(405, 26);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(163, 43);
            this.buttonConsultar.TabIndex = 12;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Finalizado
            // 
            this.Finalizado.AutoScroll = true;
            this.Finalizado.BackColor = System.Drawing.Color.White;
            this.Finalizado.Location = new System.Drawing.Point(1077, 195);
            this.Finalizado.Name = "Finalizado";
            this.Finalizado.Size = new System.Drawing.Size(480, 625);
            this.Finalizado.TabIndex = 13;
            this.Finalizado.Paint += new System.Windows.Forms.PaintEventHandler(this.Finalizado_Paint);
            // 
            // Fazendo
            // 
            this.Fazendo.AutoScroll = true;
            this.Fazendo.BackColor = System.Drawing.Color.White;
            this.Fazendo.Location = new System.Drawing.Point(561, 195);
            this.Fazendo.Name = "Fazendo";
            this.Fazendo.Size = new System.Drawing.Size(474, 625);
            this.Fazendo.TabIndex = 14;
            this.Fazendo.Paint += new System.Windows.Forms.PaintEventHandler(this.Fazendo_Paint);
            // 
            // Fazer
            // 
            this.Fazer.AutoScroll = true;
            this.Fazer.BackColor = System.Drawing.Color.White;
            this.Fazer.Location = new System.Drawing.Point(37, 195);
            this.Fazer.Name = "Fazer";
            this.Fazer.Size = new System.Drawing.Size(484, 625);
            this.Fazer.TabIndex = 14;
            this.Fazer.Paint += new System.Windows.Forms.PaintEventHandler(this.Fazer_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Font = new System.Drawing.Font("RomanD", 36.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(482, 71);
            this.label4.TabIndex = 16;
            this.label4.Text = "    Fazer    ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("RomanD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 73);
            this.label1.TabIndex = 16;
            this.label1.Text = "  Fazendo ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("RomanD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1078, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 72);
            this.label2.TabIndex = 17;
            this.label2.Text = "Finalizado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1604, 861);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Fazer);
            this.Controls.Add(this.Fazendo);
            this.Controls.Add(this.Finalizado);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Filtro);
            this.Controls.Add(this.Criar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gerenciador De Tarefas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Criar;
        private System.Windows.Forms.Button Filtro;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.FlowLayoutPanel Finalizado;
        private System.Windows.Forms.FlowLayoutPanel Fazendo;
        private System.Windows.Forms.FlowLayoutPanel Fazer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

