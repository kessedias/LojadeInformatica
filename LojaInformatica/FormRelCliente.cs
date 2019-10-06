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
    public partial class FormRelCliente : Form
    {
        public FormRelCliente()
        {
            InitializeComponent();
        }

        private void frmRelCliente37_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO TIPO DE RELATÓRIO
            cbTipoRel.Items.Add("Aniversariantes por Dia e Mês");
            cbTipoRel.Items.Add("Aniversariantes do Mês");
            cbTipoRel.Items.Add("Aniversariantes Idade");
            cbTipoRel.Items.Add("Cidade");
            cbTipoRel.Items.Add("Sexo");
            cbTipoRel.Items.Add("Status");
            cbTipoRel.SelectedIndex = 0;

            //CARREGAR COMBO MÊS
            cbMes.Items.Add("Escolha um Mês");
            cbMes.Items.Add("Janeiro");
            cbMes.Items.Add("Fevereiro");
            cbMes.Items.Add("Março");
            cbMes.Items.Add("Abril");
            cbMes.Items.Add("Maio");
            cbMes.Items.Add("Junho");
            cbMes.Items.Add("Julho");
            cbMes.Items.Add("Agosto");
            cbMes.Items.Add("Setembro");
            cbMes.Items.Add("Outubro");
            cbMes.Items.Add("Novembro");
            cbMes.Items.Add("Dezembro");
            cbMes.SelectedIndex = 0;

            //CARREGAR COMBO DIA
            cbDia.Items.Add("Escolha um Dia");
            cbDia.Items.Add("01");
            cbDia.Items.Add("02");
            cbDia.Items.Add("03");
            cbDia.Items.Add("04");
            cbDia.Items.Add("05");
            cbDia.Items.Add("06");
            cbDia.Items.Add("07");
            cbDia.Items.Add("08");
            cbDia.Items.Add("09");
            cbDia.Items.Add("10");
            cbDia.Items.Add("11");
            cbDia.Items.Add("12");
            cbDia.Items.Add("13");
            cbDia.Items.Add("14");
            cbDia.Items.Add("15");
            cbDia.Items.Add("16");
            cbDia.Items.Add("17");
            cbDia.Items.Add("18");
            cbDia.Items.Add("19");
            cbDia.Items.Add("20");
            cbDia.Items.Add("21");
            cbDia.Items.Add("22");
            cbDia.Items.Add("23");
            cbDia.Items.Add("24");
            cbDia.Items.Add("25");
            cbDia.Items.Add("26");
            cbDia.Items.Add("27");
            cbDia.Items.Add("28");
            cbDia.Items.Add("29");
            cbDia.Items.Add("30");
            cbDia.Items.Add("31");
            cbDia.SelectedIndex = 0;

            //CARREGAR COMBO SEXO
            cbSexo.Items.Add("Escolha um Sexo");
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Masculino");
            cbSexo.SelectedIndex = 0;

            //CARREGAR COMBO DE CIDADE DO BANCO DE DADOS - TABELA CLIENTE
            classCliente cCliente = new classCliente();
            cbCidade.DataSource = cCliente.BuscarCidade(); // EXECUTAR MÉTODO DE CONSULTA CRIADO NA CLASSE CLIENTE
            cbCidade.DisplayMember = "cidade_cli"; // EXIBIR NA COMBO (CIDADE)
            cbCidade.ValueMember = "cidade_cli"; // GUARDAR NO BD (CIDADE)
            cbCidade.SelectedIndex = -1;
            this.rptvCliente.RefreshReport();     
        }


        //Método de Limpeza
        private void Limpar()
        {
            rptvCliente.Clear();
            cbDia.SelectedItem = "Escolha um Dia";
            cbMes.SelectedItem = "Escolha um Mês";
            cbSexo.SelectedItem = "Escolha um Sexo";
            cbCidade.SelectedIndex = -1;
            txtIdadeFinal.Text = "";
            txtIdadeInicial.Text = "";
        }


        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbTipoRel.SelectedIndex == 0) //Aniversariantes por dia e mês
            {
                gbAniversariantes.Enabled = true;
                cbDia.Enabled = true;
                cbMes.Enabled = true;
                gbIdade.Enabled = false;
                gbStatus.Enabled = false;
                cbCidade.Enabled = false;
                cbSexo.Enabled = false;
                Limpar();
            }

            if (cbTipoRel.SelectedIndex == 1) //Aniversariantes do mês
            {
                gbAniversariantes.Enabled = true;
                cbDia.Enabled = false;
                cbMes.Enabled = true;
                gbIdade.Enabled = false;
                gbStatus.Enabled = false;
                cbCidade.Enabled = false;
                cbSexo.Enabled = false;
                Limpar();
            }

            if (cbTipoRel.SelectedIndex == 2) //Aniversariantes Idade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = true;
                gbStatus.Enabled = false;
                cbCidade.Enabled = false;
                cbSexo.Enabled = false;
                Limpar();
            }

            if (cbTipoRel.SelectedIndex == 3) //Cidade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbStatus.Enabled = false;
                cbCidade.Enabled = true;
                cbSexo.Enabled = false;
                Limpar();
            }

            if (cbTipoRel.SelectedIndex == 4) //Sexo
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbStatus.Enabled = false;
                cbCidade.Enabled = false;
                cbSexo.Enabled = true;
                Limpar();
            }

            if (cbTipoRel.SelectedIndex == 5) //Status
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbStatus.Enabled = true;
                cbCidade.Enabled = false;
                cbSexo.Enabled = false;
                Limpar();
            }
        }


        //Botão gerar Relatório
        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            classCliente cCLiente = new classCliente();
            string pesquisa = cbTipoRel.SelectedItem.ToString(); //Para pegar a opção escolhida pelo usuário
            switch (pesquisa)

            {
                case "Aniversariantes do Mês":
                    if (cbMes.Text != "Escolha um mês")
                    {
                        classClienteBindingSource.DataSource = cCLiente.RelClienteMes(cbMes.SelectedIndex);
                        this.rptvCliente.RefreshReport();

                    }
                    else
                    {
                        MessageBox.Show("Favor escolher um Mês", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Aniversariantes por Dia e Mês":
                    {
                        if (cbDia.Text != "Escolha um Dia" && cbMes.Text != "Escolha um Mês")
                        {
                            classClienteBindingSource.DataSource = cCLiente.RelClienteDiaMes(cbDia.SelectedIndex, cbMes.SelectedIndex);
                            this.rptvCliente.RefreshReport();

                        }
                        else
                        {
                            MessageBox.Show("Favor escolher um Dia e Mês", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    break;

                case "Aniversariantes Idade":
                    {
                        if (txtIdadeInicial.Text != "" && txtIdadeFinal.Text != "")
                        {
                            classClienteBindingSource.DataSource = cCLiente.RelClienteIdade(Convert.ToInt32(txtIdadeInicial.Text), Convert.ToInt32(txtIdadeFinal.Text));
                            this.rptvCliente.RefreshReport();
                        }
                        else
                        {
                            MessageBox.Show("Favor informar uma Idade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    break;

                case "Cidade":
                    {
                        if (cbCidade.Text != "")
                        {
                            classClienteBindingSource.DataSource = cCLiente.RelClienteCidade(cbCidade.SelectedValue.ToString());
                            this.rptvCliente.RefreshReport();
                        }
                        else
                        {
                            MessageBox.Show("Favor escolher uma Cidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    break;

                case "Sexo":
                    {
                        if (cbSexo.Text == "Escolha um Sexo")
                        {
                            MessageBox.Show("Favor escolher um Sexo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (cbSexo.Text == "Feminino")
                            {
                                classClienteBindingSource.DataSource = cCLiente.RelClienteSexo("F");
                                this.rptvCliente.RefreshReport();
                            }
                            else
                            {
                                classClienteBindingSource.DataSource = cCLiente.RelClienteSexo("M");
                                this.rptvCliente.RefreshReport();
                            }
                        }
                    }
                    break;

                case "Status":
                    {
                        if (rbtAtivo.Checked == true)
                        {
                            classClienteBindingSource.DataSource = cCLiente.RelClienteStatus(1);
                            this.rptvCliente.RefreshReport();
                        }
                        else
                        {
                            classClienteBindingSource.DataSource = cCLiente.RelClienteStatus(0);
                            this.rptvCliente.RefreshReport();
                        }
                    }
                    break;
            }
        }


        //Botão Sair
        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}



