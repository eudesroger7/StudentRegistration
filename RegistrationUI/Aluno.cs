namespace RegistrationUI
{
    public class Aluno
    {
        //Define os atributos do tipo Aluno
        private string nome;
        private long matricula;
        private char serie;
        private char turma;
        private string professor;
        private int nota1;
        private int nota2;
        private int nota3;
        private int nota4;
        private int notaFinal;

        /*Usamos as variaveis do tipo private para elas serem acessadas apenas
         de dentro da clase. As variaveis e metodos publicos podem ser acessadas
         de qualquer lugar.*/

        //construtor
        public Aluno(string nome, long matricula,
                    char serie, char turma, string professor,
                    int nota1, int nota2, int nota3, int nota4)
        {
            //usamos o this para referenciar as variaveis globais

            this.nome = nome; //atribui um valor nulo ao nome
            this.matricula = matricula; //atribui a matricula recebida no parametro a matricula
            this.serie = serie; //atribui uma serie nula
            this.turma = turma; //atribui uma turma nula
            this.professor = professor; //atribui um valor nulo ao professor
            this.nota1 = nota1; //atribui um valor 0 a nota 1
            this.nota2 = nota2; //atribui um valor 0 a nota 2
            this.nota3 = nota3; //atribui um valor 0 a nota 3
            this.nota4 = nota4; //atribui um valor 0 a nota 4
            this.notaFinal = (nota1 + nota2 + nota3 + nota4) / 4; //atribui um valor 0 a nota final
        }

        // getters - métodos que retornam o valor do atributos do aluno
        public string getNome() { return this.nome; } // retorna o nome
        public long getMatricula() { return this.matricula; } // retorna a matricula
        public char getSerie() { return this.serie; } // retorna a serie
        public char getTurma() { return this.turma; } // retorna a turma
        public string getProfessor() { return this.professor; } // retorna o nome do professor
        public int getNota1() { return this.nota1; } // retorna a nota 1
        public int getNota2() { return this.nota2; } // retorna a nota 2
        public int getNota3() { return this.nota3; } // retorna a nota 3
        public int getNota4() { return this.nota4; } // retorna a nota 3
        public int getNotaFinal() { return this.notaFinal; } // retorna a nota final

        //setters - metodos que modificam o valor da variável
        public void setNome(string nome) { this.nome = nome; } // recebe uma string por parameto e atribui ao nome
        //public void setMatricula(long matricula) { this.matricula = matricula; } // recebe um long por parametro e atribui a variável matricula
        public void setSerie(char serie) { this.serie = serie; } // recebe uma char por parameto e atribui a serie
        public void setTurma(char Turma) { this.turma = Turma; } // recebe uma char por parameto e atribui a turma
        public void setProfessor(string professor) { this.professor = professor; } // recebe uma string por parameto e atribui ao nome do professor
        public void setNota1(int nota) { this.nota1 = nota; } // recebe um inte por parameto e atribui a nota 1
        public void setNota2(int nota) { this.nota2 = nota; } // recebe um inte por parameto e atribui a nota 2
        public void setNota3(int nota) { this.nota3 = nota; } // recebe um inte por parameto e atribui a nota 3
        public void setNota4(int nota) { this.nota4 = nota; } // recebe um inte por parameto e atribui a nota 4
        public void setNotaFinal(int nota) { this.notaFinal = nota; } // recebe um inte por parameto e atribui a nota final

    }
}
