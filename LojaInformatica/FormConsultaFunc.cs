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
    public partial class FormConsultaFunc : Form
    {
        public FormConsultaFunc()
        {
            InitializeComponent();
        }

        private void FormConsultaFunc_Load(object sender, EventArgs e)
        {
            cbCategorias.Items.Add("Nome");
            cbCategorias.Items.Add("CPF");
            cbCategorias.Items.Add("Status");
            cbCategorias.Items.Add("Cargo");
            cbCategorias.Items.Add("Sexo");

            cbCategorias.SelectedItem = "Nome";

            rbContem.Checked = true;

            //Carregar Combo CargoFunc
            classCargo cCargo = new classCargo();
            cbCargoFunc.DataSource = cCargo.BuscarCargo();//Executar Met. na classe categoria
            cbCargoFunc.DisplayMember = "nome_cargo";//Exibir na combo(Nome)
            cbCargoFunc.ValueMember = "cod_cargo"; //guardar no bd(código)
            cbCargoFunc.SelectedIndex = -1; //Limpar a combo(não selecionar nada)

        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategorias.SelectedIndex == 0) //Nome
            {
                txtPesquisar.Enabled = true;
                gbPesquisa.Enabled = true;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                cbCargoFunc.Enabled = false;
                txtPesquisar.Focus();
            }

            if (cbCategorias.SelectedIndex == 1) //CPF
            {
                txtPesquisar.Enabled = true;
                gbPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                cbCargoFunc.Enabled = false;
            }

            if (cbCategorias.SelectedIndex == 2) //Status
            {
                txtPesquisar.Enabled = false;
                gbPesquisa.Enabled = false;
                gbStatus.Enabled = true;
                gbSexo.Enabled = false;
                cbCargoFunc.Enabled = false;
            }

            if (cbCategorias.SelectedIndex == 3) //Cargo
            {
                txtPesquisar.Enabled = false;
                gbPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                cbCargoFunc.Enabled = true;
                
            }

            if (cbCategorias.SelectedIndex == 4) //Sexo
            {
                txtPesquisar.Enabled = false;
                gbPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = true;
                cbCargoFunc.Enabled = false;
            }
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o(a) Funcionário(a) selecionado(a)?", "Sistema Loja de Informática", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Instanciar a classe Funcionário para usar métodos e propriedades
                classFuncionario cFuncionario = new classFuncionario();

                //Instanciar o formulário de cadastro/Atualização de cliente para usar os controles do FORM
                FormFuncionario fFuncionario = new FormFuncionario();

                //Atualização - Título
                fFuncionario.Text = "Atualização de Funcionário";

                //Pegar o Código do Cliente selecionado pelo usuário na Grid
                cFuncionario.ConsultarFuncionario(Convert.ToInt32(dgvResult.SelectedRows[0].Cells[0].Value));

                //Passar os Dados do BD para os controles do FORM de Funcionarios

                fFuncionario.txtCodFunc.Text = cFuncionario.cod_func.ToString();
                fFuncionario.datacad = cFuncionario.data_cad_func;
                fFuncionario.txtNomeFunc.Text = cFuncionario.nome_func.ToString();
                fFuncionario.txtSobrenomeFunc.Text = cFuncionario.sobrenome_func;
                fFuncionario.txtNomeSocialFunc.Text = cFuncionario.nome_social_func;
                fFuncionario.mtxtDataNascFunc.Text = cFuncionario.data_nasc_func.ToString();
                fFuncionario.mtxtCpfFunc.Text = cFuncionario.cpf_func.ToString();
                fFuncionario.mtxtCepFunc.Text = cFuncionario.cep_func.ToString();
                fFuncionario.txtRuaFunc.Text = cFuncionario.rua_func.ToString();
                fFuncionario.txtNumeroFunc.Text = cFuncionario.numero_func.ToString();
                fFuncionario.txtComplementoFunc.Text = cFuncionario.complemento_func.ToString();
                fFuncionario.txtBairroFunc.Text = cFuncionario.bairro_func.ToString();
                fFuncionario.txtCidadeFunc.Text = cFuncionario.cidade_func.ToString();
                fFuncionario.estado = cFuncionario.estado_func.ToString();
                fFuncionario.txtEmailFunc.Text = cFuncionario.email_func.ToString();
                fFuncionario.mtxtTelComFunc.Text = cFuncionario.tel_com_func.ToString();
                fFuncionario.mtxtTelResFunc.Text = cFuncionario.tel_res_func.ToString();
                fFuncionario.mtxtCelFunc.Text = cFuncionario.cel_func.ToString();
                fFuncionario.txtOrgEmissorFunc.Text = cFuncionario.orgao_emissor_func.ToString();
                fFuncionario.mtxtdataExpFunc.Text = cFuncionario.data_expedicao_func.ToString();
                fFuncionario.mtxtNumRgFunc.Text = cFuncionario.num_rg_func.ToString();
                fFuncionario.cargo = cFuncionario.cod_cargo.ToString();
                fFuncionario.txtSalFunc.Text = cFuncionario.sal_func.ToString();


                //RadioButton
                if (cFuncionario.sexo_func == "M")
                {
                    fFuncionario.rbMasculinoFunc.Checked = true;
                }
                else
                {
                    fFuncionario.rbFemininoFunc.Checked = true;
                }
                if (cFuncionario.status_func == 1)
                {
                    fFuncionario.ckbStatusAtivo.Checked = true;
                }
                else
                {
                    fFuncionario.ckbStatusAtivo.Checked = false;
                }

                //Mandar a informação de update
                fFuncionario.tipo = "Atualização";
                //Depois de Atualizar fecha o formulário
                fFuncionario.ShowDialog();
                //Chamar método de pesquisa
                btPesquisar_Click(this, new EventArgs());

                
            }          
        }

      


        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //Variável para o campo pesquisar
            string Consulta = cbCategorias.SelectedItem.ToString();

            //Criando objeto para chamar o método
            classFuncionario cFuncionario = new classFuncionario();

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
                            dgvResult.DataSource = cFuncionario.BuscarFuncionarioInicial(txtPesquisar.Text);
                            this.dgvResult.Columns[0].Visible = false;
                        }
                        //Contém
                        else
                        {
                            dgvResult.DataSource = cFuncionario.BuscarFuncionarioContem(txtPesquisar.Text);
                            this.dgvResult.Columns[0].Visible = false;
                        }

                    }
                    else
                        MessageBox.Show("Favor informar um Nome.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "CPF":
                    if (txtPesquisar.Text != "")
                    {
                        dgvResult.DataSource = cFuncionario.BuscarFuncionarioCPF(txtPesquisar.Text);
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
                            dgvResult.DataSource = cFuncionario.BuscarFuncionarioStatus(1);
                            this.dgvResult.Columns[0].Visible = false;
                        }
                        else
                        {
                            dgvResult.DataSource = cFuncionario.BuscarFuncionarioStatus(0);
                            this.dgvResult.Columns[0].Visible = false;
                        }
                    }
                    break;

                case "Cargo":
                    if (cbCargoFunc.SelectedIndex == -1)
                    {
                        MessageBox.Show("Favor informar um cargo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        dgvResult.DataSource = cFuncionario.BuscarFuncionarioCargo(Convert.ToInt32(cbCargoFunc.SelectedValue));
                        this.dgvResult.Columns[0].Visible = false;
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
                            dgvResult.DataSource = cFuncionario.BuscarFuncionarioSexo("M");
                            this.dgvResult.Columns[0].Visible = false;
                        }
                        else
                        {
                            dgvResult.DataSource = cFuncionario.BuscarFuncionarioSexo("F");
                            this.dgvResult.Columns[0].Visible = false;
                        }
                    }
                    break;
            }        
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            dgvResult.DataSource = null;
            txtPesquisar.Text = "";
            cbCargoFunc.SelectedIndex = -1;
        }
    }
}
