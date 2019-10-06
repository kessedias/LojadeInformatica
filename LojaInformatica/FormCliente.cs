using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.Net;
using System.ServiceModel;

namespace LojaInformatica
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        public string tipo, estado;
        public DateTime datacad;

        private void btFecharCli_Click(object sender, EventArgs e)
        {
            Close();
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
          
        //Limpeza de Campos - Método
        private void Limpar()
        {
            //campos
            txtNomeCli.Text = "";
            txtSobrenomeCli.Text = "";
            rbFemininoCli.Checked = false;
            rbMasculinoCli.Checked = false;
            mtxtDataNascCli.Text = "";
            mtxtCpfCli.Text = "";
            mtxtCelCli.Text = "";
            txtRuaCli.Text = "";
            txtNumeroCli.Text = "";
            txtComplementoCli.Text = "";
            txtBairroCli.Text = "";
            txtCidadeCli.Text = "";
            cbEstadoCli.SelectedIndex = -1;
            mtxtTelResCli.Text = "";
            mtxtTelComCli.Text = "";
            mtxtCelCli.Text = "";
            txtEmailCli.Text = "";
            mtxtCepCli.Text = "";
            //retornar cores
            txtNomeCli.BackColor = Color.White;
            txtSobrenomeCli.BackColor = Color.White;
            mtxtDataNascCli.BackColor = Color.White;
            mtxtCpfCli.BackColor = Color.White;
            mtxtCepCli.BackColor = Color.White;
            txtRuaCli.BackColor = Color.White;
            txtNumeroCli.BackColor = Color.White;
            txtBairroCli.BackColor = Color.White;
            txtCidadeCli.BackColor = Color.White;
            cbEstadoCli.BackColor = Color.White;
            mtxtTelComCli.BackColor = Color.White;
            mtxtTelResCli.BackColor = Color.White;
            mtxtCelCli.BackColor = Color.White;
            lbTelAtencao.ForeColor = Color.Black;
            lbCamposObrig.ForeColor = Color.Black;
            txtNomeCli.Focus();
           


        }

        private void btCadastrarCli_Click(object sender, EventArgs e)
        {
            //Lembrar que os campos do tipo número e data não podem ser vazio,
            //Caso não seja obrigatório no BD fazer um if para mandar 0 (Número) e uma data válida

            //Instanciar a classe cliente para usar métodos e propriedades
            classCliente cCliente = new classCliente();

   
            if (rbFemininoCli.Checked == false && rbMasculinoCli.Checked == false)
            {
                MessageBox.Show("Selecionar o campo Sexo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
                else
                {

                    //Verificar campos obrigatórios (validando pelo menos um telefone)
                    if ((txtNomeCli.Text != "" && txtSobrenomeCli.Text != "" && mtxtDataNascCli.Text != "  /  /" && mtxtCpfCli.Text != "   .   .   -" && mtxtCepCli.Text != "     -" && txtRuaCli.Text != "" && txtNumeroCli.Text != "" && txtBairroCli.Text != "" && txtCidadeCli.Text != "" && cbEstadoCli.Text != "") && (mtxtTelResCli.Text != "(  )     -" || mtxtTelComCli.Text != "(  )     -" || mtxtCelCli.Text != "(  )      -"))

                    {
                        //Passar para as propriedades o conteúdo do formulário
                        //Todos os campos que o usuário pode preencher
                        cCliente.nome_cli = txtNomeCli.Text;
                        cCliente.sobrenome_cli = txtSobrenomeCli.Text;                      
                        cCliente.data_nasc_cli = DateTime.Parse(mtxtDataNascCli.Text);
                        cCliente.cpf_cli = mtxtCpfCli.Text;
                        cCliente.cep_cli = mtxtCepCli.Text;
                        cCliente.rua_cli = txtRuaCli.Text;
                        cCliente.numero_cli = Convert.ToInt32(txtNumeroCli.Text);
                        cCliente.complemento_cli = txtComplementoCli.Text;
                        cCliente.bairro_cli = txtBairroCli.Text;
                        cCliente.cidade_cli = txtCidadeCli.Text;
                        cCliente.estado_cli = cbEstadoCli.SelectedItem.ToString();
                        cCliente.email_cli = txtEmailCli.Text;


                        //RadioButton
                        if (rbFemininoCli.Checked)
                        {
                            cCliente.sexo_cli = "F";
                        }
                        else
                        {
                            cCliente.sexo_cli = "M";
                        }


                        //Campos que são máscaras e não obrigatórios
                        if (mtxtTelResCli.Text != "(  )     -")
                        {
                            cCliente.tel_res_cli = mtxtTelResCli.Text;
                        }
                        else
                        {
                            cCliente.tel_res_cli = "";
                        }

                        if (mtxtTelComCli.Text != "(  )     -")
                        {
                            cCliente.tel_com_cli = mtxtTelComCli.Text;
                        }
                        else
                        {
                            cCliente.tel_com_cli = "";
                        }

                        if (mtxtCelCli.Text != "(  )      -")
                        {
                            cCliente.cel_cli = mtxtCelCli.Text;
                        }
                        else
                        {
                            cCliente.cel_cli = "";
                        }


                        // Chamar o método da classe cliente para fazer o cadastro
                        int aux = cCliente.CadastrarCliente();

                        //Se der certo = 1
                        if (aux != 0)
                        {
                            MessageBox.Show(" O(A) Cliente " + cCliente.nome_cli + " foi Cadastrado(a) com Sucesso.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    else
                    {
                        MessageBox.Show("Verificar os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNomeCli.BackColor = Color.MistyRose;
                        txtSobrenomeCli.BackColor = Color.MistyRose;
                        mtxtDataNascCli.BackColor = Color.MistyRose;
                        mtxtCpfCli.BackColor = Color.MistyRose;
                        mtxtCepCli.BackColor = Color.MistyRose;
                        txtRuaCli.BackColor = Color.MistyRose;
                        txtNumeroCli.BackColor = Color.MistyRose;
                        txtBairroCli.BackColor = Color.MistyRose;
                        txtCidadeCli.BackColor = Color.MistyRose;
                        cbEstadoCli.BackColor = Color.MistyRose;
                        mtxtTelComCli.BackColor = Color.MistyRose;
                        mtxtTelResCli.BackColor = Color.MistyRose;
                        mtxtCelCli.BackColor = Color.MistyRose;
                        lbTelAtencao.ForeColor = Color.DarkRed;
                        lbCamposObrig.ForeColor = Color.DarkRed;
                        txtNomeCli.Focus();
                    }
                }                     
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

            //Carregar data na Label
            lbDataCadCliRes.Text = DateTime.Now.ToShortDateString();

            //Carregar Combo de estado
            cbEstadoCli.Items.Add("AC");
            cbEstadoCli.Items.Add("AL");
            cbEstadoCli.Items.Add("AP");
            cbEstadoCli.Items.Add("AM");
            cbEstadoCli.Items.Add("BA");
            cbEstadoCli.Items.Add("CE");
            cbEstadoCli.Items.Add("DF");
            cbEstadoCli.Items.Add("ES");
            cbEstadoCli.Items.Add("GO");
            cbEstadoCli.Items.Add("MA");
            cbEstadoCli.Items.Add("MT");
            cbEstadoCli.Items.Add("MS");
            cbEstadoCli.Items.Add("MG");
            cbEstadoCli.Items.Add("PA");
            cbEstadoCli.Items.Add("PB");
            cbEstadoCli.Items.Add("PR");
            cbEstadoCli.Items.Add("PE");
            cbEstadoCli.Items.Add("PI");
            cbEstadoCli.Items.Add("RJ");
            cbEstadoCli.Items.Add("RN");
            cbEstadoCli.Items.Add("RS");
            cbEstadoCli.Items.Add("RO");
            cbEstadoCli.Items.Add("RR");
            cbEstadoCli.Items.Add("SC");
            cbEstadoCli.Items.Add("SP");
            cbEstadoCli.Items.Add("SE");
            cbEstadoCli.Items.Add("TO");
            //Colocar os itens em ordem alfabética
            cbEstadoCli.Sorted = true;

            //Máscara Campo CPF
            mtxtCpfCli.Mask = "000,000,000-00";

            if (tipo == "Atualização")
            {
                btCadastrarCli.Enabled = false;
                ckbStatusAtivo.Enabled = true;                
                lbDataCadCliRes.Text = datacad.ToString();
                cbEstadoCli.SelectedItem = estado;
                btAtualizarCli.Enabled = true;
                btExcluirCli.Enabled = true;
            }
            else
            {
                btAtualizarCli.Enabled = false;
                btExcluirCli.Enabled = false;
            }
        }
        
      
   
  
        //Permitindo apenas que o usuário digite número na caixa Número do formulário
        private void txtNumeroCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                //Se o usuário pressionar uma tecla não númerica no textbox. cancela o evento key press
                e.Handled = true;              
                txtNumeroCli.Focus();
            }
        }

        private void mtxtDataNascCli_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            {
                if (!e.IsValidInput)
                mtxtDataNascCli.Text = "  /  /";
                //validação do campo data
            }
        }

        //Validando os números válidos do CEP
        private void mtxtCpfCli_Validating(object sender, CancelEventArgs e)
        {
            //Com exceção da primeira função, o resto está sendo recebida através do método
            if (mtxtCpfCli.Text == "111.111.111-11" || mtxtCpfCli.Text == "222.222.222-22" || mtxtCpfCli.Text == "333.333.333-33" || mtxtCpfCli.Text == "444.444.444-44" || mtxtCpfCli.Text == "555.555.555-55" || mtxtCpfCli.Text == "666.666.666-66" || mtxtCpfCli.Text == "777.777.777-77" || mtxtCpfCli.Text == "888.888.888-88" || mtxtCpfCli.Text == "999.999.999-99 " || mtxtCpfCli.Text == "000.000.000-00")
            {
                MessageBox.Show("Número de CPF Inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                if (!mtxtCpfCli.MaskCompleted)
                {
                    MessageBox.Show("Número de CPF incompleto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Valida(mtxtCpfCli.Text))
                    {
                        mtxtCepCli.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Número de CPF Inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        mtxtCpfCli.Clear();
                        mtxtCpfCli.Focus();
                    }

                }
            }
        }

        //Trocando a tecla TAB pela tecla enter no formulário
        private void FormCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        //Consulta CEP - Botão para auto-preenchimento dos campos 
        private void btConsultaCEP_Click(object sender, EventArgs e)
        {
            try
            {
                Correios.AtendeClienteClient consulta = new Correios.AtendeClienteClient("AtendeClientePort");
                
                //declarando variável e convertendo para a consulta no campo CEP
                var resultado = consulta.consultaCEP(mtxtCepCli.Text);

                //apresentando os campos caso o cep digitado seja válido e diferente de não preenchido
                if (resultado != null)
                {
                    txtRuaCli.Text = resultado.end;
                    txtBairroCli.Text = resultado.bairro;
                    txtCidadeCli.Text = resultado.cidade;
                    cbEstadoCli.SelectedItem = resultado.uf;
                }

                //tratando uma excessão, caso o cep não seja encontrado ou não seja válido
            }
            catch (FaultException)
            {
                MessageBox.Show("Número de CEP não Encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtxtCepCli.Clear();
                mtxtCepCli.Focus();
            }
            catch(EndpointNotFoundException)
            {
                MessageBox.Show("Não foi possível completar a operação \nVerifique sua conexão com a internet.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btAtualizarCli_Click(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();


            if (rbFemininoCli.Checked == false && rbMasculinoCli.Checked == false)
            {
                MessageBox.Show("Selecionar o campo Sexo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //Verificar campos obrigatórios (validando pelo menos um telefone)
                if ((txtNomeCli.Text != "" && txtSobrenomeCli.Text != "" && mtxtDataNascCli.Text != "  /  /" && mtxtCpfCli.Text != "   .   .   -" && mtxtCepCli.Text != "     -" && txtRuaCli.Text != "" && txtNumeroCli.Text != "" && txtBairroCli.Text != "" && txtCidadeCli.Text != "" && cbEstadoCli.Text != "") && (mtxtTelResCli.Text != "(  )     -" || mtxtTelComCli.Text != "(  )     -" || mtxtCelCli.Text != "(  )      -"))

                {
                    //Passar para as propriedades o conteúdo do formulário
                    //Todos os campos que o usuário pode preencher
                    cCliente.nome_cli = txtNomeCli.Text;
                    cCliente.sobrenome_cli = txtSobrenomeCli.Text;
                    cCliente.data_nasc_cli = DateTime.Parse(mtxtDataNascCli.Text);                   
                    cCliente.cpf_cli = mtxtCpfCli.Text;
                    cCliente.cep_cli = mtxtCepCli.Text;
                    cCliente.rua_cli = txtRuaCli.Text;
                    cCliente.numero_cli = Convert.ToInt32(txtNumeroCli.Text);
                    cCliente.complemento_cli = txtComplementoCli.Text;
                    cCliente.bairro_cli = txtBairroCli.Text;
                    cCliente.cidade_cli = txtCidadeCli.Text;
                    cCliente.estado_cli = cbEstadoCli.SelectedItem.ToString();
                    cCliente.email_cli = txtEmailCli.Text;


                    //RadioButton
                    if (rbMasculinoCli.Checked)
                    {
                        cCliente.sexo_cli = "M";
                    }
                    else
                    {
                        cCliente.sexo_cli = "F";
                    }


                    //Campos que são máscaras e não obrigatórios
                    if (mtxtTelResCli.Text != "(  )     -")
                    {
                        cCliente.tel_res_cli = mtxtTelResCli.Text;
                    }
                    else
                    {
                        cCliente.tel_res_cli = "";
                    }

                    if (mtxtTelComCli.Text != "(  )     -")
                    {
                        cCliente.tel_com_cli = mtxtTelComCli.Text;
                    }
                    else
                    {
                        cCliente.tel_com_cli = "";
                    }

                    if (mtxtCelCli.Text != "(  )      -")
                    {
                        cCliente.cel_cli = mtxtCelCli.Text;
                    }
                    else
                    {
                        cCliente.cel_cli = "";
                    }
                    if (ckbStatusAtivo.Checked == true)
                    {
                        cCliente.status_cli = 1;
                    }
                    else
                    {
                        cCliente.status_cli = 0;                  
                    }

                    //Status CLI
                    if (cCliente.status_cli == 0)
                    {
                        ckbStatusAtivo.Checked = false;
                    }
                    else
                    {
                        if (cCliente.status_cli == 1)
                        {
                            ckbStatusAtivo.Checked = true;
                        }
                        else
                        {
                            ckbStatusAtivo.Checked = true;
                        }
                    }

                    //Convertendo o código cliente
                    cCliente.cod_cli = Convert.ToInt32(txtCodCli.Text);

                    //Chamando o Método
                    bool aux = cCliente.AtualizarCliente();

                    if (aux)
                    {
                        MessageBox.Show("O(A) Cliente " + cCliente.nome_cli + " Atualizado(a) com Sucesso.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Atualizar.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("Verificar os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomeCli.BackColor = Color.MistyRose;
                    txtSobrenomeCli.BackColor = Color.MistyRose;
                    mtxtDataNascCli.BackColor = Color.MistyRose;
                    mtxtCpfCli.BackColor = Color.MistyRose;
                    mtxtCepCli.BackColor = Color.MistyRose;
                    txtRuaCli.BackColor = Color.MistyRose;
                    txtNumeroCli.BackColor = Color.MistyRose;
                    txtBairroCli.BackColor = Color.MistyRose;
                    txtCidadeCli.BackColor = Color.MistyRose;
                    cbEstadoCli.BackColor = Color.MistyRose;
                    mtxtTelComCli.BackColor = Color.MistyRose;
                    mtxtTelResCli.BackColor = Color.MistyRose;
                    mtxtCelCli.BackColor = Color.MistyRose;
                    lbTelAtencao.ForeColor = Color.DarkRed;
                    lbCamposObrig.ForeColor = Color.DarkRed;
                    txtNomeCli.Focus();
                }
            }
        }

        private void txtNomeCli_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNomeCli.Text.Length > 0)
            {
                txtNomeCli.Text = txtNomeCli.Text.Substring(0, 1).ToUpper() + txtNomeCli.Text.Substring(1);
                txtNomeCli.SelectionStart = txtNomeCli.Text.Length + 1;
            }
        }

        private void btExcluirCli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o(a) Cliente?", "Sistema Loja de Informático!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCliente cCliente = new classCliente();
                cCliente.cod_cli = Convert.ToInt32(txtCodCli.Text);

                bool aux = cCliente.ExcluirCliente();

                if (aux)
                {
                    MessageBox.Show("O(A) Cliente " + cCliente.nome_cli + " foi excluído(a) com sucesso.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este(a) Cliente não pode ser excluído(a), há registros em outras tabelas.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void txtSobrenomeCli_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSobrenomeCli.Text.Length > 0)
            {
                txtSobrenomeCli.Text = txtSobrenomeCli.Text.Substring(0, 1).ToUpper() + txtSobrenomeCli.Text.Substring(1);
                txtSobrenomeCli.SelectionStart = txtSobrenomeCli.Text.Length + 1;
            }
        }
    }
}    
       
