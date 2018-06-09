using System;
using System.Collections;

namespace Aluno
{
    public class RepositorioAluno
    {
        private ArrayList repositorio;

        public RepositorioAluno()
        {
            this.repositorio = new ArrayList(); //cria um novo arrayList
        }

        public void inserir(Aluno aluno) //metodo para inserir, recebe um Aluno por parametro
        {
            this.repositorio.Add(aluno); //adiciona o novo aluno no array
        }

        public void remover(long matricula) //metodo para remover, recebe um long com o valor da matricula por parametro
        {
            foreach(Aluno aluno in this.repositorio) //loop que percorre todos os elementos do array
            {
                if(aluno.getMatricula() == matricula) //testa se a matricula passada por parametro e' igual a matricula do aluno em questao
                {
                    this.repositorio.Remove(aluno); //remove o aluno do array
                    break; //faz o loop parar, não sendo necessario percorrer mais o array visto que o aluno desejado foi removido
                }
            }
        }

        public void atualizar(Aluno novoAluno) /*metodo para atualizar as informações de um anúnio.
                                               recebe um Aluno por paramtro*/
        {
            foreach (Aluno aluno in this.repositorio) //loop para percorrer todo o array
            {
                if (aluno.getMatricula() == novoAluno.getMatricula()) //testo se o cpf para por parametro é igual ao de algum permitido
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
