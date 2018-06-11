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
            print("\n" + controller.listar());
            print("\nInsira a matricula do aluno");
            Aluno eudes = new Aluno("",0,' ',' ',"",0,0,0,0);
            print("Insira o nome");
            eudes.setNome(scan());
            print("Insira o nome do professor");
            eudes.setProfessor(scan());
            print("\n" + controller.criar(eudes));

            print("\nInsira a matricula do aluno");
            Aluno gabriel = new Aluno("", 0, ' ', ' ', "", 0, 0, 0, 0);
            print("Insira o nome");
            gabriel.setNome(scan());
            print("Insira o nome do professor");
            gabriel.setProfessor(scan());
            print("\n" + controller.criar(gabriel));

            print("\n" + controller.listar());
            print("\n" + controller.procurar(123));
            print("\n" + controller.deletar(122));
            print("\n" + controller.listar());



        }

        public static void print(string str)
        {
            Console.WriteLine(str);
        }

        public static string scan()
        {
            return Console.ReadLine();
        }
    }
}
