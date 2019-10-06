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
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
        }

        public string tipo;
        public DateTime datacad;

        private void Limpar()
        {
            txtNomeCateg.Text = "";
            txtNomeCateg.BackColor = Color.White;
        }

        private void btCadastrarCateg_Click(object sender, EventArgs e)
        {
            //Instanciar ClassMarca
            classCategoria cCategoria = new classCategoria();

            //Verficar campos obrigatórios
            if (txtNomeCateg.Text == "")
            {
                MessageBox.Show("Verificar os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomeCateg.BackColor = Color.MistyRose;
            }
            else
            {
                //Passar os dados
                cCategoria.nome_categ = txtNomeCateg.Text;

                // Chamar o método da classe cliente para fazer o cadastro
                int aux = cCategoria.CadastrarCategoria();

                //Se der certo = 1
                if (aux != 0)
                {
                    MessageBox.Show(" A Categoria " + cCategoria.nome_categ + " foi Cadastrada com Sucesso.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        }

        private void btFecharCateg_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            //Mostrar Data Cadastro - Marca
            lbDataCadCategRes.Text = DateTime.Now.ToShortDateString();

            //Quando Abrir o Form para Atualizar ou excluir
            if (tipo == "Atualização")
            {
                btCadastrarCateg.Enabled = false;
                ckbStatusAtivo.Enabled = true;
                lbDataCadCategRes.Text = datacad.ToString();
                btAtualizarCateg.Enabled = true;
                btExcluirCateg.Enabled = true;
            }
            else
            {
                btAtualizarCateg.Enabled = false;
                btExcluirCateg.Enabled = false;
            }
        }


        //Não permitir números e símbolos
        private void txtNomeCateg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))

            {
                e.Handled = true;
                txtNomeCateg.Focus();
            }
                
        }


        //Iniciar primeira letra Maiúscula
        private void txtNomeCateg_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNomeCateg.Text.Length > 0)
            {
                txtNomeCateg.Text = txtNomeCateg.Text.Substring(0, 1).ToUpper() + txtNomeCateg.Text.Substring(1);
                txtNomeCateg.SelectionStart = txtNomeCateg.Text.Length + 1;
            }
        }

        private void btExcluirCateg_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o Categoria?", "Sistema Loja de Informática!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCategoria cCategoria = new classCategoria();
                cCategoria.cod_categ = Convert.ToInt32(txtCodCateg.Text);

                bool aux = cCategoria.ExcluirCategoria();

                if (aux)
                {
                    MessageBox.Show("Categoria " + cCategoria.nome_categ + " excluído com sucesso", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Esta Categoria não pode ser excluído, há registros em outras tabelas.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btAtualizarCateg_Click(object sender, EventArgs e)
        {

            //Instanciar ClassCategoria
            classCategoria cCategoria = new classCategoria();

            //Verficar campos obrigatórios
            if (txtNomeCateg.Text != "")
            {
                //Passar os dados
                cCategoria.nome_categ = txtNomeCateg.Text;

                if (ckbStatusAtivo.Checked == true)
                {
                    cCategoria.status_categ = 1;
                }
                else
                {
                    if (ckbStatusAtivo.Checked == false)
                    {
                        cCategoria.status_categ = 0;
                    }

                }

                //Status Categoria
                if (cCategoria.status_categ == 0)
                {
                    ckbStatusAtivo.Checked = false;
                }
                else
                {
                    if (cCategoria.status_categ == 1)
                    {
                        ckbStatusAtivo.Checked = true;
                    }
                    else
                    {
                        ckbStatusAtivo.Checked = true;
                    }
                }

                //Método Atualizar
                cCategoria.cod_categ = Convert.ToInt32(txtCodCateg.Text);

                bool aux = cCategoria.AtualizarCategoria();

                if (aux)
                {
                    MessageBox.Show("Categoria: " + cCategoria.nome_categ + " Atualizado com Sucesso.", "Sistema Loja de Informática", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtNomeCateg.BackColor = Color.MistyRose;

            }
        }
    }
}
