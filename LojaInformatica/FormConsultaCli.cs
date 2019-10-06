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
    public partial class FormConsultaCli : Form
    {
        public FormConsultaCli()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormConsultaCli_Load(object sender, EventArgs e)
        {
            cbCategorias.Items.Add("Nome");
            cbCategorias.Items.Add("CPF");
            cbCategorias.Items.Add("Status");
            cbCategorias.Items.Add("Sexo");
            cbCategorias.Items.Add("Bairro");

            cbCategorias.SelectedItem = "Nome";

            rbContem.Checked = true;
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategorias.SelectedIndex == 0) //Nome
            {
                txtPesquisar.Enabled = true;
                gbPesquisa.Enabled = true;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                txtPesquisar.Focus();
            }

            if (cbCategorias.SelectedIndex == 1) //CPF
            {
                txtPesquisar.Enabled = true;
                gbPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                txtPesquisar.Focus();
            }

            if (cbCategorias.SelectedIndex == 2) //Status
            {
                txtPesquisar.Enabled = false;
                gbPesquisa.Enabled = false;
                gbStatus.Enabled = true;
                gbSexo.Enabled = false;
            }

            if (cbCategorias.SelectedIndex == 3) //Sexo
            {
                txtPesquisar.Enabled = false;
                gbPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = true;
            }

            if (cbCategorias.SelectedIndex == 4) //Bairro
            {
                txtPesquisar.Enabled = true;
                gbPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                txtPesquisar.Focus();
            }

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //Variável para o campo pesquisar
            string Consulta = cbCategorias.SelectedItem.ToString();

            //Criando objeto para chamar o método
            classCliente cCliente = new classCliente();

            //Abrindo o case para verificar a combo

            switch (Consulta)
            {
                case "Nome":
                    //Verificar se algum nome foi digitado
                    if (txtPesquisar.Text != "")
                    {
                        //Início
                        if (rbinicial.Checked == true)
                        {
                            dgvResult.DataSource = cCliente.BuscarClienteInicial(txtPesquisar.Text);                           
                            this.dgvResult.Columns[0].Visible = false;

                        }
                        //Contém
                        else
                        {
                            dgvResult.DataSource = cCliente.BuscarClienteContem(txtPesquisar.Text);
                            this.dgvResult.Columns[0].Visible = false;
                        }

                    }
                    else
                        MessageBox.Show("Favor informar um Nome.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "CPF":
                    if (txtPesquisar.Text != "")
                    {
                        dgvResult.DataSource = cCliente.BuscarClienteCPF(txtPesquisar.Text);
                        this.dgvResult.Columns[0].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Favor informar um número de CPF.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }                  
                    break;

                case "Status":

                    if (rbAtivo.Checked == false && rbInativo.Checked == false)
                    {
                        MessageBox.Show("Favor selecionar uma das Opções.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        if (rbAtivo.Checked == true)
                        {
                            dgvResult.DataSource = cCliente.BuscarClienteStatus(1);
                            this.dgvResult.Columns[0].Visible = false;
                        }
                        else
                        {
                            dgvResult.DataSource = cCliente.BuscarClienteStatus(0);
                            this.dgvResult.Columns[0].Visible = false;
                        }
                    }
                    break;


                case "Sexo":
                    if (rbMasculinoCon.Checked == false && rbFemininoCon.Checked == false)
                    {
                        MessageBox.Show("Favor selecionar uma das opções", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (rbMasculinoCon.Checked == true)
                        {
                            dgvResult.DataSource = cCliente.BuscarClienteSexo("M");
                            this.dgvResult.Columns[0].Visible = false;
                        }
                        else
                        {
                            dgvResult.DataSource = cCliente.BuscarClienteSexo("F");
                            this.dgvResult.Columns[0].Visible = false;
                        }
                    }
                    break;

                case "Bairro":
                    if (txtPesquisar.Text == "")
                    {
                        MessageBox.Show("Favor informar um Bairro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        dgvResult.DataSource = cCliente.BuscarClienteBairro(txtPesquisar.Text);
                        this.dgvResult.Columns[0].Visible = false;
                    }
                    break;
            }
        }

       //Na grid de clientes e editar ou excluir um cliente
       //Evento CellClick (Pode clicar em qualquer da célula, não somente no texto)
       //O evento CellContentClick (Tem que Clicar no conteúdo (text))

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o(a) cliente selecionado(a)?", "Sistema Loja de Informática", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                //Instanciar a classe cliente para usar métodos e propriedades
                classCliente cCliente = new classCliente();

                //Instanciar o formulário de cadastro/Atualização de cliente para usar os controles do FORM
                FormCliente fCliente = new FormCliente();

                //Atualização Título
                fCliente.Text = "Atualização de Cliente";

                //Pegar o Código do Cliente selecionado pelo usuário na Grid
                cCliente.ConsultarCliente(Convert.ToInt32(dgvResult.SelectedRows[0].Cells[0].Value));

                //Passar os Dados do BD para os controles do FORM de Clientes

                fCliente.txtCodCli.Text = cCliente.cod_cli.ToString();
                fCliente.datacad = cCliente.data_cad_cli;
                fCliente.txtNomeCli.Text = cCliente.nome_cli.ToString();
                fCliente.txtSobrenomeCli.Text = cCliente.sobrenome_cli.ToString();
                fCliente.mtxtDataNascCli.Text = cCliente.data_nasc_cli.ToString();
                fCliente.mtxtCpfCli.Text = cCliente.cpf_cli.ToString();
                fCliente.mtxtCepCli.Text = cCliente.cep_cli.ToString();
                fCliente.txtRuaCli.Text = cCliente.rua_cli.ToString();
                fCliente.txtNumeroCli.Text = cCliente.numero_cli.ToString();
                fCliente.txtComplementoCli.Text = cCliente.complemento_cli.ToString();
                fCliente.txtBairroCli.Text = cCliente.bairro_cli.ToString();
                fCliente.txtCidadeCli.Text = cCliente.cidade_cli.ToString();
                fCliente.estado = cCliente.estado_cli.ToString();
                fCliente.txtEmailCli.Text = cCliente.email_cli.ToString();
                fCliente.mtxtTelComCli.Text = cCliente.tel_com_cli.ToString();
                fCliente.mtxtTelResCli.Text = cCliente.tel_res_cli.ToString();
                fCliente.mtxtCelCli.Text = cCliente.cel_cli.ToString();


                //RadioButton
                if (cCliente.sexo_cli == "M")
                {
                    fCliente.rbMasculinoCli.Checked = true;
                }
                else
                {
                    fCliente.rbFemininoCli.Checked = true;
                }
                if (cCliente.status_cli == 1)
                {
                    fCliente.ckbStatusAtivo.Checked = true;
                }
                else
                {
                    fCliente.ckbStatusAtivo.Checked = false;
                }

                //Mandar a informação de update
                fCliente.tipo = "Atualização";
                //Depois de Atualizar fecha o formulário
                fCliente.ShowDialog();
                //Chamar método de pesquisa
                btPesquisar_Click(this, new EventArgs());
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            dgvResult.DataSource = null;
            txtPesquisar.Text = "";        
        }
    }
}
