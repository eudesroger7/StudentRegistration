using System;
using System.Windows.Forms;


namespace RegistrationUI
{
    public partial class telaMain : Form
    {
        public telaMain()
        {
            InitializeComponent();
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
            telaCadastrar form = new telaCadastrar();
            form.Show();
        }
    }
}
