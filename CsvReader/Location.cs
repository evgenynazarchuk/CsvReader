using System;

namespace CsvReader
{
    public class Location : CsvModel
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public override void InitializeFromRow(ReadOnlySpan<string> columns)
        {
            Id = IntegerIsRequired(columns[0]); // not for string (int, long, bool, datetime, timespan)
            Name = columns[1]; // for string
        }
    }
}
