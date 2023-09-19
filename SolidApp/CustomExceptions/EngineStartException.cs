using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class EngineStartException : Exception
    {
        public EngineStartException(String Message, Exception InnerException) : base(Message, InnerException)
        {

        }

        public EngineStartException(String Message) : base(Message)
        {

        }
    }
}
