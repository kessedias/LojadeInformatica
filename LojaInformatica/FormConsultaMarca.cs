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
    public partial class FormConsultaMarca : Form
    {
        public FormConsultaMarca()
        {
            InitializeComponent();
        }

        private void FormConsultaMarca_Load(object sender, EventArgs e)
        {

            cbCategorias.Items.Add("Nome");
            cbCategorias.Items.Add("Data");
            cbCategorias.Items.Add("Status");

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

        private void btLimpar_Click(object sender, EventArgs e)
        {
            dgvMarca.DataSource = null;
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
            classMarca cMarca = new classMarca();

            switch (Consulta)
            {
                case "Nome":
                    //INicial
                    if (txtPesquisar.Text != "")
                    {
                        if (rbinicial.Checked == true)
                        {
                            dgvMarca.DataSource = cMarca.BuscarMarcaNomeInicial(txtPesquisar.Text);
                            this.dgvMarca.Columns[0].Visible = false;
                        }
                        //Contém
                        else
                        {
                            dgvMarca.DataSource = cMarca.BuscarMarcaNomeContem(txtPesquisar.Text);
                            this.dgvMarca.Columns[0].Visible = false;
                        }
                    }
                    else
                        MessageBox.Show("Favor informar uma Marca.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                //Data
                case "Data":
                    if (mtxtDataCon1.Text == "  /  /" || mtxtDataCon2.Text == "  /  /")
                    {
                        MessageBox.Show("Favor preencher os campos vazios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        dgvMarca.DataSource = cMarca.BuscarMarcaData(Convert.ToDateTime(mtxtDataCon1.Text),Convert.ToDateTime(mtxtDataCon2.Text));
                        dgvMarca.Columns[0].Visible = false;
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
                            dgvMarca.DataSource = cMarca.BuscarMarcaStatus(1);
                            this.dgvMarca.Columns[0].Visible = false;
                        }
                        else
                        {
                            dgvMarca.DataSource = cMarca.BuscarMarcaStatus(0);
                            this.dgvMarca.Columns[0].Visible = false;
                        }
                    }
                    break;
            }
        }

        private void dgvMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar a Marca selecionada?", "Sistema Loja de Informática", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Instanciar a classe Marca
                classMarca cMarca = new classMarca();

                //Instanciar o form de cadastro/atualização de Marca
                FormMarca fMarca = new FormMarca();

                //Artualização - Título
                fMarca.Text = "Atualização de Marca";

                //Pegar o código do Marca selecionado pelo usuário na grid
                cMarca.ConsultarMarca(Convert.ToInt32(dgvMarca.SelectedRows[0].Cells[0].Value));

                //Passar os dados do BD para os Controles do Form de Marca
                fMarca.txtCodMarca.Text = cMarca.cod_marca.ToString();
                fMarca.datacad = cMarca.data_cad_marca;
                fMarca.txtNomeMarca.Text = cMarca.nome_marca.ToString();

                if (cMarca.status_marca == 1)
                {
                    fMarca.ckbStatusAtivo.Checked = true;
                }
                else
                {
                    fMarca.ckbStatusAtivo.Checked = false;
                }

                //Mandar a informação de update
                fMarca.tipo = "Atualização";
                //Depois de Atualizar fecha o Formulário
                fMarca.ShowDialog();
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
