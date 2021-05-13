namespace CsvReader
{
    public class TestCsv : CsvAutoMapperModel
    {
        public string String { get; private set; }

        public int Int { get; private set; }
        public int? IntNull { get; private set; }

        public uint UInt { get; private set; }
        public uint? UIntNull { get; private set; }

        public long Long { get; private set; }
        public long? LongNull { get; private set; }

        public ulong ULong { get; private set; }
        public ulong? ULongNull { get; private set; }

        public float Float { get; private set; }
        public float? FloatNull { get; private set; }

        public double Double { get; private set; }
        public double? DoubleNull { get; private set; }

        public decimal Decimal { get; private set; }
        public decimal? DecimalNull { get; private set; }

        public bool Bool { get; private set; }
        public bool? BoolNull { get; private set; }
        //
        //public DateTime Date { get; private set; }
        //public DateTime? DateNull { get; private set; }
        //
        //public TimeSpan Time { get; private set; }
        //public TimeSpan? TimeNull { get; private set; }
    }
}
