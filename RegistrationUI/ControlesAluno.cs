using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationUI
{
    public class ControlesAluno
    {
        private RepositorioAluno repositorio;

        public ControlesAluno()
        {
            this.repositorio = new RepositorioAluno();
        }

        public bool criar(Aluno aluno)
        {
            if (this.repositorio.existe(aluno.getMatricula())) //testa se o aluno já está cadastrado
            {
                return false;
            }
            else
            {
                this.repositorio.inserir(aluno); //chama o método do repositório que adiciona o aluno no arraylist
                return true;
            }
        }

        public bool modificar(Aluno aluno)
        {
            if (!this.repositorio.existe(aluno.getMatricula())) //testa se o aluno já está cadastrado
            {
                return false;
            }
            else
            {
                this.repositorio.atualizar(aluno);
                return true;
            }
        }

        public bool deletar(long matricula)
        {
            if (!this.repositorio.existe(matricula))
            {
                return false;
            }
            else
            {
                this.repositorio.remover(matricula);
                return true;
            }
        }

        public Aluno procurar(long matricula)
        {
            if (!this.repositorio.existe(matricula))
            {
                return null;
            }
            else
            {
                return this.repositorio.procurar(matricula);
            }
        }

        public string listar()
        {
            if (this.repositorio.arrayVazio())
            {
                return null;
            }
            else
            {
                return this.repositorio.listar();
            }
        }
    }
}
