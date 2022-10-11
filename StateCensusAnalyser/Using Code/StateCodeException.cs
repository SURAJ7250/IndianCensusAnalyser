using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCensusAnalyser.Using_Code
{
    public class StateCodeException
    {
        public enum ExceptionType
        {
            FILE_INCORRECT, TYPE_INCORRECT, Delemeter_INCORRECT, HEADER_INCORRECT
        }
        public ExceptionType type;
        public StateCodeException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
