using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    public class Aluno
    {
        private string nome;
        private long matricula;
        private char serie;
        private char turma;
        private string professor;
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;
        private double notaFinal;

        //constructor
        public Aluno(long matricula)
        {
            this.nome = null;
            this.matricula = matricula;
            this.serie = ' ';
            this.turma = ' ';
            this.professor = null;
            this.nota1 = 0;
            this.nota2 = 0;
            this.nota3 = 0;
            this.nota4 = 0;
            this.notaFinal = 0;
        }

        //getters
        public string getNome() { return this.nome; }
        public long getMatricula() { return this.matricula; }
        public char getSerie() { return this.serie; }
        public char getTurma() { return this.turma; }
        public string getProfessor() { return this.professor; }
        public double getNota1() { return this.nota1; }
        public double getNota2() { return this.nota2; }
        public double getNota3() { return this.nota3; }
        public double getNota4() { return this.nota4; }
        public double getNotaFinal() { return this.notaFinal; }

        //setters
        public void setNome(string name) { this.nome = name; }
        //public void setMatricula(long matricula) { this.matricula = matricula; }
        public void setSerie(char serie) { this.serie = serie; }
        public void setTurma(char Turma) { this.turma = Turma; }
        public void setProfessor(string professor) { this.professor = professor; }
        public void setNota1(double nota) { this.nota1 = nota; }
        public void setNota2(double nota) { this.nota2 = nota; }
        public void setNota3(double nota) { this.nota3 = nota; }
        public void setNota4(double nora) { this.nota4 = nora; }
        public void setNotaFinal(double nota) { this.notaFinal = nota; }


    }
}
