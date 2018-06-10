using System.Text.RegularExpressions;

namespace Aluno
{
    class Valida
    {
        public static bool validaNome(string nome)
        {
            bool existeCaracterEspecial = Regex.IsMatch(nome, (@"[^a-zA-Z]"));

            return existeCaracterEspecial;
        }
    }
}
