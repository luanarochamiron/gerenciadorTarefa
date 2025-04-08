using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace GerenciadorDeTarefas
{
    public partial class atualizar : Form
    {
        private int IdTarefaAtualizar;

        public atualizar(int idTarefaAtualizar)
        {
            IdTarefaAtualizar = idTarefaAtualizar;
            InitializeComponent();
            PreencherFormulario();
           
        }

        private void PreencherFormulario()
        {
            var dao = new DAO();

            var tarefa = dao.ObterTarefaPorId(IdTarefaAtualizar);

            titulo.Text = tarefa.Titulo;
            descricao.Text = tarefa.Descricao;
            dataVencimento.Text = tarefa.DataVencimento.ToString();
            prioridade.Text = tarefa.Prioridade;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoAtualizar_Click(object sender, EventArgs e)
        {
            var tituloF = titulo.Text;
            var descricaoF = descricao.Text;
            var dataVencimentoF = DateTime.Parse(dataVencimento.Text);
            var prioridadeF = prioridade.Text;
            
            var DAO = new DAO();

           // DAO.AtualizarTarefa(tituloF, descricaoF, dataVencimentoF, prioridadeF, IdTarefaAtualizar);

            var form = new Form1();

            form.ObterTarefasEAtualizarTabelas();

            this.Close();
        }

        private void titulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataVencimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void prioridade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // =========================================================================================================================

        private void atualizar_Load(object sender, EventArgs e)
        {
            ArredondarBotao(button1, 40);
            ArredondarBotao(botaoAtualizar, 50);
            ConfigurarBotao(botaoAtualizar);
            ConfigurarBotaoSair(button1);
        }

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

       
         

        
        }
}
