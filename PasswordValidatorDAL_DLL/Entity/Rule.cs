using System.ComponentModel;

namespace PasswordValidatorDAL_DLL.Entity
{
    public class Rule
    {
        private int _id = 0;
        private string _messageError = string.Empty;
        private string _description = string.Empty;
        private string _context = string.Empty;

        public Rule(int id, 
                    string description, 
                    string messageError,
                    string context)
        {
            _id = id;
            _description = description;
            _messageError = messageError;
            _context = context;
        }

        public int GetId { get { return _id; } }
        public string GetDescription { get { return _description; } }
        public string GetMessageError { get { return _messageError; } }
        public string GetContext { get { return _context; }  }

    }
}