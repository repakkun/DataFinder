using System;
using System.Collections.Generic;
using System.Text;

namespace DataFinder.BLL
{
    class BuisnessRuleException
    {
        public class BusinessRuleException : Exception
        {
            public BusinessRuleException(string message) : base(message) { }
        }
    }
}
