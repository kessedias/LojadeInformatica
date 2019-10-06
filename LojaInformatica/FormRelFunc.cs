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
    public partial class FormRelFunc : Form
    {     
        public FormRelFunc()
        {
            InitializeComponent();
        }

        private void FormRelFunc_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO TIPO DE RELATÓRIO
            cbTipoRel.Items.Add("Cargo");
            cbTipoRel.Items.Add("Bairro");
            cbTipoRel.Items.Add("Salário");
            cbTipoRel.Items.Add("Sexo");
            cbTipoRel.Items.Add("Status");
            cbTipoRel.SelectedIndex = 0;

            //CARREGAR COMBO DE CARGO DO BANCO DE DADOS - TABELA CLIENTE
            classCargo cCargo = new classCargo();
            cbCargo.DataSource = cCargo.BuscarCargo(); // EXECUTAR MÉTODO DE CONSULTA CRIADO NA CLASSE CLIENTE
            cbCargo.DisplayMember = "nome_cargo"; // EXIBIR NA COMBO (Cargo)
            cbCargo.ValueMember = "cod_cargo"; // GUARDAR NO BD (Cargo)
            cbCargo.SelectedIndex = -1;
            this.rptvFuncionario.RefreshReport();

            //CARREGAR COMBO DE Funcionario DO BANCO DE DADOS - TABELA CLIENTE
            classFuncionario cFuncionario = new classFuncionario();
            cbBairro.DataSource = cFuncionario.BuscarBairro(); // EXECUTAR MÉTODO DE CONSULTA CRIADO NA CLASSE CLIENTE
            cbBairro.DisplayMember = "bairro_func"; // EXIBIR NA COMBO (Funcionario)
            cbBairro.ValueMember = "bairro_func"; // GUARDAR NO BD (Funcionario)
            cbBairro.SelectedIndex = -1;
            this.rptvFuncionario.RefreshReport();

            //Status Sempre Ativo
            rbtAtivo.Checked = true;

        }


        //Método de Limpeza
        private void Limpar()
            {
            cbBairro.SelectedIndex = -1;
            cbCargo.SelectedIndex = -1;
            txtSal1.Text = "";
            txtSal2.Text = "";
            rptvFuncionario.Clear();
            }

        //Configuração da combo
        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0) //Cargo
            {
                gbCargo.Enabled = true;
                gbBairro.Enabled = false;
                gbSalario.Enabled = false;
                gbSexo.Enabled = false;
                gbStatus.Enabled = false;
                Limpar();
            }

            if (cbTipoRel.SelectedIndex == 1) //Bairro
            {
                gbCargo.Enabled = false;
                gbBairro.Enabled = true;
                gbSalario.Enabled = false;
                gbSexo.Enabled = false;
                gbStatus.Enabled = false;
                Limpar();
            }

            if (cbTipoRel.SelectedIndex == 2) //Salário
            {
                gbCargo.Enabled = false;
                gbBairro.Enabled = false;
                gbSalario.Enabled = true;
                gbSexo.Enabled = false;
                gbStatus.Enabled = false;
                Limpar();
            }

            if (cbTipoRel.SelectedIndex == 3) //Sexo
            {
                gbCargo.Enabled = false;
                gbBairro.Enabled = false;
                gbSalario.Enabled = false;
                gbSexo.Enabled = true;
                gbStatus.Enabled = false;
                Limpar();
            }

            if (cbTipoRel.SelectedIndex == 4) //Status
            {
                gbCargo.Enabled = false;
                gbBairro.Enabled = false;
                gbSalario.Enabled = false;
                gbSexo.Enabled = false;
                gbStatus.Enabled = true;
                Limpar();
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();
            string pesquisa = cbTipoRel.SelectedItem.ToString(); //Para pegar a opção escolhida pelo usuário

            switch (pesquisa)

            {
                case "Cargo":
                    if (cbCargo.SelectedIndex != -1)
                    {
                       
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncCargo(Convert.ToInt32(cbCargo.SelectedValue));
                        this.rptvFuncionario.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher um Cargo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Bairro":
                    if (cbBairro.SelectedIndex != -1)
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncBairro(cbBairro.SelectedValue.ToString());
                        this.rptvFuncionario.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher um Bairro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Salário":
                    if (txtSal1.Text != "" && txtSal2.Text != "")
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncSalario(Convert.ToDecimal(txtSal1.Text), Convert.ToDecimal(txtSal2.Text));
                        this.rptvFuncionario.RefreshReport();

                    }
                    else
                    {
                        MessageBox.Show("Favor preencher os campos vazios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Sexo":
                    if (rbMasculino.Checked == false && rbFeminino.Checked == false)
                    {
                        MessageBox.Show("Favor escolher um Sexo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (rbMasculino.Checked == true)
                        {
                            classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncSexo("M");
                            this.rptvFuncionario.RefreshReport();
                        }
                        else
                        {
                            classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncSexo("F");
                            this.rptvFuncionario.RefreshReport();
                        }
                    }
                    break;

                case "Status":
                    if (rbtAtivo.Checked == true)
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncStatus(1);
                        this.rptvFuncionario.RefreshReport();
                    }
                    else
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncStatus(0);
                        this.rptvFuncionario.RefreshReport();
                    }
                    break;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSal1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Só permitir o uso de uma vírgula no campo, não permitir letras e símbolos
            if (e.KeyChar == ','
            && ((sender as TextBox).Text.IndexOf(',') > -1) || (char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtSal2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Só permitir o uso de uma vírgula no campo, não permitir letras e símbolos
            if (e.KeyChar == ','
            && ((sender as TextBox).Text.IndexOf(',') > -1) || (char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
