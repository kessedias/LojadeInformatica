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
    public partial class FormConsultaCateg : Form
    {
        public FormConsultaCateg()
        {
            InitializeComponent();
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategorias.SelectedIndex == 0) //Nome
            {
                txtPesquisar.Enabled = true;
                gbPesquisa.Enabled = true;
                gbStatus.Enabled = false;
                gbDataCon.Enabled = false;                
                txtPesquisar.Focus();
            }

            if (cbCategorias.SelectedIndex == 1) //Data
            {
                txtPesquisar.Enabled = false;
                gbPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                gbDataCon.Enabled = true;
            }

            if (cbCategorias.SelectedIndex == 2) //Status
            {
                txtPesquisar.Enabled = false;
                gbPesquisa.Enabled = false;
                gbStatus.Enabled = true;
                gbDataCon.Enabled = false;
            }
        }

        private void FormConsultaCateg_Load(object sender, EventArgs e)
        {
            cbCategorias.Items.Add("Nome");
            cbCategorias.Items.Add("Data");
            cbCategorias.Items.Add("Status");

            cbCategorias.SelectedItem = "Nome";

            rbContem.Checked = true;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            dgvCateg.DataSource = null;
            txtPesquisar.Text = "";
            mtxtDataCon1.Text = "  /  /";
            mtxtDataCon2.Text = "  /  /";
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string Consulta = cbCategorias.SelectedItem.ToString();
            classCategoria cCategoria = new classCategoria();

            switch (Consulta)
            {
                case "Nome":
                    //INicial
                    if (txtPesquisar.Text != "")
                    {
                        if (rbinicial.Checked == true)
                        {
                            dgvCateg.DataSource = cCategoria.BuscarCategoriaNomeInicial(txtPesquisar.Text);
                            this.dgvCateg.Columns[0].Visible = false;
                        }
                        //Contém
                        else
                        {
                            dgvCateg.DataSource = cCategoria.BuscarCategoriaNomeContem(txtPesquisar.Text);
                            this.dgvCateg.Columns[0].Visible = false;
                        }
                    }
                    else
                        MessageBox.Show("Favor informar uma Categoria.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                //Data
                case "Data":
                    if (mtxtDataCon1.Text == "  /  /" || mtxtDataCon2.Text == "  /  /")
                    {
                        MessageBox.Show("Favor preencher os campos vazios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        dgvCateg.DataSource = cCategoria.BuscarCategoriaData(Convert.ToDateTime(mtxtDataCon1.Text), Convert.ToDateTime(mtxtDataCon2.Text));
                        dgvCateg.Columns[0].Visible = false;

                    }
                    break;

                //Status
                case "Status":
                    if (rbAtivo.Checked == false && rbInativo.Checked == false)
                    {
                        MessageBox.Show("Favor selecionar uma das Opções.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        if (rbAtivo.Checked == true)
                        {
                            dgvCateg.DataSource = cCategoria.BuscarCategoriaStatus(1);
                            this.dgvCateg.Columns[0].Visible = false;
                        }
                        else
                        {
                            dgvCateg.DataSource = cCategoria.BuscarCategoriaStatus(0);
                            this.dgvCateg.Columns[0].Visible = false;
                        }
                    }
                    break;
            }
        }


        private void dgvCateg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o Categoria selecionado?", "Sistema Loja de Informática", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Instanciar a classe Categoria
                classCategoria cCategoria = new classCategoria();

                //Instanciar o form de cadastro/atualização de Categoria
                FormCategoria fCategoria = new FormCategoria();

                //Atualização - Título
                fCategoria.Text = "Atualização de Categoria";

                //Pegar o código do Categoria selecionado pelo usuário na grid
                cCategoria.ConsultarCategoria(Convert.ToInt32(dgvCateg.SelectedRows[0].Cells[0].Value));

                //Passar os dados do BD para os Controles do Form de Categoria
                fCategoria.txtCodCateg.Text = cCategoria.cod_categ.ToString();
                fCategoria.datacad = cCategoria.data_cad_categ;
                fCategoria.txtNomeCateg.Text = cCategoria.nome_categ.ToString();

                if (cCategoria.status_categ == 1)
                {
                    fCategoria.ckbStatusAtivo.Checked = true;
                }
                else
                {
                    fCategoria.ckbStatusAtivo.Checked = false;
                }

                //Mandar a informação de update
                fCategoria.tipo = "Atualização";
                //Depois de Atualizar fecha o Formulário
                fCategoria.ShowDialog();
                //Chamar Método de pesquisa
                btPesquisar_Click(this, new EventArgs());
            }
        }

        private void mtxtDataCon_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            {
                if (!e.IsValidInput)
                    MessageBox.Show("Data Inválida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //validação do campo data
               //txtDataCon.Text = "  /  /";
            }
        }

        private void mtxtDataCon1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {

            if (e.ReturnValue != null)
            {
                DateTime valor = (DateTime)e.ReturnValue;
            }
            else
            {
                MessageBox.Show("Primeira Data Inválida", "Atenção");
                mtxtDataCon1.Text = "  /  /";
            }
        }

        private void mtxtDataCon2_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {

            if (e.ReturnValue != null)
            {
                DateTime valor = (DateTime)e.ReturnValue;
            }
            else
            {
                MessageBox.Show("Segunda Data Inválida", "Atenção");
                mtxtDataCon2.Text = "  /  /";
            }
        }
    }
}
