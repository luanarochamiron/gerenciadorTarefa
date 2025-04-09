using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTarefas
{
    public partial class Filtrar : Form
    {
        public string StatusSelecionado { get; private set; }
        public string PrioridadeSelecionada { get; private set; }
        public string TituloBusca { get; private set; }
        public DateTime? DataSelecionada { get; private set; }


        public Filtrar()
        {
            InitializeComponent();
            comboBoxStatus.Items.AddRange(new string[] { "Todos", "fazer", "fazendo", "feito" });
            comboBoxPrioridade.Items.AddRange(new string[] { "Todas", "Alta", "Média", "Baixa" });
            comboBoxStatus.SelectedIndex = 0;
            comboBoxPrioridade.SelectedIndex = 0;
        }

        private void Filtrar_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPrioridade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFiltrarData_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            StatusSelecionado = comboBoxStatus.SelectedItem.ToString();
            PrioridadeSelecionada = comboBoxPrioridade.SelectedItem.ToString();
            TituloBusca = textBoxTitulo.Text.Trim();
            DataSelecionada = checkBoxFiltrarData.Checked ? dateTimePicker1.Value.Date : (DateTime?)null;

            DialogResult = DialogResult.OK;
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
