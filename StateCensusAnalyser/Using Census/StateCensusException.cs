using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCensusAnalyser.Using_Census
{
    public class StateCensusException
    {
        public enum ExceptionType
        {
            FILE_INCORRECT, TYPE_INCORRECT, Delemeter_INCORRECT, HEADER_INCORRECT
        }
        public ExceptionType type;
        public readonly double Message;

        public StateCensusException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
