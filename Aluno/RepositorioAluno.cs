using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    public class RepositorioAluno
    {
        private ArrayList repositorio;

        public RepositorioAluno()
        {
            this.repositorio = new ArrayList();
        }

        public void inserir(Aluno aluno)
        {
            this.repositorio.Add(aluno);
        }

        public void remover(Aluno aluno)
        {
            this.repositorio.Remove(aluno);
        }

        public void atualizar(Aluno novoAluno)
        {
            foreach (Aluno aluno in this.repositorio)
            {
                if (aluno.getMatricula() == novoAluno.getMatricula())
                {
                    aluno.setNome(novoAluno.getNome());
                    aluno.setSerie(novoAluno.getSerie());
                    aluno.setTurma(novoAluno.getTurma());
                    aluno.setProfessor(novoAluno.getProfessor());
                    aluno.setNota1(novoAluno.getNota1());
                    aluno.setNota2(novoAluno.getNota2());
                    aluno.setNota3(novoAluno.getNota3());
                    aluno.setNota4(novoAluno.getNota4());
                    aluno.setNotaFinal(novoAluno.getNotaFinal());
                }
            }
        }

        public String procurar(long matricula)
        {
            foreach (Aluno aluno in this.repositorio)
            {
                if (aluno.getMatricula() == matricula)
                {
                    string str = (
                        "\n------------------------\n" +
                        "Id: " + getIndex(aluno) +
                        "\nNome: " + aluno.getNome() +
                        "\nMatricula: " + aluno.getMatricula() +
                        "\nSerie: " + aluno.getSerie() +
                        "\nTurma: " + aluno.getTurma() +
                        "\nProfessor: " + aluno.getProfessor() +
                        "\nNota 1: " + aluno.getNota1() +
                        "\nNota 2: " + aluno.getNota2() +
                        "\nNota 3: " + aluno.getNota3() +
                        "\nNota 4: " + aluno.getNota4() +
                        "\nNota Final: " + aluno.getNotaFinal() +
                         "\n------------------------\n"
                    );

                    return str;
                }
            }
            return null;
        }

        public string listar()
        {
            string str = "";

            foreach (Aluno aluno in this.repositorio)
            {
                str = str + (
                    "\n------------------------\n" +
                    "Id: " + getIndex(aluno) +
                    "\nNome: " + aluno.getNome() +
                    "\nMatricula: " + aluno.getMatricula() +
                    "\nSerie: " + aluno.getSerie() +
                    "\nTurma: " + aluno.getTurma() +
                    "\nProfessor: " + aluno.getProfessor() +
                    "\nNota 1: " + aluno.getNota1() +
                    "\nNota 2: " + aluno.getNota2() +
                    "\nNota 3: " + aluno.getNota3() +
                    "\nNota 4: " + aluno.getNota4() +
                    "\nNote Final: " + aluno.getNotaFinal() +
                    "\n------------------------\n"
                 );
            }

            return str;
        }

        public int getIndex(Aluno aluno)
        {
            int index = this.repositorio.IndexOf(aluno);
 
            return index;
        }

        public bool existe(long matricula)
        {
            bool existe = false;

            foreach (Aluno aluno in this.repositorio)
            {
                if (aluno.getMatricula() == matricula)
                {
                    existe = true;
                }
            }

            return existe;
        }

        public bool arrayVazio()
        {
            if (this.repositorio.Count < 1) { return true; }
            else { return false; }
        }


    }
}
