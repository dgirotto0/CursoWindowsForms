using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoWindowsFormsBiblioteca.Classes;
using System.ComponentModel.DataAnnotations;
using CursoWindowsFormsBiblioteca;
using System.Runtime.ConstrainedExecution;
using Microsoft.VisualBasic;
using CursoWindowsFormsBiblioteca.Databases;
using System.Linq.Expressions;
using Microsoft.VisualBasic.ApplicationServices;

namespace CursoWindowsForms
{
    public partial class Frm_Cadastro_UC : UserControl
    {
        public Frm_Cadastro_UC()
        {
            InitializeComponent();

            Tls_Principal.Items[0].ToolTipText = "Incluir um novo cliente na base de dados";
            Tls_Principal.Items[1].ToolTipText = "Buscar um cliente já cadastrado na base";
            Tls_Principal.Items[2].ToolTipText = "Salvar ou atualizar um cliente";
            Tls_Principal.Items[3].ToolTipText = "Apaga o cliente selecionado da base de dados";
            Tls_Principal.Items[4].ToolTipText = "Limpar tudo que está escrito";

            Lbl_QualOutro.Visible = false;
            Txt_QualOutro.Visible = false;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novoStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                C = LeituraFormulario();
                C.ValidaClasse();
                C.ValidaComplemento();                
                string clienteJson = Cliente.SerializedClassUnit(C);
                Fichario F = new Fichario("C:\\Users\\daniel.girotto\\OneDrive - INFORDOC SERVICOS DE INFORMATICA LTDA\\Desktop\\C#\\Alura\\CursoWF\\CursoWindowsForms\\Fichario");
                if (F.status)
                {
                    F.Incluir(C.Id, clienteJson);
                    if(F.status)
                    {
                        MessageBox.Show("OK: " + F.mensagem, "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro:" + F.mensagem, "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Erro:" + F.mensagem, "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            catch(ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        
        Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit C = new Cliente.Unit();

            C.Id = Txt_Id.Text;
            C.Nome = Txt_SeuNome.Text;
            C.NomeMae = Txt_NomeMae.Text;
            C.NomePai = Txt_NomePai.Text;
            C.Cpf = Txt_Cpf.Text;

            if (Cbx_Pai.Checked)
            {
                C.NaoTemPai = false;
            }
            else
            {
                C.NaoTemPai = true;
            }
            
            if(Cbx_Masc.Checked)
            {
                C.Genero = 0;
            }
            if (Cbx_Fem.Checked)
            {
                C.Genero = 1;
            }                      

            C.Cep = Txt_Cep.Text;
            C.Logradouro = Txt_Logradouro.Text;
            C.Bairro = Txt_Bairro.Text;
            C.Cidade = Txt_Cidade.Text;

            if(Cbb_Estado.SelectedIndex < 0)
            {
                C.Estado = "";
            }
            else
            {
                C.Estado = Cbb_Estado.Items[Cbb_Estado.SelectedIndex].ToString();
            }
            
            return C;
        }

        private void Txt_Cep_Leave_1(object sender, EventArgs e)
        {
            string vCep = Txt_Cep.Text;
            if (vCep != "")
            {
                if (vCep.Length == 8)
                {
                    if (Information.IsNumeric(vCep))
                    {
                        var vJson = Cls_Uteis.GeraJSONCEP(vCep);
                        Cep.Unit CEP = new Cep.Unit();
                        CEP = Cep.DesSerializedClassUnit(vJson);
                        Txt_Logradouro.Text = CEP.logradouro;
                        Txt_Bairro.Text = CEP.bairro;
                        Txt_Cidade.Text = CEP.localidade;

                        Cbb_Estado.SelectedIndex = -1;
                        for (int i = 0; i <= Cbb_Estado.Items.Count - 1; i++)
                        {
                            var vPos = Strings.InStr(Cbb_Estado.Items[i].ToString(), CEP.uf);
                            if (vPos > 0)
                            {
                                Cbb_Estado.SelectedIndex = i;
                            }
                        }
                    }
                }
            }
        }

        private void Cbx_Pai_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbx_Pai.Checked)
            {
                Lbl_NomePai.Enabled = false;
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Lbl_NomePai.Enabled = true;
                Txt_NomePai.Enabled = true;
            }
        }
        public void Cbx_Outro_CheckedChanged(object sender, EventArgs e)
        {
            if (Lbl_QualOutro.Visible && Txt_QualOutro.Visible)
            {
                Lbl_QualOutro.Visible = false;
                Txt_QualOutro.Visible = false;
            }
            else
            {
                Lbl_QualOutro.Visible = true;
                Txt_QualOutro.Visible = true;               
            }
        }

        private void limparStripButton_Click(object sender, EventArgs e)
        {
            LimpaFormulario();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void abrirStripButton_Click(object sender, EventArgs e)
        {
             if(Txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do cliente vazio", "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Fichario F = new Fichario("C:\\Users\\daniel.girotto\\OneDrive - INFORDOC SERVICOS DE INFORMATICA LTDA\\Desktop\\C#\\Alura\\CursoWF\\CursoWindowsForms\\Fichario");
                if (F.status)
                {
                    string clienteJson = F.Buscar(Txt_Codigo.Text);
                    Cliente.Unit C = new Cliente.Unit();
                    C = Cliente.DesSerializedClassUnit(clienteJson);
                    EscreveFormulario(C);
                }
                else
                {
                    MessageBox.Show("Erro: Código do cliente vazio", "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }

        void LimpaFormulario()
        {
            Txt_Id.Text = "";
            Txt_SeuNome.Text = "";
            Txt_NomeMae.Text = "";
            Txt_NomePai.Text = "";
            Txt_Cpf.Text = "";
            Txt_QualOutro.Text = "";
            Txt_Cep.Text = "";
            Txt_Logradouro.Text = "";
            Txt_Bairro.Text = "";
            Txt_Cidade.Text = "";
            Cbb_Estado.SelectedIndex = -1;
            Cbx_Pai.Checked = false;
            Cbx_Masc.Checked = true;
        }

        void EscreveFormulario(Cliente.Unit C)
        {
            Txt_Id.Text = C.Id;
            Txt_SeuNome.Text = C.Nome;
            Txt_NomeMae.Text = C.NomeMae;
            Txt_NomePai.Text = C.NomePai;
            Txt_Cpf.Text = C.Cpf;

            if (C.NaoTemPai == true)
            {
                Cbx_Pai.Checked = true;
                Txt_NomePai.Text = "";
            }
            else
            {
                Cbx_Pai.Checked = false;
                Txt_NomePai.Text = C.NomePai;
            }

            if (C.Genero == 0)
            {
                Cbx_Masc.Checked = true;
            }
            if (C.Genero == 1)
            {
                Cbx_Fem.Checked = true;
            }
            if (C.Genero == 2)
            {
                Cbx_Outro.Checked = true;
            }

            Txt_Cep.Text = C.Cep;
            Txt_Logradouro.Text = C.Logradouro;
            Txt_Bairro.Text = C.Bairro;
            Txt_Cidade.Text = C.Cidade;

            if (C.Estado == "")
            {
                Cbb_Estado.SelectedIndex = -1;
            }
            else
            {
                for(int i = 0; i <= Cbb_Estado.Items.Count -1; i++)
                {
                    if(C.Estado == Cbb_Estado.Items[i].ToString() )
                    {
                        Cbb_Estado.SelectedIndex = i;
                    }
                }
            }
        }

        private void salvarStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do cliente vazio", "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = LeituraFormulario();
                    C.ValidaClasse();
                    C.ValidaComplemento();
                    string clienteJson = Cliente.SerializedClassUnit(C);
                    Fichario F = new Fichario("C:\\Users\\daniel.girotto\\OneDrive - INFORDOC SERVICOS DE INFORMATICA LTDA\\Desktop\\C#\\Alura\\CursoWF\\CursoWindowsForms\\Fichario");
                    if (F.status)
                    {
                        F.Alterar(C.Id, clienteJson);
                        if (F.status)
                        {
                            MessageBox.Show("OK:" + F.mensagem, "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Erro:" + F.mensagem, "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro:" + F.mensagem, "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Cliente Cadastrado. ", "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ValidationException Ex)
                {
                    MessageBox.Show(Ex.Message, "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void excluirStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do cliente vazio", "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Fichario F = new Fichario("C:\\Users\\daniel.girotto\\OneDrive - INFORDOC SERVICOS DE INFORMATICA LTDA\\Desktop\\C#\\Alura\\CursoWF\\CursoWindowsForms\\Fichario");
                if (F.status)
                {                    
                    {
                        string clienteJson = F.Buscar(Txt_Codigo.Text);
                        Cliente.Unit C = new Cliente.Unit();
                        C = Cliente.DesSerializedClassUnit(clienteJson);
                        EscreveFormulario(C);

                        Frm_Questao Db = new Frm_Questao("icons8-question-mark-96", "Tem certeza que deseja excluir esse Id?");
                        Db.ShowDialog();

                        if (Db.DialogResult == DialogResult.Yes)
                        {
                            F.Apagar(Txt_Codigo.Text);
                            if (F.status)
                            {
                                MessageBox.Show("OK:" + F.mensagem, "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpaFormulario();
                            }
                            else
                            {
                                MessageBox.Show("Erro:" + F.mensagem, "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }                        
                    }
                    F.Apagar(Txt_Codigo.Text);
                    if (F.status)
                    {
                        MessageBox.Show("OK:" + F.mensagem, "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro:" + F.mensagem, "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Erro: Código do cliente vazio", "Infordoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Fichario F = new Fichario("C:\\Users\\daniel.girotto\\OneDrive - INFORDOC SERVICOS DE INFORMATICA LTDA\\Desktop\\C#\\Alura\\CursoWF\\CursoWindowsForms\\Fichario");
            if (F.status)
            {
                List<string> List = new List<string>();
                List = F.BuscarTodos();
                if (F.status)
                {
                    List<List<string>> ListaBusca = new List<List<string>>();
                    for (int i = 0; i <= List.Count - 1; i++)
                    {
                        Cliente.Unit C = Cliente.DesSerializedClassUnit(List[i]);
                        ListaBusca.Add(new List<string> { C.Id, C.Nome });
                    }
                    Frm_Busca FForm = new Frm_Busca(ListaBusca);
                    FForm.ShowDialog();
                    if (FForm.DialogResult == DialogResult.OK)
                    {
                        var idSelect = FForm.idSelect;
                        string clienteJson = F.Buscar(idSelect);
                        Cliente.Unit C = new Cliente.Unit();
                        C = Cliente.DesSerializedClassUnit(clienteJson);
                        EscreveFormulario(C);
                    }
                }
                else
                {
                    MessageBox.Show("ERR " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERR: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
