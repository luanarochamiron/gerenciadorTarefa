﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GerenciadorDeTarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ObterTarefasEAtualizarTabelas();
        }

        public void ObterTarefasEAtualizarTabelas()
        {
                DAO dao = new DAO();

            var tarefasAFazer = dao.ObterTarefasPorStatus("fazer");
            var tarefasFazendo = dao.ObterTarefasPorStatus("fazendo");
            var tarefasFeito = dao.ObterTarefasPorStatus("feito");

            Fazer.Controls.Clear();
            Fazendo.Controls.Clear();
            Finalizado.Controls.Clear();

            foreach (var tarefa in tarefasAFazer)
                Fazer.Controls.Add(CriarCard(tarefa));

            foreach (var tarefa in tarefasFazendo)
                Fazendo.Controls.Add(CriarCard(tarefa));

            foreach (var tarefa in tarefasFeito)
                Finalizado.Controls.Add(CriarCard(tarefa));
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
           
            ArredondarBotao(Criar, 45);
            ArredondarBotao(buttonConsultar, 45);
            ArredondarBotao(Filtro, 45);
            ArredondarBotao(Sair, 45);
            ConfigurarBotao(Criar);
            ConfigurarBotao(buttonConsultar);
            ConfigurarBotao(Filtro);
            ConfigurarBotaoSair(Sair);
            ArredondarLabel(label4, 30);
            ArredondarLabel(label2, 30);
            ArredondarLabel(label1, 30);
            ArredondarControle(Fazer, 30);
            ArredondarControle(Fazendo, 30);
            ArredondarControle(Finalizado, 30);

         
        }

        private void Criar_Click(object sender, EventArgs e)
        {
            var cadastrar = new cadastrar();
            cadastrar.ShowDialog();

        }

        //  ===================================     Aparencias do form     ================================================

        private void ArredondarBotao(Button botao, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(botao.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(botao.Width - raio, botao.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, botao.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            botao.Region = new Region(path);
        } // Fim 

       
        private void ArredondarControle(Panel panel, int raio)
        {
            GraphicsPath path = new GraphicsPath();

            // Começa no canto superior esquerdo (linha reta)
            path.AddLine(0, 0, panel.Width, 0); // Topo reto

            // Canto inferior direito (arco)
            path.AddArc(panel.Width - raio, panel.Height - raio, raio, raio, 0, 90);

            // Canto inferior esquerdo (arco)
            path.AddArc(0, panel.Height - raio, raio, raio, 90, 90);

            path.CloseFigure();

            panel.Region = new Region(path);
        } //Fim

        private void ArredondarLabel(Label label, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(label.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(label.Width - raio, label.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, label.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            label.Region = new Region(path);
        } //Fim

        private void ConfigurarBotao(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat; // Deixa o botão sem borda elevada
            btn.FlatAppearance.BorderSize = 0; // Remove a borda
            btn.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue; // Azul claro ao passar o mouse
            btn.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue; // Azul mais escuro ao clicar
        }

        private void ConfigurarBotaoSair(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat; // Deixa o botão sem borda elevada
            btn.FlatAppearance.BorderSize = 0; // Remove a borda
            btn.FlatAppearance.MouseOverBackColor = Color.LightCoral; // Azul claro ao passar o mouse
            btn.FlatAppearance.MouseDownBackColor = Color.Red; // Azul mais escuro ao clicar
        }





        // =========================================    Back do Form   ==================================================

        private void Filtro_Click(object sender, EventArgs e)
        {
            var filtroForm = new Filtrar();

            if (filtroForm.ShowDialog() == DialogResult.OK)
            {
                var dao = new DAO();
                var tarefasFiltradas = dao.FiltrarTarefas(
                    filtroForm.StatusSelecionado,
                    filtroForm.PrioridadeSelecionada,
                    filtroForm.TituloBusca,
                    filtroForm.DataSelecionada
                );

                Fazer.Controls.Clear();
                Fazendo.Controls.Clear();
                Finalizado.Controls.Clear();

                foreach (var tarefa in tarefasFiltradas)
                {
                    switch (tarefa.Status.ToLower())
                    {
                        case "fazer": Fazer.Controls.Add(CriarCard(tarefa)); break;
                        case "fazendo": Fazendo.Controls.Add(CriarCard(tarefa)); break;
                        case "feito": Finalizado.Controls.Add(CriarCard(tarefa)); break;
                    }
                }
            }
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fazendo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Feito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Fazer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Filtro2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void button2_Click(object sender, EventArgs e)
        {

        }

    

        private void button2_Click_1(object sender, EventArgs e)
        {
            ObterTarefasEAtualizarTabelas();
        }

        private void Fazer_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Fazendo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Finalizado_Paint(object sender, PaintEventArgs e)
        {

        }

        private Panel CriarCard(Tarefa tarefa)
        {
            Panel card = new Panel
            {
                Width = 210,
                Height = 210,
                BackColor = Color.FromArgb(235, 245, 255),
                Margin = new Padding(10),
                BorderStyle = BorderStyle.None,
                Padding = new Padding(10)
            };

            Label titulo = new Label
            {
                Text = tarefa.Titulo,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                AutoSize = false,
                Height = 25,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.FromArgb(0, 90, 158)
            };

            Panel descricaoPanel = new Panel
            {
                Height = 90,
                Dock = DockStyle.Top,
                AutoScroll = true,
                Margin = new Padding(10),
                BackColor = Color.Transparent // opcional
            };

            Label descricao = new Label
            {
                Text = tarefa.Descricao,
                Font = new Font("Segoe UI", 11),
                AutoSize = true,
               
                MaximumSize = new Size(190, 0), // limita a largura e quebra linha
            };

            descricaoPanel.Controls.Add(descricao);

            TimeSpan diferenca = tarefa.DataVencimento.Date - DateTime.Today;
            Label dataVencimento = new Label
            {
                Text = $"Vence em: {tarefa.DataVencimento.ToString("dd/MM/yyyy")}",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = Color.DarkBlue,
                Height = 20,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };
            // Lógica de destaque por data
            if (diferenca.TotalDays < 0)
            {
                dataVencimento.ForeColor = Color.Red;
                dataVencimento.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
            else if (diferenca.TotalDays <= 3)
            {
                dataVencimento.ForeColor = Color.DarkOrange;
                dataVencimento.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
            else
            {
                dataVencimento.ForeColor = Color.DarkBlue;
            }

            int raioBorda = 20;;
            int espessuraBorda = 6;

            Color corBorda;

            switch (tarefa.Prioridade.ToLower())
            {
                case "alta":
                    corBorda = Color.Red;
                    break;
                case "média":
                case "media":
                    corBorda = Color.Gold;
                    break;
                case "baixa":
                    corBorda = Color.LightGreen;
                    break;
                default:
                    corBorda = Color.LightGray;
                    break;
            }

            card.BorderStyle = BorderStyle.None;

            // Define região arredondada com o tamanho EXATO do painel
            card.Region = new Region(CreateRoundedPath(card.ClientRectangle, raioBorda));

            // Desenha a borda NO MESMO TAMANHO do painel (sem reduzir com espessura)
            card.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = card.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;

                using (GraphicsPath path = CreateRoundedPath(rect, raioBorda))
                using (Pen pen = new Pen(corBorda, espessuraBorda))
                {
                    pen.Alignment = PenAlignment.Inset; // Para a borda não ultrapassar
                    e.Graphics.DrawPath(pen, path);
                }
            };


            Button moverBtn = new Button
            {
                Text = "➡️",
                Font = new Font("Segoe UI Emoji", 12),
                Dock = DockStyle.Right,
                Width = 60,
               
              
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent
            };

            moverBtn.Click += (s, e) =>
            {
                DAO dao = new DAO();
                string novoStatus;

                switch (tarefa.Status)
                {
                    case "fazer":
                        novoStatus = "fazendo";
                        break;
                    case "fazendo":
                        novoStatus = "feito";
                        break;
                    default:
                        novoStatus = "fazer";
                        break;
                }

                dao.AtualizarStatusTarefa(tarefa.Id, novoStatus);
                ObterTarefasEAtualizarTabelas();
            };
            moverBtn.FlatAppearance.BorderSize = 0;
            moverBtn.FlatAppearance.MouseOverBackColor = Color.Plum;
            moverBtn.FlatAppearance.MouseDownBackColor = Color.MediumPurple;

            Button deletarBtn = new Button
            {
                Text = "🗑️",
                Font = new Font("Segoe UI Emoji", 12),
                Dock = DockStyle.Right,
                Width = 60,
               
                
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent

            };
            deletarBtn.FlatAppearance.BorderSize = 0;
            deletarBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 80, 80);  // Vermelho claro
            deletarBtn.FlatAppearance.MouseDownBackColor = Color.Red;

            deletarBtn.Click += (s, e) =>
            {
                var resultado = MessageBox.Show("Deseja realmente excluir?", "Confirmação", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    DAO dao = new DAO();
                    dao.DeletarTarefa(tarefa.Id);
                    ObterTarefasEAtualizarTabelas();
                }
            };


            Button AtualizarBtn = new Button
            {
                Text = "️✏",
                Font = new Font("Segoe UI Emoji", 12),
                Dock = DockStyle.Left,
                Width = 62,
                

                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent
            };
            AtualizarBtn.FlatAppearance.BorderSize = 0;
            AtualizarBtn.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            AtualizarBtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;

            AtualizarBtn.Click += (s, e) =>
            {
                var atualizar = new atualizar(tarefa.Id);
                atualizar.ShowDialog();
            };
            DeixarBotaoRedondo(AtualizarBtn);
            DeixarBotaoRedondo(moverBtn);
            DeixarBotaoRedondo(deletarBtn);




            card.Controls.Add(AtualizarBtn);
            card.Controls.Add(deletarBtn);
            card.Controls.Add(moverBtn);
           
            card.Controls.Add(descricaoPanel);
            card.Controls.Add(dataVencimento);
            card.Controls.Add(titulo);

        
            return card;
        }
        private GraphicsPath CreateRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Top-left
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Top-right
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-right
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-left
            path.CloseFigure();

            return path;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void DeixarBotaoRedondo(Button botao)
        {
            int tamanho = Math.Min(botao.Width, botao.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, tamanho, tamanho);
            botao.Region = new Region(path);

            botao.Paint += (s, e) =>
            {
                GraphicsPath ellipsePath = new GraphicsPath();
                ellipsePath.AddEllipse(0, 0, botao.Width, botao.Height);
                botao.Region = new Region(ellipsePath);
            };
        }



    }
}
