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
    public partial class FormMarca : Form
    {
        public FormMarca()
        {
            InitializeComponent();
        }

        //Variável Global
        public string tipo;
        public DateTime datacad;

        private void Limpar()
        {
            //
            txtNomeMarca.Text = "";
            txtNomeMarca.BackColor = Color.White;
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            //Mostrar Data Cadastro - Marca
            lbDataCadMarcaRes.Text = DateTime.Now.ToShortDateString();

            //Quando Abrir o Form para Atualizar ou excluir
            if (tipo == "Atualização")
            {
                btCadastrarMarca.Enabled = false;
                ckbStatusAtivo.Enabled = true;
                lbDataCadMarcaRes.Text = datacad.ToString();
                btAtualizarMarca.Enabled = true;
                btExcluirMarca.Enabled = true;
            }
            else
            {
                btAtualizarMarca.Enabled = false;
                btExcluirMarca.Enabled = false;
            }

        }

        private void btFecharMarca_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void LimparMarca()
        {
            txtNomeMarca.Text = "";
            txtNomeMarca.BackColor = Color.White;
        }
        private void btCadastrarMarca_Click(object sender, EventArgs e)
        {
            //Instanciar ClassMarca
            classMarca cMarca = new classMarca();

            //Verficar campos obrigatórios
            if (txtNomeMarca.Text == "")
            {
                MessageBox.Show("Verificar os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomeMarca.BackColor = Color.MistyRose;
            }
            else
            {
                //Passar os dados
                cMarca.nome_marca = txtNomeMarca.Text;

                // Chamar o método da classe cliente para fazer o cadastro
                int aux = cMarca.CadastrarMarca();

                //Se der certo = 1
                if (aux != 0)
                {
                    MessageBox.Show(" A Marca " + cMarca.nome_marca + " foi Cadastrada com Sucesso.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Limpar campos do formulário, chamando o método Limpar
                    this.LimparMarca();


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

        private void txtNomeMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))

            {
                e.Handled = true;
                txtNomeMarca.Focus();
            }
        }

        //Iniciar primeira letra Maiúscula
        private void txtNomeMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNomeMarca.Text.Length > 0)
            {
                txtNomeMarca.Text = txtNomeMarca.Text.Substring(0, 1).ToUpper() + txtNomeMarca.Text.Substring(1);
                txtNomeMarca.SelectionStart = txtNomeMarca.Text.Length + 1;
            }
        }

        private void btAtualizarMarca_Click(object sender, EventArgs e)
        {
            //Instanciar ClassMarca
            classMarca cMarca = new classMarca();

            //Verficar campos obrigatórios
            if (txtNomeMarca.Text != "")
            {
                //Passar os dados
                cMarca.nome_marca = txtNomeMarca.Text;

                if (ckbStatusAtivo.Checked == true)
                {
                    cMarca.status_marca = 1;
                }
                else
                {
                    if (ckbStatusAtivo.Checked == false)
                    {
                        cMarca.status_marca = 0;
                    }

                }

                //Status Marca
                if (cMarca.status_marca == 0)
                {
                    ckbStatusAtivo.Checked = false;
                }
                else
                {
                    if (cMarca.status_marca == 1)
                    {
                        ckbStatusAtivo.Checked = true;
                    }
                    else
                    {
                        ckbStatusAtivo.Checked = true;
                    }
                }

                //Método Atualizar
                cMarca.cod_marca = Convert.ToInt32(txtCodMarca.Text);

                bool aux = cMarca.AtualizarMarca();

                if (aux)
                {
                    MessageBox.Show("Marca: " + cMarca.nome_marca + " Atualizada com Sucesso.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtNomeMarca.BackColor = Color.MistyRose;

            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir a Marca?", "Sistema Loja de Informática", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classMarca cMarca = new classMarca();
                cMarca.cod_marca = Convert.ToInt32(txtCodMarca.Text);

                bool aux = cMarca.ExcluirMarca();

                if (aux)
                {
                    MessageBox.Show("Marca " + cMarca.nome_marca + " excluída com sucesso", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Esta Marca não pode ser excluída, há registros em outras tabelas.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
