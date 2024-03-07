using PasswordValidatorDAL_DLL.Entity;
using System.Dynamic;

namespace PasswordValidatorDAL_DLL
{
    public class Rules
    {
        private List<Rule> rules;

        public Rules()
        {
           rules = new List<Rule>();

            rules.Add(new Rule(1, "Tamanho minimo", "A senha deve ter no mínimo 9 caracteres.", ".{9,}$"));
            rules.Add(new Rule(2, "Conter Numero", "A senha deve conter um número.", "\\d"));
            rules.Add(new Rule(3, "Letra Maiuscula", "A senha deve conter uma letra maiúscula.", "[A-Z]"));
            rules.Add(new Rule(4, "Letra Minuscula", "A senha deve conter uma letra minúscula.", "[a-z]"));
            rules.Add(new Rule(5, "Carater Especial", "A senha deve conter um caracter especial.", "[!@#$%^&*()-+]"));
            rules.Add(new Rule(6, "Espaço", "A senha não deve conter espaços em branco.", "^\\S*$"));
            rules.Add(new Rule(7, "Caracter Repetido", "A senha não pode conter caracteres repetidos.", "^(?!.*(.).*\\1).+$"));
        }

        //public List<Rule> GetRules
        //{
        //    get { return rules; }
        //}

        public List<Rule> GetRules()
        {
            return rules; 
        }
    }
}
