using PasswordValidatorDAL_DLL;
using PasswordValidatorDAL_DLL.Entity;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace PasswordValidatorBL_DLL
{
    
    public class PasswordValidatorBL
    {
        public List<String> ValidatePasswordRegularExpression(string password)
        {
            Rules rulesDA = new Rules();
            List<Rule> rules = rulesDA.GetRules();

            string regras = string.Empty;
            List<string> validationErrors = new List<string>();

            foreach (Rule rule in rules)
            {
                if (!Regex.IsMatch(password, rule.GetContext))
                    validationErrors.Add(rule.GetMessageError);
            }

            return validationErrors;
        }
    }
}

