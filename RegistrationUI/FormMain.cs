using System;
using System.IO;
using System.Windows.Forms;


namespace RegistrationUI
{
    public partial class telaMain : Form
    {
        private ControlesAluno controle;

        public telaMain()
        {
            InitializeComponent();
            this.controle = new ControlesAluno();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void avisoJanela(string titulo, string texto)
        {
            MessageBox.Show(texto, titulo,
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja salvar os dados da seção antes de encerrar o programa?", "Warning",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string localDate = DateTime.Now.ToString("ddMMyyy_HHmmss");
                saveDados.FileName = "StudentRegistration_Dados_" + localDate;
                saveDados.Title = "Salvar como";
                saveDados.Filter = "text file|.txt";
                DialogResult resultado = saveDados.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveDados.FileName, FileMode.Create);
                    StreamWriter escrever = new StreamWriter(arquivo);
                    escrever.Write(this.controle.listar());
                    escrever.Close();
                    avisoJanela("Arquivo Salvo", "Arquivo salvo com sucesso!");
                    this.Dispose();
                }
                else
                {
                    DialogResult resultFile = MessageBox.Show("Tem certeza que não quer salvar os dados?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(resultFile == DialogResult.Yes) { this.Dispose(); }
                    else if (resultFile == DialogResult.No)
                    {

                    }
                }
            }
            else if (result == DialogResult.No)
            {
                this.Dispose();
            }
            
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            telaCadastrar form = new telaCadastrar(this.controle);
            form.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if(controle.listar() == null)
            {
                tbMain.Text = "Não há alunos cadastrados";
            } else
            {
                tbMain.Text = controle.listar();
            }
            
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            telaAtualizar form = new telaAtualizar(this.controle);
            form.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            telaRemover form = new telaRemover(this.controle);
            form.Show();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Validacao valida = new Validacao();

            if(!valida.campoVazio(tbProcurar.Text) && valida.validaNumero(tbProcurar.Text) && tbProcurar.TextLength == 9)
            {
                if(this.controle.procurar(long.Parse(tbProcurar.Text)) == null)
                {
                    avisoJanela("404", "Aluno não encontrado!");
                } else
                {
                    Aluno aluno = this.controle.procurar(long.Parse(tbProcurar.Text));
                    tbMain.Text = (
                        "\r\nNome:  " + aluno.getNome() +
                        "\r\nMatricula:  " + aluno.getMatricula() +
                        "\r\nSerie:  " + aluno.getSerie() +
                        "\r\nTurma:  " + aluno.getTurma() +
                        "\r\nProfessor:  " + aluno.getProfessor() +
                        "\r\nNota 1:  " + aluno.getNota1() +
                        "\r\nNota 2:  " + aluno.getNota2() +
                        "\r\nNota 3:  " + aluno.getNota3() +
                        "\r\nNota 4:  " + aluno.getNota4() +
                        "\r\nNota Final:  " + aluno.getNotaFinal()
                        );
                }
                
            } else
            {
                avisoJanela("Matrícula", "Formato de matrícula inválida!");
            }
        }
    }
}
