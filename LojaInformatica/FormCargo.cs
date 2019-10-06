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
    public partial class FormCargo : Form
    {
        public FormCargo()
        {
            InitializeComponent();
        }

        //Variável Global
        public string tipo;
        public DateTime datacad;

        private void LimparCargo()
        {
            txtNomeCargo.Text = "";
            txtNomeCargo.BackColor = Color.White;
        }

        private void FormCargo_Load(object sender, EventArgs e)
        {
            //Mostrar Data Cadastro - Marca
            lbDataCadCargoRes.Text = DateTime.Now.ToShortDateString();

            //Quando Abrir o Form para Atualizar ou excluir
            if (tipo == "Atualização")
            {
                btCadastrarCargo.Enabled = false;
                ckbStatusAtivo.Enabled = true;
                lbDataCadCargoRes.Text = datacad.ToString();
                btAtualizarCargo.Enabled = true;
                btExcluirCargo.Enabled = true;
            }
            else
            {
                btAtualizarCargo.Enabled = false;
                btExcluirCargo.Enabled = false;
            }


        }

        private void btCadastrarCargo_Click(object sender, EventArgs e)
        {
            //Instanciar ClassCargo
            classCargo cCargo = new classCargo();

            //Verficar campos obrigatórios
            if (txtNomeCargo.Text == "")
            {
                MessageBox.Show("Verificar os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomeCargo.BackColor = Color.MistyRose;
            }
            else
            {
                //Passar os dados
                cCargo.nome_cargo = txtNomeCargo.Text;

                // Chamar o método da classe cliente para fazer o cadastro
                int aux = cCargo.CadastrarCargo();

                //Se der certo = 1
                if (aux != 0)
                {
                    MessageBox.Show("O Cargo " + cCargo.nome_cargo + " foi Cadastrado com Sucesso.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Limpar campos do formulário, chamando o método Limpar
                    this.LimparCargo();


                }
                //Se der errado = 0
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro.",
                        "Sistema Loja de Informática",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btFecharCargo_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Validação do campo
        private void txtNomeCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))

            {
                e.Handled = true;
                txtNomeCargo.Focus();
            }
        }

        //Iniciar primeira Letra Maiúscula
        private void txtNomeCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNomeCargo.Text.Length > 0)
            {
                txtNomeCargo.Text = txtNomeCargo.Text.Substring(0, 1).ToUpper() + txtNomeCargo.Text.Substring(1);
                txtNomeCargo.SelectionStart = txtNomeCargo.Text.Length + 1;
            }
        }

        private void btAtualizarCargo_Click(object sender, EventArgs e)
        {

            //Instanciar ClassCargo
            classCargo cCargo = new classCargo();

            //Verficar campos obrigatórios
            if (txtNomeCargo.Text != "")
            {
                //Passar os dados
                cCargo.nome_cargo = txtNomeCargo.Text;

                if (ckbStatusAtivo.Checked == true)
                {
                    cCargo.status_cargo = 1;
                }
                else
                {
                    if (ckbStatusAtivo.Checked == false)
                    {
                        cCargo.status_cargo = 0;
                    }
                    
                }

                //Status Cargo
                if (cCargo.status_cargo == 0)
                {
                    ckbStatusAtivo.Checked = false;
                }
                else
                {
                    if (cCargo.status_cargo == 1)
                    {
                        ckbStatusAtivo.Checked = true;
                    }
                    else
                    {
                        ckbStatusAtivo.Checked = true;
                    }
                }

                //Método Atualizar
                cCargo.cod_cargo = Convert.ToInt32(txtCodCargo.Text);

                bool aux = cCargo.AtualizarCargo();

                if (aux)
                {
                    MessageBox.Show("Cargo: " + cCargo.nome_cargo + " Atualizado com Sucesso.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //Validação
            else
            {
                   MessageBox.Show("Verificar os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomeCargo.BackColor = Color.MistyRose;
                
            }
        }

        private void btExcluirCargo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o Cargo?", "Sistema Loja de Informática", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCargo cCargo = new classCargo();
                cCargo.cod_cargo = Convert.ToInt32(txtCodCargo.Text);

                bool aux = cCargo.ExcluirCargo();

                if (aux)
                {
                    MessageBox.Show("Cargo " + cCargo.nome_cargo + " excluído com sucesso", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este Cargo não pode ser excluído, há registros em outras tabelas.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
