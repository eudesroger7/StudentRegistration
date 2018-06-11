using System;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
    }
}
