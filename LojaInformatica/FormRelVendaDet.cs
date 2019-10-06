using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaInformatica
{
    public partial class FormRelVendaDet : Form
    {
        public FormRelVendaDet()
        {
            InitializeComponent();
        }

        private void FormRelVendaDet_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO TIPO DE RELATÓRIO
            cbTipoRel.Items.Add("Nome do Cliente");
            cbTipoRel.Items.Add("Nome do Funcionário");
            cbTipoRel.Items.Add("Forma de Pagamento");
            cbTipoRel.Items.Add("Valor da Venda");
            cbTipoRel.Items.Add("Data da Venda");
            cbTipoRel.SelectedIndex = 0;

            //CARREGAR COMBO DE Funcionario DO BANCO DE DADOS - TABELA FUNCIONARIO
            classFuncionario cFuncionario = new classFuncionario();
            cbFuncionario.DataSource = cFuncionario.BuscarNomeFuncionario(); // EXECUTAR MÉTODO DE CONSULTA CRIADO NA CLASSE F
            cbFuncionario.DisplayMember = "nome"; // EXIBIR NA COMBO (Funcionario)
            cbFuncionario.ValueMember = "cod_func"; // GUARDAR NO BD (Funcionario)
            cbFuncionario.SelectedIndex = -1;
            this.rptvVendaDeta.RefreshReport();

            //Carregar Combo Forma de Pagamento
            cbPagamento.Items.Add("Selecione uma Forma de Pagamento");
            cbPagamento.Items.Add("Cartão de Crédito");
            cbPagamento.Items.Add("Cartão de Débito");
            cbPagamento.Items.Add("Dinheiro");
            cbPagamento.Items.Add("Crediário");
            cbPagamento.SelectedIndex = 1;
        }

        //Método Limpar
        private void Limpar()
        {
            cbPagamento.SelectedItem = "Selecione uma Forma de Pagamento";
            cbFuncionario.SelectedIndex = -1;
            txtCliente.Text = "";
            txtPreco1.Text = "";
            txtPreco2.Text = "";
            rptvVendaDeta.Clear();
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0) //Cliente
            {
                gbCliente.Enabled = true;
                gbfuncionario.Enabled = false;
                gbPagamento.Enabled = false;
                gbPreco.Enabled = false;
                gbData.Enabled = false;
                Limpar();
            }

            if (cbTipoRel.SelectedIndex == 1) //Funcionário
            {
                gbCliente.Enabled = false;
                gbfuncionario.Enabled = true;
                gbPagamento.Enabled = false;
                gbPreco.Enabled = false;
                gbData.Enabled = false;
                Limpar();
            }

            if (cbTipoRel.SelectedIndex == 2) //Pagamento
            {
                gbCliente.Enabled = false;
                gbfuncionario.Enabled = false;
                gbPagamento.Enabled = true;
                gbPreco.Enabled = false;
                gbData.Enabled = false;
                Limpar();
            }

            if (cbTipoRel.SelectedIndex == 3) //Venda
            {
                gbCliente.Enabled = false;
                gbfuncionario.Enabled = false;
                gbPagamento.Enabled = false;
                gbPreco.Enabled = true;
                gbData.Enabled = false;
                Limpar();
            }

            if (cbTipoRel.SelectedIndex == 4) //Data
            {
                gbCliente.Enabled = false;
                gbfuncionario.Enabled = false;
                gbPagamento.Enabled = false;
                gbPreco.Enabled = false;
                gbData.Enabled = true;
                Limpar();
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            classJuncaoVenda cJuncaoVenda = new classJuncaoVenda();
            string pesquisa = cbTipoRel.SelectedItem.ToString(); //Para pegar a opção escolhida pelo usuário

            switch (pesquisa)
            {
                case "Nome do Cliente":
                    if (txtCliente.Text != "")
                    {
                        classJuncaoVendaBindingSource.DataSource = cJuncaoVenda.RelVendaDetNomeCli(txtCliente.Text);
                        this.rptvVendaDeta.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor preencher o campo vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Nome do Funcionário":
                    if (cbFuncionario.SelectedIndex == -1)
                    {
                        MessageBox.Show("Favor escolher um Funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        classJuncaoVendaBindingSource.DataSource = cJuncaoVenda.RelVendaDetNomeFunc(Convert.ToInt32(cbFuncionario.SelectedValue));
                        this.rptvVendaDeta.RefreshReport();
                    }
                    break;

                case "Forma de Pagamento":
                    if (cbPagamento.SelectedIndex == 0)
                    {
                        MessageBox.Show("Favor escolher uma Forma de Pagamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        classJuncaoVendaBindingSource.DataSource = cJuncaoVenda.RelVendaDetFormaPag(cbPagamento.SelectedItem.ToString());
                        this.rptvVendaDeta.RefreshReport();
                    }
                    break;

                case "Valor da Venda":
                    if (txtPreco1.Text != "" && txtPreco2.Text != "")
                    {
                        classJuncaoVendaBindingSource.DataSource = cJuncaoVenda.RelVendaDetPreço(Convert.ToDecimal(txtPreco1.Text), Convert.ToDecimal(txtPreco2.Text));
                        this.rptvVendaDeta.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor preencher os campos vazios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Data da Venda":
                    if (dtp1.Text != "" && dtp2.Text != "")
                    {
                        classJuncaoVendaBindingSource.DataSource = cJuncaoVenda.RelVendaDetData(Convert.ToDateTime(dtp1.Text), Convert.ToDateTime(dtp2.Text));
                        this.rptvVendaDeta.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor preencher os campos vazios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPreco1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Só permitir o uso de uma vírgula no campo, não permitir letras e símbolos
            if (e.KeyChar == ','
            && ((sender as TextBox).Text.IndexOf(',') > -1) || (char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtPreco2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Só permitir o uso de uma vírgula no campo, não permitir letras e símbolos
            if (e.KeyChar == ','
            && ((sender as TextBox).Text.IndexOf(',') > -1) || (char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}

