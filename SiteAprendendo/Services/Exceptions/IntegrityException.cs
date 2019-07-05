using System;

namespace SiteAprendendo.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message): base(message)
        {

        }
    }
}
