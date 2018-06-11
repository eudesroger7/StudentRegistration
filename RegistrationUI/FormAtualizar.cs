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
    public partial class telaAtualizar : Form
    {
        private ControlesAluno controle;
        public telaAtualizar(ControlesAluno controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
