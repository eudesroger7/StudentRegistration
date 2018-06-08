using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    public class Teste
    {
        public static void Main(string[] args)
        {
            ControlesAluno controller = new ControlesAluno();

            print("\nInsira a matricula do aluno");
            Aluno eudes = new Aluno(long.Parse(Console.ReadLine()));
            print("Insira o nome");
            eudes.setNome("Eudes");
            print("Insira o nome do professor");
            eudes.setProfessor("Raoni");
            print("\n" + controller.criar(eudes));

            print("\nInsira a matricula do aluno");
            Aluno gabriel = new Aluno(long.Parse(Console.ReadLine()));
            print("Insira o nome");
            gabriel.setNome("Gabriel");
            print("Insira o nome do professor");
            gabriel.setProfessor("Eudes");
            print("\n" + controller.criar(gabriel));

            print("\n" + controller.listar());
            print("\n" + controller.procurar(gabriel.getMatricula()));
            print("\n" + controller.deletar(gabriel));
            print("\n" + controller.listar());



        }

        public static void print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
