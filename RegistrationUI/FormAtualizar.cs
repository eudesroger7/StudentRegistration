﻿using System;
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

        private void avisoJanela(string titulo, string texto)
        {
            MessageBox.Show(texto, titulo,
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAtualizarBuscar_Click(object sender, EventArgs e)
        {   
            if(this.controle.procurar(long.Parse(tbMatricula.Text)) == null)
            {
                avisoJanela("404", "O Aluno não existe!");
                btnAtualizar.Visible = false;
            } else
            {
                Aluno aluno = this.controle.procurar(long.Parse(tbMatricula.Text));
                tbMatricula.ReadOnly = true;
                tbNome.Text = aluno.getNome();
                tbProfessor.Text = aluno.getProfessor();
                cbSerie.Text = "" + aluno.getSerie();
                cbTurma.Text = "" + aluno.getTurma();
                tbNota1.Text = "" + aluno.getNota1();
                tbNota2.Text = "" + aluno.getNota2();
                tbNota3.Text = "" + aluno.getNota3();
                tbNota4.Text = "" + aluno.getNota4();

                btnAtualizar.Visible = true;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
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

                            string nome = tbNome.Text;
                            long matricula = long.Parse(tbMatricula.Text);
                            char serie = char.Parse(cbSerie.Text);
                            char turma = char.Parse(cbTurma.Text);
                            string professor = tbProfessor.Text;
                            int nota1 = int.Parse(tbNota1.Text);
                            int nota2 = int.Parse(tbNota2.Text);
                            int nota3 = int.Parse(tbNota3.Text);
                            int nota4 = int.Parse(tbNota4.Text);

                            Aluno novoAluno = new Aluno(nome, matricula, serie, turma, professor, nota1, nota2, nota3, nota4);


                            this.controle.modificar(novoAluno);
                            avisoJanela("Sucesso!", "As informações foram atualizadas!");
                            this.Dispose();

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
