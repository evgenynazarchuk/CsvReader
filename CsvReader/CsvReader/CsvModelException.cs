using System;

namespace CsvReader
{
    public class CsvModelException : Exception
    {
        public CsvModelException(string message) : base(message)
        {
        }
    }
}