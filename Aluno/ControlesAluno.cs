﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    public class ControlesAluno
    {
        private RepositorioAluno repositorio;

        public ControlesAluno()
        {
            this.repositorio = new RepositorioAluno();
        }

        public string criar(Aluno aluno)
        {
            if (this.repositorio.existe(aluno.getMatricula())) //testa se o aluno já está cadastrado
            {
                return "Aluno já está cadastrado!";
            }
            else
            {
                this.repositorio.inserir(aluno); //chama o método do repositório que adiciona o aluno no arraylist
                return "Sucesso! Aluno cadastrado!";
            }
        }

        public string modificar(Aluno aluno)
        {
            if (!this.repositorio.existe(aluno.getMatricula())) //testa se o aluno já está cadastrado
            {
                return "Aluno não encontrado!";
            }
            else
            {
                this.repositorio.atualizar(aluno);
                return "As informações foram atualizadas!";
            }
        }

        public string deletar(long matricula)
        {
            if (!this.repositorio.existe(matricula))
            {
                return "Aluno não encontrado!";
            }
            else
            {
                this.repositorio.remover(matricula);
                return "Aluno deletado!";
            }
        }

        public string procurar(long matricula)
        {
            if (!this.repositorio.existe(matricula))
            {
                return "Aluno não encontrado!";
            }
            else
            {
                return "Aluno encontrado!\n" + this.repositorio.procurar(matricula);
            }
        }

        public string listar()
        {
            if (this.repositorio.arrayVazio())
            {
                return "Não há alunos cadastrados!";
            }
            else
            {
                return this.repositorio.listar();
            }
        }
    }
}
