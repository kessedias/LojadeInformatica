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
    public partial class FormConsultaCargo : Form
    {
        public FormConsultaCargo()
        {
            InitializeComponent();
        }

        private void FormConsultaCargo_Load(object sender, EventArgs e)
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

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string Consulta = cbCategorias.SelectedItem.ToString();
            classCargo cCargo = new classCargo();

            switch (Consulta)
            {
                case "Nome":
                    //Inicial
                    if (txtPesquisar.Text != "")
                    {
                        if (rbinicial.Checked == true)
                        {
                            dgvCargo.DataSource = cCargo.BuscarCargoNomeInicial(txtPesquisar.Text);
                            this.dgvCargo.Columns[0].Visible = false;
                        }
                        //Contém
                        else
                        {
                            dgvCargo.DataSource = cCargo.BuscarCargoNomeContem(txtPesquisar.Text);
                            dgvCargo.Columns[0].Visible = false;
                        }
                    }
                    else
                        MessageBox.Show("Favor informar um Cargo.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  

                    break;              

                //Data
                case "Data":
                    if (mtxtDataCon1.Text == "  /  /" || mtxtDataCon2.Text == "  /  /")
                    {
                        MessageBox.Show("Favor preencher os campos vazios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        dgvCargo.DataSource = cCargo.BuscarCargoData(Convert.ToDateTime(mtxtDataCon1.Text), Convert.ToDateTime(mtxtDataCon2.Text));
                        this.dgvCargo.Columns[0].Visible = false;
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
                            dgvCargo.DataSource = cCargo.BuscarCargoStatus(1);
                            this.dgvCargo.Columns[0].Visible = false;
                        }
                        else
                        {
                            dgvCargo.DataSource = cCargo.BuscarCargoStatus(0);
                            this.dgvCargo.Columns[0].Visible = false;
                        }
                    }
                    break;
            }          
        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o cargo selecionado?", "Sistema Loja de Informática", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Instanciar a classe cargo
                classCargo cCargo = new classCargo();              

                //Instanciar o form de cadastro/atualização de cargo
                FormCargo fCargo = new FormCargo();

                //Atualização - Título
                fCargo.Text = "Atualização de Cargo";

                //Pegar o código do cargo selecionado pelo usuário na grid
                cCargo.ConsultarCargo(Convert.ToInt32(dgvCargo.SelectedRows[0].Cells[0].Value));

                //Passar os dados do BD para os Controles do Form de Cargo
                fCargo.txtCodCargo.Text = cCargo.cod_cargo.ToString();
                fCargo.datacad = cCargo.data_cad_cargo;
                fCargo.txtNomeCargo.Text = cCargo.nome_cargo.ToString();

                if (cCargo.status_cargo == 1)
                {
                    fCargo.ckbStatusAtivo.Checked = true;
                }
                else
                {
                    fCargo.ckbStatusAtivo.Checked = false;
                }

                //Mandar a informação de update
                fCargo.tipo = "Atualização";
                //Depois de Atualizar fecha o Formulário
                fCargo.ShowDialog();
                //Chamar Método de pesquisa
                btPesquisar_Click(this, new EventArgs());
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            dgvCargo.DataSource = null;
            txtPesquisar.Text = "";
            mtxtDataCon1.Text = "  /  /";
            mtxtDataCon2.Text = "  /  /";
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
