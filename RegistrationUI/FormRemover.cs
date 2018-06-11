using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationUI
{
    public partial class telaRemover : Form
    {
        private ControlesAluno controle;

        public telaRemover(ControlesAluno controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        private void avisoJanela(string titulo, string texto)
        {
            MessageBox.Show(texto, titulo,
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnRemoverBuscar_Click(object sender, EventArgs e)
        {
            if (this.controle.procurar(long.Parse(tbMatricula.Text)) == null)
            {
                avisoJanela("404", "O Aluno não existe!");
                btnRemover.Visible = false;

                tbNome.Text = "";
                tbProfessor.Text = "";
                cbSerie.Items.Clear();
                cbTurma.Items.Clear();
                tbNota1.Text = "";
                tbNota2.Text = "";
                tbNota3.Text = "";
                tbNota4.Text = "";
            }
            else
            {
                Aluno aluno = this.controle.procurar(long.Parse(tbMatricula.Text));
                tbNome.Text = aluno.getNome();
                tbProfessor.Text = aluno.getProfessor();
                cbSerie.Items.Insert(0, aluno.getSerie());
                cbSerie.Text = "" + aluno.getSerie();
                cbTurma.Items.Insert(0, aluno.getTurma());
                cbTurma.Text = "" + aluno.getTurma();
                tbNota1.Text = "" + aluno.getNota1();
                tbNota2.Text = "" + aluno.getNota2();
                tbNota3.Text = "" + aluno.getNota3();
                tbNota4.Text = "" + aluno.getNota4();

                btnRemover.Visible = true;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Validacao valida = new Validacao();

            if (!valida.campoVazio(tbNome.Text) &&
                    !valida.campoVazio(tbMatricula.Text) &&
                    !valida.campoVazio(tbProfessor.Text) &&
                    !valida.campoVazio(cbSerie.Text) &&
                    !valida.campoVazio(cbTurma.Text) &&
                    !valida.campoVazio(tbNota1.Text) &&
                    !valida.campoVazio(tbNota2.Text) &&
                    !valida.campoVazio(tbNota3.Text) &&
                    !valida.campoVazio(tbNota4.Text))
            {
                if (valida.validaTexto(tbNome.Text) && valida.validaTexto(tbProfessor.Text))
                {
                    if (valida.validaNumero(tbMatricula.Text) && (tbMatricula.TextLength == 9))
                    {
                        if (valida.validaNota(tbNota1.Text) && valida.validaNota(tbNota2.Text) &&
                           valida.validaNota(tbNota3.Text) && valida.validaNota(tbNota4.Text))
                        {

                            if(this.controle.deletar(long.Parse(tbMatricula.Text)) == false)
                            {
                                avisoJanela("Erro!", "Não foi possível remover. Verifique as informações!");
                                
                            } else
                            {
                                avisoJanela("Sucesso!", "Aluno removido com sucesso!");
                                this.Dispose();
                            }

                        }
                        else
                        {
                            avisoJanela("Nota inválida!", "A nota deve conter apenas números e deve ser entre 0 e 10!");
                        }
                    }
                    else
                    {
                        avisoJanela("Matricula inválida!", "A matrícula deve conter apenas números e ter no 9 dígitos!");
                    }
                }
                else
                {
                    avisoJanela("Nome inválido", "Nome do aluno ou nome do professor não podem conter caracteres especiais ou número.");
                }
            }
            else
            {
                avisoJanela("Campo vazio", "Nenhum campo pode ficar vazio!");
            }
        }
    }
}
