using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationUI
{
    public class Validacao
    {
        public bool validaTexto(string texto)
        {
            bool state = true;
            string str = texto.ToLower();
                
            for(int i = 0; i < str.Length; i++)
            {
                string aux = str.Substring(i, 1);
                if (aux != "a")
                {
                    if (aux != "b")
                    {
                        if (aux != "c")
                        {
                            if (aux != "d")
                            {
                                if (aux != "e")
                                {
                                    if (aux != "f")
                                    {
                                        if (aux != "g")
                                        {
                                            if (aux != "h")
                                            {
                                                if (aux != "i")
                                                {
                                                    if (aux != "j")
                                                    {
                                                        if (aux != "k")
                                                        {
                                                            if (aux != "l")
                                                            {
                                                                if (aux != "m")
                                                                {
                                                                    if (aux != "n")
                                                                    {
                                                                        if (aux != "o")
                                                                        {
                                                                            if (aux != "p")
                                                                            {
                                                                                if (aux != "q")
                                                                                {
                                                                                    if (aux != "r")
                                                                                    {
                                                                                        if (aux != "s")
                                                                                        {
                                                                                            if (aux != "t")
                                                                                            {
                                                                                                if (aux != "u")
                                                                                                {
                                                                                                    if (aux != "v")
                                                                                                    {
                                                                                                        if (aux != "w")
                                                                                                        {
                                                                                                            if (aux != "x")
                                                                                                            {
                                                                                                                if (aux != "y")
                                                                                                                {
                                                                                                                    if (aux != "z")
                                                                                                                    {
                                                                                                                        if (aux != " ")
                                                                                                                        {
                                                                                                                            state = false;
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            return state;
        }

        public bool validaNumero(string numero)
        {
            bool state = true;
            string str = numero;
            for (int i = 0; i < str.Length; i++)
            {
                string aux = str.Substring(i, 1);
                if (aux != "0")
                {
                    if (aux != "1")
                    {
                        if (aux != "2")
                        {
                            if (aux != "3")
                            {
                                if (aux != "4")
                                {
                                    if (aux != "5")
                                    {
                                        if (aux != "6")
                                        {
                                            if (aux != "7")
                                            {
                                                if (aux != "8")
                                                {
                                                    if (aux != "9")
                                                    {
                                                        state = false;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return state;
        }

        public bool campoVazio(string valor)
        {
            bool state = false;

            if (valor.Length < 1) { state = true; }

            return state;
        }

        public bool validaNota(string valor)
        {
            bool state = false;

            if (validaNumero(valor))
            {
                if((int.Parse(valor) >= 0) && (int.Parse(valor) <= 10))
                {
                    state = true;
                }
            }

            return state;
        }

        public bool validaSerie(char serie)
        {
            bool state = true;

            if(serie != '1')
            {
                if(serie != '2')
                {
                    if (serie != '3')
                    {
                        if (serie != '4')
                        {
                            if (serie != '5')
                            {
                                state = false;
                            }
                        }
                    }
                }
            }

            return state;
        }

        public bool validaTurma(char turma)
        {
            bool state = true;

            if (turma != 'A')
            {
                if (turma != 'B')
                {
                    if (turma != 'C')
                    {
                        state = false;
                    }
                }
            }

            return state;
        }
    }
}
