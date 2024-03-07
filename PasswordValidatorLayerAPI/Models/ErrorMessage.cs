namespace PasswordValidatorUI.Models
{
    public class ErrorMessage
    {
        private string _name = string.Empty;
        private string _description = string.Empty;

        public ErrorMessage(string name, 
                            string description) 
        { 
            this._name = name;
            this._description = description;
        }

        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
    }
}
