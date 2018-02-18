using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Platine.Exceptions
{
    public class UserException : Exception
    {
        public string Message { get; set; }
        
    }

    public class PlatineException : Exception
    {
        public string Message { get; set; }
    }

    // 
    public class MissingException : PlatineException
    {
        public MissingException(String s)
        {
            this.Message = s+" is not in database";
        }
    }

    public class AlreadyExistException : PlatineException
    {
        public AlreadyExistException()
        {
            this.Message = "This element is already in database";
        }
    }
    public class LoginIncorrect : PlatineException
    {
        public LoginIncorrect()
        {
            this.Message = "Login is incorrect";
        }
    }
    public class PasswordIncorrect : PlatineException
    {
        public PasswordIncorrect()
        {
            this.Message = "Password is incorrect";
        }
    }

    public class NotAllowedException : PlatineException
    {
        public NotAllowedException()
        {
            this.Message = "You are not allowed to do this action";
        }
    }
}