using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaInformatica
{
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }
        public string tipo, estado, cargo;
        public DateTime datacad;

        //Carregando funções no carregamento do FORM
        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            //Carregar Combo Cargo
            classCargo cCargo = new classCargo();
            cbCargoFunc.DataSource = cCargo.BuscarCargo();
            cbCargoFunc.DisplayMember = "nome_cargo";
            cbCargoFunc.ValueMember = "cod_cargo";
            cbCargoFunc.SelectedIndex = -1;

            //Carregar Data
            lbDataCadFuncRes.Text = DateTime.Now.ToShortDateString();

            //Carregar Combo de estado
            cbEstadoFunc.Items.Add("AC");
            cbEstadoFunc.Items.Add("AL");
            cbEstadoFunc.Items.Add("AP");
            cbEstadoFunc.Items.Add("AM");
            cbEstadoFunc.Items.Add("BA");
            cbEstadoFunc.Items.Add("CE");
            cbEstadoFunc.Items.Add("DF");
            cbEstadoFunc.Items.Add("ES");
            cbEstadoFunc.Items.Add("GO");
            cbEstadoFunc.Items.Add("MA");
            cbEstadoFunc.Items.Add("MT");
            cbEstadoFunc.Items.Add("MS");
            cbEstadoFunc.Items.Add("MG");
            cbEstadoFunc.Items.Add("PA");
            cbEstadoFunc.Items.Add("PB");
            cbEstadoFunc.Items.Add("PR");
            cbEstadoFunc.Items.Add("PE");
            cbEstadoFunc.Items.Add("PI");
            cbEstadoFunc.Items.Add("RJ");
            cbEstadoFunc.Items.Add("RN");
            cbEstadoFunc.Items.Add("RS");
            cbEstadoFunc.Items.Add("RO");
            cbEstadoFunc.Items.Add("RR");
            cbEstadoFunc.Items.Add("SC");
            cbEstadoFunc.Items.Add("SP");
            cbEstadoFunc.Items.Add("SE");
            cbEstadoFunc.Items.Add("TO");

            //Colocar os itens em ordem alfabética
            cbEstadoFunc.Sorted = true;       

            //Máscara Campo CPF
            mtxtCpfFunc.Mask = "000,000,000-00";

            if (tipo == "Atualização")
            {
                btCadastrarFunc.Enabled = false;
                ckbStatusAtivo.Enabled = true;
                lbDataCadFuncRes.Text = datacad.ToString();
                cbEstadoFunc.SelectedItem = estado;
                cbCargoFunc.SelectedValue = cargo;
                btAtualizarFunc.Enabled = true;
                btExcluirFunc.Enabled = true;
            }
            else
            {
                btAtualizarFunc.Enabled = false;
                btExcluirFunc.Enabled = false;
            }
        }

        //Validação do CPF - Método
        public bool Valida(string cpf)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;

            string digito;

            int soma;

            int resto;

            cpf = cpf.Trim();

            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)

                return false;

            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);

        }

        private void Limpar()
        {
            //campos
            txtNomeFunc.Text = "";
            txtSobrenomeFunc.Text = "";
            rbFemininoFunc.Checked = false;
            rbMasculinoFunc.Checked = false;
            mtxtDataNascFunc.Text = "";
            mtxtCpfFunc.Text = "";
            mtxtCelFunc.Text = "";
            txtRuaFunc.Text = "";
            txtNumeroFunc.Text = "";
            txtComplementoFunc.Text = "";
            txtBairroFunc.Text = "";
            txtCidadeFunc.Text = "";
            cbEstadoFunc.SelectedIndex = -1;
            mtxtTelResFunc.Text = "";
            mtxtTelComFunc.Text = "";
            mtxtCelFunc.Text = "";
            txtEmailFunc.Text = "";
            mtxtCepFunc.Text = "";
            txtSalFunc.Text = "";
            txtNomeSocialFunc.Text = "";
            cbCargoFunc.SelectedItem = -1;
            mtxtdataExpFunc.Text = "";
            mtxtNumRgFunc.Text = "";
            txtOrgEmissorFunc.Text = "";
            cbCargoFunc.SelectedIndex = -1;

            //retornar cores
            txtNomeFunc.BackColor = Color.White;
            txtSobrenomeFunc.BackColor = Color.White;
            mtxtDataNascFunc.BackColor = Color.White;
            mtxtCpfFunc.BackColor = Color.White;
            cbCargoFunc.BackColor = Color.White;
            mtxtCepFunc.BackColor = Color.White;
            txtRuaFunc.BackColor = Color.White;
            txtNumeroFunc.BackColor = Color.White;
            txtBairroFunc.BackColor = Color.White;
            txtCidadeFunc.BackColor = Color.White;
            cbEstadoFunc.BackColor = Color.White;
            mtxtTelComFunc.BackColor = Color.White;
            mtxtNumRgFunc.BackColor = Color.White;
            mtxtdataExpFunc.BackColor = Color.White;
            txtOrgEmissorFunc.BackColor = Color.White;
            txtSalFunc.BackColor = Color.White;
            mtxtTelResFunc.BackColor = Color.White;
            mtxtCelFunc.BackColor = Color.White;
            lbTelAtencao.ForeColor = Color.Black;
            lbCamposObrig.ForeColor = Color.Black;
            txtNomeFunc.Focus();
        }


        //Cadastro de Funcionário
        private void btCadastrarFunc_Click(object sender, EventArgs e)
        {

            //Instanciar a classe funcionário para usar métodos e propriedades
            classFuncionario cFuncionario = new classFuncionario();
         
            //radiobutton sexo
            if (rbFemininoFunc.Checked == false && rbMasculinoFunc.Checked == false)
            {
                MessageBox.Show("Selecionar o campo Sexo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Campos obrigatórios
                if (txtNomeFunc.Text != "" && txtSobrenomeFunc.Text != "" && mtxtDataNascFunc.Text != "  /  /" && mtxtCpfFunc.Text != "   .   .   -" && txtSalFunc.Text != "" && mtxtCepFunc.Text != "     -" && txtRuaFunc.Text != "" && txtNumeroFunc.Text != "" && txtBairroFunc.Text != "" && txtCidadeFunc.Text != "" && mtxtNumRgFunc.Text != "" && txtOrgEmissorFunc.Text != "" && mtxtdataExpFunc.Text != "  /  /" && (mtxtTelResFunc.Text != "(  )     -" || mtxtTelComFunc.Text != "(  )     -" || mtxtCelFunc.Text != "(  )      -"))
                {
                    //Passar para as propriedades o conteúdo do formulário
                    //Todos os campos que o usuário pode preencher
                    cFuncionario.nome_func = txtNomeFunc.Text;
                    cFuncionario.sobrenome_func = txtSobrenomeFunc.Text;
                    cFuncionario.nome_social_func = txtNomeSocialFunc.Text;
                    cFuncionario.data_nasc_func = Convert.ToDateTime(mtxtDataNascFunc.Text);
                    cFuncionario.cpf_func = mtxtCpfFunc.Text;
                    cFuncionario.sal_func = Convert.ToDecimal(txtSalFunc.Text);
                    cFuncionario.cep_func = mtxtCepFunc.Text;
                    cFuncionario.rua_func = txtRuaFunc.Text;
                    cFuncionario.numero_func = Convert.ToInt32(txtNumeroFunc.Text);
                    cFuncionario.complemento_func = txtComplementoFunc.Text;
                    cFuncionario.bairro_func = txtBairroFunc.Text;
                    cFuncionario.cidade_func = txtCidadeFunc.Text;
                    cFuncionario.estado_func = cbEstadoFunc.SelectedItem.ToString();
                    cFuncionario.num_rg_func = mtxtNumRgFunc.Text;
                    cFuncionario.orgao_emissor_func = txtOrgEmissorFunc.Text;
                    cFuncionario.data_expedicao_func = DateTime.Parse(mtxtdataExpFunc.Text);
                    cFuncionario.email_func = txtEmailFunc.Text;
                    cFuncionario.cod_cargo = Convert.ToInt32(cbCargoFunc.SelectedValue);

                    //RadioButton
                    if (rbFemininoFunc.Checked)
                    {
                        cFuncionario.sexo_func = "F";
                    }
                    else
                    {
                        cFuncionario.sexo_func = "M";
                    }


                    //Campos que são máscaras e não obrigatórios
                    if (mtxtTelResFunc.Text != "(  )     -")
                    {
                        cFuncionario.tel_res_func = mtxtTelResFunc.Text;
                    }
                    else
                    {
                        cFuncionario.tel_res_func = "";
                    }

                    if (mtxtTelComFunc.Text != "(  )     -")
                    {
                        cFuncionario.tel_com_func = mtxtTelComFunc.Text;
                    }
                    else
                    {
                        cFuncionario.tel_com_func = "";
                    }

                    if (mtxtCelFunc.Text != "(  )      -")
                    {
                        cFuncionario.cel_func = mtxtCelFunc.Text;
                    }
                    else
                    {
                        cFuncionario.cel_func = "";
                    }
                            

                    // Chamar o método da classe cliente para fazer o cadastro
                    int aux = cFuncionario.CadastrarFuncionario();

                    //Se der certo = 1
                    if (aux != 0)
                    {
                        MessageBox.Show(" O(A) Funcionário(a) " + cFuncionario.nome_func + " foi Cadastrado(a) com Sucesso.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Limpar campos do formulário, chamando o método Limpar
                        this.Limpar();


                    }
                    //Se der errado = 0
                    else
                    {
                        MessageBox.Show("Erro ao realizar o cadastro.",
                            "Sistema Loja de Informática",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //Se os campos não forem preenchidos corretamente...
                else
                {
                    MessageBox.Show("Verificar os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomeFunc.BackColor = Color.MistyRose;
                    txtSobrenomeFunc.BackColor = Color.MistyRose;
                    mtxtDataNascFunc.BackColor = Color.MistyRose;
                    txtSalFunc.BackColor = Color.MistyRose;
                    mtxtCpfFunc.BackColor = Color.MistyRose;
                    mtxtCepFunc.BackColor = Color.MistyRose;
                    txtRuaFunc.BackColor = Color.MistyRose;
                    txtNumeroFunc.BackColor = Color.MistyRose;
                    txtBairroFunc.BackColor = Color.MistyRose;
                    txtCidadeFunc.BackColor = Color.MistyRose;
                    cbEstadoFunc.BackColor = Color.MistyRose;
                    mtxtTelComFunc.BackColor = Color.MistyRose;
                    mtxtTelResFunc.BackColor = Color.MistyRose;
                    mtxtCelFunc.BackColor = Color.MistyRose;
                    mtxtNumRgFunc.BackColor = Color.MistyRose;
                    txtOrgEmissorFunc.BackColor = Color.MistyRose;
                    mtxtdataExpFunc.BackColor = Color.MistyRose;
                    cbCargoFunc.BackColor = Color.MistyRose;
                    lbTelAtencao.ForeColor = Color.DarkRed;
                    lbCamposObrig.ForeColor = Color.DarkRed;
                    txtNomeFunc.Focus();

                }
            }
        }

        //Consulta do CEP
        private void btConsultaCEP_Click(object sender, EventArgs e)
        {
            try
            {
                Correios.AtendeClienteClient consulta = new Correios.AtendeClienteClient("AtendeClientePort");

                //declarando variável e convertendo para a consulta no campo CEP
                var resultado = consulta.consultaCEP(mtxtCepFunc.Text);

                //apresentando os campos caso o cep digitado seja válido e diferente de não preenchido
                if (resultado != null)
                {
                    txtRuaFunc.Text = resultado.end;
                    txtBairroFunc.Text = resultado.bairro;
                    txtCidadeFunc.Text = resultado.cidade;
                    cbEstadoFunc.SelectedItem = resultado.uf;
                }

                //tratando uma excessão, caso o cep não seja encontrado ou não seja válido
            }
            catch (FaultException)
            {
                MessageBox.Show("Número de CEP não Encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtxtCepFunc.Clear();
                mtxtCepFunc.Focus();
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Não foi possível completar a operação \nVerifique sua conexão com a internet.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //Validação Número Residencial
        private void txtNumeroFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                //Se o usuário pressionar uma tecla não númerica no textbox. cancela o evento key press
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }


        //Trocando a tecla TAB por ENTER
        private void FormFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }


        //Validação campo Cargo
        private void cbCargoFunc_Validating(object sender, CancelEventArgs e)
        {
            if (cbCargoFunc.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Cargo não Selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        //Validação Número CPF
        private void mtxtCpfFunc_Validating(object sender, CancelEventArgs e)
        {
            //Com exceção da primeira função, o resto está sendo recebida através do método
            if (mtxtCpfFunc.Text == "111.111.111-11" || mtxtCpfFunc.Text == "222.222.222-22" || mtxtCpfFunc.Text == "333.333.333-33" || mtxtCpfFunc.Text == "444.444.444-44" || mtxtCpfFunc.Text == "555.555.555-55" || mtxtCpfFunc.Text == "666.666.666-66" || mtxtCpfFunc.Text == "777.777.777-77" || mtxtCpfFunc.Text == "888.888.888-88" || mtxtCpfFunc.Text == "999.999.999-99 " || mtxtCpfFunc.Text == "000.000.000-00")
            {
                MessageBox.Show("Número de CPF Inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Validando o campo CPF
                if (!mtxtCpfFunc.MaskCompleted)
                {
                    MessageBox.Show("Número de CPF incompleto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Valida(mtxtCpfFunc.Text))
                    {
                        cbCargoFunc.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Número de CPF Inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        mtxtCpfFunc.Clear();
                        mtxtCpfFunc.Focus();
                    }

                }
            }
        }


        //validação do campo data de nascimento func
        private void mtxtDataNascFunc_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {

            if (!e.IsValidInput)
            {
                mtxtDataNascFunc.Text = "  /  /";
            }

        }


        //Validação do campo data de expedição RG
        private void mtxtdataExpFunc_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                mtxtdataExpFunc.Text = "  /  /";
                mtxtdataExpFunc.BackColor = Color.MistyRose;
            }
        }


        //Começar campo com a primeira letra maiúscula
        private void txtNomeFunc_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNomeFunc.Text.Length > 0)
            {
                txtNomeFunc.Text = txtNomeFunc.Text.Substring(0, 1).ToUpper() + txtNomeFunc.Text.Substring(1);
                txtNomeFunc.SelectionStart = txtNomeFunc.Text.Length + 1;
            }
        }


        //Começar campo com a primeira letra maiúscula
        private void txtSobrenomeFunc_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSobrenomeFunc.Text.Length > 0)
            {
                txtSobrenomeFunc.Text = txtSobrenomeFunc.Text.Substring(0, 1).ToUpper() + txtSobrenomeFunc.Text.Substring(1);
                txtSobrenomeFunc.SelectionStart = txtSobrenomeFunc.Text.Length + 1;
            }
        }

        //Começar campo com a primeira letra maiúscula
        private void txtNomeSocialFunc_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNomeSocialFunc.Text.Length > 0)
            {
                txtNomeSocialFunc.Text = txtNomeSocialFunc.Text.Substring(0, 1).ToUpper() + txtNomeSocialFunc.Text.Substring(1);
                txtNomeSocialFunc.SelectionStart = txtNomeSocialFunc.Text.Length + 1;
            }
        }

        //Campo Salário
        private void txtSalFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Só permitir o uso de uma vírgula no campo, não permitir letras e símbolos
            if (e.KeyChar == ','
            && ((sender as TextBox).Text.IndexOf(',') > -1) || (char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
                txtSalFunc.Focus();
            }
        }


        //Fechar FORM
        private void btFecharFunc_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Excluir Funcionário
        private void btExcluirFunc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o(a) Funcionário(a)?", "Sistema Loja de Informática!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classFuncionario cFuncionario = new classFuncionario();
                cFuncionario.cod_func = Convert.ToInt32(txtCodFunc.Text);

                bool aux = cFuncionario.ExcluirFuncionario();

                if (aux)
                {
                    MessageBox.Show("Funcionário(a)" + cFuncionario.nome_func + " excluído(a) com sucesso", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este(a) Funcionário(a) não pode ser excluído(a),pois há registros em outras tabelas.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        //Atualizar Funcionário
        private void btAtualizarFunc_Click(object sender, EventArgs e)
        {

            //Instanciar a classe funcionário para usar métodos e propriedades
            classFuncionario cFuncionario = new classFuncionario();

            //radiobutton sexo
            if (rbFemininoFunc.Checked == false && rbMasculinoFunc.Checked == false)
            {
                MessageBox.Show("Selecionar o campo Sexo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Campos obrigatórios
                if (txtNomeFunc.Text != "" && txtSobrenomeFunc.Text != "" && mtxtDataNascFunc.Text != "  /  /" && mtxtCpfFunc.Text != "   .   .   -" && txtSalFunc.Text != "" && mtxtCepFunc.Text != "     -" && txtRuaFunc.Text != "" && txtNumeroFunc.Text != "" && txtBairroFunc.Text != "" && txtCidadeFunc.Text != "" && mtxtNumRgFunc.Text != "" && txtOrgEmissorFunc.Text != "" && mtxtdataExpFunc.Text != "  /  /" && (mtxtTelResFunc.Text != "(  )     -" || mtxtTelComFunc.Text != "(  )     -" || mtxtCelFunc.Text != "(  )      -"))
                {
                    //Passar para as propriedades o conteúdo do formulário
                    //Todos os campos que o usuário pode preencher
                    cFuncionario.nome_func = txtNomeFunc.Text;
                    cFuncionario.sobrenome_func = txtSobrenomeFunc.Text;
                    cFuncionario.nome_social_func = txtNomeSocialFunc.Text;
                    cFuncionario.data_nasc_func = Convert.ToDateTime(mtxtDataNascFunc.Text);
                    cFuncionario.cpf_func = mtxtCpfFunc.Text;
                    cFuncionario.sal_func = Convert.ToDecimal(txtSalFunc.Text);
                    cFuncionario.cep_func = mtxtCepFunc.Text;
                    cFuncionario.rua_func = txtRuaFunc.Text;
                    cFuncionario.numero_func = Convert.ToInt32(txtNumeroFunc.Text);
                    cFuncionario.complemento_func = txtComplementoFunc.Text;
                    cFuncionario.bairro_func = txtBairroFunc.Text;
                    cFuncionario.cidade_func = txtCidadeFunc.Text;
                    cFuncionario.estado_func = cbEstadoFunc.SelectedItem.ToString();
                    cFuncionario.num_rg_func = mtxtNumRgFunc.Text;
                    cFuncionario.orgao_emissor_func = txtOrgEmissorFunc.Text;
                    cFuncionario.data_expedicao_func = DateTime.Parse(mtxtdataExpFunc.Text);
                    cFuncionario.email_func = txtEmailFunc.Text;
                    cFuncionario.cod_cargo = Convert.ToInt32(cbCargoFunc.SelectedValue);
                    cFuncionario.sal_func = Convert.ToDecimal(txtSalFunc.Text);

                    //RadioButton
                    if (rbFemininoFunc.Checked)
                    {
                        cFuncionario.sexo_func = "F";
                    }
                    else
                    {
                        cFuncionario.sexo_func = "M";
                    }


                    //Campos que são máscaras e não obrigatórios
                    if (mtxtTelResFunc.Text != "(  )     -")
                    {
                        cFuncionario.tel_res_func = mtxtTelResFunc.Text;
                    }
                    else
                    {
                        cFuncionario.tel_res_func = "";
                    }

                    if (mtxtTelComFunc.Text != "(  )     -")
                    {
                        cFuncionario.tel_com_func = mtxtTelComFunc.Text;
                    }
                    else
                    {
                        cFuncionario.tel_com_func = "";
                    }

                    if (mtxtCelFunc.Text != "(  )      -")
                    {
                        cFuncionario.cel_func = mtxtCelFunc.Text;
                    }
                    else
                    {
                        cFuncionario.cel_func = "";
                    }
                   
                    if (ckbStatusAtivo.Checked == true)
                    {
                        cFuncionario.status_func = 1;
                    }
                    else
                    {
                        cFuncionario.status_func = 0;
                    }

                    //Status FUNC
                    if (cFuncionario.status_func == 0)
                    {
                        ckbStatusAtivo.Checked = false;
                    }
                    else
                    {
                        if (cFuncionario.status_func == 1)
                        {
                            ckbStatusAtivo.Checked = true;
                        }
                        else
                        {
                            ckbStatusAtivo.Checked = true;
                        }
                    }

                    cFuncionario.cod_func = Convert.ToInt32(txtCodFunc.Text);

                    bool aux = cFuncionario.AtualizarFuncionario();

                    if (aux)
                    {
                        MessageBox.Show("Funcionário(a) " + cFuncionario.nome_func + " Atualizado(a) com Sucesso.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Verificar os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomeFunc.BackColor = Color.MistyRose;
                    txtSobrenomeFunc.BackColor = Color.MistyRose;
                    mtxtDataNascFunc.BackColor = Color.MistyRose;
                    txtSalFunc.BackColor = Color.MistyRose;
                    mtxtCpfFunc.BackColor = Color.MistyRose;
                    mtxtCepFunc.BackColor = Color.MistyRose;
                    txtRuaFunc.BackColor = Color.MistyRose;
                    txtNumeroFunc.BackColor = Color.MistyRose;
                    txtBairroFunc.BackColor = Color.MistyRose;
                    txtCidadeFunc.BackColor = Color.MistyRose;
                    cbEstadoFunc.BackColor = Color.MistyRose;
                    mtxtTelComFunc.BackColor = Color.MistyRose;
                    mtxtTelResFunc.BackColor = Color.MistyRose;
                    mtxtCelFunc.BackColor = Color.MistyRose;
                    mtxtNumRgFunc.BackColor = Color.MistyRose;
                    txtOrgEmissorFunc.BackColor = Color.MistyRose;
                    mtxtdataExpFunc.BackColor = Color.MistyRose;
                    cbCargoFunc.BackColor = Color.MistyRose;
                    lbTelAtencao.ForeColor = Color.DarkRed;
                    lbCamposObrig.ForeColor = Color.DarkRed;
                    txtNomeFunc.Focus();
                }
            }
        }
    }
}


                


             
           
 